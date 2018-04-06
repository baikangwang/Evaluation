using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;
using System.Web.UI.WebControls;
using System.Linq;
using System.Web.UI.HtmlControls;
using System.Configuration;

namespace Evaluation.View.Declaration
{
    /// <summary>
    /// 此页面是所有申报表的入口，新增、修改、查看申报详细内容等申报表详细内容相关的页面都从此页面跳转
    /// </summary>
    public partial class Declaration : System.Web.UI.Page
    {
        public Dal.Models.TemplateInfo TempInfo { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            if (user == null)
            {
                Response.Redirect("~/View/Mutual/UserEntry.aspx");
            }

            if (!IsPostBack)
            {
                btnNext.Attributes.Add("OnClick", "return UserAddVerify()");

                // 设定专业
                Dal.Models.Specialty spec = null;
                Dal.Models.Prize prize = null;
                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();

                string strActivityType = Request.Cookies["ActivityType"].Value;
                Dal.Models.Activity actActivated = BLL.Activity.GetActivity(strActivityType, conn);
                if (actActivated == null)
                {
                    hdMsg.Value = "当前活动已关闭，请联系活动管理人员！";
                    return;
                }

                // 设置推荐协会
                if (ConfigurationManager.AppSettings["ActivityType"] != "0102")
                {
                    RecommendationAssociation.Visible = false;
                }
                else
                {
                    List<Dal.Models.UserInfo> lstAssociation = BLL.User.GetlstAssociationUser(conn);
                    ChooseAssociation.DataSource = lstAssociation;
                    ChooseAssociation.DataTextField = "UserName";
                    ChooseAssociation.DataValueField = "UserID";
                    ChooseAssociation.DataBind();
                }

                int iDeclarationID = 0;
                int.TryParse(Request["DeclarationID"], out iDeclarationID);
                hdDeclarationID.Value = iDeclarationID.ToString();
                Dal.Models.Declaration decl = BLL.Declaration.GetDeclaration(iDeclarationID, conn);

                if (decl == null)
                {
                    // 获取菜单传递过来的参数
                    spec = BLL.Specialty.GetSpecialty(actActivated.ActivityID.Value, Request["SepcCode"], conn);
                    if (spec == null)
                    {
                        List<Dal.Models.Specialty> lst = BLL.Specialty.GetSpecialtyList(actActivated.ActivityID.Value, true, conn);
                        spec = lst[0];
                    }

                    // 设定封页台头
                    litTitle.Text = BLL.SysConstant.GetConstant(spec.TemplateCode, conn).ConstantDiscription;

                    // 设定奖项列表
                    List<Dal.Models.Specialty> lstSpecialty = BLL.Specialty.GetDirectlyChildList(spec.SpecialtyID.Value, conn);
                    List<Dal.Models.Prize> lstPrize = null;
                    if (lstSpecialty.Count == 0)
                    {
                        lblSpecil.Visible = false;
                        ddlSpecialty.Visible = false;
                        ddlChildSpecialty.Visible = false;

                        // 设定奖项列表
                        lstPrize = BLL.Prize.GetPrizeList(spec.SpecialtyID.Value, conn);
                    }
                    else
                    {
                        ddlSpecialty.Visible = true;

                        List<Dal.Models.Specialty> lstChildSpecialty = null;
                        lstSpecialty = lstSpecialty.Where(s =>
                            BLL.Prize.Count(s.SpecialtyID.Value, conn) > 0
                            || BLL.Specialty.Count(actActivated.ActivityID.Value, s.SpecialtyID, conn) > 0
                            ).ToList();
                        ddlSpecialty.DataSource = lstSpecialty;
                        ddlSpecialty.DataTextField = "SpecialtyName";
                        ddlSpecialty.DataValueField = "SpecialtyID";
                        ddlSpecialty.DataBind();
                        ddlSpecialty.SelectedIndex = 0;

                        if (lstSpecialty.Count > 0)
                        {
                            lstChildSpecialty = BLL.Specialty.GetDirectlyChildList(lstSpecialty[0].SpecialtyID.Value, conn);
                            if (lstChildSpecialty.Count == 0)
                            {
                                ddlChildSpecialty.Visible = false;

                                // 设定奖项列表
                                lstPrize = BLL.Prize.GetPrizeList(lstSpecialty[0].SpecialtyID.Value, conn);
                            }
                            else
                            {
                                ddlChildSpecialty.Visible = true;
                                ddlChildSpecialty.DataSource = lstChildSpecialty;
                                ddlChildSpecialty.DataTextField = "SpecialtyName";
                                ddlChildSpecialty.DataValueField = "SpecialtyID";
                                ddlChildSpecialty.DataBind();
                                ddlSpecialty.SelectedIndex = 0;

                                // 设定奖项列表
                                lstPrize = BLL.Prize.GetPrizeList(lstChildSpecialty[0].SpecialtyID.Value, conn);
                            }
                        }
                    }

                    if (lstPrize != null && lstPrize.Count > 0)
                    {
                        // 绑定奖项列表
                        rdlPrize.DataSource = lstPrize;
                        rdlPrize.DataTextField = "PrizeName";
                        rdlPrize.DataValueField = "PrizeID";
                        rdlPrize.DataBind();
                        rdlPrize.SelectedIndex = 0;

                        // 根据奖项获取模版
                        string strTempCode = lstPrize.Where(p => p.PrizeID.Value == Convert.ToInt32(rdlPrize.SelectedValue)).ToList()[0].TemplateCode;
                        Dal.Models.Organization org = BLL.User.GetOrganization(user.UserID.Value, conn);

                        // 绑定导入数据
                        List<Dal.Models.Declaration> lstDeclaration = BLL.Declaration.GetDeclarationList(user, actActivated.ActivityID.Value, conn);
                        lstDeclaration = lstDeclaration.Where(d => d.PrizeID == lstPrize[0].PrizeID).ToList();
                        if (lstDeclaration.Count() > 0)
                        {
                            ImportDeclarationData.DataSource = lstDeclaration;
                            ImportDeclarationData.DataTextField = "DeclarationName";
                            ImportDeclarationData.DataValueField = "DeclarationID";
                            ImportDeclarationData.DataBind();
                            ImportDeclarationData.Items.Insert(0, new ListItem("<-- 不导入 -->", "0"));
                            ImportDeclarationData.SelectedIndex = 0;
                        }
                        else
                        {
                            ImportData.Visible = false;
                        }
                        if (org != null)
                        {
                            // 设定单位信息
                            txtOrganizationName.Text = org.OrganizationName;
                        }
                        txtDeclarateDate.Text = DateTime.Today.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        hdMsg.Value = "该专业下暂无奖项，无法申报!";
                        return;
                    }
                }
                else
                {
                    // 隐藏控件
                    ddlSpecialty.Visible = false;
                    ddlChildSpecialty.Visible = false;
                    lblSpecil.Visible = false;

                    prize = BLL.Prize.GetPrize(decl.PrizeID.Value, conn);
                    spec = BLL.Specialty.GetSpecialty(prize.SpecialtyID.Value, conn);
                    ViewState["DeclarationID"] = decl.DeclarationID.Value;

                    // 设定封页台头
                    litTitle.Text = BLL.SysConstant.GetConstant(prize.TemplateCode, conn).ConstantDiscription;
                    // 设定封页台头
                    txtProjectName.Text = decl.DeclarationName;
                    txtDeclarateDate.Text = decl.DeclareDate.Value.ToString("yyyy-MM-dd");

                    Dal.Models.Organization org = BLL.User.GetOrganization(decl.UserID.Value, conn);
                    if (org != null)
                    {
                        // 设定单位信息
                        txtOrganizationName.Text = org.OrganizationName;
                    }

                    // 设定奖项列表
                    List<Dal.Models.Prize> lstPrize = BLL.Prize.GetPrizeList(spec.SpecialtyID.Value, conn);

                    foreach (Dal.Models.Prize item in lstPrize)
                    {
                        rdlPrize.Items.Add(new System.Web.UI.WebControls.ListItem(
                            item.PrizeName, item.PrizeID.Value.ToString()) { Enabled = item.TemplateCode == prize.TemplateCode });
                    }

                    rdlPrize.SelectedValue = prize.PrizeID.Value.ToString();
                    if (decl.RecommendFrom == null || decl.RecommendFrom == "0" || decl.RecommendFrom == "")
                    {
                        ChooseAssociation.SelectedValue = "0";
                        litChooseAssociation.Text = "未有推荐协会";
                    }
                    else
                    {
                        ChooseAssociation.SelectedValue = decl.RecommendFrom.ToString();
                        litChooseAssociation.Text = BLL.User.GetUserInfo(Convert.ToInt32(decl.RecommendFrom), conn).UserName;
                    }

                    // 隐藏导入数据控件
                    ImportData.Visible = false;

                    // 生成二维码
                    //string imgUrl = BLL.Declaration.CreatQRcode(decl.DeclarationCode, conn);
                    //// 显示二维码
                    //HtmlTableRow tr = new HtmlTableRow();
                    //HtmlTableCell td1 = new HtmlTableCell("td");
                    //HtmlTableCell td2 = new HtmlTableCell("td");
                    //td1.InnerHtml = "<label style='margin-top: 20px;'>二维码：</label>";
                    //td1.Style.Add("width", "30%");
                    //td2.InnerHtml = "<img src='../../Content/Temp/" + decl.DeclarationCode + "/QRcode" + decl.DeclarationCode + ".jpg' style='width:150px;height:150px;' />";
                    //td2.ColSpan = 2;
                    //tr.Cells.Add(td1);
                    //tr.Cells.Add(td2);
                    //tbInformation.Rows.Add(tr);
                }

                //接受场景                    
                if (!string.IsNullOrEmpty(Request["Situation"]))
                {
                    txtSituation.Text = Request["Situation"].Replace("'", "");
                    litProjectName.Text = decl.DeclarationName;
                    litDeclarateDate.Text = decl.DeclareDate.Value.ToString("yyyy-MM-dd");
                    litrdlPrize.Text = prize.PrizeName;
                }
                conn.Close();
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];

            // 创建申报项目
            Dal.Models.Declaration decl = null;
            bool bChanged = false;
            string strTemplateCode = "";

            DateTime dtm;
            if (!DateTime.TryParse(txtDeclarateDate.Text, out dtm))
            {
                hdMsg.Value = "项目申报时间格式错误！";
                return;
            }


            int iPrizeID = Convert.ToInt32(Request["rdlPrize"]);
            if (iPrizeID == 0 && rdlPrize.SelectedValue != "")
            {
                iPrizeID = Convert.ToInt32(rdlPrize.SelectedValue);
            }

            if (iPrizeID == 0)
            {
                hdMsg.Value = "请选择奖项!";
                return;
            }

            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            string strActivityType = Request.Cookies["ActivityType"].Value;
            Dal.Models.Activity actActivated = BLL.Activity.GetActivity(strActivityType, conn);
            string strDeclarationCode = "";
            if (ViewState["DeclarationID"] != null)
            {
                decl = BLL.Declaration.GetDeclaration(Convert.ToInt32(ViewState["DeclarationID"]), conn);
                strDeclarationCode = decl.DeclarationCode;
            }
            else
            {
                decl = new Dal.Models.Declaration();
                decl.UserID = user.UserID;
                decl.ActivityID = actActivated.ActivityID;
            }

            if (decl.DeclareDate == null || decl.DeclareDate.Value != dtm)
            {
                bChanged = true;
                decl.DeclareDate = dtm;
            }

            if (string.IsNullOrEmpty(decl.RecommendFrom) || decl.RecommendFrom != ChooseAssociation.SelectedValue)
            {
                bChanged = true;
                decl.RecommendFrom = ChooseAssociation.SelectedValue;
            }

            if (decl.PrizeID == null || decl.PrizeID != iPrizeID)
            {
                bChanged = true;
                decl.PrizeID = iPrizeID;
            }

            if (string.IsNullOrEmpty(decl.DeclarationName) || decl.DeclarationName != txtProjectName.Text.Trim())
            {
                bChanged = true;
                decl.DeclarationName = txtProjectName.Text.Trim();
            }

            Dal.Models.Prize prize = BLL.Prize.GetPrize(decl.PrizeID.Value, conn);
            strTemplateCode = prize.TemplateCode;
            int iSpecilID = prize.SpecialtyID.Value;
            int actID = prize.ActivityID.Value;
            Dal.Models.Schedule dSchedule = BLL.Schedule.GetSpecialtySchedule(iSpecilID, conn);

            if (dSchedule == null || !dSchedule.IsDeclarationStart.Value)
            {
                hdMsg.Value = "未在专业申报时间内，不能创建！";
                conn.Close();
                return;
            }

            string strSituation = "";
            if (!string.IsNullOrEmpty(Request["Situation"]))
            {
                strSituation = Request["Situation"].Replace("'", "").Replace("\"", "");
            }

            if (bChanged == true && (strSituation == Dal.Models.EnumSituation.Declaration.ToString() || strSituation == ""))
            {
                OleDbTransaction trans = conn.BeginTransaction();
                try
                {
                    BLL.Declaration.Declarate(ref decl, conn, trans);

                    string strImportDeclarationID = ImportDeclarationData.SelectedValue;
                    if (strImportDeclarationID != "0" && strImportDeclarationID != "")
                    {
                        string strDeclarationCode2 = BLL.Declaration.GetDeclaration(Convert.ToInt32(strImportDeclarationID), conn, trans).DeclarationCode;
                        BLL.Declaration.ImportDeclarate(decl.DeclarationID.Value, Convert.ToInt32(strImportDeclarationID), conn, trans);
                        BLL.Declaration.ImportUploadFile(decl.DeclarationID.Value, Convert.ToInt32(strImportDeclarationID), decl.DeclarationCode, strDeclarationCode2, conn, trans);
                    }
                    trans.Commit();
                    ViewState["DeclarationID"] = decl.DeclarationID.Value;
                }
                catch (Exception ex)
                {
                    ViewState.Remove("DeclarationID");
                    trans.Rollback();
                    hdMsg.Value = ex.Message;
                    return;
                }
            }

            // 获取申报项目的模板首页
            string strPartCode = strTemplateCode.Substring(2, 2) + "01";

            // 根据首页获取模板
            TempInfo = BLL.Declaration.GetTemplateInfo(strPartCode, conn);
            TempInfo.DeclarationID = (int)ViewState["DeclarationID"];
            TempInfo.DeclarationCode = strDeclarationCode;
            if (!string.IsNullOrEmpty(strSituation))
            {
                TempInfo.Situation = (Dal.Models.EnumSituation)Enum.Parse(typeof(Dal.Models.EnumSituation), strSituation, true);
            }
            else
            {
                TempInfo.Situation = (Dal.Models.EnumSituation)Enum.Parse(typeof(Dal.Models.EnumSituation), "Declara", true);
            }

            conn.Close();

            if (TempInfo != null)
            {
                Session.Add("TemplateInfo", TempInfo);

                // 跳转到模板页
                if (strSituation == "ExpertReview" || strSituation == "Delete" || strSituation == "Auditing")
                {
                    Server.Transfer(TempInfo.NewTemplateUrl);
                }
                else
                {
                    Server.Transfer(TempInfo.TemplateUrl);
                }
            }
        }
    }
}
