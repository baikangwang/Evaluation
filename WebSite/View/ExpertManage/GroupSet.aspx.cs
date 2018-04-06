using Dal.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Web.UI.WebControls;

namespace Evaluation.View.ExpertManage
{
    public partial class GroupSet : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"] == null )
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }

            if (!IsPostBack)
            {
                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();
                InitDdlProfession();

                string strGroupID = Request["GroupID"];
                if (!string.IsNullOrEmpty(strGroupID))
                {
                    Dal.Models.ExpertGroup ExpertGroup = BLL.ExpertGroup.GetExpertGroup(Convert.ToInt32(strGroupID), conn);
                    ddlSpecialty.SelectedValue = ExpertGroup.SpecialtyID.ToString();
                    txtExpertGroupName.Text = ExpertGroup.GroupName;
                    txtExpertGroupLeader.Text = ExpertGroup.GroupLeader.ToString();

                    txtExpertGroupLeaderText.Value = ExpertGroup.LeaderName;

                    txtDeputyLeader.Text = ExpertGroup.DeputyIDs;

                    txtDeputyLeaderText.Value = ExpertGroup.DeputyNames;

                    hfParentID.Value = ExpertGroup.ParentID == null ? "0" : ExpertGroup.ParentID.ToString();
                }
            }
        }

        //初始化加载专业下拉列表
        public void InitDdlProfession()
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            Dal.Models.UserInfo userinfo = (Dal.Models.UserInfo)Session["UserInfo"];
            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                Response.Redirect("../Mutual/HomePage.aspx");
                return;
            }
            OleDbTransaction tran = conn.BeginTransaction();
            List<Specialty> profession = BLL.Specialty.GetSpecialtyListByUserType(activity.ActivityID.Value, userinfo.UserType, userinfo.UserID.Value, false, conn, tran);//BLL.Specialty.GetSpecialtyList(activity.ActivityID.ToString(),conn, tran);
            ddlSpecialty.DataSource = profession;
            ddlSpecialty.DataTextField = "SpecialtyName";
            ddlSpecialty.DataValueField = "SpecialtyID";
            ddlSpecialty.DataBind();
            
        }

        //初始化上级专家组下拉列表
        public void InitParentGroup(int specialtyID)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            OleDbTransaction tran = conn.BeginTransaction();
            Dal.Models.UserInfo userinfo = (Dal.Models.UserInfo)Session["UserInfo"];
            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn,tran);
            if (activity == null)
            {
                Response.Redirect("../Mutual/HomePage.aspx");
                return;
            }
            //string SpecialtyIDs = BLL.Specialty.GetSpecialtyByUserType(activity.ActivityID.Value, userinfo.UserID.Value, conn, tran);
            List<Dal.Models.ExpertGroup> profession = BLL.ExpertGroup.GetGroupList(activity.ActivityID.Value, specialtyID.ToString(), conn, tran);
            ddlParentGroup.DataSource = profession;
            ddlParentGroup.DataTextField = "GroupName";
            ddlParentGroup.DataValueField = "GroupID";
            ddlParentGroup.DataBind();
            ddlParentGroup.Items.Remove(ddlParentGroup.Items.FindByText(txtExpertGroupName.Text));
        }
             
        protected void btnSaveExpertGroup_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                hdMsg.Value = "当前活动已关闭，请联系活动管理人员！";
                return;
            }

            Dal.Models.ExpertGroup expertGroup = new Dal.Models.ExpertGroup();
            string strGroupID = Request["GroupID"];
            if (!string.IsNullOrEmpty(strGroupID))
            {
                expertGroup.GroupID = Convert.ToInt32(strGroupID);
            }

            if (hfParentID.Value != "0" && hfParentID.Value != "")
            {
                expertGroup.ParentID = Convert.ToInt32(hfParentID.Value);
            }

            expertGroup.GroupName = txtExpertGroupName.Text;
            expertGroup.ActivityID = activity.ActivityID;
            expertGroup.SpecialtyID = Convert.ToInt32(ddlSpecialty.SelectedValue);

            // 组长
            if (!string.IsNullOrEmpty(txtExpertGroupLeader.Text.Trim()))
            {
                expertGroup.GroupLeader = Convert.ToInt32(txtExpertGroupLeader.Text.Trim());
            }
            else
            {
                hdMsg.Value = "专家组必须要有一个组长！";
                return;
            }

            // 副组长
            expertGroup.DeputyIDs = txtDeputyLeader.Text.Trim();

            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                BLL.ExpertGroup.CreateExpertGroup(expertGroup, user, conn, tran);
                tran.Commit();
                hdMsg.Value = "保存成功!";
            }
            catch (Exception ex)
            {
                tran.Rollback();
                hdMsg.Value = ex.Message;
                conn.Close();
                return;
            }
            conn.Close();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../View/ExpertManage/GroupList.aspx");
        }
    }
}