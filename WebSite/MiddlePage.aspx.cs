using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation
{
    public partial class MiddlePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strPara = Request["para"];
            string str = BLL.Encryption.Decrypt(strPara);
            Dal.Models.Organization org = JsonConvert.DeserializeObject<Dal.Models.Organization>(str);
            litMessage.Text = "<b>当前网站：评优系统</b><br/><br/>" + str;

            GetUserInfo();
        }

        public void GetUserInfo()
        {
            BKXPYServiceReference.BKXPY_UserTBWSSoapClient user = new BKXPYServiceReference.BKXPY_UserTBWSSoapClient("BKXPY_UserTBWSSoap");
            //初始化参数
            string PSW = "Mfj_zjz_01";
            string UserName = "BKS20160001";
            DataTable tbUser = null;
            int intError = 0;
            user.GetUser_WS(PSW, UserName, ref tbUser, ref intError);
            if (intError == 1)
            {  //读取表tbUser，获取用户表中的数据
                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();
                OleDbTransaction tran = conn.BeginTransaction();

                Dal.Models.Organization OrgList = BLL.Organization.GetOrganizationByName(tbUser.Rows[0]["CorpName"].ToString(),conn,tran);
                if (OrgList != null && OrgList.OrganizationCode != "" && OrgList.OrganizationCode == tbUser.Rows[0]["CorpCode"].ToString())
                {
                    Response.Redirect("../Mutual/HomePage.aspx");
                }
                else
                {
                    Dal.Models.Organization organization = new Dal.Models.Organization();
                    organization.OrganizationName = tbUser.Rows[0]["CorpName"].ToString();
                    organization.OrganizationCode = tbUser.Rows[0]["CorpCode"].ToString();
                    organization.OrganizationAddress = tbUser.Rows[0]["LinkAddress"].ToString();
                    //organization.LegalPersonName = "";
                    organization.UserName = tbUser.Rows[0]["CorpName"].ToString();
                    organization.Password = BLL.SysConstant.GetAppSettings("DefaultPassword", conn, tran); ;
                    //organization.Linkman = "";
                    organization.TelephoneNumber = tbUser.Rows[0]["LinkPhone"].ToString();
                    //organization.MobileNumber = "";
                    //organization.EmailAddress = "";
                    //organization.Postcode = ""
                    //organization.FaxNumber = "";

                    try
                    {
                        BLL.Organization.CreateOrganization(organization, 0, conn, tran);
                        tran.Commit();
                        conn.Close();
                        conn.Dispose();
                        Response.Redirect("../Mutual/HomePage.aspx");
                    }
                    catch (Exception)
                    {
                        tran.Rollback();
                        conn.Close();
                        conn.Dispose();
                    }
                }
            }
            else if (intError == 2)
            {  //不存在该用户
            }
            else if (intError == 3)
            {  //返回失败
            }
        }
    }
}