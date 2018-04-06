using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.Declaration
{
    public partial class CivilAirDefenceReview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dal.Models.TemplateInfo tempInfo = null;
            try
            {
                tempInfo = ((Declaration)Context.Handler).TempInfo;
            }
            catch
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }
            if (tempInfo == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }

            txtDeclarationID.Text = tempInfo.DeclarationID.ToString();
        }
        public void SetDropDownList(DropDownList drop, List<Dal.Models.SysConstant> lst)
        {
           
        }
    }
}