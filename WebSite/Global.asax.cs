using System;
using System.Configuration;
using System.Data.OleDb;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;

namespace Evaluation
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // 在应用程序启动时运行的代码
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            string strActivityType = ConfigurationManager.AppSettings["ActivityType"];
            Dal.OleDbHlper.ConnectionString = ConfigurationManager.ConnectionStrings["DB" + strActivityType].ConnectionString;
        }

        void Session_Start(object sender, EventArgs e)
        {
            //OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            //conn.Open();
            //Session.Add("OleDbConnection", conn);
        }

        void Session_End(object sender, EventArgs e)
        {
            //OleDbConnection conn = (OleDbConnection)Session["OleDbConnection"];
            //conn.Close();
            //conn.Dispose();
        }
    }
}