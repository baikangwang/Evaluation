using Dal.Models;
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

namespace Evaluation.View.ExpertManage
{
    public partial class ExpertList : System.Web.UI.Page
    {
        public void InitPage(List<Dal.Models.Expert> lstExpert = null)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];

            if (!IsPostBack)
            {
                List<SysConstant> userStatus = BLL.SysConstant.GetConstantList("07", conn);
                ddlStatus.DataSource = userStatus;
                ddlStatus.DataTextField = "ConstantValue";
                ddlStatus.DataValueField = "ConstantCode";
                ddlStatus.DataBind();
            }

            if (lstExpert == null)
            {
                try
                {
                    lstExpert = BLL.Expert.GetExpertList(conn, user);
                }
                catch
                {
                    lstExpert = null;
                }
            }

            conn.Close();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            if (user == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }

            if (!IsPostBack)
            {
                InitPage();
            }
        }

        protected void lkbExport_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            string strQuery = txtQueryString.Text;
            string strQueryStatus = hfStatus.Value;
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            DataTable dtExpert = Dal.DataTableExtensions.ToDataTable(BLL.Expert.GetExpertList(conn, user, strQuery, strQueryStatus));

            ExportExpert(dtExpert);
            conn.Close();
            conn.Dispose();
        }

        protected void btnCheckedExpert_Click(object sender, EventArgs e)
        {
            string expertIDs = checkedExpertID.Value;
            expertIDs = expertIDs.Substring(0, expertIDs.Length - 1);
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            string strQueryStatus = hfStatus.Value;
            DataTable dtExpert = Dal.DataTableExtensions.ToDataTable(BLL.Expert.GetExpertList(conn, user, null, strQueryStatus, expertIDs));

            ExportExpert(dtExpert);
            conn.Close();
            conn.Dispose();
        }

        protected void btnImport_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../View/ExpertManage/ExpertImport.aspx");
        }

        protected void ExportExpert(DataTable dtExpert)
        {
            string TempletFileName = Server.MapPath("~/Content/Template/专家.xls");      //模板文件  
            string ReportFileName = Server.MapPath("~/Content/Temp/ExcelTemp/专家用户.xls");    //导出文件  
            FileStream file = null;
            try
            {
                file = new FileStream(TempletFileName, FileMode.Open, FileAccess.Read);
            }
            catch (Exception)
            {
                hdMsg.Value = "模板文件不存在或正在打开!";
                return;
            }
            HSSFWorkbook hssfworkbook = new HSSFWorkbook(file);
            HSSFSheet ws = (HSSFSheet)hssfworkbook.GetSheet("Sheet1");
            if (ws == null)//工作薄中没有工作表
            {
                hdMsg.Value = "工作薄中没有Sheet1工作表!";
                return;
            }

            int count = dtExpert.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    int _row = i + 1; //i + 1;
                    HSSFRow row = (HSSFRow)ws.CreateRow(_row);
                    row.CreateCell(0).SetCellValue(i + 1);
                    row.CreateCell(1).SetCellValue(dtExpert.Rows[i]["ExpertName"].ToString());
                    row.CreateCell(2).SetCellValue(dtExpert.Rows[i]["Gender"].ToString());
                    row.CreateCell(3).SetCellValue(dtExpert.Rows[i]["IDTypeText"].ToString());
                    row.CreateCell(4).SetCellValue(dtExpert.Rows[i]["IDNumber"].ToString());
                    row.CreateCell(5).SetCellValue(dtExpert.Rows[i]["Email"].ToString());
                    row.CreateCell(6).SetCellValue(dtExpert.Rows[i]["AcademicTitle"].ToString());
                    row.CreateCell(7).SetCellValue(dtExpert.Rows[i]["Profession"].ToString());
                    row.CreateCell(8).SetCellValue(dtExpert.Rows[i]["Workplace"].ToString());
                    row.CreateCell(9).SetCellValue(dtExpert.Rows[i]["SpecialtyNames"].ToString());
                }
            }
            ws.ForceFormulaRecalculation = true;

            //先删除上一个临时文件
            if (File.Exists(ReportFileName))
            {
                FileInfo fi = new FileInfo(ReportFileName);
                if (fi.Attributes.ToString().IndexOf("ReadOnly") != -1)
                    fi.Attributes = FileAttributes.Normal;
                File.Delete(ReportFileName);
            }

            //创建临时文件写入数据
            using (FileStream filess = File.OpenWrite(ReportFileName))
            {
                hssfworkbook.Write(filess);
            }
            System.IO.FileInfo filet = new System.IO.FileInfo(ReportFileName);
            Response.Clear();
            Response.Charset = "GB2312";
            Response.ContentEncoding = System.Text.Encoding.UTF8;
            Response.AddHeader("Content-Disposition", "attachment; filename=" + Server.UrlEncode("专家用户.xls"));
            Response.AddHeader("Content-Length", filet.Length.ToString());
            Response.ContentType = "application/ms-excel";
            Response.WriteFile(filet.FullName);
            Response.End();
        }
    }
}