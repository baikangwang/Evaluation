using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.Declaration
{
    public partial class PublicBuildingReview : System.Web.UI.Page
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
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
           // Dal.Models.TemplateInfo tempInfo = (Dal.Models.TemplateInfo)Session["TemplateInfo"];
           // Dal.Models.TemplateInfo tempInfo = ((Declaration)Context.Handler).TempInfo;  

            DataTable dtData = BLL.Declaration.GetDeclarationData(tempInfo.DeclarationID.Value, conn);
            DataRow[] rows = dtData.Select("RecordType='RichText'");

            System.Web.UI.Control ctrl = null;
            foreach (DataRow row in rows)
            {
                if (this.FindControl(row["RecordNameEn"].ToString()) != null)
                {
                    ctrl = this.FindControl(row["RecordNameEn"].ToString());
                    ((System.Web.UI.WebControls.Label)ctrl).Text =
                                row["Data"] == null || row["Data"] == DBNull.Value ? "" : row["Data"].ToString();
                }
            }
        }
      
    }
}