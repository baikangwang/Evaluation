using Dal.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Web;
using System.Web.SessionState;

namespace Evaluation.View.Mutual
{
    /// <summary>
    /// Common 的摘要说明
    /// </summary>
    public class Common : IHttpHandler, IReadOnlySessionState
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
                    case "GetMenu":
                        GetMenu(context, conn);
                        break;
                    case "GetPie":
                        GetPie(context, conn);
                        break;
                    case "GetBar":
                        GetBar(context, conn);
                        break;
                    case "GetConstant":
                        GetConstant(context, conn);
                        break;
                    case "GetUser":
                        GetUser(context, conn);
                        break;
                    case "GetPrize":
                        GetPrize(context, conn);
                        break;
                    //case "LoadFile":
                    //    LoadFile(context, conn);
                    //    break;
                    case "PrepLoadFile":
                        PrepLoadFile(context, conn);
                        break;
                    case "ImportAtlasFile":
                        ImportAtlasFile(context, conn);
                        break;
                    case "GetAtlas":
                        GetAtlas(context, conn);
                        break;
                    //case "LoadImg":
                    //    LoadImg(context, conn);
                    //    break;
                    case "DeleteImg":
                        DeleteImg(context, conn);
                        break;
                    case "DeleteAppendix":
                        DeleteAppendix(context, conn);
                        break;
                    case "UploadFile":
                        UploadDeployFile(context, conn);
                        break;
                    case "GetUpdateContent":
                    case "GetUpdateSqlText":
                    case "GetUpdatePackage":
                    case "GetUpdateSourceCode":
                        GetDeployFile(context, conn);
                        break;
                    case "DeleteDeployFile":
                        DeleteDeployFile(context, conn);
                        break;
                }
            }

            conn.Close();
        }

        public void GetPie(HttpContext context, OleDbConnection conn)
        {
            List<KeyValuePair<string, int>> lstPie = new List<KeyValuePair<string, int>>();
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write(JsonConvert.SerializeObject("当前没有激活的活动！"));
                return;
            }
            else
            {
                List<Dal.Models.Specialty> lstSpec = BLL.Specialty.GetSpecialtyList(Convert.ToInt32(activity.ActivityID), true, conn);
                foreach (Dal.Models.Specialty spec in lstSpec)
                {
                    lstPie.Add(new KeyValuePair<string, int>(spec.SpecialtyName, BLL.Declaration.CountInSpecialty(spec.SpecialtyID.Value, "1803", conn)));
                }
            }
            object[] objs = { lstPie };
            context.Response.Write(JsonConvert.SerializeObject(objs));
        }

        public void GetBar(HttpContext context, OleDbConnection conn)
        {
            List<string> lstSpeciatlyName = new List<string>();
            List<int> lstDecNum = new List<int>();

            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write(JsonConvert.SerializeObject("当前没有激活的活动！"));
                return;
            }
            else
            {
                List<Dal.Models.Specialty> lstSpec = BLL.Specialty.GetSpecialtyList(Convert.ToInt32(activity.ActivityID), true, conn);

                foreach (Dal.Models.Specialty spec in lstSpec)
                {
                    lstSpeciatlyName.Add(spec.SpecialtyName);
                    lstDecNum.Add(BLL.Declaration.GetWeeklyNewDeclarationCount(activity.ActivityID.Value, spec.SpecialtyID.Value, conn));
                }
            }
            object[] objs = { lstSpeciatlyName, lstDecNum };
            context.Response.Write(JsonConvert.SerializeObject(objs));
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public void GetMenu(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];

            StringBuilder sbMenu = new StringBuilder();
            List<Dal.Models.SysMenu> lstMenu = BLL.SysMenu.GetMenu(user.UserID.Value, conn);
            
                context.Response.Write(JsonConvert.SerializeObject(lstMenu));
        }

        public void GetConstant(HttpContext context, OleDbConnection conn)
        {
            if (!string.IsNullOrEmpty(context.Request["ConstantCode"] ?? ""))
            {
                Dal.Models.SysConstant cnst = BLL.SysConstant.GetConstant(context.Request["ConstantCode"] ?? "", conn);
                context.Response.Write(JsonConvert.SerializeObject(cnst));
            }
            else
            {
                List<Dal.Models.SysConstant> lstConstant = BLL.SysConstant.GetConstantList(context.Request["ConstantType"] ?? "", conn);
                context.Response.Write(JsonConvert.SerializeObject(lstConstant));
            }
        }

        public void GetUser(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = null;
            int iUserID = 0;
            int.TryParse(context.Request["UserID"] ?? "0", out iUserID);
            user = BLL.User.GetUserInfo(iUserID, conn);

            context.Response.Write(JsonConvert.SerializeObject(user));
        }

        public void GetPrize(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.Prize prize = null;
            int iPrizeID = 0;
            int.TryParse(context.Request["PrizeID"] ?? "0", out iPrizeID);
            prize = BLL.Prize.GetPrize(iPrizeID, conn);

            context.Response.Write(JsonConvert.SerializeObject(prize));
        }

        public void PrepLoadFile(HttpContext context, OleDbConnection conn)
        {
            string strUploadFileID = context.Request["UploadFileID"];
            Dal.Models.UploadFileInfo dUploadFileInfo = BLL.UploadFileInfo.GetUploadFile(Convert.ToInt32(strUploadFileID), conn);
            if (dUploadFileInfo != null)
            {
                Dal.Models.UploadFileInfo file = new Dal.Models.UploadFileInfo();
                file.UploadFileID = dUploadFileInfo.UploadFileID;

                if (!File.Exists(context.Request.PhysicalApplicationPath + dUploadFileInfo.URL))
                {
                    BLL.UploadFileInfo.LoadFile(file, conn);
                }
                
                context.Response.Write(JsonConvert.SerializeObject(file));
            }
        }

        public void ImportAtlasFile(HttpContext context, OleDbConnection conn)
        {
            int a = context.Request.Files.Count;
            if (a == 0)
            {
                context.Response.Write(JsonConvert.SerializeObject("2"));
            }
            if (context.Request.Files.Count > 0)
            {
                string strDeclarationCode = context.Request["DeclarationCodeBackups"];
                string strDeclarationID = context.Request["DeclarationID"];
                string strAtlasID = context.Request["AtlasID"];
                string strID = context.Request["ID"];
                string fileName = "";
                string minfileName = "";
                HttpFileCollection files = context.Request.Files;
                OleDbTransaction trans = conn.BeginTransaction();
                Dal.Models.Atlas AtlasInfo = BLL.Atlas.GetAtlas(Convert.ToInt32(strAtlasID), conn, trans);

                string strRootDirectory = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + "Content\\";
                string strFilePath = strRootDirectory + "Temp\\" + strDeclarationCode + "\\图集\\" + strAtlasID;
                if (!Directory.Exists(strFilePath))
                {
                    Directory.CreateDirectory(strFilePath);
                }

                try
                {
                    for (int i = 0; i < files.Count; i++)
                    {

                        List<Dal.Models.UploadFileInfo> lstUploadFileInfo = BLL.UploadFileInfo.GetFileList(
                            Convert.ToInt32(strDeclarationID), Convert.ToInt32(strAtlasID), "DeclarationAtlas", conn, trans);
                        if (lstUploadFileInfo.Count < AtlasInfo.UploadLimitMax || AtlasInfo.UploadLimitMax == 0)
                        {
                            // 存入本地文件夹
                            HttpPostedFile file = files[i];
                            fileName = context.Server.MapPath("~/Content/Temp/" + strDeclarationCode + "/图集/" + strAtlasID
                                + "/" + files[i].FileName.Replace(" ", "_"));
                            file.SaveAs(fileName);
                            minfileName = context.Server.MapPath("~/Content/Temp/" + strDeclarationCode + "/图集/" + strAtlasID
                                + "/(mini)" + files[i].FileName.Replace(" ", "_"));
                            BLL.PictureHelper.MakeThumbnail(fileName, minfileName, 100, 100, true);
                                                       
                            // 存入数据库
                            Dal.Models.UploadFileInfo dataFile = new Dal.Models.UploadFileInfo();
                            dataFile.Type = FileType.DeclarationAtlas;
                            dataFile.OwnerID = Convert.ToInt32(strDeclarationID);
                            dataFile.CorrelationID = Convert.ToInt32(strAtlasID);
                            dataFile.FileName = files[i].FileName.Replace(" ", "_");
                            dataFile.URL = "Content\\Temp\\" + strDeclarationCode + "\\图集\\" + strAtlasID + "\\"
                                + files[i].FileName.Replace(" ", "_");
                            BLL.UploadFileInfo.SaveFile(dataFile, conn, trans);
                            context.Response.Write(JsonConvert.SerializeObject(strDeclarationID + "," + strAtlasID + "," + strID));
                        }
                        else
                        {
                            context.Response.Write(JsonConvert.SerializeObject("1"));
                        }
                    }
                    trans.Commit();

                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    context.Response.Write(ex.Message);
                }
            }
        }

        public void GetAtlas(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction trans = conn.BeginTransaction();
            int iOwnerID = Convert.ToInt32(context.Request["OwnerID"]);
            int iCorrelationID = Convert.ToInt32(context.Request["CorrelationID"]);
            int iID = Convert.ToInt32(context.Request["ID"]);
            try
            {
                List<Dal.Models.UploadFileInfo> lstUploadFileInfo = BLL.UploadFileInfo.GetFileList(iOwnerID, iCorrelationID, "DeclarationAtlas", conn, trans);
                trans.Commit();
                conn.Close();
                StringBuilder sbAtlasHTML = new StringBuilder();
                if (lstUploadFileInfo != null)
                {
                    for (int i = 0; i < lstUploadFileInfo.Count; i++)
                    {
                        int Index = lstUploadFileInfo[i].URL.IndexOf("Content");
                        int Index2 = lstUploadFileInfo[i].URL.IndexOf(lstUploadFileInfo[i].FileName);
                        string Path = lstUploadFileInfo[i].URL.Substring(Index);
                        string PathMax = lstUploadFileInfo[i].URL;
                        Path = Path.Insert(Index2, "(mini)");
                        Path = Path.Replace("\\", "/");
                        sbAtlasHTML.Append("<br />");
                        sbAtlasHTML.AppendFormat("<a id='Atlas{0}' class='dowebok'\">", i, Path);
                        sbAtlasHTML.AppendFormat("<img src='../../{0}' data-original='../../{1}' width='150px' height='150px' title='查看大图'/></a><br />", Path, PathMax);
                        sbAtlasHTML.Append(lstUploadFileInfo[i].FileName);
                        sbAtlasHTML.Append("<br />");
                        sbAtlasHTML.AppendFormat("<a onclick='DeleteImg({0},{1},{2},{3});return false;'  title='删除' href=''>"
                            , lstUploadFileInfo[i].UploadFileID, lstUploadFileInfo[i].OwnerID, lstUploadFileInfo[i].CorrelationID, iID);
                        sbAtlasHTML.Append("<i class='fa fa-trash-o'></i>");
                        sbAtlasHTML.Append("</a>");

                        sbAtlasHTML.AppendFormat("　　　<a id='DownloadImg{0}' onclick=\'DownloadImg({1});return false;\' title='下载' href=''>", i, lstUploadFileInfo[i].UploadFileID);
                        sbAtlasHTML.Append("<i class='fa fa-download'></i>");
                        sbAtlasHTML.Append("</a>");
                    }
                }
                context.Response.Write(JsonConvert.SerializeObject(sbAtlasHTML.ToString()));
            }
            catch (Exception ex)
            {
                context.Response.Write(JsonConvert.SerializeObject(ex.Message));
                trans.Rollback();
            }
        }

        public void DeleteImg(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction trans = conn.BeginTransaction();
            int iUploadFileID = Convert.ToInt32(context.Request["UploadFileID"]);
            int iOwnerID = Convert.ToInt32(context.Request["OwnerID"]);
            int iCorrelationID = Convert.ToInt32(context.Request["CorrelationID"]);
            int iID = Convert.ToInt32(context.Request["ID"]);
            Dal.Models.UploadFileInfo dUploadFileInfo = BLL.UploadFileInfo.GetUploadFile(iUploadFileID, conn,trans);
            if (dUploadFileInfo != null)
            {
                try
                {
                    if (File.Exists(dUploadFileInfo.URL))
                    {
                        File.Delete(dUploadFileInfo.URL);
                    }
                    BLL.UploadFileInfo.DeleteUploadFile(iUploadFileID, conn, trans);
                    List<Dal.Models.UploadFileInfo> lstUploadFileInfo = BLL.UploadFileInfo.GetFileList(iOwnerID, iCorrelationID, "DeclarationAtlas", conn, trans);
                    StringBuilder sbAtlasHTML = new StringBuilder();
                    if (lstUploadFileInfo.Count != 0)
                    {
                        for (int i = 0; i < lstUploadFileInfo.Count; i++)
                        {
                            int Index = lstUploadFileInfo[i].URL.IndexOf("Content");
                            int Index2 = lstUploadFileInfo[i].URL.IndexOf(lstUploadFileInfo[i].FileName);
                            string Path = lstUploadFileInfo[i].URL.Substring(Index);
                            string PathMax = lstUploadFileInfo[i].URL;
                            Path = Path.Insert(Index2, "(mini)");
                            Path = Path.Replace("\\", "/");
                            sbAtlasHTML.Append("<br />");
                            sbAtlasHTML.AppendFormat("<a id='Atlas" + i + "' class='dowebok'\">");
                            sbAtlasHTML.AppendFormat("<img src='../../{0}' data-original='../../{1}' width='150px' height='150px' title='查看详情'/>", Path,PathMax);
                            sbAtlasHTML.Append("</a>");
                            sbAtlasHTML.Append("<br />");
                            sbAtlasHTML.Append(lstUploadFileInfo[i].FileName);
                            sbAtlasHTML.Append("<br />");
                            sbAtlasHTML.AppendFormat("<a onclick='DeleteImg({0},{1},{2},{3});return false;'  title='删除' href=''>"
                                , lstUploadFileInfo[i].UploadFileID, lstUploadFileInfo[i].OwnerID, lstUploadFileInfo[i].CorrelationID, iID);
                            sbAtlasHTML.Append("<i class='fa fa-trash-o'></i></a>");
                            sbAtlasHTML.AppendFormat("<a id='DownloadImg{0}' onclick=\"DownloadImg({1});return false;\" title='下载' href=''>"
                                , i, lstUploadFileInfo[i].UploadFileID);
                            sbAtlasHTML.Append("<i class='fa fa-download'></i>");
                            sbAtlasHTML.Append("</a>");
                        }
                        context.Response.Write(JsonConvert.SerializeObject(sbAtlasHTML.ToString()));
                    }
                    else 
                    {
                        string strAtlas = "该专业下暂无图集!";
                        context.Response.Write(JsonConvert.SerializeObject(strAtlas));
                    }
                    
                    trans.Commit();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    context.Response.Write(JsonConvert.SerializeObject(ex.Message));
                    trans.Rollback();
                }
            }
        }

        public void DeleteAppendix(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction trans = conn.BeginTransaction();
            int iUploadFileID = Convert.ToInt32(context.Request["UploadFileID"]);
            int iOwnerID = Convert.ToInt32(context.Request["OwnerID"]);
            int iCorrelationID = Convert.ToInt32(context.Request["CorrelationID"]);
            int iID = Convert.ToInt32(context.Request["ID"]);
            Dal.Models.UploadFileInfo dUploadFileInfo = BLL.UploadFileInfo.GetUploadFile(iUploadFileID, conn, trans);
            string strFileUrl = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + dUploadFileInfo.URL;
            if (dUploadFileInfo != null)
            {
                try
                {
                    if (File.Exists(strFileUrl))
                    {
                        File.Delete(strFileUrl);
                    }
                    BLL.UploadFileInfo.DeleteUploadFile(iUploadFileID, conn, trans);
                   // dUploadFileInfo = BLL.UploadFileInfo.GetUploadFile(iOwnerID, iCorrelationID, "DeclarationAppendix", conn, trans);
                    string strFileName = "暂未上传文件！";
                    context.Response.Write(JsonConvert.SerializeObject(strFileName));
                    trans.Commit();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    context.Response.Write(JsonConvert.SerializeObject(ex.Message));
                    trans.Rollback();
                }
            }
        }
        public void UploadDeployFile(HttpContext context, OleDbConnection conn)
        {
            if (context.Request.Files.Count > 0)
            {
                string strFileType = context.Request["FileType"];
                string fileName = "";

                HttpFileCollection files = context.Request.Files;
                OleDbTransaction trans = conn.BeginTransaction();
                try
                {
                    for (int i = 0; i < files.Count; i++)
                    {
                        // 存入文件夹
                        HttpPostedFile file = files[i];
                        string strRootDirectory = System.Web.HttpContext.Current.Request.PhysicalApplicationPath;
                        string strFilePath = strRootDirectory + "Content\\Temp\\Deploy";
                        if (!Directory.Exists(strFilePath))
                        {
                            Directory.CreateDirectory(strFilePath);
                        }

                        Dal.Models.UploadFileInfo dUploadFileInfo = BLL.UploadFileInfo.GetUploadFile(0, 0, "UpdateContent", conn, trans);

                        if (dUploadFileInfo != null)
                        {
                            int Index = dUploadFileInfo.URL.IndexOf("Content");
                            string Pathe = dUploadFileInfo.URL.Substring(Index);
                            string MapPath = strRootDirectory + Pathe;
                            if (File.Exists(MapPath))
                            {
                                File.Delete(MapPath);
                            }
                        }

                        string strPath = "Deploy\\" + file.FileName.Replace(" ", "_");
                        fileName = context.Server.MapPath("~\\Content\\Temp\\" + strPath);
                        file.SaveAs(fileName);

                        // 存入数据库
                        Dal.Models.UploadFileInfo dataFile = new Dal.Models.UploadFileInfo();
                        dataFile.Type = (Dal.Models.FileType)Enum.Parse(typeof(Dal.Models.FileType), strFileType, true);
                        dataFile.OwnerID = 0;
                        dataFile.CorrelationID = 0;
                        dataFile.FileName = file.FileName.Replace(" ", "_");
                        dataFile.URL = "Content\\Temp\\" + strPath;
                        BLL.UploadFileInfo.SaveFile(dataFile, conn, trans);
                    }
                    trans.Commit();
                    context.Response.Write(JsonConvert.SerializeObject(strFileType));
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    context.Response.Write(JsonConvert.SerializeObject(ex.Message));
                }
            }
        }
        public void GetDeployFile(HttpContext context, OleDbConnection conn)
        {
            string strFileType = context.Request["FileType"];
            try
            {
                Dal.Models.UploadFileInfo dUploadFileInfo = BLL.UploadFileInfo.GetUploadFile(0, 0, strFileType, conn);
                StringBuilder sbFileName = new StringBuilder();
                sbFileName.AppendFormat("<a onclick='LoadFile({0})'>{1}</a>", dUploadFileInfo.UploadFileID, dUploadFileInfo.FileName);
                sbFileName.Append("<br />");
                sbFileName.AppendFormat("<a  onclick='DeleteAppendix({0},{1},{2});return false;' title='删除' href=''>"
                    , dUploadFileInfo.UploadFileID, dUploadFileInfo.OwnerID, dUploadFileInfo.CorrelationID);
                sbFileName.Append("<i class='fa fa-trash-o'></i></a>");
                sbFileName.AppendFormat("　　　<a onclick=\'DownloadAppendix({0});return false;\' title='下载' href=''>", dUploadFileInfo.UploadFileID);
                sbFileName.Append("<i class='fa fa-download'></i></a>");
                context.Response.Write(JsonConvert.SerializeObject(sbFileName.ToString()));
            }
            catch (Exception ex)
            {
                context.Response.Write(JsonConvert.SerializeObject(ex.Message));
            }
        }
        public void DeleteDeployFile(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction trans = conn.BeginTransaction();
            int iUploadFileID = Convert.ToInt32(context.Request["UploadFileID"]);
            Dal.Models.UploadFileInfo dUploadFileInfo = BLL.UploadFileInfo.GetUploadFile(iUploadFileID, conn, trans);
            string strFileType = dUploadFileInfo.TypeCode;
            string strFileUrl = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + dUploadFileInfo.URL;
            if (dUploadFileInfo != null)
            {
                try
                {
                    if (File.Exists(strFileUrl))
                    {
                        File.Delete(strFileUrl);
                    }
                    BLL.UploadFileInfo.DeleteUploadFile(iUploadFileID, conn, trans);
                    context.Response.Write(JsonConvert.SerializeObject(strFileType));
                    trans.Commit();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    context.Response.Write(JsonConvert.SerializeObject(ex.Message));
                    trans.Rollback();
                }
            }
        }        
    }
}