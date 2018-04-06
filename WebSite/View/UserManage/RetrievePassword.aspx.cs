using System;

namespace Evaluation.View.UserManage
{
    public partial class RetrievePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dal.Models.UserInfo user = ((Dal.Models.UserInfo)Session["UserInfo"]);
            if (user != null && user.UserName != null)
            {
                txtUserName.Text = user.UserName;
            }
            else 
            {
                string strUserLoginName = Request.QueryString["userLoginName"];
                txtUserName.Text = strUserLoginName;
            }
        }
    }
}