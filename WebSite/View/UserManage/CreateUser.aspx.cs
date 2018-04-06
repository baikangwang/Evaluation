using Dal.Models;
using System;
using System.Data.OleDb;

namespace Evaluation.View.UserManage
{
    public partial class CreateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }
            InitPage();
        }
        public void InitPage()
        {
            Dal.Models.UserInfo userinfo = (Dal.Models.UserInfo)Session["UserInfo"];

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
                //ddlSpecialtyUser.DataSource = BLL.Specialty.GetSpecialtyList(activity.ActivityID.Value, false, conn);
                //ddlSpecialtyUser.DataValueField = "SpecialtyID";
                //ddlSpecialtyUser.DataTextField = "SpecialtyName";
                //ddlSpecialtyUser.DataBind();
            }
        }
        
    }
}