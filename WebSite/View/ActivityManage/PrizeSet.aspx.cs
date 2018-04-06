using Dal.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web.UI.HtmlControls;

namespace Evaluation.View.ActivityManage
{
    public partial class PrizeSet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }

            if (!IsPostBack)
            {
                InitPage(Request["PrizeID"] ?? "", Request["SpecialID"] ?? "");
                hfOpenFrom.Value = Request["OpenFrom"];
                hfSpecialID.Value = Request["SpecialID"];
            }
      
        }
        private void InitPage(string strPrizeID, string strSpecialID)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                Response.Redirect("../Mutual/HomePage.aspx");
            }
            else
            {
                divMultipleVoteRound.Visible = false;
                //设置控件只读，（前台设置时，会导致后台取不到值。）
                txtPrizeCode.Attributes.Add("readonly", "true");

                // 所属专业绑值
                List<Dal.Models.Specialty> lstSpeciatly = BLL.Specialty.GetSpecialtyList(activity.ActivityID.Value, conn);

                ddlSpecialty.DataSource = lstSpeciatly;
                ddlSpecialty.DataValueField = "SpecialtyID";
                ddlSpecialty.DataTextField = "SpecialtyName";
                ddlSpecialty.DataBind();

                // 奖项的专业模版绑值
                ddlTemplateCode.DataSource = BLL.SysConstant.GetConstantList("02", conn);
                ddlTemplateCode.DataTextField = "ConstantValue";
                ddlTemplateCode.DataValueField = "ConstantCode";
                ddlTemplateCode.DataBind();

                //奖项类别选择绑定人员数量
                List<Dal.Models.SysConstant> lstPrizeType = BLL.SysConstant.GetConstantList("03", conn);
                System.Web.UI.WebControls.ListItem option = null;
                foreach (Dal.Models.SysConstant item in lstPrizeType)
                {
                    option = new System.Web.UI.WebControls.ListItem(item.ConstantValue, item.ConstantCode);
                    option.Attributes.Add("data", item.CorrelationValue);
                    ddlPrizeType.Items.Add(option);
                }

                // 综合奖投票类别
                List<Dal.Models.SysConstant> lstMultipleVote = BLL.SysConstant.GetConstantList("22", conn);
                ddlVoteType.DataTextField = "ConstantValue";
                ddlVoteType.DataValueField = "ConstantCode";
                ddlVoteType.DataBind();

                //判断是否存在奖项ID
                Dal.Models.Prize dprize = null;
                Dal.Models.Specialty dSpecialty = null;
                List<Dal.Models.Appendix> dAppendix = null;
                List<Dal.Models.Atlas> dAtlas = null;
                List<Dal.Models.Media> dMedia = null;

                int iPrizeID = 0;
                if (!string.IsNullOrEmpty(strPrizeID))
                {
                    ddlSpecialty.Attributes.Add("disabled", "disabled");
                    int.TryParse(strPrizeID, out iPrizeID);
                    dprize = BLL.Prize.GetPrize(iPrizeID, conn);
                    if (dprize != null)
                    {
                        dSpecialty = BLL.Specialty.GetSpecialty(dprize.SpecialtyID.Value, conn);
                        dAppendix = BLL.Appendix.GetAppendixListSpecialty(dprize.SpecialtyID.Value, conn);
                        dAtlas = BLL.Atlas.GetAtlasList(dprize.SpecialtyID.Value, AtlasType.Specialty, conn);
                        dMedia = BLL.Media.GetMediaList(dprize.SpecialtyID.Value, MediaType.Specialty, conn);
                    }
                }

                btnUpdatePrize.Visible = false;

                if (!string.IsNullOrEmpty(strSpecialID))
                {
                    ddlSpecialty.SelectedValue = strSpecialID;
                    ddlSpecialty.Attributes.Add("disabled", "disabled");
                    btnUpdatePrize.Visible = false;
                    dAppendix = BLL.Appendix.GetAppendixListSpecialty(Convert.ToInt32(strSpecialID), conn);
                    dAtlas = BLL.Atlas.GetAtlasList(Convert.ToInt32(strSpecialID), AtlasType.Specialty, conn);
                    dMedia = BLL.Media.GetMediaList(Convert.ToInt32(strSpecialID), MediaType.Specialty, conn);

                    SetAppendix(dAppendix);

                    SetAtlas(dAtlas);

                    SetMedia(dMedia);
                }

                if (dprize != null)
                {
                    if ((dprize.PrizeTypeCode == "0301" && dprize.IsMultipleVoting == true) || (dprize.PrizeTypeCode == "0304" && dprize.IsMultipleVoting == true))
                    {
                        divMultipleVoteRound.Visible = true;
                    }
                    ddlSpecialty.SelectedValue = dprize.SpecialtyID.ToString();
                    ddlVoteType.SelectedValue = dprize.VoteType;
                    txtPrizeName.Text = dprize.PrizeName;
                    txtPrizeID.Text = dprize.PrizeID.ToString();
                    txtPrizeCode.Text = dprize.PrizeCode;
                    ddlTemplateCode.SelectedValue = dprize.TemplateCode;
                    txtOrdinal.Text = dprize.Ordinal.ToString();
                    ddlPrizeType.SelectedValue = dprize.PrizeTypeCode;
                    txtParticipantLimit.Text = dprize.ParticipantLimit.ToString();

                    List<Dal.Models.PrizeLevel> pl = BLL.Prize.GetPrizeLimitNumList(dprize.PrizeID.Value, conn);
                    if (pl.Count != 0)
                    {
                        if (pl.Count > 2)
                        {
                            txtFirstPrizeNum.Text = pl[0].LevelLimitNumber.ToString();
                            txtSecondPrizeNum.Text = pl[1].LevelLimitNumber.ToString();
                            txtThirdPrizeNum.Text = pl[2].LevelLimitNumber.ToString();
                        }
                        else if (pl.Count > 1)
                        {
                            txtFirstPrizeNum.Text = pl[0].LevelLimitNumber.ToString();
                            txtSecondPrizeNum.Text = pl[1].LevelLimitNumber.ToString();
                        }
                        else
                        {
                            txtPrizeNum.Text = pl[0].LevelLimitNumber.ToString();
                        }
                    }

                    SetAppendix(dAppendix);

                    SetAtlas(dAtlas);

                    SetMedia(dMedia);
                    
                    txtSpecialtyID.Text = dprize.SpecialtyID.ToString();
                    btnCreatePrize.Visible = false;
                    btnUpdatePrize.Visible = true;
                    ddlPrizeType.Attributes.Add("disabled", "disabled");
                }
            }
            conn.Close();
        }

        public void SetAtlas(List<Dal.Models.Atlas> dAtlas)
        {
            for (int i = 0; i < dAtlas.Count; i++)
            {
                HtmlTableRow tu = new HtmlTableRow();
                HtmlTableCell tuji1 = new HtmlTableCell("td");
                HtmlTableCell tuji2 = new HtmlTableCell("td");
                tuji1.InnerHtml = dAtlas[i].Ordinal.ToString();
                tuji2.InnerHtml = dAtlas[i].AtlasName.ToString();
                tu.Cells.Add(tuji1);
                tu.Cells.Add(tuji2);
                lsAtlasDiscription.Rows.Add(tu);
            }
        }

        public void SetAppendix(List<Dal.Models.Appendix> dAppendix)
        {
            for (int i = 0; i < dAppendix.Count; i++)
            {
                HtmlTableRow tr = new HtmlTableRow();
                HtmlTableCell td1 = new HtmlTableCell("td");
                HtmlTableCell td2 = new HtmlTableCell("td");
                td1.InnerHtml = dAppendix[i].Ordinal.ToString();
                td2.InnerHtml = dAppendix[i].AppendixName.ToString();
                tr.Cells.Add(td1);
                tr.Cells.Add(td2);
                lstAppendixDiscription.Rows.Add(tr);
            }
        }

        public void SetMedia(List<Dal.Models.Media> dMedia)
        {
            for (int i = 0; i < dMedia.Count; i++)
            {
                HtmlTableRow tr = new HtmlTableRow();
                HtmlTableCell td1 = new HtmlTableCell("td");
                HtmlTableCell td2 = new HtmlTableCell("td");
                td1.InnerHtml = dMedia[i].Ordinal.ToString();
                td2.InnerHtml = dMedia[i].MediaName.ToString();
                tr.Cells.Add(td1);
                tr.Cells.Add(td2);
                lstMedia.Rows.Add(tr);
            }
        }
    }
}