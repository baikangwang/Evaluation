using Dal.Models;
using System;
using System.Data.OleDb;

namespace Evaluation.View.UserManage
{
    public partial class LeaguerChildUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (string.IsNullOrEmpty(Request["lcuid"]))
                {
                    BtnEditUser.Visible = false;
                }
                else
                {
                    int id = Convert.ToInt32(Request["lcuid"]);
                    txtUserName.ReadOnly = true;
                    OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                    conn.Open();
                    UserInfo user = BLL.User.GetUserInfo(id, conn);
                    if (user != null)
                    {
                        txtUserName.Text = user.UserName;
                        txtEmail.Text = user.Email;
                    }
                    conn.Close();
                    btnCreateUser.Visible = false;
                }
            }
        }

        protected void BtnEditUser_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            OleDbTransaction tran = conn.BeginTransaction();
            int iVerification = Verification();
            if (iVerification > 0)
            {
                //Dal.Models.MailInfo mailinfo = new Dal.Models.MailInfo();
                //mailinfo.Subject = "";
                //mailinfo.SenderAddress = System.Configuration.ConfigurationManager.AppSettings["SenderAddress"];
                //mailinfo.SmtpAcount = System.Configuration.ConfigurationManager.AppSettings["SmtpAcount"];
                //mailinfo.SmtpPassword = System.Configuration.ConfigurationManager.AppSettings["SmtpPassword"];
                //mailinfo.RecipientAddress.Add(txtEmail.Text.Trim());
                //mailinfo.BCC.Add(txtEmail.Text.Trim());
                //mailinfo.CC.Add(txtEmail.Text.Trim());
                //mailinfo.IsBodyHtml = true;
                //mailinfo.Content = "您已成功修改" + System.Configuration.ConfigurationManager.AppSettings["SystemName"] + "系统的账号！";
                //try
                //{
                //    BLL.Common.SendMail(mailinfo);
                    try
                    {
                        UserInfo user = BLL.User.GetUserByName(txtUserName.Text, conn, tran);
                        user.Email = txtEmail.Text.Trim();
                        //user.Password = BLL.Common.MD5Encrypt(txtPassword.Text);
                        BLL.User.Update(user, conn, tran);
                        tran.Commit();
                        //Response.Write("<script>alert('修改成功!')</script>");
                        hdMsg.Value = "修改成功!";
                    }
                    catch
                    {
                        tran.Rollback();
                    }
                //}
                //catch
                //{
                //    hdMsg.Value = "邮箱错误或不存在，请重新输入！";
                //}
            }
            conn.Close();
        }

        public int Verification()
        {
            int iResult = 1;
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                //Response.Write("<script>alert('请输入用户名或密码!')</script>");
                hdMsg.Value = "请输入用户名!";
                iResult = -1;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text))
            {
                //Response.Write("<script>alert('请输入邮箱!')</script>");
                hdMsg.Value = "请输入邮箱!";
                iResult = -1;
            }
            //else if (txtPassword.Text != txtPasswordConfirm.Text)
            //{
            //    //Response.Write("<script>alert('两次密码输入不一致!')</script>");
            //    hdMsg.Value = "两次密码输入不一致!";
            //}
            //else
            //{
            //    iResult = 1;
            //}
            return iResult;
        }

        protected void btnCreateUser_Click(object sender, EventArgs e)
        {
            UserInfo CreateUser = (UserInfo)Session["UserInfo"];
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            int iVerification = Verification();
            if (iVerification > 0)
            {
                //Dal.Models.MailInfo mailinfo = new Dal.Models.MailInfo();
                //mailinfo.Subject = "";
                //mailinfo.SenderAddress = System.Configuration.ConfigurationManager.AppSettings["SenderAddress"];
                //mailinfo.SmtpAcount = System.Configuration.ConfigurationManager.AppSettings["SmtpAcount"];
                //mailinfo.SmtpPassword = System.Configuration.ConfigurationManager.AppSettings["SmtpPassword"];
                //mailinfo.RecipientAddress.Add(txtEmail.Text.Trim());
                //mailinfo.BCC.Add(txtEmail.Text.Trim());
                //mailinfo.CC.Add(txtEmail.Text.Trim());
                //mailinfo.IsBodyHtml = true;
                //mailinfo.Content = "您已成功注册" + System.Configuration.ConfigurationManager.AppSettings["SystemName"] + "系统的账号！";
                //try
                //{
                    //BLL.Common.SendMail(mailinfo);
                    OleDbTransaction tran = conn.BeginTransaction();
                    UserInfo user = new UserInfo();
                    user.UserName = txtUserName.Text;
                    //string strPwd = System.Configuration.ConfigurationManager.AppSettings["DefaultPassword"];
                    string strPwd = BLL.SysConstant.GetAppSettings("DefaultPassword", conn, tran);
                    user.Password = strPwd;
                    user.Email = txtEmail.Text;
                    user.CreateUser = CreateUser.UserID.Value;
                    user.IsPasswordChanged = false;
                    try
                    {
                        BLL.User.CreateUser(user, conn, tran);
                        BLL.User.ResetPassword(user.UserID.Value, strPwd, conn, tran);
                        tran.Commit();
                        //Response.Write("<script>alert('修改成功!')</script>");
                        hdMsg.Value = "保存成功!";
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        hdMsg.Value = ex.Message;
                    }
                //}
                //catch
                //{
                //    hdMsg.Value = "邮箱错误或不存在，请重新输入！";
                //}
                conn.Close();
            }
        }

        protected void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/view/UserManage/LeaguerChildUserList.aspx");
        }
    }
}
   
