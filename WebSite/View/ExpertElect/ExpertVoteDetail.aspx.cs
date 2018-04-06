using Newtonsoft.Json;
using NPOI.HSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace Evaluation.View.ExpertElect
{
    public partial class ExpertVoteDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }
            if (Request.QueryString["PrizeID"] != null)
            {
                ViewState["PrizeID"] = Request.QueryString["PrizeID"];
            }
        }
        

    }
}