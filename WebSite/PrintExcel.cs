using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class PrintExcel
{
    public static void ExportToExcel(string FileType, string FileName, string ExcelContent)
    {
        System.Web.HttpContext.Current.Response.ContentType = FileType;
        System.Web.HttpContext.Current.Response.ContentEncoding = System.Text.Encoding.UTF8;
        System.Web.HttpContext.Current.Response.Charset = "utf-8";
        System.Web.HttpContext.Current.Response.AppendHeader("Content-Disposition", "attachment;filename=" + HttpUtility.UrlEncode(FileName, System.Text.Encoding.UTF8).ToString());

        System.IO.StringWriter tw = new System.IO.StringWriter();
        System.Web.HttpContext.Current.Response.Output.Write(ExcelContent.ToString());
        /*乱码BUG修改 20140505*/
        //如果采用以上代码导出时出现内容乱码，可将以下所注释的代码覆盖掉上面【System.Web.HttpContext.Current.Response.Output.Write(ExcelContent.ToString());】即可实现。
        //System.Web.HttpContext.Current.Response.Write("<meta http-equiv=\"content-type\" content=\"application/ms-excel; charset=utf-8\"/>" + ExcelContent.ToString());
        System.Web.HttpContext.Current.Response.Flush();
        System.Web.HttpContext.Current.Response.End();
    }
}
