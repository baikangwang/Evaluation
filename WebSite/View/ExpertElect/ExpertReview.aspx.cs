using System;
using System.Data.OleDb;
using System.Web;

namespace Evaluation.View.ExpertElect
{
    public partial class ExpertReview : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request["DeclarationID"];
            if (Session["ActivityType"] == null || Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
                return;
            }
            if (!string.IsNullOrEmpty(id))
            {
                Export(Context);
            }

            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];

            //奖项绑值
            ddlPrizeName.DataSource = BLL.Prize.GetPrizeList(user, strActivityType, "", conn);
            ddlPrizeName.DataValueField = "PrizeID";
            ddlPrizeName.DataTextField = "PrizeName";
            ddlPrizeName.DataBind();

            conn.Close();
        }

        public void DowmLoad(HttpContext context, string strSavePath)
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

        public void Export(HttpContext context)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            int iDeclarationID = 0;
            int.TryParse(context.Request["DeclarationID"] ?? "0", out iDeclarationID);
            string strServerMapPath = context.Server.MapPath("/");
            string strSavePath = BLL.Declaration.ExportDeclaration(iDeclarationID, strServerMapPath, conn);

            DowmLoad(context, strSavePath);

            conn.Close();
        }
    }
}