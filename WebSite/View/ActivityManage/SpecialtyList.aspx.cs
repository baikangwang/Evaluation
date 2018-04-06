using System;
using System.Data.OleDb;
using System.Web.UI.WebControls;


namespace Evaluation.View.ActivityManage
{
    public partial class SpecialtyList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Request.QueryString["specialtyMSg"] != null && Request.QueryString["specialtyMSg"] != "")
            //{
            //    hdMsg.Value = Request.QueryString["specialtyMSg"];
            //}

            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];

            if (user == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }

            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            conn.Close();
            if (activity == null)
            {
                hdMsg.Value = "当前没有已经激活的申报活动，请确认。";
            }
            else
            {
                if (!IsPostBack)
                {
                    InitPage();
                }
            }
        }

        //protected void gvSpecialty_RowCommand(object sender, GridViewCommandEventArgs e)
        //{
        //    OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
        //    conn.Open();

        //    switch (e.CommandName)
        //    {
        //        case "Delete":
        //            OleDbTransaction tran = conn.BeginTransaction();
        //            try
        //            {
        //                int iSpecialtyID = Convert.ToInt32(e.CommandArgument);
        //                BLL.Specialty.DeleteSpecialty(0,iSpecialtyID, conn, tran);
        //                tran.Commit();
        //                //Response.Write("<script>alert('专业删除成功')</script>");
        //                hdMsg.Value = "专业删除成功！";
        //            }
        //            catch (Exception ex)
        //            {
        //                tran.Rollback();
        //                //Response.Write("<script>alert('" + ex.Message + "')</script>");
        //                hdMsg.Value = ex.Message;
        //            }
        //            InitPage();
        //            break;
        //    }

        //    conn.Close();
        //}

        public void InitPage()
        {
            
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                hdMsg.Value = "当前没有已经激活的申报活动，请确认。";
            }
            else
            {
                if (user.UserType == "0804")
                {
                    ddlSpecialty.DataSource = BLL.Specialty.GetUserSpecialtyList(activity.ActivityID.Value, user.UserID.Value, true, conn);
                }
                else
                {
                    ddlSpecialty.DataSource = BLL.Specialty.GetSpecialtyList(activity.ActivityID.Value, true, conn);
                }
                
                ddlSpecialty.DataTextField = "SpecialtyName";
                ddlSpecialty.DataValueField = "SpecialtyID";
                ddlSpecialty.DataBind();
            }
            conn.Close();
        }

    }
}