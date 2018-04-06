using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.Declaration
{
    public partial class AuditOpinion : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnAuditOpinionSave_Click(object sender, EventArgs e)
        {
            //Dal.Models.TemplateInfo tempInfo = (Dal.Models.TemplateInfo)Session["TemplateInfo"];
            //BLL.Common.SaveData<Dal.Models.Template_0302>(
            //tempInfo.DeclarationID.Value, new Dal.Models.Template_0302(), panelPart_0302);
        }
    }
}