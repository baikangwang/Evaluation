using Newtonsoft.Json;
using NPOI.HSSF.UserModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI.WebControls;

namespace Evaluation.View.ActivityManage
{
    public partial class SingleRevoteSet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }
            else
            {
                InitPage();
            }
        }
        public void InitPage()
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            string strActivityType = Session["ActivityType"].ToString();

            //奖项绑值
            BindDropDownList(ddlPrizeName, BLL.Prize.GetPrizeList(user, strActivityType, "", conn), "PrizeName", "PrizeID");

            // 奖项类别绑值
            BindDropDownList(ddlPrizeType, BLL.SysConstant.GetSysConstantList("03", conn), "ConstantValue", "ConstantCode");
            conn.Close();
            hfPrizeID.Value = Request["PrizeID"];
        }

        protected void BindDropDownList(DropDownList ddl, object objDataSource, string strDataTextField, string strDataValueField, string strDefaultText = "", string strDefaultValue = "")
        {
            ddl.DataSource = objDataSource;
            ddl.DataValueField = strDataValueField;
            ddl.DataTextField = strDataTextField;
            ddl.DataBind();

            if (!string.IsNullOrEmpty(strDefaultText))
            {
                ddl.Items.Insert(0, new ListItem(strDefaultText, strDefaultValue));
            }
        }
    }
}