using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.Declaration
{
    public partial class DeclarationDeleted : System.Web.UI.Page
    {
        protected void BindDropDownList(DropDownList ddl, object objDataSource, string strDataTextField, string strDataValueField, string strDefaultText = "", string strDefaultValue = "")
        {
            ddl.DataSource = objDataSource;
            ddl.DataValueField = strDataValueField;
            ddl.DataTextField = strDataTextField;
            ddl.DataBind();

            if (!string.IsNullOrEmpty(strDefaultText))
            {
                ddl.Items.Insert(0, new ListItem(strDefaultText, strDefaultValue));
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ActivityType"] == null || Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
                return;
            }

            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            string strActivityType = Session["ActivityType"].ToString();
            //Dal.Models.Activity actActivated = BLL.Activity.GetActivity(strActivityType, conn);
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];

            if (user.UserType == "0806" || user.UserType == "0807")
            {
                txtDeclarationUnit.Visible = false;
                txtUserType.Text = "会员";
            }
            else {
                txtDeclarationUnit.Visible = true;
                txtUserType.Text = "管理员";
                ddlDeclarationStatus.Visible = false;
            }
            
            //奖项绑值
             BindDropDownList(ddlPrizeName, BLL.Prize.GetPrizeList(user, strActivityType, "", conn), "PrizeName", "PrizeID");

            //申报状态绑值
            ddlDeclarationStatus.Items.Add(new ListItem() { Text = "管理员删除", Value = "1805" });
            ddlDeclarationStatus.Items.Add(new ListItem() { Text = "会员单位删除", Value = "1806" });

            conn.Close();
        }
    }
}