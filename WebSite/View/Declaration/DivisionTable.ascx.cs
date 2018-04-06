using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.Declaration
{
    public partial class DivisionTable : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //根据当前模板状态显示部件
                Dal.Models.TemplateInfo tempInfo = (Dal.Models.TemplateInfo)Session["TemplateInfo"];

                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();

                //显示模板的当前编辑部分
                //Page.Form.Controls[3].FindControl(tempInfo.Anchor).Visible = true;
                Dal.Models.Template_01_PublicBuilding tempPublicBuilding =
                    BLL.Declaration.GetDeclarationData<Dal.Models.Template_01_PublicBuilding>(tempInfo.DeclarationID.Value, conn);
                Dal.Models.Declaration decl = BLL.Declaration.GetDeclaration(tempInfo.DeclarationID.Value, conn);

                //SetDropDownList(DesignCategory, BLL.SysConstant.GetConstantList("14", conn));
                //SetDropDownList(InvestSource, BLL.SysConstant.GetConstantList("15", conn));
                //SetDropDownList(DeclarationLevel, BLL.SysConstant.GetConstantList("04", conn));

                //List<Dal.Models.SysConstant> lstDomesticOrAbord = BLL.SysConstant.GetConstantList("19", conn);
                //SetDropDownList(DomesticOrAbord1, lstDomesticOrAbord);
                //SetDropDownList(DomesticOrAbord2, lstDomesticOrAbord);
                //SetDropDownList(DomesticOrAbord3, lstDomesticOrAbord);
                //SetDropDownList(DomesticOrAbord4, lstDomesticOrAbord);

                //List<Dal.Models.SysConstant> lstCollaborativePhase = BLL.SysConstant.GetConstantList("20", conn);
                //SetDropDownList(CollaborativePhase1, lstCollaborativePhase);
                //CollaborativePhase1.Items.Insert(0, new ListItem(""));
                //SetDropDownList(CollaborativePhase2, lstCollaborativePhase);
                //CollaborativePhase2.Items.Insert(0, new ListItem(""));
                //SetDropDownList(CollaborativePhase3, lstCollaborativePhase);
                //CollaborativePhase3.Items.Insert(0, new ListItem(""));
                //SetDropDownList(CollaborativePhase4, lstCollaborativePhase);
                //CollaborativePhase4.Items.Insert(0, new ListItem(""));

                //为控件赋值
                BLL.Common.SetData<Dal.Models.Template_01_PublicBuilding>(tempPublicBuilding, Page);

                // 设置参与人员
                //ucParticipant.ParticipantList = BLL.Declaration.GetParticipant(tempInfo.DeclarationID.Value, conn);

                Dal.Models.Organization org = BLL.Organization.GetOrganization(decl.OrganizationID.Value, conn);
                //DeclarationName.Text = decl.DeclarationName;
                DeclarationUnit.Text = org.OrganizationName;
                //PostalAddress.Text = org.OrganizationAddress;
                //Linkman.Text = org.Linkman;
                //TelephoneNumber.Text = org.TelephoneNumber;
                //FaxNumber.Text = org.FaxNumber;
                //MobileNumber.Text = org.MobileNumber;
                //Postcode.Text = org.Postcode;
                //EmailAddress.Text = Request.QueryString["id"];//org.EmailAddress

                conn.Close();
            }
        }
        protected void btnDivisionTablePrev_Click(object sender, EventArgs e)
        {

        }
        protected void btnDivisionTableNext_Click(object sender, EventArgs e)
        {

        }
    }
}