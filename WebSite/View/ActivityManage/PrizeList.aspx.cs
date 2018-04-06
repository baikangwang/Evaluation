using System;
using System.Data.OleDb;
using System.Web.UI.WebControls;

namespace Evaluation.View.ActivityManage
{
    public partial class PrizeList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }
            if(!IsPostBack)
            {
                InitPage();
            }
        }
        public void InitPage()
        {
            Dal.Models.UserInfo userinfo=(Dal.Models.UserInfo)Session["UserInfo"];

            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                return;
            }
            else
            {
                Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
                if (user.UserType == "0804")
                {
                    ddlSpecialtyID.DataSource = BLL.Specialty.GetUserSpecialtyList(activity.ActivityID.Value, user.UserID.Value, true, conn);
                }
                else
                {
                    ddlSpecialtyID.DataSource = BLL.Specialty.GetSpecialtyList(activity.ActivityID.Value, true, conn);
                }

                ddlSpecialtyID.DataValueField = "SpecialtyID";
                ddlSpecialtyID.DataTextField = "SpecialtyName";
                ddlSpecialtyID.DataBind();
            }

            conn.Close();
        }
		
        protected void GridView_PrizeList_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            switch (e.CommandName)
            {
                case "Search":
                    break;
                case "Del":
                    OleDbTransaction tran = conn.BeginTransaction();
                    try
                    {
                        int SpecialtysID = Convert.ToInt32(Request.QueryString["DelSpecialtysID"]);
                        BLL.Prize.DeletePrize(SpecialtysID,Convert.ToInt32(e.CommandArgument), conn, tran);
                        tran.Commit();
                    }
                    catch
                    {
                        tran.Rollback();
                    }
                    InitPage();
                    break;
            }
            conn.Close();
        }
    }
}