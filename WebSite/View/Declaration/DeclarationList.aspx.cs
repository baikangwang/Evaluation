using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluation.View.Declaration
{
    public partial class DeclarationList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserInfo"] == null)
            {
                Response.Redirect("../Mutual/UserEntry.aspx");
            }

            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            string strActivityType = Session["ActivityType"].ToString();
            Dal.Models.Activity act = BLL.Activity.GetActivity(strActivityType, conn);
            if (act == null)
            {
                 hdMsg.Value = "当前没有已经激活的申报活动。";
            }
            else
            {
                Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
                txtUser.Text = user.UserType;
                try
                {
                    txtLastUpdateTime.Text = BLL.Schedule.GetActivitySchedule(Convert.ToInt32(act.ActivityID), conn).DeclarationEndDate.ToString();
                }
                catch
                {
                    txtLastUpdateTime.Text = DateTime.Now.ToString();
                }
                string id = Request["DeclarationID"];
                string Img = Request["UploadFileID"];
                string ExportDeclarationID = Request["ExportDeclarationID"];
                string ExportSummaryID = Request["ExportSummaryID"];
                string NoticeID = Request["NoticeID"];
                string ExportCertificateID = Request["ExportCertificateID"];
                string ExportRecommendOpinionID = Request["ExportRecommendOpinionID"];
                string ExportRecommendSummaryID = Request["ExportRecommendSummaryID"];
                string ExportDivisionID = Request["ExportDivisionID"];
                string ExportOpinionID = Request["ExportOpinionID"];

                if (!string.IsNullOrEmpty(NoticeID))
                {
                    ExportNoticeFile(Context);
                }

                if (!string.IsNullOrEmpty(id))
                {
                    Export(Context);
                }

                if (!string.IsNullOrEmpty(Img))
                {
                    DownloadImg(Context);
                }

                if (!string.IsNullOrEmpty(ExportDeclarationID))
                {
                    ExportAll(Context);
                }

                if (!string.IsNullOrEmpty(ExportOpinionID))
                {
                    ExportOpinion(Context);
                }

                if (!string.IsNullOrEmpty(ExportSummaryID))
                {
                    ExportSummary(Context);
                }

                if (!string.IsNullOrEmpty(ExportCertificateID))
                {
                    ExportCertificate(Context);
                }

                if (!string.IsNullOrEmpty(ExportRecommendSummaryID))
                {
                    ExportRecommendSummary(Context);
                }

                if (!string.IsNullOrEmpty(ExportRecommendOpinionID))
                {
                    ExportRecommendOpinion(Context);
                }

                if (!string.IsNullOrEmpty(ExportDivisionID))
                {
                    ExportDivision(Context);
                }

                if (user.UserType == "0806" || user.UserType == "0807")
                {
                    txtUserType.Text = "会员";
                }

                //奖项绑值
                ddlPrizeName.DataSource = BLL.Prize.GetPrizeList(user, strActivityType, "", conn);
                ddlPrizeName.DataValueField = "PrizeID";
                ddlPrizeName.DataTextField = "PrizeName";
                ddlPrizeName.DataBind();

                //申报状态绑值
                ddlDeclarationStatus.DataSource = BLL.SysConstant.GetConstantList("18", conn);
                ddlDeclarationStatus.DataValueField = "ConstantCode";
                ddlDeclarationStatus.DataTextField = "ConstantValue";
                ddlDeclarationStatus.DataBind();
                ddlDeclarationStatus.Items.Remove(ddlDeclarationStatus.Items.FindByValue("1805"));
                ddlDeclarationStatus.Items.Remove(ddlDeclarationStatus.Items.FindByValue("1806"));   
            }
            conn.Close();
        }

        public void DownLoad(HttpContext context, string strSavePath)
        {
            try
            {
                System.IO.FileInfo file = new System.IO.FileInfo(strSavePath);

                if (file.Exists)//判断文件是否存在
                {
                    string outputFileName = null;
                    //string browser = this.Context.Request.UserAgent.ToUpper();
                    string browser = Request.Browser.Type.ToString();

                    //if (browser.Contains("MS") == true && browser.Contains("IE") == true)
                    if (browser.Contains("InternetExplorer") == true || browser.Contains("IE") == true)
                    {
                        outputFileName = HttpUtility.UrlEncode(file.Name);
                    }
                    else if (browser.Contains("FIREFOX") == true)
                    {
                        outputFileName = "/" + file.Name + "/";
                    }
                    else
                    {
                        outputFileName = file.Name;
                    }


                    // 微软为Response对象提供了一个新的方法TransmitFile来解决使用Response.BinaryWrite 
                    // 下载超过400mb的文件时导致Aspnet_wp.exe进程回收而无法成功下载的问题。
                    context.Response.Clear();
                    context.Response.ClearHeaders();
                    context.Response.Buffer = false;
                    context.Response.AddHeader("Content-Disposition", "attachment;filename=" + outputFileName);
                    context.Response.AddHeader("cintent_length", "attachment;filename=" + HttpUtility.UrlDecode(file.Name));
                    context.Response.AddHeader("cintent_length", file.Length.ToString());
                    context.Response.ContentType = "application/octet-stream";
                    //context.Response.WriteFile(file.FullName);//通过response对象，执行下载操作
                    //context.Response.Flush();
                    Response.TransmitFile(file.FullName);
                    Response.End();
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }

        public void ExportSummary(HttpContext context)
        {
            Dal.Models.UserInfo use = (Dal.Models.UserInfo)Session["UserInfo"];
            string strActivityType = Session["ActivityType"].ToString();
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            string strSelctedDeclarationID = context.Request["ExportSummaryID"];

            string strSaveFile = BLL.Declaration.ExportSummaryTable(use, strActivityType, strSelctedDeclarationID, conn);
            DownLoad(context, strSaveFile);

            conn.Close();
        }

        public void ExportRecommendSummary(HttpContext context)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            string strActivityType = Session["ActivityType"].ToString();
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            string strSelctedDeclarationID = context.Request["ExportRecommendSummaryID"];
            string strServerMapPath = context.Server.MapPath("/");

            string strSaveFile = BLL.Declaration.ExportRecommendSummary(
                user, strActivityType, strSelctedDeclarationID, strServerMapPath, conn);

            DownLoad(context, strSaveFile);

            conn.Close();
        }

        /// <summary>
        /// 导出推荐意见表
        /// </summary>
        /// <param name="context"></param>
        public void ExportRecommendOpinion(HttpContext context)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            string strServerMapPath = context.Server.MapPath("/");
            List<string> SavePath = new List<string>();
            string strSavePath = strServerMapPath + "Content\\Temp\\RecommendOpinion\\";
            if (Directory.Exists(strSavePath))
            {
                Directory.Delete(strSavePath, true);
            }
            Directory.CreateDirectory(strSavePath);

            string strSelctedDeclarationID = context.Request["ExportRecommendOpinionID"];
            if (!string.IsNullOrEmpty(strSelctedDeclarationID))
            {
                string[] strDeclarationID = strSelctedDeclarationID.Split(',');

                for (int i = 0; i < strDeclarationID.Count(); i++)
                {
                    SavePath.Add(BLL.Declaration.ExportRecommendOpinion(
                        Convert.ToInt32(strDeclarationID[i]), strServerMapPath, conn));
                }
            }

            if (SavePath.Count() > 1)
            {
                string strDestinationPath = "推荐意见表" + DateTime.Now.ToFileTime().ToString() + ".zip";
                BLL.ZipClass.ZipFileDownload(SavePath.ToArray(), strDestinationPath);
                DownLoad(context, strDestinationPath);
            }

            if (SavePath.Count() == 1)
            {
                DownLoad(context, string.Join(",", SavePath.ToArray()));
            }
        }

        public void ExportOpinion(HttpContext context)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            string strServerMapPath = context.Server.MapPath("/");
            //List<string> SavePath = new List<string>();
            string strSavePath = strServerMapPath + "Content\\Temp\\Opinion\\";
            if (Directory.Exists(strSavePath))
            {
                Directory.Delete(strSavePath, true);
            }
            Directory.CreateDirectory(strSavePath);

            string strSelctedDeclarationID = context.Request["ExportOpinionID"];
            if (!string.IsNullOrEmpty(strSelctedDeclarationID))
            {
                strSavePath = BLL.Declaration.ExportOpinion(strSelctedDeclarationID, strServerMapPath, conn);
            }

            DownLoad(context, strSavePath);
        }

        public void ExportCertificate(HttpContext context)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            string strServerMapPath = context.Server.MapPath("/");
            List<string> SavePath = new List<string>();
            string strSavePath = strServerMapPath + "Content\\Temp\\Certificate\\";
            if (Directory.Exists(strSavePath))
            {
                Directory.Delete(strSavePath, true);
            }
            Directory.CreateDirectory(strSavePath);

            string strSelctedDeclarationID = context.Request["ExportCertificateID"];
            if (!string.IsNullOrEmpty(strSelctedDeclarationID))
            {
                string[] strDeclarationID = strSelctedDeclarationID.Split(',');

                for (int i = 0; i < strDeclarationID.Count(); i++)
                {
                    SavePath.Add(BLL.Declaration.ExportCertificate(Convert.ToInt32(strDeclarationID[i]), strServerMapPath, conn));
                }
            }

            if (SavePath.Count() > 1)
            {
                string strDestinationPath = "法人申明" + DateTime.Now.ToFileTime().ToString() + ".zip";
                BLL.ZipClass.ZipFileDownload(SavePath.ToArray(), strDestinationPath);
                DownLoad(context, strDestinationPath);
            }

            if (SavePath.Count() == 1)
            {
                DownLoad(context, string.Join(",", SavePath.ToArray()));
            }

            conn.Close();
        }

        public void ExportDivision(HttpContext context)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)Session["UserInfo"];
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            string strServerMapPath = context.Server.MapPath("/");

            List<string> SavePath = new List<string>();
            string strSavePath = strServerMapPath + "Content\\Temp\\Division\\" + user.OrganizationName + "\\";
            string strSelctedDeclarationID = context.Request["ExportDivisionID"];
            if (Directory.Exists(strSavePath))
            {
                Directory.Delete(strSavePath, true);
            }

            Directory.CreateDirectory(strSavePath);

            if (!string.IsNullOrEmpty(strSelctedDeclarationID))
            {
                string[] strDeclarationID = strSelctedDeclarationID.Split(',');

                for (int i = 0; i < strDeclarationID.Count(); i++)
                {
                    SavePath.Add(BLL.Declaration.ExportDivision(
                      Convert.ToInt32(strDeclarationID[i]), strServerMapPath, conn));
                }
            }

            if (SavePath.Count() > 1)
            {
                string strDestinationPath = "[" + user.OrganizationName + "_合作分工表" + "].zip";
                BLL.ZipClass.ZipFileDownload(SavePath.ToArray(), strDestinationPath);
                DownLoad(context, strDestinationPath);
            }

            if (SavePath.Count() == 1)
            {
                DownLoad(context, string.Join(",", SavePath.ToArray()));
            }

            conn.Close();
        }

        public void Export(HttpContext context)
        {
            Dal.Models.UserInfo use = (Dal.Models.UserInfo)Session["UserInfo"];
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            string strServerMapPath = context.Server.MapPath("/");
            List<string> SavePath = new List<string>();
            string strSavePath = strServerMapPath + "Content\\Temp\\DeclarationFile\\";
            string strSavePath2 = strServerMapPath + "Content\\Temp\\CompressFile";
            string[] strDeclarationID = null;
            try
            {
                if (!Directory.Exists(strSavePath))
                {
                    Directory.CreateDirectory(strSavePath);
                }
                if (!Directory.Exists(strSavePath2))
                {
                    Directory.CreateDirectory(strSavePath2);
                }
                if (!string.IsNullOrEmpty(context.Request["DeclarationID"]))
                {
                    strDeclarationID = context.Request["DeclarationID"].Split(',');

                    for (int i = 0; i < strDeclarationID.Count(); i++)
                    {
                        SavePath.Add(BLL.Declaration.ExportDeclaration(Convert.ToInt32(strDeclarationID[i]), strServerMapPath, conn));
                    }
                }
                System.String[] str = SavePath.ToArray();
                if (strDeclarationID.Count() > 1)
                {
                    string strDestinationPath = "[" + use.UserName + DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss") + "].zip";
                    BLL.ZipClass.ZipFileDownload(str, strDestinationPath);
                    DownLoad(context, strDestinationPath);
                }

                if (strDeclarationID.Count() == 1)
                {
                    DownLoad(context, string.Join(",", str));
                }
            }
            catch (Exception ex)
            {
                hdMsg.Value = ex.Message;
            }

            conn.Close();

        }

        public void ExportAll(HttpContext context)
        {
            Dal.Models.UserInfo use = (Dal.Models.UserInfo)Session["UserInfo"];

            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            List<string> SavePath = new List<string>();
            string strServerMapPath = context.Server.MapPath("/");
            string strSavePath = strServerMapPath + "/Content/Temp/CompressFile";
            string strSavePath2 = strServerMapPath + "/Content/Temp/DeclarationFile";
            string[] strDeclarationID = null;

            try
            {
                if (!Directory.Exists(strSavePath))
                {
                    Directory.CreateDirectory(strSavePath);
                }
                if (!Directory.Exists(strSavePath2))
                {
                    Directory.CreateDirectory(strSavePath2);
                }
                if (!string.IsNullOrEmpty(context.Request["ExportDeclarationID"]))
                {
                    strDeclarationID = context.Request["ExportDeclarationID"].Split(',');
                    for (int i = 0; i < strDeclarationID.Count(); i++)
                    {
                        BLL.Declaration.ExportDeclaration(Convert.ToInt32(strDeclarationID[i]), strServerMapPath, conn);

                        Dal.Models.Declaration decl = BLL.Declaration.GetDeclaration(Convert.ToInt32(strDeclarationID[i]), conn);
                        string strPath = strServerMapPath + "/Content/Temp/DownLoad" + decl.DeclarationCode + "";
                        string strDestinationPath = strServerMapPath + "/Content/Temp/CompressFile/" + "[" + decl.PrizeName + "][" + decl.DeclarationName + "][" + decl.OrganizationName + "].zip";
                        BLL.Compression.ZipDirectory(strPath, strDestinationPath);
                        SavePath.Add(strDestinationPath);
                    }
                }
                System.String[] str = SavePath.ToArray();
                if (str.Count() > 1)
                {
                    //strServerMapPath + "Content\\Temp\\DeclarationFile\\[All"
                    string strPaths = strServerMapPath + "Content\\Temp\\DeclarationFile\\[All" + use.UserID + DateTime.Now.ToString("yyyy-MM-dd hh-mm-ss") + "].zip";
                    BLL.ZipClass.Zip(str, strPaths);
                    DownLoad(context, strPaths);
                    conn.Close();
                }
                if (str.Count() == 1)
                {
                    string DeclarationID = string.Join(",", strDeclarationID);
                    Dal.Models.Declaration decl = BLL.Declaration.GetDeclaration(Convert.ToInt32(DeclarationID), conn);
                    string strPaths = strServerMapPath + "Content\\Temp\\CompressFile\\" + "[" + decl.PrizeName + "][" + decl.DeclarationName + "][" + decl.OrganizationName + "].zip";
                    DownLoad(context, strPaths);
                    conn.Close();
                }
            }
            catch(Exception ex)
            {
                hdMsg.Value = ex.Message;
            }
        }

        public void DownloadImg(HttpContext context)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            int iUploadFileID = 0;
            int.TryParse(context.Request["UploadFileID"] ?? "0", out iUploadFileID);
            Dal.Models.UploadFileInfo dUploadFileInfo = BLL.UploadFileInfo.GetUploadFile(iUploadFileID, conn);

            try
            {
                string strServerMapPath = Server.MapPath("/");
                int Index1 = dUploadFileInfo.URL.IndexOf("Content");
                string Path = strServerMapPath + dUploadFileInfo.URL.Substring(Index1).Replace("\\", "/");
                DownLoad(context, Path);
                conn.Close();
            }
            catch(Exception ex) 
            {
                hdMsg.Value = ex.Message;
            }           
        }

        public void ExportNoticeFile(HttpContext context)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            int iNoticeID = 0;
            int.TryParse(context.Request["NoticeID"] ?? "0", out iNoticeID);
            Dal.Models.UploadFileInfo dUploadFileInfo = BLL.UploadFileInfo.GetUploadFile(iNoticeID, null, "NoticeAppendix", conn);
            if (dUploadFileInfo != null)
            {
                try
                {
                    string strServerMapPath = Server.MapPath("/");
                    int Index1 = dUploadFileInfo.URL.IndexOf("Content");
                    string Path = strServerMapPath + dUploadFileInfo.URL.Substring(Index1).Replace("\\", "/");
                    DownLoad(context, Path);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    hdMsg.Value = ex.Message;
                }
            }
        }

    }
}