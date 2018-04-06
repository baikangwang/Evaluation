using Dal.Models;
using Newtonsoft.Json;
using NPOI.Util;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.SessionState;

namespace Evaluation.View.Mutual
{
    /// <summary>
    /// ActivityManage 的摘要说明
    /// </summary>
    public class ActivityManage : IHttpHandler, IReadOnlySessionState
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
                    case "GetActivityList":
                        GetActivityList(context, conn);
                        break;
                    case "GetSpecialtyTable":
                        GetSpecialtyTable(context, conn);
                        break;
                    case "GetNoticeList":
                        GetNoticeList(context, conn);
                        break;
                    case "GetAllNoticeList":
                        GetAllNoticeList(context, conn);
                        break;
                    case "SetPrize":
                        SetPrize(context, conn);
                        break;
                    case "GetPrizeList":
                        GetPrizeList(context, conn);
                        break;
                    case "GetRevotePrizeList":
                        GetRevotePrizeList(context, conn);
                        break;
                    case "GetPrizeListBySpeciatly":
                        GetPrizeListBySpeciatly(context, conn);
                        break;
                    case "DelPrize":
                        DelPrize(context, conn);
                        break;
                    case "DelSpecialty":
                        DelSpecialty(context, conn);
                        break;
                    case "IsExistChildSpecialty":
                        IsExistChildSpecialty(context, conn);
                        break;
                    case "DelNotice":
                        DelNotice(context, conn);
                        break;
                    case "GetDeclarationAuditing":
                        GetDeclarationAuditing(context, conn);
                        break;
                    case "MultiselectDelPrize":
                        MultiselectDelPrize(context, conn);
                        break;
                    case "MultiselectDelSpecialtyList":
                        MultiselectDelSpecialtyList(context, conn);
                        break;
                    case "MultiselectDelNoticeList":
                        MultiselectDelNoticeList(context, conn);
                        break;
                    case "GetAtlasByAtlasID":
                        GetAtlasByAtlasID(context, conn);
                        break;
                    case "GetAppendixByAppendixID":
                        GetAppendixByAppendixID(context, conn);
                        break;
                    case "GetAtlasList":
                        GetAtlasList(context, conn);
                        break;
                    case "CreateAtlas":
                        CreateAtlas(context, conn);
                        break;
                    case "DelAtlas":
                        DelAtlas(context, conn);
                        break;
                    case "UpdateAtlas":
                        UpdateAtlas(context, conn);
                        break;
                    case "SearchPrize":
                        SearchPrize(context, conn);
                        break;
                    case "SpecialtySetCount":
                        SpecialtySetCount(context, conn);
                        break;
                    case "SpecialtyTemplete":
                        SpecialtyTemplete(context, conn);
                        break;
                    case "GetSpecialtyCode":
                        GetSpecialtyCode(context, conn);
                        break;
                    case "GetAppendixList":
                        GetAppendixList(context, conn);
                        break;
                    case "GetMediaList":
                        GetMediaList(context, conn);
                        break;
                    case "CreateAppendix":
                        CreateAppendix(context, conn);
                        break;
                    case "DelAppendix":
                        DelAppendix(context, conn);
                        break;
                    case "UpdateAppendix":
                        UpdateAppendix(context, conn);
                        break;
                    case "BindPrizeCodeAndTemplateCode":
                        BindPrizeCodeAndTemplateCode(context, conn);
                        break;
                    case "GetChildSpecialtyList":
                        GetChildSpecialtyList(context, conn);
                        break;
                    case "GetScheduleData":
                        GetScheduleData(context, conn);
                        break;
                    case "GetVoteList":
                        GetVoteList(context, conn);
                        break;
                    case "GetExpertVoteList":
                        GetExpertVoteList(context, conn);
                        break;
                    case "GetExpertVoteDetail":
                        GetExpertVoteDetail(context, conn);
                        break;
                    case "GetReviewList":
                        GetReviewList(context, conn);
                        break;
                    case "BatchDelSpecialty":
                        BatchDelSpecialty(context, conn);
                        break;
                    case "ImportNoticeAppendix":
                        ImportNoticeAppendix(context, conn);
                        break;
                    case "GetNoticeAppendix":
                        GetNoticeAppendix(context, conn);
                        break;
                    case "LoadNoticeFile":
                        LoadNoticeFile(context, conn);
                        break;
                    case "DeleteNoticeAppendix":
                        DeleteNoticeAppendix(context, conn);
                        break;
                    case "GetMediaByMediaID":
                        GetMediaByMediaID(context, conn);
                        break;
                    case "DelMedia":
                        DelMedia(context, conn);
                        break;
                    case "CreateMedia":
                        CreateMedia(context, conn);
                        break;
                    case "GetVoteDetail":
                        GetVoteDetail(context, conn);
                        break;
                    case "GetReVoteList":
                        GetReVoteList(context,conn);
                        break;
                    case "SetSingleRevote":
                        SetSingleRevote(context,conn);
                        break;
                    case "GetMagReVoteList":
                        GetMagReVoteList(context, conn);
                        break;
                    case"GetAllVoteList":
                        GetAllVoteList(context, conn);
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

        /// <summary>
        /// 专业列表
        /// </summary>
        /// <param name="context"></param>
        public void GetSpecialtyTable(HttpContext context, OleDbConnection conn)
        {
            string specialtys = context.Request["Specialtys"];
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write(JsonConvert.SerializeObject("当前没有激活的活动！"));
                return;
            }
            List<Dal.Models.Specialty> lstSpecialty = null;
            if (user.UserType == "0804")
            {
                lstSpecialty = BLL.Specialty.GetUserSpecialtyList(activity.ActivityID.Value, user.UserID.Value, false, conn, specialtys);
            }
            else
            {
                lstSpecialty = BLL.Specialty.GetSpecialtyList(activity.ActivityID.Value, false, specialtys, conn);
            }
            
            Dal.Models.PageInfo<Dal.Models.Specialty> pgInfo = BLL.Common.Pagger<Dal.Models.Specialty>(context, lstSpecialty);
            DataTable dtSpecialty = pgInfo.Table;

