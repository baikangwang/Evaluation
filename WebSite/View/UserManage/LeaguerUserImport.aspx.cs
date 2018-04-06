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
    public partial class LeaguerChildImport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnDownload_Click(object sender, EventArgs e)
        {
            FileStream file = null;
            string TempletFileName = Server.MapPath("~/Content/Template/会员用户.xls");      //模板文件  
            string ReportFileName = Server.MapPath("~/Content/Temp/ExcelTemp/会员用户.xls");    //导出文件

            try
            {
                file = new FileStream(TempletFileName, FileMode.Open, FileAccess.Read);
                HSSFWorkbook hssfworkbook = new HSSFWorkbook(file);
                //创建临时文件写入数据
                using (FileStream filess = File.OpenWrite(ReportFileName))
                {
                    hssfworkbook.Write(filess);
                }
                System.IO.FileInfo filet = new System.IO.FileInfo(ReportFileName);
                string outputFileName = null;
                //string browser = this.Context.Request.UserAgent.ToUpper();
                string browser = Request.Browser.Type.ToString();
                //if (browser.Contains("MS") == true && browser.Contains("IE") == true)
                if (browser.Contains("InternetExplorer") == true)
                {
                    outputFileName = HttpUtility.UrlEncode("会员用户模板.xls");
                }
                else if (browser.Contains("FIREFOX") == true)
                {
                    outputFileName = "/会员用户模板.xls/";
                }
                else
                {
                    outputFileName = HttpUtility.UrlEncode("会员用户模板.xls");
                }
                Response.Clear();
                Response.Charset = "GB2312";
                Response.ContentEncoding = System.Text.Encoding.UTF8;
                Response.AddHeader("Content-Disposition", "attachment; filename=" + outputFileName);
                Response.AddHeader("Content-Length", filet.Length.ToString());
                Response.ContentType = "application/ms-excel";
                Response.WriteFile(filet.FullName);
                Response.End();
            }
            catch (Exception)
            {
                //Response.Write("<script>alert('模板文件不存在或正在打开');</script>");
                hdMsg.Value = "模板文件不存在或正在打开!";
                return;
            }
        }
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("../../View/UserManage/LeaguerUserList.aspx");
        }
    }

}