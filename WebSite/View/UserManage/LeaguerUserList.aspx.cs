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

namespace Evaluation.View.UserManage
{
    public partial class LeaguerUserList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExpertExcel_Click(object sender, EventArgs e)
        {
            string userIDs = checkedUserID.Value;
            userIDs = userIDs.Substring(0, userIDs.Length - 1);

            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            Dal.Models.PageInfo<Dal.Models.UserInfo> pgif = new Dal.Models.PageInfo<Dal.Models.UserInfo>();
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            string userName = tbxUserName.Text;
            DataTable dtOrg = BLL.User.GetOrganizationlist(Convert.ToInt32(user.UserID), userName,userIDs, conn);

            string TempletFileName = Server.MapPath("~/Content/Template/会员用户.xls");      //模板文件  
            string ReportFileName = Server.MapPath("~/Content/Temp/ExcelTemp/会员用户.xls");    //导出文件  
            FileStream file = null;
            try
            {
                file = new FileStream(TempletFileName, FileMode.Open, FileAccess.Read);
            }
            catch (Exception)
            {
                //Response.Write("<script>alert('模板文件不存在或正在打开');</script>");
                hdMsg.Value = "模板文件不存在或正在打开!";
                return;
            }
            HSSFWorkbook hssfworkbook = new HSSFWorkbook(file);
            HSSFSheet ws = (HSSFSheet)hssfworkbook.GetSheet("Sheet1");
            if (ws == null)//工作薄中没有工作表
            {
                //Response.Write("<script>alert('工作薄中没有Sheet1工作表');</script>");
                hdMsg.Value = "工作薄中没有Sheet1工作表!";
                return;
            }
            
            int count = dtOrg.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    int _row = i + 1; //i + 1;
                    HSSFRow row = (HSSFRow)ws.CreateRow(_row);
                    row.CreateCell(0).SetCellValue(i + 1);
                    row.CreateCell(1).SetCellValue(dtOrg.Rows[i]["OrganizationName"].ToString().Trim());
                    row.CreateCell(2).SetCellValue(dtOrg.Rows[i]["OrganizationCode"].ToString().Trim());
                    row.CreateCell(3).SetCellValue(dtOrg.Rows[i]["UserName"].ToString().Trim());
                    row.CreateCell(4).SetCellValue(dtOrg.Rows[i]["OrganizationAddress"].ToString().Trim());
                    row.CreateCell(5).SetCellValue(dtOrg.Rows[i]["LegalPersonName"].ToString().Trim());
                    row.CreateCell(6).SetCellValue(dtOrg.Rows[i]["LegalPersonIDNo"].ToString().Trim());
                    row.CreateCell(7).SetCellValue(dtOrg.Rows[i]["Linkman"].ToString().Trim());
                    row.CreateCell(8).SetCellValue(dtOrg.Rows[i]["TelephoneNumber"].ToString().Trim());
                    row.CreateCell(9).SetCellValue(dtOrg.Rows[i]["MobileNumber"].ToString().Trim());        
                    row.CreateCell(10).SetCellValue(dtOrg.Rows[i]["EmailAddress"].ToString().Trim());
                    row.CreateCell(11).SetCellValue(dtOrg.Rows[i]["Postcode"].ToString().Trim());
                    row.CreateCell(12).SetCellValue(dtOrg.Rows[i]["FaxNumber"].ToString().Trim());        
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
            Response.AddHeader("Content-Disposition", "attachment; filename=" + Server.UrlEncode("会员用户.xls"));
            Response.AddHeader("Content-Length", filet.Length.ToString());
            Response.ContentType = "application/ms-excel";
            Response.WriteFile(filet.FullName);
            Response.End();

            conn.Close();
        }