            context.Response.Write(JsonConvert.SerializeObject(pgInfo));
        }

        public void GetChildSpecialtyList(HttpContext context, OleDbConnection conn)
        {
            string SpecialtyID = context.Request["SpecialtyID"];
            if (!string.IsNullOrEmpty(SpecialtyID))
            {
                List<Dal.Models.Specialty> lstSpecialty = BLL.Specialty.GetDirectlyChildList(Convert.ToInt32(SpecialtyID), conn);
                context.Response.Write(JsonConvert.SerializeObject(lstSpecialty));
            }
        }

 

        /// <summary>
        /// 通知列表Gqx
        /// </summary>
        /// <param name="context"></param>
        public void GetNoticeList(HttpContext context, OleDbConnection conn)
        {
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                activity = new Dal.Models.Activity();
                activity.ActivityID = 0;
            }
            List<Dal.Models.Notice> lstNotice = BLL.Notice.GetNoticeList(Convert.ToInt32(activity.ActivityID), conn);

            Dal.Models.PageInfo<Dal.Models.Notice> pgInfo = BLL.Common.Pagger<Dal.Models.Notice>(context, lstNotice);

            context.Response.Write(JsonConvert.SerializeObject(pgInfo));
        }

        /// <summary>
        /// 通知列表Gqx，包含未有效的通知
        /// </summary>
        /// <param name="context"></param>
        public void GetAllNoticeList(HttpContext context, OleDbConnection conn)
        {
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write(JsonConvert.SerializeObject("当前没有激活的活动！"));
                return;
            }
            List<Dal.Models.Notice> lstNotice = BLL.Notice.GetNoticeList(Convert.ToInt32(activity.ActivityID), conn);

            Dal.Models.PageInfo<Dal.Models.Notice> pgInfo = BLL.Common.Pagger<Dal.Models.Notice>(context, lstNotice);

            context.Response.Write(JsonConvert.SerializeObject(pgInfo));
        }

        public void SetPrize(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.Prize prize = new Dal.Models.Prize();
            prize.SpecialtyID = Convert.ToInt32(context.Request["SpecialtyID"]);
            int iPrizeID = 0;
            if (int.TryParse(context.Request["PrizeID"], out iPrizeID))
            {
                prize.PrizeID = iPrizeID;
            }

            int iOrdinal = 0;
            if (int.TryParse(context.Request["Ordinal"] ?? int.MaxValue.ToString(), out iOrdinal))
            {
                prize.Ordinal = iOrdinal;
            }

            int iSpecialtyID = 0;
            if (int.TryParse(context.Request["SpecialtyID"], out iSpecialtyID))
            {
                prize.SpecialtyID = iSpecialtyID;
            }

            prize.PrizeName = context.Request["PrizeName"];
            prize.VoteType = context.Request["VoteType"];
            if (string.IsNullOrEmpty(prize.VoteType))
            {
                prize.VoteType = "2201";
            }

            prize.IsMultipleVoting = prize.VoteType != "2201";

            int iParticipantLimit = 0;
            prize.PrizeTypeCode = context.Request["PrizeTypeCode"];
            prize.TemplateCode = context.Request["TemplateCode"];
            if (int.TryParse(context.Request["ParticipantLimit"], out iParticipantLimit))
            {
                prize.ParticipantLimit = iParticipantLimit;
            }

            List<int> LstPrizeLimitNum = new List<int>();

            if (string.IsNullOrEmpty(context.Request["PrizeLimitNum"]))
            {
                //为空时，是多个值
                LstPrizeLimitNum.Add(string.IsNullOrEmpty(context.Request["FirstPrizeLimitNum"]) ? 0 : Convert.ToInt32(context.Request["FirstPrizeLimitNum"]));
                LstPrizeLimitNum.Add(string.IsNullOrEmpty(context.Request["SecondPrizeLimitNum"]) ? 0 : Convert.ToInt32(context.Request["SecondPrizeLimitNum"]));
                LstPrizeLimitNum.Add(string.IsNullOrEmpty(context.Request["ThirdPrizeLimitNum"]) ? 0 : Convert.ToInt32(context.Request["ThirdPrizeLimitNum"]));
            }
            else
            {
                LstPrizeLimitNum.Add(string.IsNullOrEmpty(context.Request["PrizeLimitNum"]) ? 0 : Convert.ToInt32(context.Request["PrizeLimitNum"]));
            }

            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                BLL.Prize.SetPrize(prize, LstPrizeLimitNum, conn, tran);
                tran.Commit();
                if (iPrizeID == 0)
                {
                    context.Response.Write("添加成功！");
                }
                else
                {
                    context.Response.Write("修改成功！");
                }
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }


        public void GetPrizeList(HttpContext context, OleDbConnection conn)
        {
            string SpecialtyIDs = context.Request["Specialtys"];
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            string strActivityType = context.Session["ActivityType"].ToString();
            List<Dal.Models.Prize> lstPrize = BLL.Prize.GetPrizeList(user, strActivityType, SpecialtyIDs, conn);
            Dal.Models.PageInfo<Dal.Models.Prize> pgif = BLL.Common.Pagger<Dal.Models.Prize>(context, lstPrize);
            DataTable dtPrize = pgif.Table;

            context.Response.Write(JsonConvert.SerializeObject(pgif));
        }

        public void GetRevotePrizeList(HttpContext context, OleDbConnection conn)
        {
            string SpecialtyIDs = context.Request["Specialtys"];
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            string strActivityType = context.Session["ActivityType"].ToString();
            BLL.Revote bllRevote = new BLL.Revote();
            List<Dal.Models.RevotePrize> lstPrize = bllRevote.GetRevotePrizeList(user, strActivityType, SpecialtyIDs, conn);
            Dal.Models.PageInfo<Dal.Models.RevotePrize> pgif = BLL.Common.Pagger<Dal.Models.RevotePrize>(context, lstPrize);
            DataTable dtPrize = pgif.Table;

            context.Response.Write(JsonConvert.SerializeObject(pgif));
        }
        public void GetPrizeListBySpeciatly(HttpContext context, OleDbConnection conn)
        {
            int iSpeciatlyID = 0;
            Int32.TryParse(context.Request["SpeciatlyID"], out iSpeciatlyID);
            if (iSpeciatlyID > 0)
            {
                List<Dal.Models.Prize> lstPrize = BLL.Prize.GetPrizeList(iSpeciatlyID, conn);
                context.Response.Write(JsonConvert.SerializeObject(lstPrize));
            }
        }

        /// <summary>
        /// 删除奖项，需要参数，PrizeID
        /// </summary>
        /// <param name="context"></param>
        public void DelPrize(HttpContext context, OleDbConnection conn)
        {
            try
            {
                int iPrizeID = 0;
                int.TryParse(context.Request["PrizeID"] ?? "", out iPrizeID);
                int iSpecialtyId = Convert.ToInt32(context.Request["DelSpecialtyID"]);
                OleDbTransaction trans = conn.BeginTransaction();
                try
                {
                    BLL.Prize.DeletePrize(iSpecialtyId,iPrizeID, conn, trans);
                    context.Response.Write("success");
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    context.Response.Write(ex.Message);
                }
            }
            catch (Exception ex)
            {
                context.Response.Write(ex.Message);
            }

        }

        /// <summary>
        /// 多选删除奖项
        /// </summary>
        /// <param name="context"></param>
        public void MultiselectDelPrize(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction trans = conn.BeginTransaction();
            int iSpecialtyId = context.Request["DelSpecialtyID"] == null ? 0 : Convert.ToInt32(context.Request["DelSpecialtyID"]);
            string strPrizeID = context.Request["PrizeID"];
            string[] arrayPrizeID = strPrizeID.Split(',');

            List<int> listPrizeID = new List<int>();
            foreach (var item in arrayPrizeID)
            {
                listPrizeID.Add(Convert.ToInt32(item));
            }

            try
            {
                for (int i = 0; i < listPrizeID.Count(); i++)
                {
                    int iPrizeID = Convert.ToInt32(listPrizeID[i]);
                    if (iSpecialtyId == 0)
                    {
                        Dal.Models.Prize mPrize = BLL.Prize.GetPrize(iPrizeID, conn, trans);
                        iSpecialtyId = mPrize.SpecialtyID.Value;
                    }

                    BLL.Prize.DeletePrize(iSpecialtyId,iPrizeID, conn, trans);
                }
                trans.Commit();
                context.Response.Write("删除成功!");
            }
            catch (Exception ex)
            {
                trans.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        /// <summary>
        /// 删除专业，需要参数，SpecialtyID
        /// </summary>
        /// <param name="context"></param>
        public void DelSpecialty(HttpContext context, OleDbConnection conn)
        {
            try
            {
                string id = context.Request["SpecialtyID"];
                int iSpecialtyId = Convert.ToInt32(context.Request["DelSpecialtyID"]);
                OleDbTransaction trans = conn.BeginTransaction();
                try
                {
                    int iSpecialtyID = 0;
                    int.TryParse(id, out iSpecialtyID);
                    BLL.Specialty.DeleteSpecialty(iSpecialtyID, conn, trans);
                    trans.Commit();
                    context.Response.Write("success");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    context.Response.Write(ex.Message);
                }
            }
            catch (Exception ex)
            {
                context.Response.Write(ex.Message);
            }
        }

        /// <summary>
        /// 批量删除专业，需要参数，SpecialtyID
        /// </summary>
        /// <param name="context"></param>
        public void BatchDelSpecialty(HttpContext context, OleDbConnection conn)
        {
            string ids = context.Request["SpecialtyIDs"];
            OleDbTransaction trans = conn.BeginTransaction();
            if (!string.IsNullOrEmpty(ids))
            {
                try
                {
                    string[] SpecialtyIDs = ids.Split(',');
                    foreach (string iSpecialtyID in SpecialtyIDs)
                    {
                        BLL.Specialty.DeleteSpecialty(Convert.ToInt32(iSpecialtyID), conn, trans);
                    }
                    context.Response.Write("删除成功！");
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    context.Response.Write(ex.Message);
                }
            }
        }

        public void IsExistChildSpecialty(HttpContext context, OleDbConnection conn)
        {
            int childNum = 0;//0代表没有子专业，1代表有子专业
            string id = context.Request["SpecialtyID"];
            int iSpecialtyID = 0;
            int.TryParse(id, out iSpecialtyID);
            List<Dal.Models.Specialty> list = BLL.Specialty.GetChildList(iSpecialtyID, conn);
            if (list.Count > 0)
            {
                childNum = 1;
            }
            context.Response.Write(childNum);
        }

        public void GetDeclarationAuditing(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write(JsonConvert.SerializeObject("当前没有激活的活动！"));
                return;
            }
            List<Dal.Models.Declaration> lstDeclaration = BLL.Declaration.GetDeclarationList(user, Convert.ToInt32(activity.ActivityID), conn);
            Dal.Models.PageInfo<Dal.Models.Declaration> pgif = BLL.Common.Pagger<Dal.Models.Declaration>(context, lstDeclaration);
            System.Data.DataTable dtDeclaration = pgif.Table;

            string strJson = JsonConvert.SerializeObject(pgif);
            context.Response.Write(strJson);
        }

        /// <summary>
        /// 获取活动列表
        /// </summary>
        /// <param name="context"></param>
        public void GetActivityList(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            string strActivityType = context.Session["ActivityType"].ToString();

            List<Dal.Models.Activity> lstActivity = BLL.Activity.GetActivityList(strActivityType, conn);
            Dal.Models.PageInfo<Dal.Models.Activity> pgif = BLL.Common.Pagger<Dal.Models.Activity>(context, lstActivity);
            DataTable dtActivity = pgif.Table;

            foreach (DataRow row in dtActivity.Rows)
            {
                row["CreateTime"] = Convert.ToDateTime(row["CreateTime"].ToString()).ToString("yyyy-MM-dd");
            }

            context.Response.Write(JsonConvert.SerializeObject(pgif));
        }

        /// <summary>
        /// 删除多选专业管理
        /// </summary>
        /// <param name="context"></param>
        /// <remarks>Gqx</remarks>
        public void MultiselectDelSpecialtyList(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction trans = conn.BeginTransaction();
            int iParentSpecialtyId = Convert.ToInt32(context.Request["DelSpecialtyID"]);
            string strSpecialtyID = context.Request["SpecialtyID"];
            string[] arraySpecialtyID = strSpecialtyID.Split(',');

            List<int> listSpecialtyID = new List<int>();
            foreach (var item in arraySpecialtyID)
            {
                listSpecialtyID.Add(Convert.ToInt32(item));
            }

            try
            {
                for (int i = 0; i < listSpecialtyID.Count(); i++)
                {
                    int iSpecialtyID = Convert.ToInt32(listSpecialtyID[i]);
                    BLL.Specialty.DeleteSpecialty(iSpecialtyID, conn, trans);
                }
                trans.Commit();
                context.Response.Write("删除成功!");
            }
            catch (Exception ex)
            {
                trans.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        /// <summary>
        /// 删除公告列表
        /// </summary>
        /// <param name="context"></param>
        /// <remarks>Gqx</remarks>
        public void MultiselectDelNoticeList(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction trans = conn.BeginTransaction();

            string strNoticeID = context.Request["NoticeID"];
            string[] arrayNoticeID = strNoticeID.Split(',');

            List<int> listNoticeID = new List<int>();
            foreach (var item in arrayNoticeID)
            {
                listNoticeID.Add(Convert.ToInt32(item));
            }

            try
            {
                for (int i = 0; i < listNoticeID.Count(); i++)
                {
                    int iNoticeID = Convert.ToInt32(listNoticeID[i]);
                    BLL.Notice.DelNotice(iNoticeID, conn, trans);
                }
                trans.Commit();
                context.Response.Write("删除成功!");
            }
            catch (Exception ex)
            {
                trans.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        /// <summary>
        /// 删除公告，需要参数，NoticeID
        /// </summary>
        /// <param name="context"></param>
        public void DelNotice(HttpContext context, OleDbConnection conn)
        {
            try
            {
                string id = context.Request["NoticeID"];
                OleDbTransaction trans = conn.BeginTransaction();
                try
                {
                    int iNoticeID = 0;
                    int.TryParse(id, out  iNoticeID);
                    BLL.Notice.DelNotice(iNoticeID, conn, trans);
                    trans.Commit();
                    context.Response.Write("success");
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    context.Response.Write(ex.Message);
                }
            }
            catch (Exception ex)
            {
                context.Response.Write(ex.Message);
            }
        }

        public void GetAppendixList(HttpContext context, OleDbConnection conn)
        {
            string strSpecialtyID = context.Request["SpecialtyID"];
            List<Dal.Models.Appendix> lstAppendix = null;
            int sid = 0;
            if (int.TryParse(strSpecialtyID, out sid))
            {
                lstAppendix = BLL.Appendix.GetAppendixList(sid, Dal.Models.AppendixType.Specialty, conn);
            }
            else
            {
                lstAppendix = new List<Dal.Models.Appendix>();
            }

            context.Response.Write(JsonConvert.SerializeObject(lstAppendix));
        }

        public void GetMediaList(HttpContext context, OleDbConnection conn)
        {
            string strSpecialtyID = context.Request["SpecialtyID"];
            List<Dal.Models.Media> lstMedia = null;
            int sid = 0;
            if (int.TryParse(strSpecialtyID, out sid))
            {
                lstMedia = BLL.Media.GetMediaList(sid, Dal.Models.MediaType.Specialty, conn);
            }
            else
            {
                lstMedia = new List<Dal.Models.Media>();
            }

            context.Response.Write(JsonConvert.SerializeObject(lstMedia));
        }

        public void GetAtlasList(HttpContext context, OleDbConnection conn)
        {
            string strSpecialtyID = context.Request["SpecialtyID"];
            int sid = 0;
            List<Dal.Models.Atlas> lstAtlas = null;
            if (int.TryParse(strSpecialtyID, out sid))
            {
                lstAtlas = BLL.Atlas.GetAtlasList(sid, Dal.Models.AtlasType.Specialty, conn);
            }
            else
            {
                lstAtlas = new List<Dal.Models.Atlas>();
            }

            context.Response.Write(JsonConvert.SerializeObject(lstAtlas));
        }

        public void GetAtlasByAtlasID(HttpContext context, OleDbConnection conn)
        {
            string id = context.Request["upAtlasID"];
            Dal.Models.Atlas atlas = BLL.Atlas.GetAtlas(Convert.ToInt32(id), conn);
            context.Response.Write(JsonConvert.SerializeObject(atlas));
        }

        public void GetAppendixByAppendixID(HttpContext context, OleDbConnection conn)
        {
            string id = context.Request["upAppendixID"];
            Dal.Models.Appendix atlas = BLL.Appendix.GetAppendix(Convert.ToInt32(id), conn);
            context.Response.Write(JsonConvert.SerializeObject(atlas));
        }

        public void GetMediaByMediaID(HttpContext context, OleDbConnection conn)
        {
            string id = context.Request["upMediaID"];
            Dal.Models.Media media = BLL.Media.GetMedia(Convert.ToInt32(id), conn);
            context.Response.Write(JsonConvert.SerializeObject(media));
        }

        public void CreateAppendix(HttpContext context, OleDbConnection conn)
        {
            string ss = context.Request["AppendixID"];
            int intAppendixID = context.Request["AppendixID"] == "" ? 0 : Convert.ToInt32(context.Request["AppendixID"]);
            OleDbTransaction tran = conn.BeginTransaction();
            Dal.Models.Appendix appendix = new Dal.Models.Appendix();
            appendix.AppendixName = context.Request["AppendixName"];
            appendix.SpecialtyID = Convert.ToInt32(context.Request["SpecialtyID"]);
            appendix.UploadLimitMax = Convert.ToInt32(context.Request["UploadLimitMax"]);
            appendix.UploadLimitMin = Convert.ToInt32(context.Request["UploadLimitMin"]);
            appendix.SizeLimit = Convert.ToInt32(context.Request["SizeLimit"]);
            appendix.Ordinal = Convert.ToInt32(context.Request["AppendixOrdinal"]);
            appendix.IsRequired = context.Request["IsRequired"] == "True";
            appendix.AppendixID = intAppendixID;
            try
            {
                BLL.Appendix.SetAppendix(appendix, conn, tran);
                tran.Commit();
                context.Response.Write("保存成功!");
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }

        }

        public void CreateMedia(HttpContext context, OleDbConnection conn)
        {
            string ss = context.Request["MediaID"];
            int intMediaID = context.Request["MediaID"] == "" ? 0 : Convert.ToInt32(context.Request["MediaID"]);
            OleDbTransaction tran = conn.BeginTransaction();
            Dal.Models.Media media = new Dal.Models.Media();
            media.MediaName = context.Request["MediaName"];
            media.SpecialtyID = Convert.ToInt32(context.Request["SpecialtyID"]);
            media.SizeLimit = Convert.ToInt32(context.Request["SizeLimit"]);
            media.Ordinal = Convert.ToInt32(context.Request["MediaOrdinal"]);
            media.IsRequired = context.Request["IsRequired"] == "True";

            media.MediaID = intMediaID;
            try
            {
                BLL.Media.SetMedia(media, conn, tran);
                tran.Commit();
                context.Response.Write("保存成功!");
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }

        }

        public void CreateAtlas(HttpContext context, OleDbConnection conn)
        {
            int intAtlasID = context.Request["txtAtlasID"] == "" ? 0 : Convert.ToInt32(context.Request["txtAtlasID"]);
            OleDbTransaction tran = conn.BeginTransaction();
            Dal.Models.Atlas atlas = new Dal.Models.Atlas();
            atlas.AtlasName = context.Request["txtAtlasName"];
            atlas.SpecialtyID = Convert.ToInt32(context.Request["txtSpecialtyID"]);
            atlas.UploadLimitMax = Convert.ToInt32(context.Request["txtUploadLimitMax"]);
            atlas.UploadLimitMin = Convert.ToInt32(context.Request["txtUploadLimitMin"]);
            atlas.SizeLimit = Convert.ToInt32(context.Request["txtSizeLimit"]);
            atlas.Ordinal = Convert.ToInt32(context.Request["txtAtlasOrdinal"]);
            atlas.IsRequired = context.Request["IsRequired"] == "True";

            if (intAtlasID > 0)
            {
                atlas.AtlasID = intAtlasID;
            }

            try
            {
                BLL.Atlas.SetAtlas(atlas, conn, tran);
                tran.Commit();
                context.Response.Write("保存成功!");
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        public void UpdateAppendix(HttpContext context, OleDbConnection conn)
        {
            string id = context.Request["AppendixID"];

            Dal.Models.Appendix appendix = BLL.Appendix.GetAppendix(Convert.ToInt32(id), conn);
            appendix.Ordinal = Convert.ToInt32(context.Request["Ordinal"]);
            appendix.AppendixName = context.Request["AppendixName"];
            appendix.UploadLimitMax = Convert.ToInt32(context.Request["UploadLimitMax"]);
            appendix.UploadLimitMin = Convert.ToInt32(context.Request["UploadLimitMin"]);
            appendix.SizeLimit = Convert.ToInt32(context.Request["SizeLimit"]);
            appendix.IsRequired = context.Request["IsRequired"] == "True";

            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                BLL.Appendix.SetAppendix(appendix, conn, tran);
                tran.Commit();
                context.Response.Write("修改成功!");
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }
        public void UpdateAtlas(HttpContext context, OleDbConnection conn)
        {
            string id = context.Request["AtlasID"];

            Dal.Models.Atlas atlas = BLL.Atlas.GetAtlas(Convert.ToInt32(id), conn);
            atlas.Ordinal = Convert.ToInt32(context.Request["Ordinal"]);
            atlas.AtlasName = context.Request["AtlasName"];
            atlas.UploadLimitMax = Convert.ToInt32(context.Request["UploadLimitMax"]);
            atlas.UploadLimitMin = Convert.ToInt32(context.Request["UploadLimitMin"]);
            atlas.SizeLimit = Convert.ToInt32(context.Request["SizeLimit"]);

            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                BLL.Atlas.SetAtlas(atlas, conn, tran);
                tran.Commit();
                context.Response.Write("修改成功!");
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }
        public void DelAppendix(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction tran = conn.BeginTransaction();
            int iAppendixId = Convert.ToInt32(context.Request["AppendixID"]);
            int iSpecialtyId = Convert.ToInt32(context.Request["DelSpecialtyID"]);
            try
            {
                bool bIsExsitData = BLL.UploadFileInfo.IsExsitData("DeclarationAppendix", iAppendixId, conn, tran);
                if (bIsExsitData)
                {
                    tran.Rollback();
                    context.Response.Write("不可以删除已经上传了文件的附件！");
                    return;
                }
                else
                {
                    BLL.Appendix.DeleteAppendix(iSpecialtyId,iAppendixId, conn, tran);
                    tran.Commit();
                    context.Response.Write("删除成功！");
                }
            }

            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        public void DelMedia(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction tran = conn.BeginTransaction();
            int iMediaId = Convert.ToInt32(context.Request["MediaID"]);
            int iSpecialtyId = Convert.ToInt32(context.Request["DelSpecialtyID"]);
            try
            {
                bool bIsExsitData = BLL.UploadFileInfo.IsExsitData("DeclarationMedia", iMediaId, conn, tran);
                if (bIsExsitData)
                {
                    context.Response.Write("不可以删除已经上传了文件的视频！");
                    return;
                }
                else
                {
                    BLL.Media.DeleteMedia(iSpecialtyId, iMediaId, conn, tran);
                    tran.Commit();
                    context.Response.Write("删除成功！");
                }
            }

            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        public void DelAtlas(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction tran = conn.BeginTransaction();
            int iAtlasId = Convert.ToInt32(context.Request["AtlasID"]);
            int iSpecialtyId = Convert.ToInt32(context.Request["DelSpecialtyID"]);
            try
            {
                bool bIsExsitData = BLL.UploadFileInfo.IsExsitData("DeclarationAtlas", iAtlasId, conn, tran);
                if (bIsExsitData)
                {
                    context.Response.Write("不可以删除已经上传了文件的图集！");
                    return;
                }
                else
                {
                    BLL.Atlas.DeleteAtlas(iSpecialtyId,iAtlasId, conn, tran);
                    tran.Commit();
                    context.Response.Write("删除成功！");
                }
            }

            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }
        public void SearchPrize(HttpContext context, OleDbConnection conn)
        {
            string strSpecialtyID = context.Request["SpecialtyIDList"];
            string[] SpecialtyIDList = strSpecialtyID.Split(',');
            List<Dal.Models.Prize> allPrizeList = new List<Dal.Models.Prize>();
            for (int i = 0; i < SpecialtyIDList.Length; i++)
            {
                if (SpecialtyIDList[i] != "")
                {
                    List<Dal.Models.Prize> PrizeList = BLL.Prize.GetPrizeList(Convert.ToInt32(SpecialtyIDList[i]), conn);
                    for (int j = 0; j < PrizeList.Count(); j++)
                    {
                        allPrizeList.Add(PrizeList[j]);
                    }
                }
            }
            context.Response.Write(JsonConvert.SerializeObject(allPrizeList));
        }

        /// <summary>
        /// 新建专业时默认给出排序序号
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        public void SpecialtySetCount(HttpContext context, OleDbConnection conn)
        {
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write(JsonConvert.SerializeObject("当前没有激活的活动！"));
                return;
            }
            string CountNum;
            if (context.Request["ParentId"] == "0")
            {
                CountNum = (BLL.Specialty.Count(activity.ActivityID.Value, null, conn, null) + 1).ToString();
            }
            else
            {
                int iParentId = Convert.ToInt32(context.Request["ParentId"]);
                CountNum = (BLL.Specialty.Count(activity.ActivityID.Value, iParentId, conn, null) + 1).ToString();
            }
            context.Response.Write(CountNum);
        }

        /// <summary>
        /// 当继选择承模版时,选择父专业自动更改为父专业模版
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        public void SpecialtyTemplete(HttpContext context, OleDbConnection conn)
        {
            string id = context.Request["SpecialtyID"];
            Dal.Models.Specialty spe = BLL.Specialty.GetSpecialty(Convert.ToInt32(id), conn);
            string speTem = spe.TemplateCode;
            context.Response.Write(speTem);
        }

        /// <summary>
        /// 给专业编码输出一个默认值
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        public void GetSpecialtyCode(HttpContext context, OleDbConnection conn)
        {
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write(JsonConvert.SerializeObject("当前没有激活的活动！"));
                return;
            }
            int? ParentId = null;
            if (context.Request["ParentId"] != "0")
            {
                ParentId = Convert.ToInt32(context.Request["ParentId"]);
            }
            string SpecialtyCode = BLL.Specialty.GetSpecialtyCode(activity.ActivityID.Value, ParentId, conn);
            context.Response.Write(SpecialtyCode);
        }

        /// <summary>
        /// 创建奖项，选择专业时给 奖项编码，奖项模版，排序，给一个默认值
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        public void BindPrizeCodeAndTemplateCode(HttpContext context, OleDbConnection conn)
        {
            string strSpecialtyID = context.Request["SpecialtyID"];
            int iSpecialtyID = 0;
            if (!string.IsNullOrEmpty(strSpecialtyID))
            {
                iSpecialtyID = Convert.ToInt32(strSpecialtyID);
                string strPrizeCode = BLL.Prize.GetPrizeCode(iSpecialtyID, conn);
                string strTemplateCode = BLL.Specialty.GetSpecialty(iSpecialtyID, conn).TemplateCode;
                string CountNum = (BLL.Prize.Count(iSpecialtyID, conn, null) + 1).ToString();
                object[] strResult = { strPrizeCode, strTemplateCode, CountNum };

                context.Response.Write(JsonConvert.SerializeObject(strResult));
            }
            else
            {
                object[] strResult = { "", "", "" };

                context.Response.Write(JsonConvert.SerializeObject(strResult));
            }

        }

        public void GetScheduleData(HttpContext context, OleDbConnection conn)
        {
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write(JsonConvert.SerializeObject("当前没有激活的活动！"));
                return;
            }
            Dal.Models.Schedule schedule = BLL.Schedule.GetActivitySchedule(activity.ActivityID.Value, conn);
            context.Response.Write(JsonConvert.SerializeObject(schedule));
        }

        //获取投票结果
        public void GetVoteList(HttpContext context, OleDbConnection conn)
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

            int ActivityID = Convert.ToInt32(activity.ActivityID);
            string DeclarationName = context.Request["DeclarationName"];
            string OrganizationName = context.Request["DeclarationUnit"];
            string PrizeID = context.Request["PrizeID"];
            string PrizeType = context.Request["PrizeType"];

            List<Dal.Models.Vote> lstVote = BLL.Vote.GetVoteList(DeclarationName, OrganizationName, PrizeID, PrizeType, ActivityID,conn, trans);

            int iPageSize = 50;
            if (!Int32.TryParse(context.Request["PageSize"] ?? "50", out iPageSize))
            {
                iPageSize = 50;
            }

            int iCuttentPage = 1;
            if (!Int32.TryParse(context.Request["CuttentPage"] ?? "0", out iCuttentPage))
            {
                iCuttentPage = 1;
            }

            int iRecordNumber = lstVote.Count;
            int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPageSize));
            lstVote = lstVote.Skip(iPageSize * (iCuttentPage - 1)).Take(iPageSize).ToList();
            System.Data.DataTable dtExpertVote = Dal.DataTableExtensions.ToDataTable(lstVote);

            Dal.Models.PageInfo<Dal.Models.Declaration> pgif = new Dal.Models.PageInfo<Dal.Models.Declaration>();
            pgif.CuttentPage = iCuttentPage;
            pgif.PerPage = iPageSize;
            pgif.RecordNumber = iRecordNumber;
            pgif.PagesCount = iPagesCount;
            pgif.Table = dtExpertVote;

            context.Response.Write(JsonConvert.SerializeObject(pgif));
            conn.Close();
        }

        /// <summary>
        /// 获取投票详情
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        public void GetExpertVoteDetail(HttpContext context, OleDbConnection conn)
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

            int ActivityID = Convert.ToInt32(activity.ActivityID);
            string DeclarationName = context.Request["DeclarationName"];
            string OrganizationName = context.Request["DeclarationUnit"];
            int PrizeID = Convert.ToInt32(context.Request["PrizeID"]);
            string PrizeType = context.Request["PrizeType"];

            List<Dal.Models.Vote> lstVote = BLL.Vote.GetExpertVoteStatus(ActivityID, PrizeID, conn, trans);

            int iPageSize = 50;
            if (!Int32.TryParse(context.Request["PageSize"] ?? "50", out iPageSize))
            {
                iPageSize = 50;
            }

            int iCuttentPage = 1;
            if (!Int32.TryParse(context.Request["CuttentPage"] ?? "0", out iCuttentPage))
            {
                iCuttentPage = 1;
            }

            int iRecordNumber = lstVote.Count;
            int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPageSize));
            lstVote = lstVote.Skip(iPageSize * (iCuttentPage - 1)).Take(iPageSize).ToList();
            System.Data.DataTable dtExpertVote = Dal.DataTableExtensions.ToDataTable(lstVote);

            Dal.Models.PageInfo<Dal.Models.Declaration> pgif = new Dal.Models.PageInfo<Dal.Models.Declaration>();
            pgif.CuttentPage = iCuttentPage;
            pgif.PerPage = iPageSize;
            pgif.RecordNumber = iRecordNumber;
            pgif.PagesCount = iPagesCount;
            pgif.Table = dtExpertVote;

            context.Response.Write(JsonConvert.SerializeObject(pgif));
            conn.Close();
        }

        //获取投票和复投的总结果
        public void GetAllVoteList(HttpContext context, OleDbConnection conn)
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

            int ActivityID = Convert.ToInt32(activity.ActivityID);
            string DeclarationName = context.Request["DeclarationName"];
            string OrganizationName = context.Request["DeclarationUnit"];
            string PrizeID = context.Request["PrizeID"];
            string PrizeType = context.Request["PrizeType"];

            List<Dal.Models.Vote> lstVote = BLL.Vote.GetAllVoteList(DeclarationName, OrganizationName, PrizeID, PrizeType, ActivityID, conn, trans);

            int iPageSize = 50;
            if (!Int32.TryParse(context.Request["PageSize"] ?? "50", out iPageSize))
            {
                iPageSize = 50;
            }

            int iCuttentPage = 1;
            if (!Int32.TryParse(context.Request["CuttentPage"] ?? "0", out iCuttentPage))
            {
                iCuttentPage = 1;
            }

            int iRecordNumber = lstVote.Count;
            int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPageSize));
            lstVote = lstVote.Skip(iPageSize * (iCuttentPage - 1)).Take(iPageSize).ToList();
            System.Data.DataTable dtExpertVote = Dal.DataTableExtensions.ToDataTable(lstVote);

            Dal.Models.PageInfo<Dal.Models.Declaration> pgif = new Dal.Models.PageInfo<Dal.Models.Declaration>();
            pgif.CuttentPage = iCuttentPage;
            pgif.PerPage = iPageSize;
            pgif.RecordNumber = iRecordNumber;
            pgif.PagesCount = iPagesCount;
            pgif.Table = dtExpertVote;

            context.Response.Write(JsonConvert.SerializeObject(pgif));
            conn.Close();
        }

        public void GetMagReVoteList(HttpContext context, OleDbConnection conn)
        {
            //OleDbTransaction trans = conn.BeginTransaction();
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write(JsonConvert.SerializeObject("当前没有激活的活动！"));
                return;
            }

            int ActivityID = Convert.ToInt32(activity.ActivityID);
            string DeclarationName = context.Request["DeclarationName"];
            string OrganizationName = context.Request["DeclarationUnit"];
            string PrizeID = context.Request["PrizeID"];
            string PrizeType = context.Request["PrizeType"];

            List<Dal.Models.Vote> lstVote = BLL.Vote.GetReVoteList(DeclarationName, OrganizationName, PrizeID, PrizeType, ActivityID, conn);

            //复投的奖项级别（例：一二三等奖）
            string reVotePrizeLevelCode = "";
            Dal.Models.Prize prize = BLL.Prize.GetPrize(Convert.ToInt32(PrizeID),conn);

            List<Dal.Models.Vote> lstVoteFirstPrize = lstVote.GetRange(0, prize.FirstPrize.Value).ToList();
            List<Dal.Models.Vote> lstVoteOutFirstPrize = lstVote.GetRange(prize.FirstPrize.Value, lstVote.Count - prize.FirstPrize.Value).ToList();
            int iMaxOrdinal = lstVoteFirstPrize.Max(v => v.Ordinal).Value;
            if (lstVoteOutFirstPrize.Where(v => v.Ordinal == iMaxOrdinal).Count() > 0)
            {
                // 一等奖等票复投
                reVotePrizeLevelCode = "0401";
            }
            else
            {
                List<Dal.Models.Vote> lstVoteSecPrize = lstVote.GetRange(prize.FirstPrize.Value, prize.SecondPrize.Value).ToList();
                List<Dal.Models.Vote> lstVoteOutSecPrize = lstVote.GetRange(
                    prize.FirstPrize.Value + prize.SecondPrize.Value,
                    lstVote.Count - prize.SecondPrize.Value - prize.FirstPrize.Value).ToList();
                iMaxOrdinal = lstVoteSecPrize.Max(v => v.Ordinal).Value;
                if (lstVoteOutSecPrize.Where(v => v.Ordinal == iMaxOrdinal).Count() > 0)
                {
                    // 二等奖等票复投
                    reVotePrizeLevelCode = "0402";
                }
                else
                {
                    List<Dal.Models.Vote> lstVoteThdPrize = lstVote.GetRange(prize.FirstPrize.Value + prize.SecondPrize.Value, prize.ThirdPrize.Value).ToList();
                    List<Dal.Models.Vote> lstVoteOutThdPrize = lstVote.GetRange(
                        prize.FirstPrize.Value + prize.SecondPrize.Value + prize.ThirdPrize.Value,
                        lstVote.Count - prize.SecondPrize.Value - prize.FirstPrize.Value - prize.ThirdPrize.Value).ToList();
                    iMaxOrdinal = lstVoteThdPrize.Max(v => v.Ordinal).Value;
                    if (lstVoteOutThdPrize.Where(v => v.Ordinal == iMaxOrdinal).Count() > 0)
                    {
                        // 三等奖等票复投
                        reVotePrizeLevelCode = "0403";
                    }
                }
            }
            int iPageSize = 50;
            if (!Int32.TryParse(context.Request["PageSize"] ?? "50", out iPageSize))
            {
                iPageSize = 50;
            }

            int iCuttentPage = 1;
            if (!Int32.TryParse(context.Request["CuttentPage"] ?? "0", out iCuttentPage))
            {
                iCuttentPage = 1;
            }

            int iRecordNumber = lstVote.Count;
            int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPageSize));
            lstVote = lstVote.Skip(iPageSize * (iCuttentPage - 1)).Take(iPageSize).ToList();
            System.Data.DataTable dtExpertVote = Dal.DataTableExtensions.ToDataTable(lstVote);

            Dal.Models.PageInfo<Dal.Models.Declaration> pgif = new Dal.Models.PageInfo<Dal.Models.Declaration>();
            pgif.CuttentPage = iCuttentPage;
            pgif.PerPage = iPageSize;
            pgif.RecordNumber = iRecordNumber;
            pgif.PagesCount = iPagesCount;
            pgif.Table = dtExpertVote;

            context.Response.Write(JsonConvert.SerializeObject(new object[] { pgif, reVotePrizeLevelCode}));
            conn.Close();
        }

        public void GetReVoteList(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write(JsonConvert.SerializeObject("当前没有激活的活动！"));
                return;
            }

            int ActivityID = Convert.ToInt32(activity.ActivityID);
            int PrizeID = context.Request["PrizeID"] == "" ? 0 : Convert.ToInt32(context.Request["PrizeID"]);

            List<Dal.Models.Declaration> lstVote = BLL.Vote.GetReVoteList(PrizeID, conn);
            Dal.Models.ReVoteBatch reVoteBatch = BLL.Vote.GetReVoteBatch(PrizeID, conn);

            int iPageSize = 50;
            if (!Int32.TryParse(context.Request["PageSize"] ?? "50", out iPageSize))
            {
                iPageSize = 50;
            }

            int iCuttentPage = 1;
            if (!Int32.TryParse(context.Request["CuttentPage"] ?? "0", out iCuttentPage))
            {
                iCuttentPage = 1;
            }

            int iRecordNumber = lstVote.Count;
            int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPageSize));
            lstVote = lstVote.Skip(iPageSize * (iCuttentPage - 1)).Take(iPageSize).ToList();
            System.Data.DataTable dtExpertVote = Dal.DataTableExtensions.ToDataTable(lstVote);

            Dal.Models.PageInfo<Dal.Models.Declaration> pgif = new Dal.Models.PageInfo<Dal.Models.Declaration>();
            pgif.CuttentPage = iCuttentPage;
            pgif.PerPage = iPageSize;
            pgif.RecordNumber = iRecordNumber;
            pgif.PagesCount = iPagesCount;
            pgif.Table = dtExpertVote;

            context.Response.Write(JsonConvert.SerializeObject(new object[]{pgif, reVoteBatch}));
            conn.Close();
        }
        public void GetExpertVoteList(HttpContext context, OleDbConnection conn)
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
            int ActivityID = Convert.ToInt32(activity.ActivityID);
            List<Dal.Models.Vote> lstExpertVote = BLL.Vote.GetExpertVoteList(conn,ActivityID, trans);

            int iPageSize = 50;
            if (!Int32.TryParse(context.Request["PageSize"] ?? "50", out iPageSize))
            {
                iPageSize = 50;
            }

            int iCuttentPage = 1;
            if (!Int32.TryParse(context.Request["CuttentPage"] ?? "0", out iCuttentPage))
            {
                iCuttentPage = 1;
            }

            int iRecordNumber = lstExpertVote.Count;
            int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPageSize));
            lstExpertVote = lstExpertVote.Skip(iPageSize * (iCuttentPage - 1)).Take(iPageSize).ToList();
            System.Data.DataTable dtExpertVote = Dal.DataTableExtensions.ToDataTable(lstExpertVote);

            Dal.Models.PageInfo<Dal.Models.Declaration> pgif = new Dal.Models.PageInfo<Dal.Models.Declaration>();
            pgif.CuttentPage = iCuttentPage;
            pgif.PerPage = iPageSize;
            pgif.RecordNumber = iRecordNumber;
            pgif.PagesCount = iPagesCount;
            pgif.Table = dtExpertVote;

            context.Response.Write(JsonConvert.SerializeObject(pgif));
            conn.Close();
        }

        public void GetReviewList(HttpContext context, OleDbConnection conn)
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

            string strDeclarationName = context.Request["DeclarationName"];
            string strOrganizationName = context.Request["DeclarationUnit"];
            string strPrizeIDs = context.Request["PrizeID"];
            string strExpertName = context.Request["ExpertName"];
            string strAwardCodes = context.Request["AwardCode"];

            List<Dal.Models.Declaration> lstDeclaration = BLL.Declaration.GetReviewList(user, activity.ActivityID.Value
                , strDeclarationName, strOrganizationName, strPrizeIDs, strExpertName, strAwardCodes, conn, trans);

            int iPageSize = 50;
            if (!Int32.TryParse(context.Request["PageSize"] ?? "50", out iPageSize))
            {
                iPageSize = 50;
            }

            int iCuttentPage = 1;
            if (!Int32.TryParse(context.Request["CuttentPage"] ?? "0", out iCuttentPage))
            {
                iCuttentPage = 1;
            }

            int iRecordNumber = lstDeclaration.Count;
            int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPageSize));
            lstDeclaration = lstDeclaration.Skip(iPageSize * (iCuttentPage - 1)).Take(iPageSize).ToList();

            Dal.Models.PageInfo<Dal.Models.Declaration> pgif = new Dal.Models.PageInfo<Dal.Models.Declaration>();
            pgif.CuttentPage = iCuttentPage;
            pgif.PerPage = iPageSize;
            pgif.RecordNumber = iRecordNumber;
            pgif.PagesCount = iPagesCount;
            pgif.List = lstDeclaration;

            context.Response.Write(JsonConvert.SerializeObject(pgif));
            conn.Close();
        }

        public void ImportNoticeAppendix(HttpContext context, OleDbConnection conn)
        {
            if (context.Request.Files.Count > 0)
            {
                string strNoticeID = context.Request["NoticeID"];
                string fileName = "";
                HttpFileCollection files = context.Request.Files;
                OleDbTransaction trans = conn.BeginTransaction();
                try
                {
                    for (int i = 0; i < files.Count; i++)
                    {
                        string strRootDirectory = System.Web.HttpContext.Current.Request.PhysicalApplicationPath;
                        string strFilePath = strRootDirectory + "Content\\Temp\\Notice\\" + strNoticeID + "\\";
                        if (!Directory.Exists(strFilePath))
                        {
                            Directory.CreateDirectory(strFilePath);
                        }
                        Dal.Models.UploadFileInfo dUploadFileInfo = BLL.UploadFileInfo.GetUploadFile(
                            Convert.ToInt32(strNoticeID), null, "NoticeAppendix", conn, trans);
                        Dal.Models.Notice NoticeInfo = BLL.Notice.GetNotice(Convert.ToInt32(strNoticeID), conn, trans);
                        string strNoticeTitle = NoticeInfo.Title;

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

                        // 存入文件夹
                        HttpPostedFile file = files[i];
                        fileName = context.Server.MapPath("~\\Content\\Temp\\Notice\\"
                            + strNoticeID + "\\" + strNoticeTitle.Replace(" ", "_") + Path.GetExtension(file.FileName));
                        file.SaveAs(fileName);

                        // 存入数据库
                        Dal.Models.UploadFileInfo dataFile = new Dal.Models.UploadFileInfo();
                        dataFile.Type = FileType.NoticeAppendix;
                        dataFile.OwnerID = Convert.ToInt32(strNoticeID);
                        dataFile.FileName = strNoticeTitle.Replace(" ", "_") + Path.GetExtension(file.FileName);
                        dataFile.URL = "Content\\Temp\\Notice\\" + strNoticeID + "\\"
                            + strNoticeTitle.Replace(" ", "_") + Path.GetExtension(file.FileName);
                        BLL.UploadFileInfo.SaveFile(dataFile, conn, trans);
                    }
                    trans.Commit();
                    context.Response.Write(JsonConvert.SerializeObject("上传成功"));
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    context.Response.Write(JsonConvert.SerializeObject(ex.Message));
                    //context.Response.Write(ex.Message);
                }
            }
        }
        public void GetNoticeAppendix(HttpContext context, OleDbConnection conn)
        {
            string strNoticeID = context.Request["NoticeID"];
            Dal.Models.UploadFileInfo dUploadFileInfo = BLL.UploadFileInfo.GetUploadFile(Convert.ToInt32(strNoticeID), null, "NoticeAppendix", conn);
            if (dUploadFileInfo != null)
            {
                StringBuilder sbNoticeHTML = new StringBuilder();
                sbNoticeHTML.Append(dUploadFileInfo.FileName);
                sbNoticeHTML.AppendFormat("<a class='DeleteNoticeAppendix' onclick='DeleteNoticeAppendix({0});return false;' title='删除' href=''>"
                    , strNoticeID);
                sbNoticeHTML.Append("<i class='fa fa-trash-o'></i>");
                sbNoticeHTML.Append("</a>");
                sbNoticeHTML.AppendFormat("　　　<a class='DownloadNoticeAppendix' onclick=\"DownloadAppendix({0});return false;\" title='下载' href=''>"
                    , strNoticeID);
                sbNoticeHTML.Append("<i class='fa fa-download'></i></a>");

                context.Response.Write(JsonConvert.SerializeObject(sbNoticeHTML.ToString()));
            }
        }

        public void LoadNoticeFile(HttpContext context, OleDbConnection conn)
        {
            string strNoticeID = context.Request["NoticeID"];
            Dal.Models.UploadFileInfo dUploadFileInfo = BLL.UploadFileInfo.GetUploadFile(Convert.ToInt32(strNoticeID), null, "NoticeAppendix", conn);
            if (dUploadFileInfo != null)
            {
                Dal.Models.UploadFileInfo file = new Dal.Models.UploadFileInfo();
                file.UploadFileID = dUploadFileInfo.UploadFileID;
                string strRootDirectory = System.Web.HttpContext.Current.Request.PhysicalApplicationPath;
                string strFilePath = strRootDirectory + dUploadFileInfo.URL;
                if (File.Exists(strFilePath))
                {
                    context.Response.Write(JsonConvert.SerializeObject(file));
                }
                else
                {
                    BLL.UploadFileInfo.LoadFile(file, conn);
                    context.Response.Write(JsonConvert.SerializeObject(file));
                }                               
            }
        }
        public void DeleteNoticeAppendix(HttpContext context, OleDbConnection conn)
        {
            OleDbTransaction trans = conn.BeginTransaction();
            int iNoticeID = Convert.ToInt32(context.Request["NoticeID"]);
            Dal.Models.UploadFileInfo dUploadFileInfo = BLL.UploadFileInfo.GetUploadFile(iNoticeID, null, "NoticeAppendix", conn,trans);
            if (dUploadFileInfo != null)
            {
                try
                {
                    Dal.Models.Notice NoticeInfo = BLL.Notice.GetNotice(Convert.ToInt32(iNoticeID), conn, trans);
                    string strRootDirectory = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + "Content\\";
                    string strRootDirectory2 = System.Web.HttpContext.Current.Request.PhysicalApplicationPath;
                    string strNoticeTitle = NoticeInfo.Title;
                    if (dUploadFileInfo != null)
                    {
                        int Index = dUploadFileInfo.URL.IndexOf("Content");
                        string Pathe = dUploadFileInfo.URL.Substring(Index).Replace("\\", "/");
                        string MapPath = strRootDirectory2 + Pathe;
                        if (File.Exists(MapPath))
                        {
                            File.Delete(MapPath);
                        }
                    }
                    BLL.UploadFileInfo.DeleteUploadFile(dUploadFileInfo.UploadFileID.Value, conn, trans);

                    context.Response.Write(JsonConvert.SerializeObject("删除成功"));
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
        /// 获取投票详情
        /// </summary>
        /// <param name="context"></param>
        public void GetVoteDetail(HttpContext context, OleDbConnection conn)
        {
            string strActivityType = context.Session["ActivityType"].ToString();
            int intDeclarationID = Convert.ToInt32(context.Request["DeclarationID"]);
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write(JsonConvert.SerializeObject("当前没有激活的活动！"));
                return;
            }
            List<Dal.Models.Vote> lstVoteDetail = BLL.Vote.GetVoteDetail(intDeclarationID,conn);
            context.Response.Write(JsonConvert.SerializeObject(lstVoteDetail));
        }


        public void SetSingleRevote(HttpContext context, OleDbConnection conn)
        {

            int prizeId = Convert.ToInt32(context.Request["PrizeID"]);
            string reVoteList = context.Request["DeclarationIDs"];
            string reVotePrizeLevelCode = context.Request["ReVotePrizeLevelCode"];
            string[] declaration = reVoteList.Split(',');
            List<string> temp = reVoteList.Split(',').ToList();

            string strActivityType = context.Session["ActivityType"].ToString();
            Dal.Models.Activity activity = BLL.Activity.GetActivity(strActivityType, conn);
            if (activity == null)
            {
                context.Response.Write(JsonConvert.SerializeObject("当前没有激活的活动！"));
                return;
            }
            int ActivityID = Convert.ToInt32(activity.ActivityID);
            string prizeLevel = reVotePrizeLevelCode;
            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                Dal.Models.ReVoteBatch reVoteBatch = new ReVoteBatch();
                reVoteBatch.PrizeID = prizeId;
                reVoteBatch.PrizeLevelCode = prizeLevel;
                int intReVoteBatch = BLL.Vote.SetReVote(reVoteBatch, conn, tran);
                if (intReVoteBatch > 0)
                {
                    for (int i = 0; i < declaration.Count(); i++)
                    {
                        Dal.Models.ReVoteDeclaration reVoteDeclaration = new ReVoteDeclaration();
                        reVoteDeclaration.ReVoteBatchID = intReVoteBatch;
                        reVoteDeclaration.DeclarationID = Convert.ToInt32(declaration[i]);
                        BLL.Vote.SetReVoteDeclaration(reVoteDeclaration, conn, tran);
                    }
                }
                context.Response.Write("等票复投已开启！");
                tran.Commit();
                conn.Close();
            }
            catch (Exception ex)
            {
                context.Response.Write(JsonConvert.SerializeObject(ex.Message));
                tran.Rollback();
            }
        }
    }
}