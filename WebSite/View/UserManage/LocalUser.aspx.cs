using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.UserManage
{
    public partial class LocalUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }

            if (!IsPostBack)
            {
                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();
                ddlLocal.DataSource = BLL.SysConstant.GetConstantList("34", conn);
                ddlLocal.DataTextField = "ConstantValue";
                ddlLocal.DataValueField = "ConstantCode";
                ddlLocal.DataBind();

                int iUserID = 0;

                if (int.TryParse(Request.QueryString["id"], out iUserID))
                {
                    Dal.Models.UserInfo user = BLL.User.GetUserInfo(iUserID, conn);
                    txtUserName.Value = user.UserName;
                    txtEmail.Value = user.Email;
                    hdUserID.Value = Request.QueryString["id"];

                    Dal.Models.UserInfo userLogin = (Dal.Models.UserInfo)Session["UserInfo"];
                    if (iUserID == userLogin.UserID.Value)
                    {
                        ddlLocal.Enabled = false;
                        listLocal.Visible = true;
                    }
                    checkeds.Value = BLL.User.GetUserRegion(iUserID, conn);
                }
            }
        }
    }
}