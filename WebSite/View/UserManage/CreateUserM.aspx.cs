using Dal.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace Evaluation.View.UserManage
{
    public partial class CreateUserM : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }
            if (!IsPostBack)
            {
                InitSpecialty();
                int userId = Request.QueryString["id"] == null ? 0 : Convert.ToInt32(Request.QueryString["id"]);
                hdUserID.Value = userId.ToString();
                string type = Request.QueryString["operateType"] == null ? "" : Request.QueryString["operateType"].ToString();
                if (type == "update")
                {
                    Dal.Models.UserInfo userLogin = (Dal.Models.UserInfo)Session["UserInfo"];
                    if (userLogin.UserID.Value == userId)
                    {
                        hdIsSelf.Value = "true";
                    }

                    operateType.Value = type;
                    OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                    conn.Open();
                    UserInfo user = BLL.User.GetUserInfo(userId, conn);
                    //List<UserSpecialty> userSp = BLL.User.GetUserSpecialtyList(userId, conn);
                    checkeds.Value = BLL.User.GetUserSpecialtyIDs(userId, conn);
                    conn.Close();

                    txtUserName.Value = user.UserName;
                    txtEmail.Value = user.Email;

                    //string temp = "";
                    //if (userSp.Count > 0)
                    //{
                    //    for (int i = 0; i < userSp.Count; i++)
                    //    {
                    //        temp += userSp[i].SpecialtyID.Value.ToString() + ",";
                    //    }
                    //    checkeds.Value = temp.Substring(0, temp.Length - 1);
                    //}
                    InitSpecialtyList();
                }
            }
        }

        public void InitSpecialty()
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                Response.Redirect("../Mutual/HomePage.aspx");
                return;
            }
            else
            {
                ddlSpecialty.DataSource = BLL.Specialty.GetSpecialtyList(activity.ActivityID.Value, true, conn);
                ddlSpecialty.DataTextField = "SpecialtyName";
                ddlSpecialty.DataValueField = "SpecialtyID";
                ddlSpecialty.DataBind();
            }
            conn.Close();
        }

        public void InitSpecialtyList()
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            Dal.Models.UserInfo user = ((Dal.Models.UserInfo)Session["UserInfo"]);
            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                Response.Redirect("../Mutual/HomePage.aspx");
                return;
            }
            listSpecialty.DataSource = BLL.Specialty.GetSpecialtyListByUserType(activity.ActivityID.Value,user.UserType,user.UserID.Value, true, conn);
            listSpecialty.DataTextField = "SpecialtyName";
            listSpecialty.DataValueField = "SpecialtyID";
            listSpecialty.DataBind();
            conn.Close();
        }
    }
}