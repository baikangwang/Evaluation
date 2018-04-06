using Dal.Models;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.UserManage
{
    public partial class ManagerUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string id = Request.QueryString["id"].ToString();
                    getUserInfo(Convert.ToInt32(id));
                }
                catch
                {
                    Response.Redirect("UserList.aspx");
                }
            }
        }

        public void getUserInfo(int id)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            UserInfo user = BLL.User.GetUserInfo(id, conn);
            UserName.Text = user.UserName;
            //PassWord.Text = user.Password;
            Email.Text = user.Email;

            conn.Close();
        }

        protected void BtnEditUser_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            UserInfo user = BLL.User.GetUserInfo(Convert.ToInt32(Request["id"]), conn);
            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                user.UserName = UserName.Text.Trim();
                //user.Password = PassWord.Text;
                user.Email = Email.Text.Trim();
                BLL.User.Update(user, conn, tran);
                tran.Commit();
                //Response.Write("<script>alert('修改成功!')</script>");
                hdMsg.Value = "修改成功!";
            }
            catch (Exception)
            {
                //Response.Write("<script>alert('修改失败!')</script>");
                hdMsg.Value = "修改失败!";
                tran.Rollback();
            }

            conn.Close();
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../View/UserManage/UserList.aspx");
        }
    }
}