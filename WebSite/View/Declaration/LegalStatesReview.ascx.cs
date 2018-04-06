using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.Declaration
{
    public partial class LegalStatesReview : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                    conn.Open();
                    litAwardName.Text = BLL.SysConstant.GetAppSettings("AwardName", conn);
                    conn.Close();
                    conn.Dispose();
                }
                catch
                {
                }
            }
        }
    }
}