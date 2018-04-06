using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evaluation.View.Mutual
{
    /// <summary>
    /// LeaguerElect 的摘要说明
    /// </summary>
    public class LeaguerElect : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Write("Hello World");
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