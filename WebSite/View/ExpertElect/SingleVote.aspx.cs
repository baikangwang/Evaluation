using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.ExpertElect
{
    public partial class SingleVote : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InitPage();
            }
        }
        private void InitPage()
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            string PrizeID = Request["PrizeID"].ToString();
            txtPrizeID.Text = PrizeID;
            labPrizeName.Text = BLL.Prize.GetPrize(Convert.ToInt32(PrizeID), conn).PrizeName.ToString();
            conn.Close();
        }
    }
}