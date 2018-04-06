using NPOI.HSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.ExpertManage
{
    public partial class GroupList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InitPage();
        }
        public void InitPage()
        {
            Dal.Models.UserInfo userinfo = (Dal.Models.UserInfo)Session["UserInfo"];

            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                Response.Redirect("../Mutual/HomePage.aspx");
                return;
            }
            else
            {
                ddlSpecialty.DataSource = BLL.Specialty.GetSpecialtyListByUserType(activity.ActivityID.Value, userinfo.UserType, userinfo.UserID.Value, false, conn);
                ddlSpecialty.DataValueField = "SpecialtyID";
                ddlSpecialty.DataTextField = "SpecialtyName";
                ddlSpecialty.DataBind();
            }
        }

    }
}