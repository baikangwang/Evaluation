using Dal.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace Evaluation.View.Mutual
{
    /// <summary>
    /// Declaration 的摘要说明
    /// </summary>
    public class Declaration : IHttpHandler, System.Web.SessionState.IRequiresSessionState
    {
        public void ProcessRequest(HttpContext context)
        {
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();

            context.Response.ContentType = "text/plain";
            string strAction = context.Request["Action"];
            if (!string.IsNullOrEmpty(strAction))
            {
                switch (strAction)
                {
                    case "GetDeclarationList":
                        GetDeclarationList(context, conn);
                        break;
                    case "GetDeclarationExList":
                        GetDeclarationExList(context, conn);
                        break;
                    case "GetData":
                        GetData(context, conn);
                        break;
                    case "Save":
                        Save(context, conn);
                        break;
                    case "SetReviewComment":
                        SetReviewComment(context, conn);
                        break;
                    case "FreshDivision":
                        FreshDivision(context, conn);
                        break;
                    case "GetChildList":
                        GetChildList(context, conn);
                        break;
                    case "GetParticipant":
                        GetParticipant(context, conn);
                        break;
                    case "ImportAppendix":
                        ImportAppendix(context, conn);
                        break;
                    case "GetAppendix":
                        GetAppendix(context, conn);
                        break;
                    case "ImportAtlas":
                        ImportAtlas(context, conn);
                        break;
                    case "GetAtlas":
                        GetAtlas(context, conn);
                        break;
                    case "ImportMedia":
                        ImportMedia(context, conn);
                        break;
                    case "GetMedia":
                        GetMedia(context, conn);
                        break;
                    case "DeleteUploadFile":
                        DeleteUploadFile(context, conn);
                        break;
                    case "Check":
                    case "Return":
                    case "ThoroughDelete":
                    case "Auditing":
                    case "Delete":
                        AuditingStatus(context, conn);
                        break;
                    //case "Auditing":
                    //    Auditing(context, conn);
                    //    break;
                    case "Recovery":
                        Recovery(context, conn);
                        break;
                    case "SubmitDeclaration":
                        SubmitDeclaration(context, conn);
                        break;
                    case "GetPrize":
                        GetPrize(context, conn);
                        break;
                    case "GetError":
                        GetError(context, conn);
                        break;
                    case "UpdateOrganizationOrdinal":
                        UpdateOrganizationOrdinal(context, conn);
                        break;
                    case "UpdateAssociationOrdinal":
                        UpdateAssociationOrdinal(context, conn);
                        break;
                    case "GetImportDeclaration":
                        GetImportDeclaration(context, conn);
                        break;
                    case "DeleteDeclaration":
                        DeleteDeclaration(context, conn);
                        break;
                    case "SetDeclarationStatus":
                        SetDeclarationStatus(context, conn);
                        break;
                    case "SubmitComment":
                        SubmitComment(context, conn);
                        break;
                    case "GetComment":
                        GetComment(context, conn);
                        break;
                    case "PackageEvaluation":
                        PackageEvaluation(context, conn);
                        break;
                    case "PackageAll":
                        PackageAll(context, conn);
                        break;

                }
            }

            conn.Close();
            conn.Dispose();
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        /// <remarks>1、模板英文名 TemplateName ，2、申报表编号 DeclarationID </remarks>
        public void GetData(HttpContext context, OleDbConnection conn)
        {
            string DeclarationID = context.Request["DeclarationID"];
            int iDeclarationID = 0;
            if (string.IsNullOrEmpty(DeclarationID) || !int.TryParse(DeclarationID, out iDeclarationID))
            {
                context.Response.Write(JsonConvert.SerializeObject("参数错误！"));
                return;
            }

            Dal.Models.Declaration decl = BLL.Declaration.GetDeclaration(iDeclarationID, conn);
            DataTable dtData = BLL.Declaration.GetDeclarationData(iDeclarationID, conn);
            List<Dal.Models.Participant> lstParticipant = BLL.Declaration.GetParticipant(iDeclarationID, conn);
            List<Dal.Models.UploadFileInfo> lstAppendixFile = BLL.UploadFileInfo.GetAppendixList(iDeclarationID, conn);
            List<Dal.Models.UploadFileInfo> lstAtlasFile = BLL.UploadFileInfo.GetAtlasList(iDeclarationID, conn);
            List<Dal.Models.UploadFileInfo> lstMediaFile = BLL.UploadFileInfo.GetMediaList(iDeclarationID, conn);
            DataTable dtCollaborative = BLL.Declaration.GetCollaborative(decl, dtData, conn);

            dtData.Columns["Data"].ReadOnly = false;
            string strContent = "";
            foreach (DataRow row in dtData.Rows)
            {
                if (row["RecordType"] != null
                    && row["RecordType"] != DBNull.Value
                    && row["RecordType"].ToString() == "RichText"
                    && row["Data"] != null
                    && row["Data"] != DBNull.Value
                    && !string.IsNullOrEmpty(row["Data"].ToString()))
                {
                    strContent = row["Data"].ToString();
                    row["Data"] = strContent.Replace("&lt;", "<").
                        Replace("&gt;", ">").
                        Replace("&quot;", "\"").
                        Replace("&rsquo;", "'").
                        Replace("&frasl;", "/").
                        Replace("&nbsp;", " ");
                }
            }

            if (lstAppendixFile.Count() > 0)
            {
                LoadFiles("AppendixFile", decl.DeclarationCode, lstAppendixFile, conn);
            }
            if (lstAtlasFile.Count() > 0)
            {
                LoadFiles("AtlasFile", decl.DeclarationCode, lstAtlasFile, conn);
            }
            if (lstMediaFile.Count() > 0)
            {
                LoadFiles("MediaFile", decl.DeclarationCode, lstMediaFile, conn);
            }
            context.Response.Write(JsonConvert.SerializeObject(new object[] { decl, dtData, lstParticipant, lstAppendixFile, lstAtlasFile, dtCollaborative, lstMediaFile }));
        }

        public void LoadFiles(string strFileType, string strDeclarationCode, List<Dal.Models.UploadFileInfo> lstFile, OleDbConnection conn)
        {
            for (int i = 0; i < lstFile.Count(); i++)
            {
                if (!string.IsNullOrEmpty(lstFile[i].UploadFileID.ToString()))
                {
                    Dal.Models.UploadFileInfo file = new Dal.Models.UploadFileInfo();
                    file.UploadFileID = lstFile[i].UploadFileID;
                    string strPath = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + lstFile[i].URL;
                    if (!File.Exists(strPath))
                    {
                        BLL.UploadFileInfo.LoadFile(file, conn);
                        if (strFileType == "AtlasFile" && strDeclarationCode != "")
                        {
                            string fileName = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + file.URL;
                            string minfileName = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + "Content/Temp/" + strDeclarationCode + "/图集/" + lstFile[i].CorrelationID + "/(mini)" + lstFile[i].FileName;
                            BLL.PictureHelper.MakeThumbnail(fileName, minfileName, 100, 100, true);
                        }
                    }
                }
            }
        }

        public void GetParticipant(HttpContext context, OleDbConnection conn)
        {
            string DeclarationID = context.Request["DeclarationID"];
            int iDeclarationID = 0;

            try
            {
                if (string.IsNullOrEmpty(DeclarationID) || !int.TryParse(DeclarationID, out iDeclarationID))
                {
                    context.Response.Write(JsonConvert.SerializeObject("参数错误！"));
                }

                Dal.Models.Declaration decl = BLL.Declaration.GetDeclaration(iDeclarationID, conn);
                List<Dal.Models.Participant> lstParticipant = BLL.Declaration.GetParticipant(
                    Convert.ToInt32(DeclarationID), conn).OrderBy(v => v.Ordinal).ToList();

                List<Dal.Models.SysConstant> lstCnst = BLL.SysConstant.GetConstantList("09", conn);
                string strIDName = lstCnst.Where(c => c.ConstantCode == "0901").ToList()[0].ConstantValue;
                while (lstParticipant.Count < decl.ParticipantLimit.Value)
                {
                    lstParticipant.Add(new Participant()
                    {
                        Ordinal = lstParticipant.Count + 1,
                        DeclarationID = iDeclarationID,
                        IDType = "0901",
                        IDTypeName = strIDName
                    });
                }

                context.Response.Write(JsonConvert.SerializeObject(new object[] { lstParticipant, lstCnst }));
            }
            catch (Exception ex)
            {
                context.Response.Write(JsonConvert.SerializeObject(new object[] { ex.Message }));
            }

        }

        /// <summary>
        /// 专家评审页面：获取项目列表
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        public void GetDeclarationExList(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write(JsonConvert.SerializeObject("当前没有激活的活动！"));
                return;
            }

            Dal.Models.DeclarationSearchCondition condition = new DeclarationSearchCondition()
            {
                ActivityID = Convert.ToInt32(activity.ActivityID),
                UserType = user.UserType,
                UserID = user.UserID,
                UserName = user.UserName,
                OrganizationName = context.Request["DeclarationUnit"],
                PrizeID = context.Request["PrizeName"],
                DeclarationStatus = context.Request["DeclarationStatus"],
                DeclarationName = context.Request["DeclarationName"]                 
            };

            DateTime dtm;
            if (!string.IsNullOrEmpty(context.Request["DeclarationBeginDate"])
                && DateTime.TryParse(context.Request["DeclarationBeginDate"], out dtm))
            {
                condition.DeclarationBeginDate = dtm;
            }

            if (!string.IsNullOrEmpty(context.Request["DeclarationEndDate"])
                && DateTime.TryParse(context.Request["DeclarationEndDate"], out dtm))
            {
                condition.DeclarationEndDate = dtm;
            }

            if (!string.IsNullOrEmpty(context.Request["EditBeginDate"])
                && DateTime.TryParse(context.Request["EditBeginDate"], out dtm))
            {
                condition.EditBeginDate = dtm;
            }

            if (!string.IsNullOrEmpty(context.Request["EditEndDate"])
                && DateTime.TryParse(context.Request["EditEndDate"], out dtm))
            {
                condition.EditEndDate = dtm;
            }
            List<Dal.Models.Declaration> lstDeclaration = BLL.Declaration.GetDeclarationExList(condition, conn);

            string strExpertReview = context.Request["ExpertReview"];
            string strDeclarationAuditing = context.Request["DeclarationAuditing"];
            string strPageType = context.Request["PageType"];
            string strAllocationList = context.Request["AllocationList"];

            if (!string.IsNullOrEmpty(strAllocationList))
            {
                //只要收件封存状态的
                lstDeclaration = lstDeclaration.Where(d => d.DeclarationStatus == "1803").ToList();
            }

            //判断已删除项目页
            if (!string.IsNullOrEmpty(strPageType) && strPageType == "会员")
            {
                lstDeclaration = lstDeclaration.Where(d => !(new string[] { "1801", "1802", "1803", "1804" }.Contains(d.DeclarationStatus))).ToList();
            }
            else if (!string.IsNullOrEmpty(strPageType) && strPageType == "管理员")
            {
                lstDeclaration = lstDeclaration.Where(d => !(new string[] { "1801", "1802", "1803", "1804", "1806" }.Contains(d.DeclarationStatus))).ToList();
            }
            else
            {
                lstDeclaration = lstDeclaration.Where(d => !(new string[] { "1805", "1806" }.Contains(d.DeclarationStatus))).ToList();
            }

            if (!string.IsNullOrEmpty(strDeclarationAuditing))
            {
                lstDeclaration = lstDeclaration.Where(d => !(new string[] { "1801", "1804", "1806" }.Contains(d.DeclarationStatus))).OrderBy(d => d.AssociationOrdinal).ToList();
            }
            else if (!string.IsNullOrEmpty(strExpertReview))
            {
                lstDeclaration = lstDeclaration.OrderBy(d => d.BigOrdinal).ToList();
            }

            int iDeclaration = lstDeclaration.Count;
            int iPageSize = 10;
            if (!Int32.TryParse(context.Request["PageSize"] ?? "50", out iPageSize))
            {
                iPageSize = 10;
            }

            int iCuttentPage = 1;
            if (!Int32.TryParse(context.Request["CuttentPage"] ?? "0", out iCuttentPage))
            {
                iCuttentPage = 1;
            }

            int iRecordNumber = lstDeclaration.Count;
            int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPageSize));
            lstDeclaration = lstDeclaration.Skip(iPageSize * (iCuttentPage - 1)).Take(iPageSize).ToList();

            System.Data.DataTable dtDeclaration = Dal.DataTableExtensions.ToDataTable(lstDeclaration);

            dtDeclaration.Columns.Add("ExpertType");

            Dal.Models.Expert expert = BLL.Expert.GetExpertByUserID(user.UserID.Value, conn);
            foreach (DataRow row in dtDeclaration.Rows)
            {
                row["DeclareDate"] = Convert.ToDateTime(row["DeclareDate"]).ToString("yyyy-MM-dd");
                row["CreateTime"] = Convert.ToDateTime(row["CreateTime"]).ToString("yyyy-MM-dd");
                row["LastUpdateTime"] = Convert.ToDateTime(row["LastUpdateTime"]).ToString("yyyy-MM-dd HH:mm");
                if (!row.IsNull("DeleteTime"))
                {
                    row["DeleteTime"] = Convert.ToDateTime(row["DeleteTime"]).ToString("yyyy-MM-dd HH:mm");
                }

                if (!string.IsNullOrEmpty(strExpertReview))
                {
                    if (!string.IsNullOrEmpty(row["ExpertReviewGroupID"].ToString()) && !string.IsNullOrEmpty(row["ExpertReviewer"].ToString()))
                    {
                        if (row["ExpertReviewer"].ToString() == expert.ExpertID.ToString())
                        {
                            row["ExpertType"] = "意见填写人";
                        }
                        else
                        {
                            row["ExpertType"] = "审阅人";
                        }
                    }
                }
            }

            Dal.Models.PageInfo<Dal.Models.Declaration> pgif = new Dal.Models.PageInfo<Dal.Models.Declaration>();
            pgif.CuttentPage = iCuttentPage;
            pgif.PerPage = iPageSize;
            pgif.RecordNumber = iRecordNumber;
            pgif.PagesCount = iPagesCount;
            pgif.Table = dtDeclaration;

            string strJson = JsonConvert.SerializeObject(pgif);
            context.Response.Write(strJson);
            conn.Close();
        }

        public void GetDeclarationList(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write(JsonConvert.SerializeObject("当前没有激活的活动！"));
                return;
            }

            Dal.Models.DeclarationSearchCondition condition = new DeclarationSearchCondition()
            {
                ActivityID = Convert.ToInt32(activity.ActivityID),
                UserType = user.UserType,
                UserID = user.UserID,
                UserName = user.UserName,
                OrganizationName = context.Request["DeclarationUnit"],
                PrizeID = context.Request["PrizeName"],
                DeclarationStatus = context.Request["DeclarationStatus"],
                DeclarationName = context.Request["DeclarationName"]
            };

            DateTime dtm;
            if (!string.IsNullOrEmpty(context.Request["DeclarationBeginDate"])
                && DateTime.TryParse(context.Request["DeclarationBeginDate"], out dtm))
            {
                condition.DeclarationBeginDate = dtm;
            }

            if (!string.IsNullOrEmpty(context.Request["DeclarationEndDate"])
                && DateTime.TryParse(context.Request["DeclarationEndDate"], out dtm))
            {
                condition.DeclarationEndDate = dtm;
            }

            if (!string.IsNullOrEmpty(context.Request["EditBeginDate"])
                && DateTime.TryParse(context.Request["EditBeginDate"], out dtm))
            {
                condition.EditBeginDate = dtm;
            }

            if (!string.IsNullOrEmpty(context.Request["EditEndDate"])
                && DateTime.TryParse(context.Request["EditEndDate"], out dtm))
            {
                condition.EditEndDate = dtm;
            }
            List<Dal.Models.Declaration> lstDeclaration = BLL.Declaration.GetDeclarationList(condition, conn);

            string strExpertReview = context.Request["ExpertReview"];
            string strDeclarationAuditing = context.Request["DeclarationAuditing"];
            string strPageType = context.Request["PageType"];
            string strAllocationList = context.Request["AllocationList"];

            if (!string.IsNullOrEmpty(strAllocationList))
            {
                //只要收件封存状态的
                lstDeclaration = lstDeclaration.Where(d => d.DeclarationStatus == "1803").ToList();
            }

            //判断已删除项目页
            if (!string.IsNullOrEmpty(strPageType) && strPageType == "会员")
            {
                lstDeclaration = lstDeclaration.Where(
                    d => !(new string[] { "1801", "1802", "1803", "1804" }.Contains(d.DeclarationStatus))).ToList();
            }
            else if (!string.IsNullOrEmpty(strPageType) && strPageType == "管理员")
            {
                lstDeclaration = lstDeclaration.Where(
                    d => !(new string[] { "1801", "1802", "1803", "1804", "1806" }.Contains(d.DeclarationStatus))).ToList();
            }
            else
            {
                lstDeclaration = lstDeclaration.Where(d => !(new string[] { "1805", "1806" }.Contains(d.DeclarationStatus))).ToList();
            }

            if (!string.IsNullOrEmpty(strDeclarationAuditing))
            {
                lstDeclaration = lstDeclaration.Where(
                    d => !(new string[] { "1801", "1804", "1806" }.Contains(
                        d.DeclarationStatus))).OrderBy(d => d.AssociationOrdinal).OrderBy(d => d.TemplateCode).ToList();
            }
            else if (!string.IsNullOrEmpty(strExpertReview))
            {
                //lstDeclaration = lstDeclaration.Where(d => !(new string[] { "1801", "1804", "1806" }.Contains(d.DeclarationStatus))).OrderBy(d => d.AssociationOrdinal).ToList();
                lstDeclaration = lstDeclaration.OrderBy(d => d.BigOrdinal).ToList();
            }

            int iDeclaration = lstDeclaration.Count;
            int iPageSize = 10;
            if (!Int32.TryParse(context.Request["PageSize"] ?? "50", out iPageSize))
            {
                iPageSize = 10;
            }

            int iCuttentPage = 1;
            if (!Int32.TryParse(context.Request["CuttentPage"] ?? "0", out iCuttentPage))
            {
                iCuttentPage = 1;
            }

            int iRecordNumber = lstDeclaration.Count;
            int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPageSize));
            lstDeclaration = lstDeclaration.Skip(iPageSize * (iCuttentPage - 1)).Take(iPageSize).ToList();

            System.Data.DataTable dtDeclaration = Dal.DataTableExtensions.ToDataTable(lstDeclaration);

            dtDeclaration.Columns.Add("ExpertType");

            Dal.Models.Expert expert = BLL.Expert.GetExpertByUserID(user.UserID.Value, conn);
            foreach (DataRow row in dtDeclaration.Rows)
            {
                row["DeclareDate"] = Convert.ToDateTime(row["DeclareDate"]).ToString("yyyy-MM-dd");
                row["CreateTime"] = Convert.ToDateTime(row["CreateTime"]).ToString("yyyy-MM-dd");
                row["LastUpdateTime"] = Convert.ToDateTime(row["LastUpdateTime"]).ToString("yyyy-MM-dd HH:mm");
                if (!row.IsNull("DeleteTime"))
                {
                    row["DeleteTime"] = Convert.ToDateTime(row["DeleteTime"]).ToString("yyyy-MM-dd HH:mm");
                }

                if (!string.IsNullOrEmpty(strExpertReview))
                {
                    if (!string.IsNullOrEmpty(row["ExpertReviewGroupID"].ToString()) && !string.IsNullOrEmpty(row["ExpertReviewer"].ToString()))
                    {
                        if (row["ExpertReviewer"].ToString() == expert.ExpertID.ToString())
                        {
                            row["ExpertType"] = "意见填写人";
                        }
                        else
                        {
                            row["ExpertType"] = "审阅人";
                        }
                    }
                }
            }

            Dal.Models.PageInfo<Dal.Models.Declaration> pgif = new Dal.Models.PageInfo<Dal.Models.Declaration>();
            pgif.CuttentPage = iCuttentPage;
            pgif.PerPage = iPageSize;
            pgif.RecordNumber = iRecordNumber;
            pgif.PagesCount = iPagesCount;
            pgif.Table = dtDeclaration;

            string strJson = JsonConvert.SerializeObject(pgif);
            context.Response.Write(strJson);
            conn.Close();
        }

        public void SetReviewComment(HttpContext context, OleDbConnection conn)
        {
            int iDeclarationID =0;
            int.TryParse(context.Request["DeclarationID"], out iDeclarationID);

            string strReviewComment = context.Request["ReviewComment"].Trim();

            if (!string.IsNullOrEmpty(strReviewComment))
            {                
                try
                {
                    BLL.Declaration.SetReviewComment(iDeclarationID, strReviewComment, conn);
                    context.Response.Write("success");
                }
                catch (Exception ex)
                {
                    context.Response.Write(ex.Message);
                }
            } 
        }

        public void Save(HttpContext context, OleDbConnection conn)
        {
            int iDeclarationID = Convert.ToInt32(context.Request["DeclarationID"]);
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];

            int iIdx = 0;
            List<KeyValuePair<string, string>> lstData = new List<KeyValuePair<string, string>>();
            while (context.Request["PageData[" + iIdx.ToString() + "][Name]"] != null)
            {
                lstData.Add(new KeyValuePair<string, string>(
                    context.Request["PageData[" + iIdx.ToString() + "][Name]"].Trim(),
                    context.Request["PageData[" + iIdx.ToString() + "][Value]"].Trim()));
                iIdx++;
            }

            bool bChanged = false;
            OleDbTransaction trans = null;
            switch (context.Request["PartCode"])
            {
                case "Participant":
                    List<Dal.Models.Participant> lstParticipant = new List<Dal.Models.Participant>();
                    DateTime dtNow = DateTime.Now;
                    iIdx = 1;
                    while (lstData.Where(c => c.Key == "ParticipantName" + iIdx.ToString()).Count() > 0)
                    {
                        Dal.Models.Participant p = new Dal.Models.Participant();

                        p.DeclarationID = iDeclarationID;
                        p.Ordinal = iIdx;
                        p.ParticipantName = (lstData.Where(c => c.Key == "ParticipantName" + iIdx.ToString()).ToList()[0].Value ?? "").Trim();
                        p.AcademicTitle = (lstData.Where(c => c.Key == "AcademicTitle" + iIdx.ToString()).ToList()[0].Value ?? "").Trim();
                        p.Speciality = (lstData.Where(c => c.Key == "Speciality" + iIdx.ToString()).ToList()[0].Value ?? "").Trim();
                        p.Duties = (lstData.Where(c => c.Key == "Duties" + iIdx.ToString()).ToList()[0].Value ?? "").Trim();
                        p.IDType = (lstData.Where(c => c.Key == "IDType" + iIdx.ToString()).ToList()[0].Value ?? "").Trim();
                        p.IDNumber = (lstData.Where(c => c.Key == "IDNumber" + iIdx.ToString()).ToList()[0].Value ?? "").Trim();
                        p.Workplace = (lstData.Where(c => c.Key == "Workplace" + iIdx.ToString()).ToList()[0].Value ?? "").Trim();
                        p.LastUpdateTime = dtNow;
                        p.LastUpdateUser = user.UserID;
                        if (!string.IsNullOrEmpty(p.ParticipantName) && !string.IsNullOrEmpty(p.IDNumber))
                        {
                            lstParticipant.Add(p);
                        }
                        iIdx++;
                    }

                    List<Dal.Models.Participant> lstParticipantOriginal = BLL.Declaration.GetParticipant(iDeclarationID, conn);

                    if (lstParticipantOriginal.Count == lstParticipant.Count)
                    {
                        foreach (Dal.Models.Participant pNew in lstParticipant)
                        {
                            if (lstParticipantOriginal.Where(p =>
                                p.Ordinal == pNew.Ordinal &&
                                p.ParticipantName == pNew.ParticipantName &&
                                p.AcademicTitle == pNew.AcademicTitle &&
                                p.Speciality == pNew.Speciality &&
                                p.Duties == pNew.Duties &&
                                p.IDType == pNew.IDType &&
                                p.IDNumber == pNew.IDNumber &&
                                p.Workplace == pNew.Workplace
                                ).Count() == 0)
                            {
                                bChanged = true;
                                break;
                            }
                        }

                    }
                    else
                    {
                        bChanged = true;
                    }
                    if (bChanged)
                    {
                        try
                        {
                            // 事务做到数据库中，此处不在使用事务
                            BLL.Declaration.SaveParticipant(iDeclarationID, lstParticipant, conn);
                            context.Response.Write("success");
                        }
                        catch (Exception ex)
                        {
                            context.Response.Write(ex.Message);
                        }
                    }
                    break;
                case "Review":
                    List<Dal.Models.Declaration> lstDeclaration = new List<Dal.Models.Declaration>();
                    DateTime dtNoww = DateTime.Now;
                    iIdx = 1;
                    if (lstData.Where(c => c.Key == "ExpertReviewComment").Count() > 0)
                    {
                        Dal.Models.Declaration d = new Dal.Models.Declaration();
                        d.DeclarationID = iDeclarationID;
                        d.ExpertReviewComment = lstData.Where(c => c.Key == "ExpertReviewComment").ToList()[0].Value;
                        d.ExpertReviewTime = dtNoww;
                        lstDeclaration.Add(d);
                        iIdx++;
                    }

                    Dal.Models.Declaration declOriginal = BLL.Declaration.GetDeclaration(iDeclarationID, conn);
                    if (declOriginal.ExpertReviewComment != lstDeclaration[0].ExpertReviewComment)
                    {
                        trans = conn.BeginTransaction();
                        try
                        {
                            BLL.Declaration.SaveDeclarationReview(iDeclarationID, lstDeclaration, conn, trans);
                            context.Response.Write("success");
                            trans.Commit();
                        }
                        catch (Exception ex)
                        {
                            trans.Rollback();
                            //throw ex;
                            context.Response.Write(ex.Message);
                        }
                    }

                    break;
                default:
                    BLL.Declaration.SaveData(iDeclarationID,
                        "Dal.Models." + context.Request["PartCode"], lstData, conn);
                    context.Response.Write("success");
                    break;
            }
        }

        public void Recovery(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction trans = conn.BeginTransaction();
            string DeclarationID = context.Request["DeclarationID"];
            var liststr = DeclarationID.Split(',');
            try
            {
                for (int i = 0; i < liststr.Count(); i++)
                {
                    int iDeclarationID = Convert.ToInt32(liststr[i]);
                    BLL.Declaration.RecoveryDeclaration(iDeclarationID, conn, trans);
                }
                trans.Commit();
                context.Response.Write("success");
            }
            catch (Exception ex)
            {
                trans.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        public void GetChildList(HttpContext context, OleDbConnection conn)
        {
            string SpecialtyID = context.Request["SpecialtyID"];

            List<Dal.Models.Specialty> lstSpecialty = BLL.Specialty.GetDirectlyChildList(Convert.ToInt32(SpecialtyID), conn);
            if (lstSpecialty.Count > 0)
            {
                object[] objs = { "Specialty", lstSpecialty };
                context.Response.Write(JsonConvert.SerializeObject(objs));
            }
            else
            {
                List<Dal.Models.Prize> lstPrize = BLL.Prize.GetPrizeList(Convert.ToInt32(SpecialtyID), conn);
                object[] objs = { "Prize", lstPrize };
                context.Response.Write(JsonConvert.SerializeObject(objs));
            }
        }

        public void ImportAppendix(HttpContext context, OleDbConnection conn)
        {
            if (context.Request.Files.Count > 0)
            {
                string strDeclarationCode = context.Request["DeclarationCode"];
                string strDeclarationID = context.Request["DeclarationID"];
                string strAppendixID = context.Request["AppendixID"];
                string strID = context.Request["ID"];
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
                        string strFilePath = strRootDirectory + "Content\\Temp\\" + strDeclarationCode + "\\附件\\" + strAppendixID;
                        if (!Directory.Exists(strFilePath))
                        {
                            Directory.CreateDirectory(strFilePath);
                        }
                        Dal.Models.UploadFileInfo dUploadFileInfo = BLL.UploadFileInfo.GetUploadFile(Convert.ToInt32(strDeclarationID)
                            , Convert.ToInt32(strAppendixID), "DeclarationAppendix", conn, trans);
                        Dal.Models.Appendix AppendixInfo = BLL.Appendix.GetAppendix(Convert.ToInt32(strAppendixID), conn, trans);

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

                        string strPath = strDeclarationCode + "\\附件\\" + file.FileName.Replace(" ", "_");
                        fileName = context.Server.MapPath("~/Content/Temp/" + strPath);
                        file.SaveAs(fileName);

                        // 存入数据库
                        Dal.Models.UploadFileInfo dataFile = new Dal.Models.UploadFileInfo();
                        dataFile.Type = FileType.DeclarationAppendix;
                        dataFile.OwnerID = Convert.ToInt32(strDeclarationID);
                        dataFile.CorrelationID = Convert.ToInt32(strAppendixID);
                        dataFile.FileName = file.FileName.Replace(" ", "_");
                        dataFile.URL = "Content\\Temp\\" + strPath;
                        dataFile.SizeLimit = AppendixInfo.SizeLimit;
                        dataFile.AmountLimit = 1;
                        BLL.UploadFileInfo.SaveFile(dataFile, conn, trans);
                    }
                    trans.Commit();
                    context.Response.Write(JsonConvert.SerializeObject(strDeclarationID + "," + strID + "," + strAppendixID));
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    context.Response.Write(JsonConvert.SerializeObject(ex.Message));
                }
            }
        }

        public void GetAppendix(HttpContext context, OleDbConnection conn)
        {
            string strOwnerID = context.Request["OwnerID"];
            int iOwnerID = Convert.ToInt32(context.Request["OwnerID"]);
            int iCorrelationID = Convert.ToInt32(context.Request["CorrelationID"]);
            int iID = Convert.ToInt32(context.Request["ID"]);
            try
            {
                Dal.Models.UploadFileInfo dUploadFileInfo = BLL.UploadFileInfo.GetUploadFile(iOwnerID, iCorrelationID, "DeclarationAppendix", conn);
                StringBuilder sbFileName = new StringBuilder();
                sbFileName.AppendFormat("<a id='LoadFile{0}' onclick='LoadFile({1})'>{2}</a>", iID, dUploadFileInfo.UploadFileID, dUploadFileInfo.FileName);
                sbFileName.Append("<br />");
                sbFileName.AppendFormat("<a  onclick='DeleteAppendix({0},{1},{2},{3});return false;' title='删除' href=''>"
                    , dUploadFileInfo.UploadFileID, dUploadFileInfo.OwnerID, dUploadFileInfo.CorrelationID, iID);
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

        public void ImportAtlas(HttpContext context, OleDbConnection conn)
        {
            int a = context.Request.Files.Count;
            if (a == 0)
            {
                context.Response.Write(JsonConvert.SerializeObject("2"));
            }
            if (context.Request.Files.Count > 0)
            {
                string strDeclarationCode = context.Request["DeclarationCode"];
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
                            dataFile.SizeLimit = AtlasInfo.SizeLimit;
                            dataFile.AmountLimit = AtlasInfo.UploadLimitMax;

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
                        sbAtlasHTML.AppendFormat("<a id='Atlas{0}' class='dowebok'>", i);
                        sbAtlasHTML.AppendFormat("<img src='../../{0}' data-original='../../{1}' width='150px' height='150px' title='查看大图'/></a><br />", Path, PathMax);
                        sbAtlasHTML.Append(lstUploadFileInfo[i].FileName);
                        sbAtlasHTML.Append("<br />");
                        sbAtlasHTML.AppendFormat("<a onclick='DeleteImg({0},{1},{2},{3});return false;'  title='删除' href=''>"
                            , lstUploadFileInfo[i].UploadFileID, lstUploadFileInfo[i].OwnerID, lstUploadFileInfo[i].CorrelationID, iID);
                        sbAtlasHTML.Append("<i class='fa fa-trash-o'></i>");
                        sbAtlasHTML.Append("</a>");

                        sbAtlasHTML.AppendFormat("<a id='DownloadImg{0}' onclick=\'DownloadImg({1});return false;\' title='下载' href=''>"
                            , i, lstUploadFileInfo[i].UploadFileID);
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

        public void ImportMedia(HttpContext context, OleDbConnection conn)
        {
            int a = context.Request.Files.Count;
            if (a == 0)
            {
                context.Response.Write(JsonConvert.SerializeObject("请选择上传文件"));
            }

            if (context.Request.Files.Count > 0)
            {
                string strDeclarationCode = context.Request["DeclarationCode"];
                string strDeclarationID = context.Request["DeclarationID"];
                string strMediaID = context.Request["MediaID"];
                string strID = context.Request["ID"];
                string fileName = "";

                HttpFileCollection files = context.Request.Files;
                OleDbTransaction trans = conn.BeginTransaction();
                Dal.Models.Media MediaInfo = BLL.Media.GetMedia(Convert.ToInt32(strMediaID), conn, trans);

                string strRootContent = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + "Content\\";
                string strFilePath = strRootContent + "Temp\\" + strDeclarationCode + "\\视频\\" + strMediaID;
                if (!Directory.Exists(strFilePath))
                {
                    Directory.CreateDirectory(strFilePath);
                }

                try
                {
                    // 1兆 = 1024 * 1024 字节    1024 * 1024 = 1048576
                    if (files[0].ContentLength > (1048576 * MediaInfo.SizeLimit))
                    {
                        throw new InvalidOperationException("文件大小超过限制！");
                    }

                    int iMediaID = Convert.ToInt32(strMediaID);
                    int iDeclarationID = Convert.ToInt32(strDeclarationID);

                    Dal.Models.UploadFileInfo dataFile = BLL.UploadFileInfo.GetUploadFile(
                        iDeclarationID, iMediaID, "DeclarationMedia", conn, trans);

                    if (dataFile == null)
                    {
                        dataFile = new Dal.Models.UploadFileInfo()
                        {
                            OwnerID = iDeclarationID,
                            CorrelationID = iMediaID,
                            Type = FileType.DeclarationMedia,
                            SizeLimit = MediaInfo.SizeLimit,
                            AmountLimit = 1
                        };
                    }
                    else
                    {
                        string strExistsFile = context.Server.MapPath(
                            "~/Content/Temp/" + strDeclarationCode + "/视频/" + strMediaID + "/" + dataFile.FileName);
                        if (File.Exists(strExistsFile))
                        {
                            File.Delete(strExistsFile);
                        }
                    }

                    // 存入本地文件夹
                    HttpPostedFile file = files[0];
                    fileName = context.Server.MapPath("~/Content/Temp/" + strDeclarationCode + "/视频/" + strMediaID + "/"
                        + files[0].FileName.Replace(" ", "_"));
                    file.SaveAs(fileName);

                    dataFile.FileName = files[0].FileName.Replace(" ", "_");
                    dataFile.URL = "Content\\Temp\\" + strDeclarationCode + "\\视频\\" + strMediaID + "\\" + dataFile.FileName;
                    BLL.UploadFileInfo.SaveFile(dataFile, conn, trans);

                    trans.Commit();

                    context.Response.Write(JsonConvert.SerializeObject(strDeclarationID + "," + strMediaID + "," + strID));
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    context.Response.Write(ex.Message);
                }
            }
        }

        public void GetMedia(HttpContext context, OleDbConnection conn)
        {
            int iOwnerID = Convert.ToInt32(context.Request["OwnerID"]);
            int iCorrelationID = Convert.ToInt32(context.Request["CorrelationID"]);
            int iID = Convert.ToInt32(context.Request["ID"]);
            try
            {
                Dal.Models.UploadFileInfo media = BLL.UploadFileInfo.GetUploadFile(iOwnerID, iCorrelationID, "DeclarationMedia", conn);

                conn.Close();
                StringBuilder sbMediaHTML = new StringBuilder();
                if (media != null)
                {
                    sbMediaHTML.AppendFormat("<a id='LoadFile{0}'>{1}</a>", iID, media.FileName);
                    sbMediaHTML.AppendFormat("<p><a class='DeleteAppendix' onclick='DeleteMedia({0},{1});return false;'", media.UploadFileID, iID);
                    sbMediaHTML.Append("'  title='删除' href=''><i class='fa fa-trash-o'></i></a>");
                    sbMediaHTML.AppendFormat("<a class='DownloadAppendix' onclick=\"DownloadMedia({0});", media.UploadFileID);
                    sbMediaHTML.Append("return false;\" title='下载' href=''><i class='fa fa-download'></i></a>");
                    sbMediaHTML.AppendFormat("<a class='mediaplay' onclick=\"initplayer('{0}','{1}')\">"
                        , "../../" + media.URL.Replace("\\", "/"), media.FileName);
                    sbMediaHTML.Append("<i class='fa fa-play-circle' aria-hidden='true'></i></a></p>");
                }
                context.Response.Write(JsonConvert.SerializeObject(sbMediaHTML.ToString()));
            }
            catch (Exception ex)
            {
                context.Response.Write(JsonConvert.SerializeObject(ex.Message));
            }
        }

        public void DeleteUploadFile(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction trans = conn.BeginTransaction();
            int iUploadFileID = Convert.ToInt32(context.Request["UploadFileID"]);
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

                    context.Response.Write(JsonConvert.SerializeObject("暂未上传文件！"));
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

        /// <summary>
        /// 收件封存、驳回、管理员删除
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        public void AuditingStatus(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];

            //OleDbTransaction trans = conn.BeginTransaction();
            string DeclarationID = context.Request["DeclarationID"];
            string straction = context.Request["Action"];
            var liststr = DeclarationID.Split(',');
            string strMailContent = "";
            if (!string.IsNullOrEmpty(DeclarationID))
            {
                try
                {
                    // 设置项目评价
                    if (!string.IsNullOrEmpty(context.Request["MailContent"]))
                    {
                        strMailContent = context.Request["MailContent"];
                        strMailContent = strMailContent.Replace("&gt;", ">");
                        strMailContent = strMailContent.Replace("&lt;", "<");
                        strMailContent = strMailContent.Replace("&quot;", "\"");
                        strMailContent = strMailContent.Replace("&rsquo;", "'");
                        strMailContent = strMailContent.Replace("&frasl;", "/");
                        strMailContent = strMailContent.Replace("&nbsp;", "　");
                        strMailContent = strMailContent.Replace("<p　style='white-space:　normal;'>;", " ");

                        //BLL.Declaration.UpdateDeclarationComment(DeclarationID, strMailContent, conn, trans);
                    }

                    string strStatus;
                    switch (straction)
                    {
                        case "Check"://收件封存
                            strStatus = "1803";
                            break;
                        case "Return"://驳回
                            strStatus = "1804";
                            break;
                        case "ThoroughDelete":// 管理员删除
                            strStatus = "1805";
                            break;
                        case "Delete":// 申报用户删除
                            strStatus = "1806";
                            break;
                        default:
                            strStatus = "";
                            break;
                    }

                    BLL.Declaration.SetDeclarationSataus(DeclarationID, user.UserID.Value, strStatus, strMailContent, conn);
                    conn.Close();
                    if (straction == "Check")
                    {
                        context.Response.Write(JsonConvert.SerializeObject("收件并发送邮件成功!"));
                    }
                    else if (straction == "Return")
                    {
                        context.Response.Write(JsonConvert.SerializeObject("退件并发送邮件成功!"));
                    }
                    else if (straction == "ThoroughDelete")
                    {
                        context.Response.Write(JsonConvert.SerializeObject("删除并发送邮件成功!"));
                    }
                    else if (straction == "Delete")
                    {
                        context.Response.Write(JsonConvert.SerializeObject("删除成功!"));
                    }
                }
                catch (Exception ex)
                {
                    context.Response.Write(JsonConvert.SerializeObject(ex.Message));
                    //trans.Rollback();
                }
            }
        }

        public void FreshDivision(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction trans = conn.BeginTransaction();
            int iDeclarationID = 0;
            try
            {
                if (context.Request["DeclarationID"] != "")
                {
                    iDeclarationID = Convert.ToInt32(context.Request["DeclarationID"]);
                }
                else
                {
                    throw new Exception("参数错误！");
                }

                Dal.Models.Declaration decl = BLL.Declaration.GetDeclaration(iDeclarationID, conn, trans);
                Dal.Models.Prize prize = BLL.Prize.GetPrize(Convert.ToInt32(decl.PrizeID), conn, trans);
                List<Dal.Models.TemplateConstant> sys = BLL.SysConstant.GetSysConstantListOfConstantDiscription(prize.TemplateCode, conn, trans);
                List<Dal.Models.Declaration_Data> lstDecl = BLL.Declaration.GetDeclarationDivisionList(iDeclarationID, sys[1].KeyValue, sys[0].KeyValue, conn, trans);
                context.Response.Write(JsonConvert.SerializeObject(lstDecl));
                trans.Commit();
            }
            catch (Exception ex)
            {
                context.Response.Write(JsonConvert.SerializeObject(ex.Message));
                trans.Rollback();
            }
        }

        /// <summary>
        /// 提交项目
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        public void SubmitDeclaration(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            //OleDbTransaction trans = conn.BeginTransaction();
            int iDeclarationID = Convert.ToInt32(context.Request["DeclarationID"]);

            try
            {
                BLL.Declaration.SetDeclarationSataus(iDeclarationID, user.UserID.Value, "1802", null, conn);
                context.Response.Write(JsonConvert.SerializeObject("提交成功!"));

                conn.Close();
            }
            catch (Exception ex)
            {
                context.Response.Write(JsonConvert.SerializeObject(ex.Message));
                //trans.Rollback();
            }
        }

        public void GetPrize(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction trans = conn.BeginTransaction();
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn, trans);
            if (activity == null)
            {
                context.Response.Write(JsonConvert.SerializeObject("当前没有激活的活动！"));
                return;
            }
            Dal.Models.Specialty spec = null;
            string SepcCode = context.Request["SepcCode"];
            // 获取菜单传递过来的参数
            spec = BLL.Specialty.GetSpecialty(activity.ActivityID.Value, SepcCode, conn, trans);
            if (spec == null)
            {
                List<Dal.Models.Specialty> lst = BLL.Specialty.GetSpecialtyList(activity.ActivityID.Value, true, conn, trans);
                spec = lst[0];
            }
            List<Dal.Models.Specialty> lstSpecialty = BLL.Specialty.GetDirectlyChildList(spec.SpecialtyID.Value, conn, trans);
            List<Dal.Models.Prize> lstPrize = null;
            if (lstSpecialty.Count == 0)
            {
                lstPrize = BLL.Prize.GetPrizeList(spec.SpecialtyID.Value, conn, trans);
            }
            else
            {
                List<Dal.Models.Specialty> lstChildSpecialty = null;
                lstSpecialty = lstSpecialty.Where(s => BLL.Prize.Count(s.SpecialtyID.Value, conn, trans) > 0 || BLL.Specialty.Count(activity.ActivityID.Value, s.SpecialtyID, conn, trans) > 0).ToList();
                if (lstSpecialty.Count > 0)
                {
                    lstChildSpecialty = BLL.Specialty.GetDirectlyChildList(lstSpecialty[0].SpecialtyID.Value, conn, trans);
                    if (lstChildSpecialty.Count == 0)
                    {
                        lstPrize = BLL.Prize.GetPrizeList(lstSpecialty[0].SpecialtyID.Value, conn, trans);
                    }
                    else
                    {
                        lstPrize = BLL.Prize.GetPrizeList(lstChildSpecialty[0].SpecialtyID.Value, conn, trans);
                    }
                }
            }
            if (lstPrize != null)
            {
                if (lstPrize.Count == 0)
                {
                    context.Response.Write(JsonConvert.SerializeObject("该专业下暂无奖项，无法申报!"));
                }
            }
            else
            {
                context.Response.Write(JsonConvert.SerializeObject("该专业下暂无奖项，无法申报!"));
            }
        }

        public void GetError(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction trans = conn.BeginTransaction();
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            int iDeclarationID = Convert.ToInt32(context.Request["DeclarationID"]);
            string strDeclarationStatus = context.Request["DeclarationStatus"].Replace("\"", "");
            string strPrizeID = context.Request["PrizeID"];
            string strPrizeID2 = context.Request["PrizeID2"];
            string strTemplateCode = "";
            string strDeclarationName = context.Request["DeclarationName"];
            int iSpecilID = 0;
            int iPrizeID = Convert.ToInt32(strPrizeID);
            int iPrizeID2 = Convert.ToInt32(strPrizeID2);

            Dal.Models.Declaration declNamed = null;
            if (iPrizeID == 0)
            {
                if (iPrizeID2 != 0)
                {
                    strTemplateCode = BLL.Prize.GetPrize(iPrizeID2, conn, trans).TemplateCode;
                    iSpecilID = Convert.ToInt32(BLL.Prize.GetPrize(iPrizeID2, conn, trans).SpecialtyID);
                    declNamed = BLL.Declaration.GetDeclaration(strDeclarationName, iPrizeID2, conn, trans);
                }
                else
                {
                    context.Response.Write(JsonConvert.SerializeObject("请选择建奖项!"));
                    return;
                }
            }
            else
            {
                strTemplateCode = BLL.Prize.GetPrize(iPrizeID, conn, trans).TemplateCode;
                iSpecilID = Convert.ToInt32(BLL.Prize.GetPrize(iPrizeID, conn, trans).SpecialtyID);
                declNamed = BLL.Declaration.GetDeclaration(strDeclarationName, iPrizeID, conn, trans);
            }

            int actID = BLL.Specialty.GetSpecialty(iSpecilID, conn, trans).ActivityID.Value;
            Dal.Models.Schedule dSchedule = BLL.Schedule.GetSpecialtySchedule(iSpecilID, conn, trans);
            if (strDeclarationStatus != "ExpertReview" && strDeclarationStatus != "Auditing")
            {
                if (dSchedule == null)
                {
                    Dal.Models.Schedule status = BLL.Schedule.GetActivitySchedule(actID, conn, trans);
                    if (status == null || !(status.IsDeclarationStart ?? false))
                    {
                        context.Response.Write(JsonConvert.SerializeObject("未在专业申报时间内，不能创建！"));
                        return;
                    }
                }
                else if (!dSchedule.IsDeclarationStart.Value)
                {
                    context.Response.Write(JsonConvert.SerializeObject("未在专业申报时间内，不能创建！"));
                    return;
                }
            }
            if (declNamed != null && declNamed.DeclarationID != iDeclarationID)
            {
                context.Response.Write(JsonConvert.SerializeObject("该奖项下已存在同名申报,不能重复创建!"));
            }
        }

        public void UpdateOrganizationOrdinal(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            int newValue = Convert.ToInt32(context.Request["newValue"]);
            OleDbTransaction trans = conn.BeginTransaction();
            int DeclarationID = Convert.ToInt32(context.Request["DeclarationID"]);
            try
            {
                Dal.Models.Declaration declarationInfo = BLL.Declaration.GetDeclaration(DeclarationID, conn, trans);
                declarationInfo.OrganizationOrdinal = newValue;
                BLL.Declaration.SetOrganizationOrdinal(declarationInfo, conn, trans);
                trans.Commit();
                context.Response.Write("内部推荐序号设定成功！");
            }
            catch (Exception ex)
            {
                trans.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        public void UpdateAssociationOrdinal(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            int newValue = Convert.ToInt32(context.Request["newValue"]);
            OleDbTransaction trans = conn.BeginTransaction();
            int DeclarationID = Convert.ToInt32(context.Request["DeclarationID"]);
            try
            {
                Dal.Models.Declaration declarationInfo = BLL.Declaration.GetDeclaration(DeclarationID, conn, trans);
                declarationInfo.AssociationOrdinal = newValue;
                BLL.Declaration.SetAssociationOrdinal(declarationInfo, conn, trans);
                trans.Commit();
                context.Response.Write("协会推荐序号设定成功！");
            }
            catch (Exception ex)
            {
                trans.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        public void GetImportDeclaration(HttpContext context, OleDbConnection conn)
        {
            string PrizeID = context.Request["PrizeID"];
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            Dal.Models.Organization org = BLL.User.GetOrganization(user.UserID.Value, conn);
            List<Dal.Models.Declaration> lstDeclaration = BLL.Declaration.GetDeclarationList(org.OrganizationID.Value, Convert.ToInt32(PrizeID), conn);
            if (lstDeclaration.Count > 0)
            {
                object[] objs = { "lstDeclaration", lstDeclaration };
                context.Response.Write(JsonConvert.SerializeObject(objs));
            }
            else
            {
                context.Response.Write(JsonConvert.SerializeObject("1"));
            }
        }

        /// <summary>
        /// 彻底删除项目
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        public void DeleteDeclaration(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction trans = conn.BeginTransaction();
            string strDeclarationID = context.Request["DeclarationID"];
            var liststr = strDeclarationID.Split(',');
            try
            {
                for (int i = 0; i < liststr.Count(); i++)
                {
                    int iDeclarationID = Convert.ToInt32(liststr[i]);
                    BLL.Declaration.DeleteDeclaration(Convert.ToInt32(liststr[i]), conn, trans);
                }
                trans.Commit();
                conn.Close();
                context.Response.Write(JsonConvert.SerializeObject("删除成功"));
            }
            catch (Exception ex)
            {
                context.Response.Write(JsonConvert.SerializeObject(ex.Message));
                trans.Rollback();
            }
        }

        /// <summary>
        /// 调用：从提交状态直接进入编辑状态
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        public void SetDeclarationStatus(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];

            //OleDbTransaction trans = conn.BeginTransaction();
            string strDeclarationID = context.Request["DeclarationID"];
            string strDeclarationStatus = context.Request["DeclarationStatus"];
            try
            {
                //BLL.Declaration.SetDeclarationSataus(Convert.ToInt32(strDeclarationID), strDeclarationStatus, null, conn, trans);
                BLL.Declaration.SetDeclarationSataus(Convert.ToInt32(strDeclarationID), user.UserID.Value, strDeclarationStatus, null, conn);
                //trans.Commit();
                conn.Close();
                context.Response.Write(JsonConvert.SerializeObject(strDeclarationID));
            }
            catch (Exception ex)
            {
                context.Response.Write(JsonConvert.SerializeObject(ex.Message));
                //trans.Rollback();
            }
        }

        /// <summary>
        /// 项目评审的时候提交评审意见
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        public void SubmitComment(HttpContext context, OleDbConnection conn)
        {
            //OleDbTransaction trans = conn.BeginTransaction();
            //int iDeclarationID = Convert.ToInt32(context.Request["DeclarationID"]) ;
            //string strDeclarationComment = context.Request["DeclarationComment"];
            //try
            //{
            //    BLL.Declaration.UpdateDeclarationComment(iDeclarationID, strDeclarationComment, conn, trans);
            //    trans.Commit();
            //    conn.Close();
            //    context.Response.Write(JsonConvert.SerializeObject("提交成功！"));
            //}
            //catch (Exception ex)
            //{
            //    context.Response.Write(JsonConvert.SerializeObject(ex.Message));
            //    trans.Rollback();
            //}
        }

        public void GetComment(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction trans = conn.BeginTransaction();
            int iDeclarationID = Convert.ToInt32(context.Request["DeclarationID"]);
            try
            {
                Dal.Models.Declaration decl = BLL.Declaration.GetDeclaration(iDeclarationID, conn, trans);
                trans.Commit();
                conn.Close();
                context.Response.Write(JsonConvert.SerializeObject(decl.QualificationReviewComment));
            }
            catch (Exception ex)
            {
                context.Response.Write(JsonConvert.SerializeObject(ex.Message));
                trans.Rollback();
            }
        }

        public void PackageEvaluation(HttpContext context, OleDbConnection conn)
        {
            int iPrizeID = Convert.ToInt32(context.Request["PrizeID"]);
            string strServerMapPath = System.Web.HttpContext.Current.Request.PhysicalApplicationPath;

            BLL.Declaration.PackageDeclaration(iPrizeID, strServerMapPath, conn);
            context.Response.Write(JsonConvert.SerializeObject("成功"));
        }

        public void PackageAll(HttpContext context, OleDbConnection conn)
        {
            //int iPrizeID = Convert.ToInt32(context.Request["PrizeID"]);
            string strServerMapPath = System.Web.HttpContext.Current.Request.PhysicalApplicationPath;
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            string strActivityType = context.Session["ActivityType"].ToString();

            List<Dal.Models.Prize> lstPrize = BLL.Prize.GetPrizeList(user, strActivityType, null, conn);
            try
            {
                foreach (Dal.Models.Prize p in lstPrize)
                {
                    BLL.Declaration.PackageDeclaration(p.PrizeID.Value, strServerMapPath, conn);
                }
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }

            //BLL.Declaration.PackageDeclaration(iPrizeID, strServerMapPath, conn);
            context.Response.Write(JsonConvert.SerializeObject("成功"));
        }
    }
}