using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace Evaluation.View.ActivityManage
{
    public partial class ReviewResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }

            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity act = BLL.Activity.GetActivity(strActivityType, conn);
            if (act == null)
            {
                hdMsg.Value = "当前没有已经激活的申报活动。";
            }
            else
            {
                Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
                txtUser.Text = user.UserType;
                try
                {
                    txtLastUpdateTime.Text = BLL.Schedule.GetActivitySchedule(Convert.ToInt32(act.ActivityID), conn).DeclarationEndDate.ToString();
                }
                catch
                {
                    txtLastUpdateTime.Text = DateTime.Now.ToString();
                }
                string id = Request["DeclarationID"];
                string Img = Request["UploadFileID"];

                if (user.UserType == "0806" || user.UserType == "0807")
                {
                    txtDeclarationUnit.Visible = false;
                    txtUserType.Text = "会员";
                }

                ddlPrize.DataSource = BLL.Prize.GetPrizeList(user, strActivityType, null, conn);
                ddlPrize.DataTextField = "PrizeName";
                ddlPrize.DataValueField = "PrizeID";
                ddlPrize.DataBind();

                ddlAwardCode.DataSource = BLL.SysConstant.GetConstantList("23", conn);
                ddlAwardCode.DataTextField = "ConstantValue";
                ddlAwardCode.DataValueField = "ConstantCode";
                ddlAwardCode.DataBind();
            }
            conn.Close();
        }
    }
}