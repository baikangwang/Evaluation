using System;
using System.Data.OleDb;

namespace Evaluation.View.ExpertManage
{
    public partial class GroupMember : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Request["id"]))
            {
                Response.Redirect("../ExpertManage/GroupList");
            }
            if (Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }

            if (!IsPostBack)
            {
                InitPage();
            }
        }
        public void InitPage()
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            int id = Convert.ToInt32(Request["id"]);
            int specialtyId = Convert.ToInt32(Request["SpecialtyID"]);
            Dal.Models.ExpertGroup expertGroup = BLL.ExpertGroup.GetExpertGroup(id, conn);
            labExpertGroupName.Text = expertGroup.GroupName;
            txtExpertGroupID.Text = Convert.ToString(expertGroup.GroupID);
            hfSpecialtyID.Value = specialtyId.ToString();
            conn.Close();
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ExpertManage/GroupList.aspx");
        }
    }
}