        protected void btnExpertExcelAll_Click(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            Dal.Models.PageInfo<Dal.Models.UserInfo> pgif = new Dal.Models.PageInfo<Dal.Models.UserInfo>();
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            string userName = tbxUserName.Text;
            DataTable dtOrg = BLL.User.GetOrganizationlist(Convert.ToInt32(user.UserID), userName,"", conn);
            //DataTable dtOrg = BLL.Organization.GetOrganizationlist(conn);

            string TempletFileName = Server.MapPath("~/Content/Template/会员用户.xls");      //模板文件  
            string ReportFileName = Server.MapPath("~/Content/Temp/ExcelTemp/会员用户.xls");    //导出文件  
            FileStream file = null;
            try
            {
                file = new FileStream(TempletFileName, FileMode.Open, FileAccess.Read);
            }
            catch (Exception)
            {
                //Response.Write("<script>alert('模板文件不存在或正在打开');</script>");
                hdMsg.Value = "模板文件不存在或正在打开!";
                return;
            }
            HSSFWorkbook hssfworkbook = new HSSFWorkbook(file);
            HSSFSheet ws = (HSSFSheet)hssfworkbook.GetSheet("Sheet1");
            if (ws == null)//工作薄中没有工作表
            {
                //Response.Write("<script>alert('工作薄中没有Sheet1工作表');</script>");
                hdMsg.Value = "工作薄中没有Sheet1工作表!";
                return;
            }

            int count = dtOrg.Rows.Count;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    int _row = i + 1; //i + 1;
                    HSSFRow row = (HSSFRow)ws.CreateRow(_row);
                    row.CreateCell(0).SetCellValue(i + 1);
                    row.CreateCell(0).SetCellValue(i + 1);
                    row.CreateCell(1).SetCellValue(dtOrg.Rows[i]["OrganizationName"].ToString().Trim());
                    row.CreateCell(2).SetCellValue(dtOrg.Rows[i]["OrganizationCode"].ToString().Trim());
                    row.CreateCell(3).SetCellValue(dtOrg.Rows[i]["UserName"].ToString().Trim());
                    row.CreateCell(4).SetCellValue(dtOrg.Rows[i]["OrganizationAddress"].ToString().Trim());
                    row.CreateCell(5).SetCellValue(dtOrg.Rows[i]["LegalPersonName"].ToString().Trim());
                    row.CreateCell(6).SetCellValue(dtOrg.Rows[i]["LegalPersonIDNo"].ToString().Trim());
                    row.CreateCell(7).SetCellValue(dtOrg.Rows[i]["Linkman"].ToString().Trim());
                    row.CreateCell(8).SetCellValue(dtOrg.Rows[i]["TelephoneNumber"].ToString().Trim());
                    row.CreateCell(9).SetCellValue(dtOrg.Rows[i]["MobileNumber"].ToString().Trim());
                    row.CreateCell(10).SetCellValue(dtOrg.Rows[i]["EmailAddress"].ToString().Trim());
                    row.CreateCell(11).SetCellValue(dtOrg.Rows[i]["Postcode"].ToString().Trim());
                    row.CreateCell(12).SetCellValue(dtOrg.Rows[i]["FaxNumber"].ToString().Trim());                 
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
            Response.AddHeader("Content-Disposition", "attachment; filename=" + Server.UrlEncode("会员用户.xls"));
            Response.AddHeader("Content-Length", filet.Length.ToString());
            Response.ContentType = "application/ms-excel";
            Response.WriteFile(filet.FullName);
            Response.End();

            conn.Close();
        }

        //protected void btnDownload_Click(object sender, EventArgs e)
        //{
        //    FileStream file = null;
        //    string TempletFileName = Server.MapPath("~/Content/Template/会员用户.xls");      //模板文件  
        //    string ReportFileName = Server.MapPath("~/Content/Temp/ExcelTemp/会员用户.xls");    //导出文件

        //    try
        //    {
        //        file = new FileStream(TempletFileName, FileMode.Open, FileAccess.Read);
        //        HSSFWorkbook hssfworkbook = new HSSFWorkbook(file);
        //        //创建临时文件写入数据
        //        using (FileStream filess = File.OpenWrite(ReportFileName))
        //        {
        //            hssfworkbook.Write(filess);
        //        }
        //        System.IO.FileInfo filet = new System.IO.FileInfo(ReportFileName);
        //        Response.Clear();
        //        Response.Charset = "GB2312";
        //        Response.ContentEncoding = System.Text.Encoding.UTF8;
        //        Response.AddHeader("Content-Disposition", "attachment; filename=" + Server.UrlEncode("会员用户模板.xls"));
        //        Response.AddHeader("Content-Length", filet.Length.ToString());
        //        Response.ContentType = "application/ms-excel";
        //        Response.WriteFile(filet.FullName);
        //        Response.End();
        //    }
        //    catch (Exception)
        //    {
        //        //Response.Write("<script>alert('模板文件不存在或正在打开');</script>");
        //        hdMsg.Value = "模板文件不存在或正在打开!";
        //        return;
        //    }
        //}
    }
}