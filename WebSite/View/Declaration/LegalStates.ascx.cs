using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.Declaration
{
    public partial class LegalStates : System.Web.UI.UserControl
    {
        public Dal.Models.Organization Org { get; set; }
        public Dal.Models.Declaration Decl { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                LegalPeopleNumber.Text = Org.LegalPersonIDNo;
                LegalPeopleName.Text = Org.LegalPersonName;
                PriceName.Text = Decl.PrizeName;

                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();
                litAwardName.Text = BLL.SysConstant.GetAppSettings("AwardName", conn);
                conn.Close();
                conn.Dispose();
            }
            catch
            {
            }
            //DeliveryDate.Text = Decl.DeclareDate.Value.ToString("yyyy-MM-dd");
        }

    }
}