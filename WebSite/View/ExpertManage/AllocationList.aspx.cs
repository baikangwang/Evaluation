using System;
using System.Data.OleDb;

namespace Evaluation.View.ExpertManage
{
    public partial class AllocationList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
                return;
            }
            if (!IsPostBack)
            {
                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();
                string strActivityType = Session["ActivityType"].ToString();
                Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
                if (activity == null)
                {
                    Response.Redirect("../Mutual/HomePage.aspx");
                    return;
                }
            }
            InitPage();
        }

        public void InitPage()
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            //奖项绑值
            Dal.Models.UserInfo userinfo = (Dal.Models.UserInfo)Session["UserInfo"];
            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                Response.Redirect("../Mutual/HomePage.aspx");
                return;
            }

            ddlPrizeName.DataSource = BLL.Prize.GetPrizeList(userinfo, strActivityType, "", conn);
            ddlPrizeName.DataValueField = "PrizeID";
            ddlPrizeName.DataTextField = "PrizeName";
            ddlPrizeName.DataBind();

            //申报状态绑值
            ddlDeclarationStatus.DataSource = BLL.SysConstant.GetConstantList("18", conn);
            ddlDeclarationStatus.DataValueField = "ConstantCode";
            ddlDeclarationStatus.DataTextField = "ConstantValue";
            ddlDeclarationStatus.DataBind();

            conn.Close();
        }
    }
}