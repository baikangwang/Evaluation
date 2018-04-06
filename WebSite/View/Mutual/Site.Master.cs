using System;
using System.Configuration;
using System.Data.OleDb;

namespace Evaluation.View.Mutual
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ActivityType"] == null || Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
                return;
            }

            if (!IsPostBack)
            {
                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();
                string strActivityType = ConfigurationManager.AppSettings["ActivityType"];

                hfLogoImage.Value = BLL.SysConstant.GetAppSettings("LogoImage_" + strActivityType, conn);
                
                Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
                if (user == null)
                {
                    Response.Redirect("../Mutual/UserEntry.aspx");
                }
                else
                {
                    string strTime = "";
                    if (DateTime.Now.Hour < 12)
                    {
                        strTime = "早上好，";
                    }
                    else if (DateTime.Now.Hour > 12 && DateTime.Now.Hour < 19)
                    {
                        strTime = "下午好，";

                    }
                    else
                    {
                        strTime = "晚上好，";
                    }

                    string strUserType = "";
                    try
                    {
                        strUserType = BLL.SysConstant.GetConstant(user.UserType, conn).ConstantValue;
                        tyUserType.Value = strUserType;
                    }
                    catch
                    {
                        strUserType = "用户";
                        user.LastLoginTime = DateTime.Now;
                    }

                    litTimeInfo.Text = strTime + strUserType + "（" + user.UserName + "）";
                    if(user.UserType=="0806")
                    {
                        spUserName.InnerText = user.OrganizationName;
                    }
                    else
                    {
                        spUserName.InnerText = user.UserName;
                    }

                    spUserLoginTime.InnerText = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
                }

                conn.Close();
            }

        }

        protected void btnLoginOut_Click(object sender, EventArgs e)
        {
            Session["UserInfo"] = null;
            Session["ActivityType"] = null;
            Response.Redirect("../Mutual/UserEntry.aspx");
        }

        protected void btnPassword_Click(object sender, EventArgs e)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            Response.Redirect("../UserManage/UpdatePassword.aspx?setPsUserID=" + user.UserID);
        }

        protected void forbiddenEnter_Click(object sender, EventArgs e)
        {

        }
    }
}