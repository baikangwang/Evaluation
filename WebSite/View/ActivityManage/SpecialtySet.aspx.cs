using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web.UI.WebControls;

namespace Evaluation.View.ActivityManage
{
    public partial class SpecialtySet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtUploadLimitMax.Attributes.Add("onkeyup","value.replace(/[^\\d]/g, '')");

            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];

            if (user == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }

            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                hdMsg.Value = "当前没有已经激活的申报活动，请确认。";
            }
            else
            {
                InitPage(conn);  
            }
            conn.Close();
        }

        public void InitPage(OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            int iSpecialtyID = 0;
            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                Response.Redirect("~/View/Mutual/HomePage.aspx");
                return;
            }

            if (!IsPostBack)
            {
                //修改
                if (Request["sid"] != null || ViewState["SpecialtyID"] != null)
                {
                    if (!Int32.TryParse(Request["sid"] ?? "0", out iSpecialtyID))
                    {
                        Response.Redirect("SpecialtyList.aspx");
                    }
                    else
                    {
                        hfSpecialtyLevel.Value = Request["specialtyLevel"];
                        ViewState["SpecialtyID"] = iSpecialtyID;
                        hfSpecialID.Value = Request["sid"];
                        hfParentID.Value = Request["pid"];
                        Dal.Models.Specialty spec = null;
                        try
                        {
                            spec = BLL.Specialty.GetSpecialty(iSpecialtyID, conn);
                        }
                        catch (Exception ex)
                        {
                            spec = null;
                            hdMsg.Value = ex.Message;
                        }

                        if (spec == null)
                        {
                            hdMsg.Value = "参数错误!";
                            Response.Redirect("SpecialtyList.aspx");
                        }
                        else
                        {
                            //修改时
                            txtSpecialtyName.Text = spec.SpecialtyName;
                            txtSpecialtyID.Text = (spec.SpecialtyID).ToString();
                           // txtSpecialtyCode.Text = spec.SpecialtyCode;
                            txtIconPicker.Value = spec.SpecialtyIcon;//ddlIsInheritTemplet.SelectedValue = "false";
                            txtOrdinal.Text = (spec.Ordinal ?? 0).ToString();
                            Dal.Models.Specialty parentSpecialty = BLL.Specialty.GetSpecialty((spec.ParentID ?? 0), conn);

                            if (parentSpecialty != null)
                            {
                                ListItem item = new ListItem(parentSpecialty.SpecialtyName, parentSpecialty.SpecialtyID.ToString());
                                ddlParent.Items.Add(item);
                                ddlParent.Items.Insert(0, new ListItem("--请选择--", "0"));
                                ddlParent.SelectedValue = (parentSpecialty.SpecialtyID ?? 0).ToString();
                                hfLevel.Value = parentSpecialty.SpecialtyLevel;
                            }
                            else
                            {
                                hfLevel.Value = "";//一级专业没有父级
                            }

                            ddlParent.Enabled = false;                          
                            ddlIsInheritSchedule.SelectedValue = (spec.IsInheritSchedule ?? true).ToString();
                            ddlIsAllowUpdate.SelectedValue = (spec.IsAllowUpdate ?? false).ToString();
                            ddlIsAllowSubmit.SelectedValue = spec.IsAllowSubmit.ToString();
                            ddlIsSendReceivePost.SelectedValue = spec.IsSendReceivePost.ToString() == "True" ? "1" : "0";
                            ddlIsSendUpdatePost.SelectedValue = spec.IsSendUpdatePost.ToString()=="True"?"1":"0";
                            ddlIsSendDeletePost.SelectedValue = spec.IsSendDeletePost.ToString() == "True" ? "1" : "0";

                            ucSchedule.UcSchedule = BLL.Schedule.GetSpecialtySchedule(iSpecialtyID, conn);
                            if (ucSchedule.UcSchedule == null)
                            {
                                ucSchedule.UcSchedule = new Dal.Models.Schedule();
                            }
                            ucSchedule.UcSchedule.SpecialtyID = iSpecialtyID;
                            ucSchedule.UcSchedule.ActivityID = null;

                            //ddlTemplate.SelectedValue = spec.TemplateCode;
                            //ddlTemplate.Enabled = !(spec.IsInheritTemplet ?? true);
                            //ddlIsInheritTemplet.SelectedValue = (spec.IsInheritTemplet ?? spec.ParentID != null).ToString();
                            //ddlTemplate.Enabled = false;
                            //txtSpecialtyCode.Enabled = false;
                            lkbCreate.Visible = false;
                            ucSchedule.Visible = true;
                            //lkbSetPrize.Visible = true;
                            lkbSetAtlas.Visible = true;
                            lkbSetAppendix.Visible = true;
                            //string showType = Request.QueryString["show"];
                            //if (spec.PrizeCount != 0 || spec.ChildCount != 0)
                            //{
                            //    divPrizeList.Visible = spec.PrizeCount > 0;
                            //    divChild.Visible = spec.ChildCount > 0;
                            //}
                            //if (showType == "all")
                            //{
                            //    divPrizeList.Visible = true;
                            //    divChild.Visible = true;
                            //}
                            //else if (showType == "child")
                            //{
                            //    divPrizeList.Visible = false;
                            //    divChild.Visible = true;
                            //}
                            //else
                            //{
                            //    divPrizeList.Visible = true;
                            //    divChild.Visible = false;
                            //}

                            tbxSpecialtyAtlas.Text = spec.SpecialtyName;
                            tbxSpecialtyAppendix.Text = spec.SpecialtyName;
                        }
                    }

                }
                else //新建
                {
                    // 专业下拉列表
                    List<Dal.Models.Specialty> lstTemp = BLL.Specialty.GetSpecialtyDropList(activity.ActivityID.Value,user.UserType,user.UserID.Value, true, conn);
                    List<Dal.Models.Specialty> lstSpec = lstTemp;
                    List<Dal.Models.Specialty> listtemp = lstTemp;

                    for (int i = 0; i < lstSpec.Count(); i++)
                    {
                        List<Dal.Models.Specialty> lstChildSpec = BLL.Specialty.GetDirectlyChildTowList(lstSpec[i].SpecialtyID, conn);
                        for (int j = 0; j < lstChildSpec.Count(); j++)
                        {
                            lstChildSpec[j].SpecialtyName = " " + lstChildSpec[j].SpecialtyName;
                            listtemp.Add(lstChildSpec[j]);
                        }
                    }
                    listtemp = listtemp.OrderBy(s => s.TotalOrdinal).ToList();

                    ListItem option = null;
                    foreach (Dal.Models.Specialty item in listtemp)
                    {
                        option = new ListItem(item.SpecialtyName, item.SpecialtyID.ToString());
                        ddlParent.Items.Add(option);
                    }
                    //ddlParent.Items.Insert(0, new ListItem("--请选择--", "0"));
                    ListItem itemParent = ddlParent.Items.FindByValue(Request["pid"]);
                    if (itemParent != null)
                    {
                        ddlParent.SelectedValue = Request["pid"];
                        ddlParent.Enabled = false;
                    }
                    else 
                    {
                       // hdMsg.Value = "已经有奖项的专业不可以添加子专业！";
                    }

                    txtOrdinal.Text = (BLL.Specialty.Count(activity.ActivityID.Value, null, conn, null) + 1).ToString();
                    ddlIsInheritSchedule.SelectedValue = "True";
                    ddlIsAllowSubmit.SelectedValue = "True";
                    //ddlIsInheritTemplet.SelectedValue = "false";

                    if (ddlParent.SelectedValue != "")
                    {
                        int parentSpecialtyID = Convert.ToInt32(ddlParent.SelectedValue);
                        Dal.Models.Specialty spl = BLL.Specialty.GetSpecialty(parentSpecialtyID, conn);
                        hfLevel.Value = spl.SpecialtyLevel;
                    }
                    else 
                    {
                        hdMsg.Value = "对不起，您没有专业权限或专业下有奖项，不能再新建专业！";
                    }

                    if (ddlParent.Items.Count > 0)
                    {
                        lkbCreate.Enabled = true;
                    }
                    else
                    {
                        lkbCreate.Enabled = false;
                    }
                    lkbUpdate.Visible = false;
                    ucSchedule.Visible = false;
                    //lkbSetPrize.Visible = false;
                    lkbSetAtlas.Visible = false;
                    lkbSetAppendix.Visible = false;
                    //divPrizeList.Visible = false;
                    //divChild.Visible = false;
                    txtSpecialtyName.Enabled = true;
                }
            }

            ucSchedule.OnSaveSchedule += SaveSchedule;
        }

        protected void lkbCreate_Click(object sender, EventArgs e)
        {
            int num = BLL.Specialty.IsExist(txtSpecialtyName.Text);
            if (num > 0)
            {
                hdMsg.Value = "该专业名已存在!";
                //Response.Write("<script>alert('该专业名已存在!')</script>");
            }
            else
            {
                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();

                string strActivityType = Session["ActivityType"].ToString();
                Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
                if (activity == null)
                {
                    hdMsg.Value = "当前活动已经结束!";
                    return;
                }
                Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];

                Dal.Models.Specialty specialty = new Dal.Models.Specialty();

                if (ddlParent.SelectedValue != "0")
                {
                    specialty.ParentID = Convert.ToInt32(ddlParent.SelectedValue);
                }
                specialty.ActivityID = activity.ActivityID;
                if (!string.IsNullOrEmpty(txtIconPicker.Value))
                {
                    specialty.SpecialtyIcon = txtIconPicker.Value;
                }

                specialty.SpecialtyName = txtSpecialtyName.Text;
                //specialty.SpecialtyCode = txtSpecialtyCode.Text;

                if (hfLevel.Value == "一级")
                {
                    specialty.SpecialtyLevel = "二级";
                }
                else if (hfLevel.Value == "二级")
                {
                    specialty.SpecialtyLevel = "三级";
                }
                else if (hfLevel.Value == "三级")
                {
                    hdMsg.Value = "不能给三级专业再创建子专业！";
                    return;
                }

                string templateCode = BLL.Specialty.GetTempletCode(Convert.ToInt32(specialty.ParentID), conn);
                specialty.TemplateCode = templateCode;//ddlTemplate.SelectedValue;

                int iOrdinal = 0;
                if (!string.IsNullOrEmpty(txtOrdinal.Text) && Int32.TryParse(txtOrdinal.Text, out iOrdinal))
                {
                    specialty.Ordinal = iOrdinal;
                }

                specialty.IsInheritSchedule = ddlIsInheritSchedule.SelectedValue == "True";
                specialty.IsInheritTemplet = false; //ddlIsInheritTemplet.SelectedValue == "True";
                specialty.IsAllowUpdate = ddlIsAllowUpdate.SelectedValue == "True";
                specialty.IsAllowSubmit = ddlIsAllowSubmit.SelectedValue == "True";

                specialty.IsSendReceivePost = ddlIsSendReceivePost.SelectedValue == "True";
                specialty.IsSendUpdatePost = ddlIsSendUpdatePost.SelectedValue == "True";
                specialty.IsSendDeletePost = ddlIsSendDeletePost.SelectedValue == "True";
                //specialty.IsSendReceivePost = Convert.ToInt32(ddlIsSendReceivePost.SelectedValue);
                //specialty.IsSendUpdatePost = Convert.ToInt32(ddlIsSendUpdatePost.SelectedValue);
                //specialty.IsSendDeletePost = Convert.ToInt32(ddlIsSendDeletePost.SelectedValue);

                OleDbTransaction trans = conn.BeginTransaction();
                try
                {
                    int result = BLL.Specialty.CreateSpecialty(specialty, conn, trans);
                    trans.Commit();
                    hdMsg.Value = "添加成功!";
                    txtSpecialtyID.Text = result.ToString();
                    //Response.Write("<script>alert('添加成功!')</script>");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    //Response.Write("<script>alert('" + ex.Message + "')</script>");
                    hdMsg.Value = ex.Message;
                }
                conn.Close();
                //Response.Redirect("~/view/ActivityManage/SpecialtyList.aspx?specialtyMSg=" + hdMsg.Value);
            }
        }

        protected void lkbUpdate_Click(object sender, EventArgs e)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];

            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            
            int iSpecialID = Convert.ToInt32(ViewState["SpecialtyID"]);
            Dal.Models.Specialty specialty = BLL.Specialty.GetSpecialty(iSpecialID, conn);
            if (specialty == null)
            {
                hdMsg.Value = "专业不存在!";
                //Response.Write("<script>alert('专业不存在!')</script>");
                Response.Redirect("SpecialtyList.aspx");
            }
            else
            {
                string strActivityType = Session["ActivityType"].ToString();
                Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
                if (activity == null)
                {
                    hdMsg.Value = "当前活动已经结束!";
                    return;
                }

                if (ddlParent.SelectedValue != "" && ddlParent.SelectedValue != "0")
                {
                    specialty.ParentID = Convert.ToInt32(ddlParent.SelectedValue);
                }
                if (!string.IsNullOrEmpty(txtIconPicker.Value))
                {
                    specialty.SpecialtyIcon = txtIconPicker.Value;
                }
                //specialty.SpecialtyIcon = "glyphicon-home";
                specialty.SpecialtyName = txtSpecialtyName.Text;
                //specialty.SpecialtyCode = txtSpecialtyCode.Text;

                if (hfLevel.Value == "一级")
                {
                    specialty.SpecialtyLevel = "二级";
                }
                else if (hfLevel.Value == "二级")
                {
                    specialty.SpecialtyLevel = "三级";
                }
                else
                {
                    specialty.SpecialtyLevel = "一级";
                }

                int iOrdinal = 0;
                if (!string.IsNullOrEmpty(txtOrdinal.Text) && Int32.TryParse(txtOrdinal.Text, out iOrdinal))
                {
                    specialty.Ordinal = iOrdinal;
                }

                specialty.IsInheritSchedule = ddlIsInheritSchedule.SelectedValue == "True";
                specialty.IsInheritTemplet = false;//ddlIsInheritTemplet.SelectedValue == "True";
                specialty.IsAllowUpdate = ddlIsAllowUpdate.SelectedValue == "True";
                specialty.IsAllowSubmit = ddlIsAllowSubmit.SelectedValue == "True";

                specialty.IsSendReceivePost = ddlIsSendReceivePost.SelectedValue == "1";
                specialty.IsSendUpdatePost = ddlIsSendUpdatePost.SelectedValue == "1";
                specialty.IsSendDeletePost = ddlIsSendDeletePost.SelectedValue == "1";
                //specialty.IsSendReceivePost = Convert.ToInt32(ddlIsSendReceivePost.SelectedValue);
                //specialty.IsSendUpdatePost = Convert.ToInt32(ddlIsSendUpdatePost.SelectedValue);
                //specialty.IsSendDeletePost = Convert.ToInt32(ddlIsSendDeletePost.SelectedValue);

                OleDbTransaction trans = conn.BeginTransaction();
                try
                {
                    BLL.Specialty.UpdateSpecialty(specialty, conn, trans);
                    trans.Commit();
                    hdMsg.Value = "修改成功!";
                    //Response.Write("<script>alert('修改成功!')</script>");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                   // Response.Write("<script>alert('" + ex.Message + "')</script>");
                    hdMsg.Value = ex.Message;
                }
            }
            conn.Close();
            //Response.Redirect("~/view/ActivityManage/SpecialtyList.aspx?specialtyMSg=" + hdMsg.Value);
        }

        protected void lkbSetPrize_Click(object sender, EventArgs e)
        {
            Response.Redirect("PrizeSet.aspx?SpecialID=" + ViewState["SpecialtyID"].ToString() + "&OpenFrom=specialtySet");
        }

      

        protected void ddlParent_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            int parentSpecialtyID = Convert.ToInt32(ddlParent.SelectedValue);
            Dal.Models.Specialty spl = BLL.Specialty.GetSpecialty(parentSpecialtyID,conn);
            hfLevel.Value = spl.SpecialtyLevel;
        }

        protected void SaveSchedule(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            OleDbTransaction trans = conn.BeginTransaction();
            Dal.Models.Schedule UcSchedule = new Dal.Models.Schedule();
            UcSchedule.SpecialtyID = Convert.ToInt32(ViewState["SpecialtyID"]);

            DateTime dt;
            if (!string.IsNullOrEmpty(ucSchedule.DeclarationBeginDate)
                && DateTime.TryParse(ucSchedule.DeclarationBeginDate, out dt))
            {
                UcSchedule.DeclarationBeginDate = dt;
            }

            if (!string.IsNullOrEmpty(ucSchedule.DeclarationEndDate)
                && DateTime.TryParse(ucSchedule.DeclarationEndDate, out dt))
            {
                UcSchedule.DeclarationEndDate = dt;
            }

            UcSchedule.IsDeclarationStart = ucSchedule.IsDeclarationStart == "True";
            UcSchedule.IsDeclarationAutoStart = ucSchedule.IsDeclarationAutoStart == "True";
            UcSchedule.IsDeclarationAutoEnd = ucSchedule.IsDeclarationAutoEnd == "True";

            if (!string.IsNullOrEmpty(ucSchedule.PrimaryElectionBeginDate)
                && DateTime.TryParse(ucSchedule.PrimaryElectionBeginDate, out dt))
            {
                UcSchedule.PrimaryElectionBeginDate = dt;
            }

            if (!string.IsNullOrEmpty(ucSchedule.PrimaryElectionEndDate)
                && DateTime.TryParse(ucSchedule.PrimaryElectionEndDate, out dt))
            {
                UcSchedule.PrimaryElectionEndDate = dt;
            }

            UcSchedule.IsPrimaryElectionStart = ucSchedule.IsPrimaryElectionStart == "True";
            UcSchedule.IsPrimaryElectionAutoStart = ucSchedule.IsPrimaryElectionAutoStart == "True";
            UcSchedule.IsPrimaryElectionAutoEnd = ucSchedule.IsPrimaryElectionAutoEnd == "True";

            if (!string.IsNullOrEmpty(ucSchedule.ExpertReviewBeginDate)
                && DateTime.TryParse(ucSchedule.ExpertReviewBeginDate, out dt))
            {
                UcSchedule.ExpertReviewBeginDate = dt;
            }

            if (!string.IsNullOrEmpty(ucSchedule.ExpertReviewEndDate)
                && DateTime.TryParse(ucSchedule.ExpertReviewEndDate, out dt))
            {
                UcSchedule.ExpertReviewEndDate = dt;
            }

            UcSchedule.IsExpertReviewStart = ucSchedule.IsExpertReviewStart == "True";
            UcSchedule.IsExpertReviewAutoStart = ucSchedule.IsExpertReviewAutoStart == "True";
            UcSchedule.IsExpertReviewAutoEnd = ucSchedule.IsExpertReviewAutoEnd == "True";

            if (!string.IsNullOrEmpty(ucSchedule.DownloadBeginDate)
               && DateTime.TryParse(ucSchedule.DownloadBeginDate, out dt))
            {
                UcSchedule.DownloadBeginDate = dt;
            }

            if (!string.IsNullOrEmpty(ucSchedule.DownloadEndDate)
                && DateTime.TryParse(ucSchedule.DownloadEndDate, out dt))
            {
                UcSchedule.DownloadEndDate = dt;
            }

            UcSchedule.IsDownloadStart = ucSchedule.IsDownloadStart == "True";
            UcSchedule.IsDownloadAutoStart = ucSchedule.IsDownloadAutoStart == "True";
            UcSchedule.IsDownloadAutoEnd = ucSchedule.IsDownloadAutoEnd == "True";

            //投票
            if (!string.IsNullOrEmpty(ucSchedule.VoteBeginDate)
               && DateTime.TryParse(ucSchedule.VoteBeginDate, out dt))
            {
                UcSchedule.VoteBeginDate = dt;
            }
            if (!string.IsNullOrEmpty(ucSchedule.VoteEndDate)
                && DateTime.TryParse(ucSchedule.VoteEndDate, out dt))
            {
                UcSchedule.VoteEndDate = dt;
            }
            UcSchedule.IsVoteStart = ucSchedule.IsVoteStart == "True";
            UcSchedule.IsVoteAutoStart = ucSchedule.IsVoteAutoStart == "True";
            UcSchedule.IsVoteAutoEnd = ucSchedule.IsVoteAutoEnd == "True";

            UcSchedule.IsReVoteStart = ucSchedule.IsReVoteStart == "True";

            try
            {
                BLL.Schedule.SetSchedule(UcSchedule, conn, trans);
                trans.Commit();
                hdMsg.Value = "时间节点设置成功！";
            }
            catch (Exception ex)
            {
                trans.Rollback();
                hdMsg.Value = ex.Message;
                ViewState["ErrorMessage"] = ex.Message;
            }

            conn.Close();
        }




    }
}