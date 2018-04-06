using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
namespace Evaluation.View.ActivityManage
{
    public partial class VoteDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            if (user == null)
            {
                Response.Redirect("~/View/Mutual/UserEntry.aspx");
            }
            else
            {
                DeclarationID.Value = Request.QueryString["DeclarationID"];
                lblDeclarationName.Text = Request.QueryString["DeclarationName"];
            }
        }
    }
}