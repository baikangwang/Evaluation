using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.Declaration
{
    public partial class Declare : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtSepcCode.Value = Request["SepcCode"];
            }
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            string SepcCode = Request["SepcCode"];//new

            Response.Redirect("Declaration.aspx?SepcCode=" + SepcCode + "");//new
        }
    }
}