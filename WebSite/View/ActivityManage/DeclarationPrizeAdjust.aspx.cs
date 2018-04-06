using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace Evaluation.View.ActivityManage
{
    public partial class DeclarationPrizeAdjust : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            string strActivityType =Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                //这里要提示错误
                return;
            }

            List<Dal.Models.Specialty> lstSpecialty = BLL.Specialty.GetSpecialtyList(activity.ActivityID.Value, false, conn);

            int iPerPage = 10;
            if (!Int32.TryParse(Request["PerPage"] ?? "10", out iPerPage))
            {
                iPerPage = 10;
            }

            int iCuttentPage = 1;
            if (!Int32.TryParse(Request["CuttentPage"] ?? "1", out iCuttentPage))
            {
                iCuttentPage = 1;
            }

            int iRecordNumber = lstSpecialty.Count();
            int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPerPage));


            ViewState["PerPage"] = iPerPage;
            ViewState["CuttentPage"] = iCuttentPage;
            ViewState["RecordNumber"] = iRecordNumber;
            ViewState["PagesCount"] = iPagesCount;

            lstSpecialty = lstSpecialty.Skip(iPerPage * (iCuttentPage - 1)).Take(iPerPage).ToList();

            conn.Close();
        }
    }
}