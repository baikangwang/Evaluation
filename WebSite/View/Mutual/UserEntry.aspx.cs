using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Evaluation.View.Mutual
{
    public partial class UserEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookies = Request.Cookies["Evaluation"];

            //判断是否有cookie值，有的话就读取出来
            if (cookies != null && cookies.HasKeys)
            {
                if (txtUserName.Text.Trim() == "" || txtUserName.Text.Trim() == cookies["Name"])
                {
                    txtUserName.Text = cookies["Name"];
                    txtPwdword.Attributes.Add("value", cookies["Pwd"]);
                    this.chkState.Checked = true;
                }
            }

            if (!IsPostBack)
            {
                string strActivityType = ConfigurationManager.AppSettings["ActivityType"];
                try
                {
                    OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                    conn.Open();

                    Dictionary<string, string> dicAppSettings = BLL.SysConstant.GetAppSettingDict(strActivityType, conn);
                    txtEntryImage.Text = dicAppSettings["EntryImage_" + strActivityType];
                    txtEntryNoticeInformation.Text = dicAppSettings["EntryNoticeInformation_" + strActivityType];
                    txtEntryFooterInformation1.Text = dicAppSettings["EntryFooterInformation1_" + strActivityType];
                    txtEntryFooterInformation2.Text = dicAppSettings["EntryFooterInformation2_" + strActivityType];
                    txtEntryFooterInformation3.Text = dicAppSettings["EntryFooterInformation3_" + strActivityType];

                    conn.Close();
                }
                catch
                {
                    ;
                }
            }
        }

        protected void lkbLogin_Click(object sender, EventArgs e)
        {
            Dal.Models.Activity actActivated = null;
            Dal.Models.UserInfo user = new Dal.Models.UserInfo();
            string strErrorMessage = "";
            try
            {
                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();
                user = BLL.User.Login(txtUserName.Text.Trim()
                    , txtPwdword.Text.Trim()
                    , ConfigurationManager.AppSettings["ActivityType"]
                    , out actActivated, conn);

                conn.Close();

                if (user != null)
                {
                    // 活动关闭阶段只有超级管理员、系统管理员、协会管理员可以登录
                    if (actActivated == null && !(new string[] { "0801", "0802", "0803" }).Contains(user.UserType))
                    {
                        strErrorMessage = "活动暂未开启，请耐心等待！";
                    }
                    else
                    {
                        if (user.UserStatus == "0701")
                        {
                            user.Password = "";
                            Session["UserInfo"] = user;
                            Session["ActivityType"] = ConfigurationManager.AppSettings["ActivityType"];

                            Response.Cookies.Add(new HttpCookie("ActivityType", ConfigurationManager.AppSettings["ActivityType"]));
                            Response.Cookies.Add(new HttpCookie("UserInfo", JsonConvert.SerializeObject(user)));
                            Response.Cookies.Add(new HttpCookie("WebServiceHost", ConfigurationManager.AppSettings["WebServiceHost"]));

                            Response.Cookies["UserId"].Value = (user.UserID).ToString();
                            Response.Cookies["UserId"].Expires = DateTime.Now.AddHours(1);
                        }
                        else
                        {
                            strErrorMessage = "申报开始后，非协会推荐企业，不允许登录系统进行申报!";
                        }
                    }
                }
                else
                {
                    strErrorMessage = "用户名或者密码错误!";
                }
            }
            catch (Exception ex)
            {
                strErrorMessage = ex.Message;
            }

            if (string.IsNullOrEmpty(strErrorMessage))
            {
                Response.Redirect("HomePage.aspx");
            }
            else
            {
                hdMsg.Value = strErrorMessage;
            }
        }

        protected void forgetPassword_Click(object sender, EventArgs e)
        {

            string userLoginName = txtUserName.Text.Trim();
            if (userLoginName == null || userLoginName == "")
            {
                hdMsg.Value = "请先输入账号！";
            }
            else
            {
                Response.Redirect("../UserManage/RetrievePassword.aspx?userLoginName=" + userLoginName);
            }
        }
    }
}