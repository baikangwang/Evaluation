using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.ExpertElect
{
    public partial class ExpertVoteDetailList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }
            InitPage();

        }

        public void InitPage()
        {
            Dal.Models.UserInfo userinfo = (Dal.Models.UserInfo)Session["UserInfo"];

            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            if (activity == null)
            {
                return;
            }
            else
            {
                //专业列表绑定
                ddlSpecialtyID.DataSource = BLL.Specialty.GetSpecialtyList(activity.ActivityID.Value, true, conn);
                ddlSpecialtyID.DataValueField = "SpecialtyID";
                ddlSpecialtyID.DataTextField = "SpecialtyName";
                ddlSpecialtyID.DataBind();

                //奖项类别绑定
                ddlPrize.DataSource = BLL.SysConstant.GetConstantList("03", conn);
                ddlPrize.DataValueField = "ConstantCode";
                ddlPrize.DataTextField = "ConstantValue";
                ddlPrize.DataBind();
            }
            conn.Close();

            hfVoteType.Value = Request.QueryString["VoteType"];
        }

    }
}