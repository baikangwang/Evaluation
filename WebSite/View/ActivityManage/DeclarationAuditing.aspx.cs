using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.ActivityManage
{
    public partial class DeclarationAuditing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);

            conn.Open();

            //奖项绑值
            Dal.Models.UserInfo userinfo = (Dal.Models.UserInfo)Session["UserInfo"];
            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
                return;
            }

            ddlPrizeName.DataSource = BLL.Prize.GetPrizeList(userinfo, strActivityType, null, conn);
            ddlPrizeName.DataValueField = "PrizeID";
            ddlPrizeName.DataTextField = "PrizeName";
            ddlPrizeName.DataBind();

            //申报状态绑值
            ddlDeclarationStatus.DataSource = BLL.SysConstant.GetConstantList("18", conn).Where(s=> "1802,1803".Contains(s.ConstantCode)).ToList();
            ddlDeclarationStatus.DataValueField = "ConstantCode";
            ddlDeclarationStatus.DataTextField = "ConstantValue";
            ddlDeclarationStatus.DataBind();

            conn.Close();
        }
    }
}