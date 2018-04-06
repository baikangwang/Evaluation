using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.Declaration
{
    public partial class Certificate : System.Web.UI.UserControl
    {
        public Dal.Models.Declaration Decl  { get; set; }
        public Dal.Models.Organization Org { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();
                OleDbTransaction trans = conn.BeginTransaction();
                DeclarationName.Text = Decl.DeclarationName;
                DeclarationUnit.Text = Org.OrganizationName;
                litDeclarationUnit.Text = Org.OrganizationName;
                SurveylitDeclarationUnit.Text = Org.OrganizationName;
                txtMaiDeclarationUnit.Text = Org.OrganizationName;

                Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
                txtUserType.Text = user.UserType;
                Dal.Models.Prize prize = BLL.Prize.GetPrize(Convert.ToInt32(Decl.PrizeID), conn, trans);
                uPrize.InnerText = prize.PrizeName;
                Dal.Models.Specialty spec = BLL.Specialty.GetSpecialty(Convert.ToInt32(prize.SpecialtyID), conn, trans);
                IsAllowUpdate.Value = spec.IsAllowUpdate.ToString();
                List<Dal.Models.TemplateConstant> sys = BLL.SysConstant.GetSysConstantListOfConstantDiscription(prize.TemplateCode, conn, trans);
                List<Dal.Models.Declaration_Data> decl = BLL.Declaration.GetDeclarationDivisionList(Convert.ToInt32(Decl.DeclarationID), sys[1].KeyValue, sys[0].KeyValue, conn, trans);
                TemplateCode.Value = prize.TemplateCode;
                txtdeclID.Text = Decl.DeclarationID.ToString();
                if (prize.TemplateCode == "0216" || prize.TemplateCode == "0217" || prize.TemplateCode == "0218")
                {
                    if (!string.IsNullOrEmpty(decl[0].Data))
                    {
                        txtCooperationUnit2.Text = decl[0].Data;
                    }
                    if (!string.IsNullOrEmpty(decl[2].Data))
                    {
                        txtUndertakeWork2.Text = decl[2].Data;
                    }

                    if (!string.IsNullOrEmpty(decl[3].Data))
                    {
                        txtCooperationUnit3.Text = decl[3].Data;
                    }
                    if (!string.IsNullOrEmpty(decl[5].Data))
                    {
                        txtUndertakeWork3.Text = decl[5].Data;
                    }

                    if (!string.IsNullOrEmpty(decl[6].Data))
                    {
                        txtCooperationUnit4.Text = decl[6].Data;
                    }
                    if (!string.IsNullOrEmpty(decl[8].Data))
                    {
                        txtUndertakeWork4.Text = decl[8].Data;
                    }

                    if (!string.IsNullOrEmpty(decl[9].Data))
                    {
                        txtCooperationUnit5.Text = decl[9].Data;
                    }
                    if (!string.IsNullOrEmpty(decl[11].Data))
                    {
                        txtUndertakeWork5.Text = decl[11].Data;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(decl[0].Data))
                    {
                        txtDeclarationUnit2.Text = decl[0].Data;
                        SurveylitDeclarationUnit2.Text = decl[0].Data;
                        if (!string.IsNullOrEmpty(decl[2].Data))
                        {
                            Division2.Value = decl[2].Data;
                            SetSurveyCollaborativePhase("SurveyCollaborativePhase2_", decl[2].Data.Split(','));
                        }
                    }
                    if (!string.IsNullOrEmpty(decl[3].Data))
                    {
                        txtDeclarationUnit3.Text = decl[3].Data;
                        SurveylitDeclarationUnit3.Text = decl[3].Data;
                        if (!string.IsNullOrEmpty(decl[5].Data))
                        {
                            Division3.Value = decl[5].Data;
                            SetSurveyCollaborativePhase("SurveyCollaborativePhase3_", decl[5].Data.Split(','));
                        }
                    }

                    if (!string.IsNullOrEmpty(decl[6].Data))
                    {
                        txtDeclarationUnit4.Text = decl[6].Data;
                        SurveylitDeclarationUnit4.Text = decl[6].Data;
                        if (!string.IsNullOrEmpty(decl[8].Data))
                        {
                            Division4.Value = decl[8].Data;
                            SetSurveyCollaborativePhase("SurveyCollaborativePhase4_", decl[8].Data.Split(','));
                        }
                    }

                    if (!string.IsNullOrEmpty(decl[9].Data))
                    {
                        txtDeclarationUnit5.Text = decl[9].Data;
                        SurveylitDeclarationUnit5.Text = decl[9].Data;
                        if (!string.IsNullOrEmpty(decl[11].Data))
                        {
                            Division5.Value = decl[11].Data;
                            SetSurveyCollaborativePhase("SurveyCollaborativePhase5_", decl[11].Data.Split(','));
                        }
                    }
                }
                trans.Commit();
                conn.Close();
            }
            catch
            { }            
        }
        public void SetSurveyCollaborativePhase(string strContralNamePrefix, string[] strArray)
        {
            for (int i = 0; i < strArray.Count(); i++)
            {
                Literal lit = (Literal)this.FindControl(strContralNamePrefix + strArray[i].Substring(2, 2));
                lit.Text = "√";
            }
        }
    }
}