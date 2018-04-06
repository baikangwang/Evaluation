using System;
using System.Data.OleDb;
using System.Web;
using System.Web.SessionState;

namespace Evaluation.View.Mutual
{
    /// <summary>
    /// HistoryData 的摘要说明
    /// </summary>
    public class HistoryData : IHttpHandler, IReadOnlySessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            //Session丢失时，将cookie赋给Session
            if (context.Session["UserInfo"] == null)
            {
                context.Session["UserInfo"] = BLL.User.GetUserInfo(Convert.ToInt32(context.Request.Cookies["UserId"].Value), conn);
            }

            context.Response.ContentType = "text/plain";
            string strAction = context.Request["Action"];
            if (!string.IsNullOrEmpty(strAction))
            {
                switch (strAction)
                {
                    default:
                        break;
                }
            }

            conn.Close();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}