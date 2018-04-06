using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;
using System.Web;

namespace Evaluation.View.Mutual
{
    public partial class upgrade_your_browser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();

                string strActivityType = ConfigurationManager.AppSettings["ActivityType"];
                Dictionary<string, string> dicAppSettings = BLL.SysConstant.GetAppSettingDict(strActivityType, conn);
                txtEntryImage.Text = dicAppSettings["EntryImage_" + strActivityType];
                txtEntryFooterInformation1.Text = dicAppSettings["EntryFooterInformation1_" + strActivityType];
                txtEntryFooterInformation2.Text = dicAppSettings["EntryFooterInformation2_" + strActivityType];
                txtEntryFooterInformation3.Text = dicAppSettings["EntryFooterInformation3_" + strActivityType];

                conn.Close();
            }
        }
    }
}