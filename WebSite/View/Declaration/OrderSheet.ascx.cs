using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.Declaration
{
    public partial class OrderSheet : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Dal.Models.TemplateInfo tempInfo = (Dal.Models.TemplateInfo)Session["TemplateInfo"];

                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();

                Dal.Models.Declaration decl = BLL.Declaration.GetDeclaration(Convert.ToInt32(tempInfo.DeclarationID), conn);
                Dal.Models.Prize Prize = BLL.Prize.GetPrize(Convert.ToInt32(decl.PrizeID), conn);
                rdlPrize.Text = Prize.PrizeName;

                conn.Close();
            }
        }
        protected void btnOrderSheetPrev_Click(object sender, EventArgs e)
        {

        }
        protected void btnOrderSheetNext_Click(object sender, EventArgs e)
        {

        }
    }
}