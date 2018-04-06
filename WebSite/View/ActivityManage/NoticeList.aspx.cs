using System;
using System.Web;

namespace Evaluation.View.ActivityManage
{
    public partial class NoticeList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //下载
            //if (Request.QueryString["operat"] != null && Request.QueryString["operat"] == "download")
            //{
            //    OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            //    conn.Open();
            //    int noticeID = Convert.ToInt32(Request["noticeID"]);
            //    //Dal.Models.Notice notice = BLL.Notice.GetNotice(noticeID,conn);
            //    if (!string.IsNullOrEmpty(Request["NoticeID"]))
            //    {
            //        Export(Context, conn);
            //    }
            //    conn.Close();
            //}
        }

        //public void Export(HttpContext context, OleDbConnection conn)
        //{
        //    int iNoticeID = 0;
        //    try
        //    {
        //        if (int.TryParse(context.Request["NoticeID"], out iNoticeID))
        //        {
        //            // 创建Docx文件
        //            string strServerMapPath = context.Server.MapPath("/");
        //            string strFileName = BLL.Notice.CreateNoticeFile(iNoticeID, strServerMapPath
        //                , "http://" + context.Request.Url.Host + ":" + context.Request.Url.Port.ToString(), conn);
        //            DownLoad(context, strFileName);
        //            File.Delete(strFileName);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.Write(ex.Message);
        //    }
        //}

        public void DownLoad(HttpContext context, string strSavePath)
        {
            try
            {
                System.IO.FileInfo file = new System.IO.FileInfo(strSavePath);

                if (file.Exists)//判断文件是否存在
                {
                    context.Response.Clear();
                    context.Response.ClearHeaders();
                    context.Response.Buffer = false;
                    context.Response.AddHeader("content-disposition", "attachment;filename=" + file.Name);
                    context.Response.AddHeader("cintent_length", "attachment;filename=" + HttpUtility.UrlDecode(file.Name));
                    context.Response.AddHeader("cintent_length", file.Length.ToString());
                    context.Response.ContentType = "application/octet-stream";
                    context.Response.WriteFile(file.FullName);//通过response对象，执行下载操作
                    context.Response.Flush();
                    context.Response.End();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }
    }
}