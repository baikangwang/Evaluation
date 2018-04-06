using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.UserManage
{
    public partial class UpdatePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            int userID = Request.QueryString["setPsUserID"] == null ? 0 : Convert.ToInt32(Request.QueryString["setPsUserID"]);
            Dal.Models.UserInfo user = new Dal.Models.UserInfo();
            if (userID > 0)
            {
                user = BLL.User.GetUserInfo(userID,conn);
            }
            if (BLL.Encryption.MD5Encrypt(txtYsPassword.Text.Trim(), conn) != user.Password
                && BLL.Encryption.MD5Encrypt(txtYsPassword.Text.Trim()) != user.Password)
            {
                hdMsg.Value = "原始密码错误，请重新输入！";
                return;
            }
            else
            {
                //修改当前登录用户
                string newPassword = txtPassword.Text.Trim();
                try
                {
                    BLL.User.ResetPassword(Convert.ToInt32(user.UserID), newPassword, conn);
                    hdMsg.Value = "修改成功！";
                }
                catch (Exception ex)
                {
                    hdMsg.Value = ex.Message;
                    conn.Close();
                }
                conn.Close();
            }
        }

        protected void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/Mutual/HomePage.aspx");
        }
    }
}