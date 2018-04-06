using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.Declaration
{
    public partial class Participant : System.Web.UI.UserControl
    {
        public List<Dal.Models.Participant> ParticipantList { get; set; }
        public Dal.Models.Declaration Decl { get; set; }
        public Dal.Models.Organization Org { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();
                
                List<Dal.Models.SysConstant> lstConstant = BLL.SysConstant.GetConstantList("09", conn);
                Dal.Models.Prize prize = BLL.Prize.GetPrize(Convert.ToInt32(Decl.PrizeID), conn);
                conn.Close();

                try
                {
                    PeopleNum.Text = prize.ParticipantLimit.ToString();
                }
                catch {
                    PeopleNum.Text = "0";
                }
                
                DropDownList ddl;
                for (int i = 1; i <= 15; i++)
                {
                    ddl = ((DropDownList)tblParticipant.FindControl("IDType" + i.ToString()));
                    SetDropDownList(ddl, lstConstant);

                }

                if (ParticipantList != null)
                {
                    int j = 0;
                    for (int i = 1; i <= 15; i++)
                    {
                        TextBox ParticipantName = (TextBox)tblParticipant.Rows[i].FindControl("ParticipantName" + i.ToString());
                        TextBox AcademicTitle = (TextBox)tblParticipant.Rows[i].FindControl("AcademicTitle" + i.ToString());
                        TextBox Speciality = (TextBox)tblParticipant.Rows[i].FindControl("Speciality" + i.ToString());
                        TextBox Duties = (TextBox)tblParticipant.Rows[i].FindControl("Duties" + i.ToString());
                        DropDownList IDType = (DropDownList)tblParticipant.Rows[i].FindControl("IDType" + i.ToString());
                        TextBox IDNumber = (TextBox)tblParticipant.Rows[i].FindControl("IDNumber" + i.ToString());
                        TextBox Workplace = (TextBox)tblParticipant.Rows[i].FindControl("Workplace" + i.ToString());

                        ParticipantName.Attributes.Add("data", "Participant");
                        AcademicTitle.Attributes.Add("data", "Participant");
                        Speciality.Attributes.Add("data", "Participant");
                        Duties.Attributes.Add("data", "Participant");
                        IDType.Attributes.Add("data", "Participant");
                        IDNumber.Attributes.Add("data", "Participant");
                        Workplace.Attributes.Add("data", "Participant");

                        j = i - 1;
                        if (j < ParticipantList.Count)
                        {
                            AcademicTitle.Text = ParticipantList[j].AcademicTitle;
                            Speciality.Text = ParticipantList[j].Speciality;
                            Duties.Text = ParticipantList[j].Duties;
                            IDType.SelectedValue = ParticipantList[j].IDType;
                            IDNumber.Text = ParticipantList[j].IDNumber;
                            Workplace.Text = ParticipantList[j].Workplace;
                            ParticipantName.Text = ParticipantList[j].ParticipantName;
                        }
                    }
                }
            }
        }

        public void SetDropDownList(DropDownList ddl, List<Dal.Models.SysConstant> lst)
        {
            ddl.DataSource = lst;
            ddl.DataTextField = "ConstantValue";
            ddl.DataValueField = "ConstantCode";
            ddl.DataBind();
            //ddl.Items.Insert(0, new ListItem("<-- 请选择 -->", "0"));
        }
    }
}