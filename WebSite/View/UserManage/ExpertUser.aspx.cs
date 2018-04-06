using Dal.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace Evaluation.View.UserManage
{
    public partial class ExpertUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }

            if(!IsPostBack)
            {
                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();

                // 获取当前活动
                string strActivityType = Session["ActivityType"].ToString();
                Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
                if (activity == null)
                {
                    Response.Redirect("../Mutual/HomePage.aspx");
                    return;
                }

                // 获取当前活动顶级专业
                List<Dal.Models.Specialty> lstSpecial = BLL.Specialty.GetSpecialtyList(activity.ActivityID.Value, true, conn);
                ddlSpecialty.DataSource = lstSpecial;
                ddlSpecialty.DataTextField = "SpecialtyName";
                ddlSpecialty.DataValueField = "SpecialtyID";
                ddlSpecialty.DataBind();

                listSpecialty.Enabled = false;

                if (!string.IsNullOrEmpty(Request["epid"]))
                {
                    InitPage(conn);
                }
                else
                {
                    listSpecialty.Visible = false;
                    btnEditUser.Visible = false;
                }

                //Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
                //if (user.UserType == "0805") {
                //    trGender.Visible = false;
                //    trIdType.Visible = false;
                //    trId.Visible = false;
                //    trIdMsg.Visible = false;

                //}

                conn.Close();
            }
        }

        private void InitPage(OleDbConnection conn)
        {
            btnCreateUser.Visible = false;

            int iExpertId = 0;
            int.TryParse(Request["epid"], out iExpertId);
            if (iExpertId > 0)
            {
                try
                {
                    Dal.Models.UserInfo userinfo = (Dal.Models.UserInfo)Session["UserInfo"];
                    Dal.Models.Expert expert = BLL.Expert.GetExpert(iExpertId, conn);
                    if (userinfo.UserID == expert.UserID)
                    {
                        ddlSpecialty.Enabled = false;
                        ddlSpecialty.Visible = false;
                        listSpecialty.Visible = true;
                    }
                    else
                    {
                        userinfo = BLL.User.GetUserInfo(expert.UserID.Value, conn);
                    }
                    txtExpertName.Text = expert.ExpertName;
                    txtUserName.Text = userinfo.UserName;
                    txtAcademicTitle.Text = expert.AcademicTitle;
                    txtProfession.Text = expert.Profession;
                    txtWorkplace.Text = expert.Workplace;
                    rbtnIDType.SelectedValue = expert.IDType;
                    txtIDNumber.Text = expert.IDNumber;

                    //if (expert.IDType == "0901" && BLL.IDOperation.CheckIDCard18(expert.IDNumber))
                    //{
                    //    rbtnIDType.Enabled = false;
                    //    txtIDNumber.Enabled = false;                       
                    //}

                    txtEmail.Text = userinfo.Email;
                    ddlGender.SelectedValue = expert.Gender;
                    if (expert.SpecialtyIDs != null && expert.SpecialtyIDs != "" && expert.SpecialtyNames != null && expert.SpecialtyNames != "")
                    {
                        string[] arrSpecialtyID = expert.SpecialtyIDs.Split(',');
                        expert.SpecialtyNames = expert.SpecialtyNames.Replace(",", "，");
                        string[] arrSpecialtyName = expert.SpecialtyNames.Split('，');
                        for (int i = 0; i < arrSpecialtyID.Length; i++)
                        {
                            listSpecialty.Items.Add(new System.Web.UI.WebControls.ListItem(arrSpecialtyName[i], arrSpecialtyID[i]));
                        }
                        checkeds.Value = string.Join(",", arrSpecialtyID);
                    }
                    hdMsg.Value = "";
                }
                catch (Exception ex)
                {
                    hdMsg.Value = ex.Message;
                }
            }
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            if (user.UserType == "0805")
            {
                txtExpertName.Enabled = false;
                //ddlGender.Enabled = false;
                txtAcademicTitle.Enabled = false;
                txtProfession.Enabled = false;
            }
        }

        protected void btnEditUser_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            // 获取当前活动
            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                Response.Redirect("../Mutual/HomePage.aspx");
                return;
            }

            int iExpertId = 0;
            int.TryParse(Request["epid"], out iExpertId);
            Dal.Models.Expert expert = BLL.Expert.GetExpert(iExpertId, conn);
            expert.ExpertName = txtExpertName.Text;
            expert.AcademicTitle = txtAcademicTitle.Text;
            expert.Profession = txtProfession.Text;
            expert.Workplace = txtWorkplace.Text;
            expert.IDType = rbtnIDType.SelectedValue;
            expert.IDNumber = txtIDNumber.Text;
            expert.Gender = ddlGender.SelectedValue;
            expert.Email = txtEmail.Text;
            expert.SpecialtyIDs = checkeds.Value;

            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                BLL.Expert.UpdateExpert(expert, conn, tran);
                BLL.User.SetUserSpecialty(expert.UserID.Value, activity.ActivityID.Value, expert.SpecialtyIDs, conn, tran);
                tran.Commit();
                hdMsg.Value = "修改成功!";
            }
            catch (Exception ex)
            {
                tran.Rollback();
                conn.Close();
                hdMsg.Value = ex.Message;
                return;
            }
            conn.Close();
        }

        protected void btnCreateUser_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

                        // 获取当前活动
            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                Response.Redirect("../Mutual/HomePage.aspx");
                return;
            }
            OleDbTransaction tran = conn.BeginTransaction();
            Dal.Models.Expert expert = new Dal.Models.Expert();
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            expert.ExpertName = txtExpertName.Text;
            expert.AcademicTitle = txtAcademicTitle.Text;
            expert.Profession = txtProfession.Text;
            expert.Workplace = txtWorkplace.Text;
            expert.IDType = rbtnIDType.SelectedValue;
            expert.IDNumber = txtIDNumber.Text;
            expert.Gender = ddlGender.SelectedValue;
            expert.Email = txtEmail.Text;
            expert.SpecialtyIDs = checkeds.Value;
            //string strDefaultPassword = System.Configuration.ConfigurationManager.AppSettings["DefaultPassword"];
            string strDefaultPassword = BLL.SysConstant.GetAppSettings("DefaultPassword", conn, tran);
           
            try
            {
                BLL.Expert.CreateExpert(expert, strDefaultPassword, user.UserID.Value, conn, tran);
                BLL.User.SetUserSpecialty(expert.UserID.Value, activity.ActivityID.Value, expert.SpecialtyIDs, conn, tran);
                tran.Commit();
                hdMsg.Value = "添加成功!";
                conn.Close();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                conn.Close();
                hdMsg.Value = ex.Message;
                return;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/view/ExpertManage/ExpertList.aspx");
        }
    }
}