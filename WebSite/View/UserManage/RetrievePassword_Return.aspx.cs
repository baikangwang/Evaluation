using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.UserManage
{
    public partial class RetrievePassword_Return : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int iUserId = 0;
            string strId = BLL.Encryption.Decrypt(Request["id"]);//解密
            int.TryParse(strId, out iUserId);
            if (iUserId == 0)
            {
                Response.Redirect("../UserManage/RetrievePassword.aspx");
            }
            if(!IsPostBack)
            {
                InitPage(iUserId);
            }

        }
        public void InitPage(int iUserId)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            Dal.Models.UserInfo user = BLL.User.GetUserInfo(iUserId, conn);
            UserName.Text = user.UserName;
            conn.Close();
        }

        protected void Btn_success_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(UserName.Text))
            {
                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();
                if (Password.Text != Password_R.Text)
                {
                    //Response.Write("<script>alert('两次输入密码不同')</script>");
                    hdMsg.Value = "两次输入密码不同!";
                }
                else
                {
                    Dal.Models.UserInfo user = BLL.User.GetUserByName(UserName.Text, conn);
                    user.Password = Password.Text.Trim();
                    BLL.User.ResetPassword(user.UserID.Value, user.Password, conn);
                    Response.Redirect("../UserManage/RetrievePasswordSuccess.aspx");
                }
                conn.Close();
            }
        }
    }
}