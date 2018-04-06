using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Web;
using System.Web.SessionState;
using System.Linq;
using Newtonsoft.Json;
using System.Web.Script.Serialization;
using System.IO;
using Dal.Models;
using BLL;

namespace Evaluation.View.Mutual
{
    /// <summary>
    /// ExpertElect 的摘要说明
    /// </summary>
    public class ExpertElect : IHttpHandler, IRequiresSessionState
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
                    case "GetExpertVotePrizeList":
                        GetExpertVotePrizeList(context, conn);
                        break;
                    case "GetExpertRevotePrizeList":
                        GetExpertRevotePrizeList(context, conn);
                        break;
                    case "GetExpertVoteList":
                        GetExpertVoteList(context, conn);
                        break;
                    case "GetRevoteGroupViews":
                        GetRevoteGroupViews(context, conn);
                        break;
                    case "GetVoteResult":
                        GetVoteResult(context, conn);
                        break;
                    case "SetVoteResult":
                        SetVoteResult(context, conn);
                        break;
                    case "StopPrizeVote":
                        StopPrizeVote(context, conn);
                        break;
                    case "StartMultipleVote":
                        StartMultipleVote(context, conn);
                        break;
                    case "GetPrizeMultipleVoteRound":
                        GetPrizeMultipleVoteRound(context, conn);
                        break;
                    case "SetAwardCount":
                        SetAwardCount(context, conn);
                        break;
                    case "Revote":
                        this.Revote(context,conn);
                        break;
                    case "RevoteMore":
                        this.RevoteMore(context, conn);
                        break;
                    //case "FinishVote":
                    //    FinishVote(context, conn);
                    //    break;
                    case "SubmitVote":
                        SubmitVote(context, conn);
                        break;
                    case "Ballot":
                        Ballot(context, conn);
                        break;
                    case "BatchBallot":
                        BatchBallot(context, conn);
                        break;
                    case "BatchRevotingVote":
                        BatchRevotingVote(context, conn);
                        break;
                    case "RevotingVote":
                        RevotingVote(context, conn);
                        break;
                    case "SubmitRevotingVote":
                        SubmitRevotingVote(context, conn);
                        break;
                    case "GetAwardResult":
                        GetAwardResult(context, conn);
                        break;
                    case "GetRevoteResult":
                        GetRevoteResult(context, conn);
                        break;
                    case "GetPrizeResultLevel":
                        GetPrizeResultLevel(context, conn);
                        break;
                    //case "SetAwardResult":
                    //    SetAwardResult(context, conn);
                    //    break;
                    case "SubmitRevoteResult":
                        SubmitRevoteResult(context, conn);
                        break;
                    case "GetAwardCode":
                        GetAwardCode(context, conn);
                        break;
                    case "SetAwardCode":
                        SetAwardCode(context, conn);
                        break;
                    case "SetInnerOrdinal":
                        SetInnerOrdinal(context, conn);
                        break;
                    case "ResetAwardResult":
                        ResetAwardResult(context, conn);
                        break;
                    case "ResetVoteResult":
                        ResetVoteResult(context, conn);
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

        public void GetExpertVotePrizeList(HttpContext context, OleDbConnection conn)
        {
            string specialtys = context.Request["Specialtys"];
            string prizeType = context.Request["PrizeType"];
            string prizeName = context.Request["PrizeName"];

            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            Dal.Models.Activity activity = BLL.Activity.GetActivity(context.Session["ActivityType"].ToString(), conn);
            if (activity == null)
            {
                context.Response.Write("活动未开始！");
            }

            List<Dal.Models.Prize> lstPrize = null;
            if (user.UserType == "0801" || user.UserType == "0802" || user.UserType == "0803")
            {
                lstPrize = BLL.Prize.GetPrizeList(specialtys, prizeType, prizeName, conn);
            }
            else if (user.UserType == "0805")
            {
                // 专家所评审的项目对应的奖项
                lstPrize = BLL.Prize.GetExpertVotePrize(user.UserID.Value, activity.ActivityID.Value, conn);
            }

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

            int iRecordNumber = lstPrize.Count;
            int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPageSize));
            lstPrize = lstPrize.Skip(iPageSize * (iCuttentPage - 1)).Take(iPageSize).ToList();

            Dal.Models.PageInfo<Dal.Models.Declaration> pgif = new Dal.Models.PageInfo<Dal.Models.Declaration>();
            pgif.CuttentPage = iCuttentPage;
            pgif.PerPage = iPageSize;
            pgif.RecordNumber = iRecordNumber;
            pgif.PagesCount = iPagesCount;
            pgif.Table = Dal.DataTableExtensions.ToDataTable(lstPrize);

            string strJson = JsonConvert.SerializeObject(pgif);
            context.Response.Write(strJson);
            conn.Close();
        }

        public void GetExpertRevotePrizeList(HttpContext context, OleDbConnection conn)
        {
            string specialtys = context.Request["Specialtys"];
            string prizeType = context.Request["PrizeType"];
            string prizeName = context.Request["PrizeName"];

            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            Dal.Models.Activity activity = BLL.Activity.GetActivity(context.Session["ActivityType"].ToString(), conn);
            if (activity == null)
            {
                context.Response.Write("活动未开始！");
            }

            List<Dal.Models.RevotePrize> lstPrize = null;
            if (user.UserType == "0801" || user.UserType == "0802" || user.UserType == "0803")
            {
                //lstPrize = BLL.Prize.GetPrizeList(specialtys, prizeType, prizeName, conn);
            }
            else if (user.UserType == "0805")
            {
                // 专家所评审的项目对应的奖项
                BLL.Revote bllRevote = new BLL.Revote();
                lstPrize = bllRevote.GetExpertRevotePrize(user.UserID.Value, activity.ActivityID.Value, conn);
            }

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

            int iRecordNumber = lstPrize.Count;
            int iPagesCount = Convert.ToInt32(Math.Ceiling((float)iRecordNumber / (float)iPageSize));
            lstPrize = lstPrize.Skip(iPageSize * (iCuttentPage - 1)).Take(iPageSize).ToList();

            Dal.Models.PageInfo<Dal.Models.Declaration> pgif = new Dal.Models.PageInfo<Dal.Models.Declaration>();
            pgif.CuttentPage = iCuttentPage;
            pgif.PerPage = iPageSize;
            pgif.RecordNumber = iRecordNumber;
            pgif.PagesCount = iPagesCount;
            pgif.Table = Dal.DataTableExtensions.ToDataTable(lstPrize);

            string strJson = JsonConvert.SerializeObject(pgif);
            context.Response.Write(strJson);
            conn.Close();
        }


        private void GetLimit(Dal.Models.Prize prize, List<Dal.Models.Vote> lstVote
            , ref Dictionary<string, int> dicVote, ref  Dictionary<string, int> dicRemain)
        {
            if (dicVote == null)
            {
                dicVote = new Dictionary<string, int>();
            }
            else
            {
                dicVote.Clear();
            }

            if (dicRemain == null)
            {
                dicRemain = new Dictionary<string, int>();
            }
            else
            {
                dicRemain.Clear();
            }

            if ((prize.MultipleVoteRound ?? 1) == 1 || (prize.VoteType == "2202" && prize.MultipleVoteRound == 2))
            {
                dicVote.Add("FirstPrize", prize.FirstPrize == null ? 0 : lstVote.Where(v => v.FirstPrize != null && v.FirstPrize.Value).Count());
                dicVote.Add("SecondPrize", prize.SecondPrize == null ? 0 : lstVote.Where(v => v.SecondPrize != null && v.SecondPrize.Value).Count());
                dicVote.Add("ThirdPrize", prize.ThirdPrize == null ? 0 : lstVote.Where(v => v.ThirdPrize != null && v.ThirdPrize.Value).Count());
                dicVote.Add("Recommended", lstVote.Where(v => v.Recommended != null && v.Recommended.Value).Count());
                dicVote.Add("NotRecommended", lstVote.Where(v => v.NotRecommended != null && v.NotRecommended.Value).Count());
                dicVote.Add("SlowRating", lstVote.Where(v => v.SlowRating != null && v.SlowRating.Value).Count());
                dicVote.Add("TurnOut", lstVote.Where(v => v.TurnOut != null && v.TurnOut.Value).Count());
                dicVote.Add("Voted", lstVote.Where(v => v.VoteID != null).Count());

                dicRemain.Add("FirstPrize", prize.FirstPrize == null ? 0 : prize.FirstPrize.Value - dicVote["FirstPrize"]);
                dicRemain.Add("SecondPrize", prize.SecondPrize == null ? 0 : prize.SecondPrize.Value - dicVote["SecondPrize"]);
                dicRemain.Add("ThirdPrize", prize.ThirdPrize == null ? 0 : prize.ThirdPrize.Value - dicVote["ThirdPrize"]);
                dicRemain.Add("Recommended", prize.AwardCount == null ? 0 : prize.AwardCount.Value - dicVote["Recommended"]);
            }
            else if (prize.VoteType == "2203" && prize.MultipleVoteRound == 2)
            {
                dicVote.Add("FirstPrize", 0);
                dicVote.Add("SecondPrize", 0);
                dicVote.Add("ThirdPrize", 0);
                dicVote.Add("Recommended", lstVote.Where(v => v.Recommended != null && v.Recommended.Value).Count());
                dicVote.Add("NotRecommended", lstVote.Where(v => v.NotRecommended != null && v.NotRecommended.Value).Count());
                dicVote.Add("SlowRating", lstVote.Where(v => v.SlowRating != null && v.SlowRating.Value).Count());
                dicVote.Add("TurnOut", lstVote.Where(v => v.TurnOut != null && v.TurnOut.Value).Count());
                dicVote.Add("Voted", lstVote.Where(v => v.VoteID != null).Count());

                dicRemain.Add("FirstPrize", 0);
                dicRemain.Add("SecondPrize", 0);
                dicRemain.Add("ThirdPrize", 0);
                dicRemain.Add("Recommended", prize.FirstPrize.Value + prize.SecondPrize.Value - dicVote["Recommended"]);
            }
            else
            {
                dicVote.Add("FirstPrize", 0);
                dicVote.Add("SecondPrize", 0);
                dicVote.Add("ThirdPrize", 0);
                dicVote.Add("Recommended", lstVote.Where(v => (v.Recommended != null && v.Recommended.Value)).Count());
                dicVote.Add("NotRecommended", lstVote.Where(v => (v.NotRecommended != null && v.NotRecommended.Value)).Count());
                dicVote.Add("SlowRating", lstVote.Where(v => (v.SlowRating != null && v.SlowRating.Value)).Count());
                dicVote.Add("TurnOut", lstVote.Where(v => (v.TurnOut != null && v.TurnOut.Value)).Count());
                dicVote.Add("Voted", lstVote.Where(v => v.VoteID != null).Count());

                dicRemain.Add("FirstPrize", 0);
                dicRemain.Add("SecondPrize", 0);
                dicRemain.Add("ThirdPrize", 0);
                dicRemain.Add("Recommended", prize.FirstPrize.Value - dicVote["Recommended"]);
            }
        }

        public void GetExpertVoteList(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            Dal.Models.Expert expert = BLL.Expert.GetExpertByUserID(user.UserID.Value, conn);

            int iPrizeID = 0;
            if (!Int32.TryParse(context.Request["PrizeID"], out iPrizeID))
            {
                context.Response.Write("暂无奖项!");
                return;
            }

            Dal.Models.Prize prize = BLL.Prize.GetPrize(iPrizeID, conn);

            if (prize == null)
            {
                context.Response.Write("暂无奖项!");
                return;
            }

            Dal.Models.Schedule schedule = BLL.Schedule.GetSpecialtySchedule(prize.SpecialtyID.Value, conn);

            if (schedule.IsVoteStart == false)
            {
                context.Response.Write("投票未开始或已经结束!");
            }
            else
            {
                //根据专家和奖项获评奖项目
                List<Dal.Models.Vote> lstVote = BLL.Vote.GetVoteDeclarationList(expert, prize, conn);
                lstVote = lstVote.OrderBy(d => d.BigOrdinal).ToList();

                //获取每个奖项的已评奖数量
                Dictionary<string, int> dicVote = new Dictionary<string, int>();

                //获取每个奖项未评奖数量
                Dictionary<string, int> dicRemain = new Dictionary<string, int>();

                GetLimit(prize, lstVote, ref dicVote, ref dicRemain);

                object[] obj = { prize, lstVote, dicVote, dicRemain };
                context.Response.Write(JsonConvert.SerializeObject(obj));
            }
        }

        public void GetRevoteGroupViews(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            Dal.Models.Expert expert = BLL.Expert.GetExpertByUserID(user.UserID.Value, conn);

            int iPrizeID = 0;
            if (!Int32.TryParse(context.Request["PrizeID"], out iPrizeID))
            {
                context.Response.Write("暂无奖项!");
                return;
            }

            Dal.Models.Prize prize = BLL.Prize.GetPrize(iPrizeID, conn);

            if (prize == null)
            {
                context.Response.Write("暂无奖项!");
                return;
            }

            var groupViews = BuildRevoteGroupViews(prize, expert, conn);

            context.Response.Write(JsonConvert.SerializeObject(groupViews.ToArray()));
        }

        private List<dynamic> BuildRevoteGroupViews(Dal.Models.Prize prize, Dal.Models.Expert expert, OleDbConnection conn)
        {
            BLL.Revote revote = new Revote();

            List<RevoteGroup> groups = revote.GetRevoteGroups(prize, conn);
            List<dynamic> groupViews = new List<dynamic>();
            foreach (var revoteGroup in groups)
            {
                int revoteGroupId = revoteGroup.RevoteGroupId;
                List<RevotePrizeLevel> awards = revote.GetRevotePrizeLevelsByGroupId(revoteGroupId, conn);
                List<RevotingVoteView> votingViews = revote.GetRevotingVoteViews(revoteGroupId, expert.UserID.Value, conn);

                // 推荐票数 = 评选奖项总数-最低奖项数量
                // 举例,若评选2个一等奖,1个二等奖,则推荐票数为(2+1)-1=2
                // 若仅有一种奖项,则取该奖项的评选数量
                int recommended = awards.Count == 1
                    ? awards.Sum(a => a.LevelLimitNumber)
                    : awards.Sum(a => a.LevelLimitNumber) - awards.LastOrDefault().LevelLimitNumber;

                // 是否已提交, 当且仅当全部投票IsSubmit=true则视为该专家已经提交
                bool isSubmit = votingViews.TrueForAll(v => v.IsSubmit.HasValue && v.IsSubmit.Value);

                // 已投票
                int voted = votingViews.Count(v => v.RevoteRecommended.HasValue && v.RevoteRecommended.Value == 1);

                dynamic groupView = new
                {
                    RevoteGroupId = revoteGroupId,
                    VotingViews = votingViews.ToArray(),
                    Info = new
                    {
                        Awards = awards.Select(a => a.ToAwardView()).ToArray<AwardView>(),
                        Recommended = recommended,
                        Voted = voted,
                        IsSubmit = isSubmit
                    }
                };

                groupViews.Add(groupView);
            }

            return groupViews;
        } 

        public void SetAwardCount(HttpContext context, OleDbConnection conn)
        {
            int iPrizeID = 0;
            
            Int32.TryParse(context.Request["PrizeID"].ToString(), out iPrizeID);
            Dal.Models.Prize prize = BLL.Prize.GetPrize(iPrizeID, conn);

            OleDbTransaction tran = conn.BeginTransaction();

            try
            {
                int iAwardCount = 0;
                if (prize.PrizeTypeCode == "0302" || prize.PrizeTypeCode == "0303")
                {
                    if (int.TryParse(context.Request["AwardCount"], out iAwardCount))
                    {
                        BLL.Prize.SetPrizeLevel(
                            new Dal.Models.PrizeLevel()
                            {
                                LevelCode = prize.PrizeTypeCode == "0302" ? "0404" : "0405",
                                LevelLimitNumber = iAwardCount,
                                PrizeID = prize.PrizeID
                            }
                            , conn, tran);
                    }
                    else
                    {
                        throw new Exception("请正确输入获奖数量!");
                    }
                }
                else
                {
                    if (int.TryParse(context.Request["FirstPrize"], out iAwardCount))
                    {
                        prize.FirstPrize = iAwardCount;
                        BLL.Prize.SetPrizeLevel(
                            new Dal.Models.PrizeLevel()
                            {
                                LevelCode = "0401",
                                LevelLimitNumber = iAwardCount,
                                PrizeID = prize.PrizeID
                            }
                            , conn, tran);
                    }
                    else {
                        throw new Exception("请正确输入获奖数量!");
                    }

                    if (int.TryParse(context.Request["SecondPrize"], out iAwardCount))
                    {
                        BLL.Prize.SetPrizeLevel(
                            new Dal.Models.PrizeLevel()
                            {
                                LevelCode = "0402",
                                LevelLimitNumber = iAwardCount,
                                PrizeID = prize.PrizeID
                            }
                            , conn, tran);
                    }
                    else
                    {
                        throw new Exception("请正确输入获奖数量！");
                    }

                    if (int.TryParse(context.Request["ThirdPrize"], out iAwardCount))
                    {
                        BLL.Prize.SetPrizeLevel(
                            new Dal.Models.PrizeLevel()
                            {
                                LevelCode = "0403",
                                LevelLimitNumber = iAwardCount,
                                PrizeID = prize.PrizeID
                            }
                            , conn, tran);
                    }
                    else
                    {
                        throw new Exception("请正确输入获奖数量！");
                    }

                    tran.Commit();
                    context.Response.Write("获奖数量设定成功！");
                }                
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        public void StartMultipleVote(HttpContext context, OleDbConnection conn)
        {
            int iPrizeID = 0;
            Int32.TryParse(context.Request["PrizeID"].ToString(), out iPrizeID);
            Dal.Models.Prize prize = BLL.Prize.GetPrize(iPrizeID, conn);
            if (prize.IsMultipleVoting ?? false)
            {
                //获取当前投票轮次
                int iMultipleVoteRound = prize.MultipleVoteRound ?? 1;

                string strValue = context.Request["btnValue"].ToString();

                if (strValue == "开启下一轮")
                {
                    //获取当前轮是否有投票，如果有就可以开启下一轮投票，如果没有就不可以开启下一轮
                    //int currentVoteCount = BLL.Vote.GetCurrentVoteCount(prize.PrizeID.Value, iMultipleVoteRound, conn);
                    List<Dal.Models.VoteResult> lstVoteResult = BLL.Vote.GetSelectedResult(prize.PrizeID.Value, iMultipleVoteRound, conn);
                    if (lstVoteResult.Count > 0)
                    {
                        if (iMultipleVoteRound + 1 > 3)
                        {
                            context.Response.Write("当前已经是最后一轮，开启下一轮失败!");
                            return;
                        }
                        else
                        {
                            iMultipleVoteRound += 1;
                        }
                    }
                    else
                    {
                        context.Response.Write("当前轮还没有选定投票结果，不可以进行下轮投票");
                        return;
                    }
                }
                else if (strValue == "返回上一轮")
                {
                    //获取当前轮是否有投票，如果有就不可以返回上一轮投票，如果没有就可以返回上一轮投票
                    int currentVoteCount = BLL.Vote.GetCurrentVoteCount(prize.PrizeID.Value, iMultipleVoteRound, conn);
                    if (currentVoteCount > 0)
                    {
                        context.Response.Write("当前轮已经有投票记录，不可以再返回上一轮!");
                        return;
                    }
                    else
                    {
                        if (iMultipleVoteRound - 1 <= 0)
                        {
                            context.Response.Write("当前已经是第一轮，返回上一轮失败!");
                            return;
                        }
                        else
                        {
                            iMultipleVoteRound -= 1;
                        }
                    }
                }

                //修改
                BLL.Vote.UpdateMultipleVoteRound(iPrizeID, iMultipleVoteRound, conn);

                context.Response.Write(iMultipleVoteRound.ToString());
            }
        }

        public void GetPrizeMultipleVoteRound(HttpContext context, OleDbConnection conn)
        {
            int iPrizeID = 0;
            Int32.TryParse(context.Request["PrizeID"].ToString(), out iPrizeID);
            Dal.Models.Prize prize = BLL.Prize.GetPrize(iPrizeID, conn);
            if (iPrizeID != 0)
            {
                if (prize.IsMultipleVoting == true)
                {
                    ////当本活动投票轮次为空时，设置默认值为1
                    //if (prize.MultipleVoteRound.ToString() == "")
                    //{
                    //    BLL.Vote.UpdateMultipleVoteRound(iPrizeID, 1, conn);
                    //}
                    //int iMultipleVoteRound = BLL.Prize.GetPrize(iPrizeID, conn).MultipleVoteRound.Value;
                    context.Response.Write((prize.MultipleVoteRound ?? 1).ToString());
                }
            }
        }

        public void SubmitVote(HttpContext context, OleDbConnection conn)
        {
            int iPrizeID = 0;
            Int32.TryParse(context.Request["PrizeID"], out iPrizeID);
            Dal.Models.Prize prize = BLL.Prize.GetPrize(iPrizeID, conn);
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            Dal.Models.Expert expert = BLL.Expert.GetExpertByUserID(user.UserID.Value, conn);

            if (prize == null || prize.IsStopVote)
            {
                context.Response.Write("当前奖项及轮次已结束投票。");
                return;
            }

            OleDbTransaction tran = conn.BeginTransaction();

            try
            {
                //根据专家和奖项获评奖项目
                List<Dal.Models.Vote> lstVote = BLL.Vote.GetVoteDeclarationList(expert, prize, conn, tran);

                //获取每个奖项的已评奖数量
                Dictionary<string, int> dicVote = new Dictionary<string, int>();

                //获取每个奖项未评奖数量
                Dictionary<string, int> dicRemain = new Dictionary<string, int>();

                GetLimit(prize, lstVote, ref dicVote, ref dicRemain);

                if (dicVote["Voted"] < lstVote.Count)
                {
                    throw new Exception("尚未完成投票,提交失败!");
                }

                BLL.Vote.SubmitVote(expert, prize, conn, tran);

                tran.Commit();
                context.Response.Write("提交成功!");
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        public void SubmitRevotingVote(HttpContext context, OleDbConnection conn)
        {
            int iPrizeID = 0;
            Int32.TryParse(context.Request["PrizeID"], out iPrizeID);
            Dal.Models.Prize prize = BLL.Prize.GetPrize(iPrizeID, conn);
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            Dal.Models.Expert expert = BLL.Expert.GetExpertByUserID(user.UserID.Value, conn);

            if (prize == null || prize.IsStopVote)
            {
                context.Response.Write("当前奖项及轮次已结束投票。");
                return;
            }

            OleDbTransaction tran = conn.BeginTransaction();

            try
            {
                BLL.Revote revote=new Revote();

                RevotePrize last = revote.GetLastRevotePrize(prize, conn,tran);

                bool saved=revote.SubmitRevotingVote(expert.UserID.Value, last.RevotePrizeId, conn, tran);

                if (saved)
                {
                    tran.Commit();
                    context.Response.Write("提交成功!");
                }
                else
                {
                    tran.Commit();
                    context.Response.Write("提交错误!");
                }
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        //public void FinishVote(HttpContext context, OleDbConnection conn)
        //{
        //    Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];

        //    //Issubmit="1"，是投票结果的状态为提交，专家不能再更改投票结果,投票时，此字段默认值为0
        //    string strIsSubmit = "1";

        //    //获取当前活动类型编码
        //    string strActivityType = context.Session["ActivityType"].ToString();

        //    //获取当前活动ID
        //    int iActivityID = BLL.Activity.GetActivity(strActivityType, conn).ActivityID.Value;

        //    //获取当前活动时间节点
        //    Dal.Models.Schedule schedule = BLL.Schedule.GetActivitySchedule(iActivityID, conn);

        //    //获取所有本次活动的奖项

        //    List<Dal.Models.Prize> lstPrize = BLL.Prize.GetPrizeList(user, strActivityType, "", conn);

        //    //修改Schedule的投票阶段
        //    BLL.Vote.UpdateScheduleVoteFinish(schedule.ScheduleID.Value, false, conn);

        //    foreach (var item in lstPrize)
        //    {
        //        List<Dal.Models.Vote> lstVote = BLL.Vote.GetActivityPrizeVoteList(item.PrizeID.Value, conn);
        //        foreach (var Vote in lstVote)
        //        {
        //            //修改Vote为已经提交
        //            BLL.Vote.SubmitVote(Vote.VoteID.Value, strIsSubmit, conn);
        //        }
        //    }
        //    context.Response.Write("投票已提交");
        //}

        private void Ballot(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            Dal.Models.Expert expert = BLL.Expert.GetExpertByUserID(user.UserID.Value, conn);
            OleDbTransaction tran = conn.BeginTransaction();
            try
            {

                int iDeclarationID = 0;
                int iPrizeID = 0;
                int iMultipleVoteRound = 0;
                if (!int.TryParse(context.Request["DeclarationID"], out iDeclarationID) ||
                    !int.TryParse(context.Request["PrizeID"], out iPrizeID) ||
                    !int.TryParse(context.Request["MultipleVoteRound"], out iMultipleVoteRound))
                {
                    throw new Exception("参数错误！");
                }

                Dal.Models.Prize prize = BLL.Prize.GetPrize(iPrizeID, conn, tran);
                if (prize == null || prize.IsStopVote)
                {
                    throw new Exception("当前奖项及轮次已结束投票。");
                }


                string strVoteCode = context.Request["VoteCode"];
                string strLevelCode = context.Request["LevelCode"];
                if (strLevelCode == "0404")
                {
                    strLevelCode = "";
                }

                Dal.Models.Declaration decl = BLL.Declaration.GetDeclaration(iDeclarationID, conn, tran);
                if (decl.PrizeID != iPrizeID)
                {
                    throw new Exception("参数错误！");
                }

                prize = BLL.Prize.GetPrize(decl.AdjustedPrize.Value, conn, tran);
                if (prize.MultipleVoteRound != iMultipleVoteRound)
                {
                    throw new Exception("当前已进入新一轮投票，请重新进入本页面进行投票！");
                }

                Dal.Models.Vote vote = new Dal.Models.Vote()
                {
                    UserID = user.UserID.Value,
                    Votor = expert.ExpertID.Value,
                    DeclarationID = iDeclarationID,
                    ActivityID = decl.ActivityID.Value,
                    MultipleVoteRound = prize.MultipleVoteRound ?? 1,
                    RevoteCode = prize.RevoteCode ?? "",
                    RevoteRound = prize.RevoteRound ?? 0,
                    IsSubmit = false,
                    PrizeID = prize.PrizeID.Value,
                    VoteCode = strVoteCode,
                    PrizeLevelCode = strLevelCode,
                    VoteType = "0502"
                };

                BLL.Vote.Ballot(vote, conn, tran);

                //根据专家和奖项获评奖项目
                List<Dal.Models.Vote> lstVote = BLL.Vote.GetVoteDeclarationList(expert, prize, conn, tran);

                //获取每个奖项的已评奖数量
                Dictionary<string, int> dicVote = new Dictionary<string, int>();

                //获取每个奖项未评奖数量
                Dictionary<string, int> dicRemain = new Dictionary<string, int>();

                GetLimit(prize, lstVote, ref dicVote, ref dicRemain);

                string Message = "";
                //if (strVoteCode == "0601" && (dicRemain["Recommended"] == 0
                //    || (strLevelCode == "0401" && dicRemain["FirstPrize"] == 0)
                //    || (strLevelCode == "0402" && dicRemain["SecondPrize"] == 0)
                //    || (strLevelCode == "0403" && dicRemain["ThirdPrize"] == 0)))
                //{
                //    Message = "所投选项名额已满，请注意！";
                //}
                //else
                //{
                Message = "投票成功!";
                //}

                tran.Commit();

                object[] obj = { prize, lstVote, dicVote, dicRemain, Message };

                context.Response.Write(JsonConvert.SerializeObject(obj));
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(JsonConvert.SerializeObject(new object[] { ex.Message }));
            }
        }

        private void BatchBallot(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            Dal.Models.Expert expert = BLL.Expert.GetExpertByUserID(user.UserID.Value, conn);

            int iPrizeID = 0;
            int.TryParse(context.Request["PrizeID"], out iPrizeID);
            string strVoteCode = context.Request["VoteCode"];
            string strLevelCode = context.Request["LevelCode"];
            if (strLevelCode == "0404")
            {
                strLevelCode = "";
            }

            Dal.Models.Prize prize = BLL.Prize.GetPrize(iPrizeID, conn);

            if (prize == null || prize.IsStopVote)
            {
                context.Response.Write("当前奖项及轮次已结束投票。");
                return;
            }

            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                //根据专家和奖项获评奖项目
                List<Dal.Models.Vote> lstVote = BLL.Vote.GetVoteDeclarationList(expert, prize, conn, tran);

                //获取每个奖项的已评奖数量
                Dictionary<string, int> dicVote = new Dictionary<string, int>();

                //获取每个奖项未评奖数量
                Dictionary<string, int> dicRemain = new Dictionary<string, int>();

                GetLimit(prize, lstVote, ref dicVote, ref dicRemain);

                //if (strVoteCode == "0601" && (dicRemain["Recommended"] == 0
                //    || (strLevelCode == "0401" && dicRemain["FirstPrize"] == 0)
                //    || (strLevelCode == "0402" && dicRemain["SecondPrize"] == 0)
                //    || (strLevelCode == "0403" && dicRemain["ThirdPrize"] == 0)))
                //{
                //    throw new Exception("所投选项名额已满，请重新投票！");
                //}

                Dal.Models.Vote vote = new Dal.Models.Vote()
                {
                    UserID = user.UserID.Value,
                    Votor = expert.ExpertID.Value,
                    ActivityID = prize.ActivityID.Value,
                    MultipleVoteRound = prize.MultipleVoteRound ?? 1,
                    VoteRound = prize.MultipleVoteRound ?? 1,
                    IsSubmit = false,
                    PrizeID = prize.PrizeID.Value,
                    VoteCode = strVoteCode,
                    PrizeLevelCode = strLevelCode,
                    VoteType = "0502"
                };

                BLL.Vote.BatchBallot(vote, conn, tran);

                tran.Commit();
                context.Response.Write(JsonConvert.SerializeObject("投票成功!"));
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(JsonConvert.SerializeObject(ex.Message));
            }
        }

        private void BatchRevotingVote(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            Dal.Models.Expert expert = BLL.Expert.GetExpertByUserID(user.UserID.Value, conn);

            int prizeId = 0;
            int recommended, notRecommended;
            int.TryParse(context.Request["PrizeID"], out prizeId);
            int.TryParse(context.Request["Recommended"], out recommended);
            int.TryParse(context.Request["NotRecommended"], out notRecommended);

            Dal.Models.Prize prize = BLL.Prize.GetPrize(prizeId, conn);

            if (prize == null || prize.IsStopVote)
            {
                context.Response.Write("当前奖项及轮次已结束投票。");
                return;
            }
            BLL.Revote revote = new Revote();
            RevotePrize revotePrize = revote.GetLastRevotePrize(prize, conn);

            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                bool saved= revote.SaveBatchRevotingVotes(revotePrize.RevotePrizeId,expert.UserID.Value,recommended,notRecommended,conn,tran);

                tran.Commit();
                context.Response.Write(JsonConvert.SerializeObject("投票成功!"));
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(JsonConvert.SerializeObject(ex.Message));
            }
        }

        private void RevotingVote(HttpContext context, OleDbConnection conn)
        {
            Dal.Models.UserInfo user = (Dal.Models.UserInfo)context.Session["UserInfo"];
            Dal.Models.Expert expert = BLL.Expert.GetExpertByUserID(user.UserID.Value, conn);
            OleDbTransaction tran = conn.BeginTransaction();
            try
            {

                int declarationId = 0;
                int revoteGroupId = 0;
                int recommended = 0;
                int notRecommened = 0;
                int prizeId = 0;
                if (!int.TryParse(context.Request["DeclarationID"], out declarationId) ||
                    !int.TryParse(context.Request["RevoteGroupId"], out revoteGroupId) ||
                    !int.TryParse(context.Request["RevoteRecommended"], out recommended) ||
                    !int.TryParse(context.Request["NotRevoteRecommended"], out notRecommened) ||
                    !int.TryParse(context.Request["PrizeId"], out prizeId))
                {
                    throw new Exception("参数错误！");
                }

                Dal.Models.Prize prize = BLL.Prize.GetPrize(prizeId, conn, tran);
                if (prize == null || prize.IsStopVote)
                {
                    throw new Exception("当前奖项及轮次已结束投票。");
                }

                Revote revote=new Revote();
                bool saved= revote.SaveRevotingVote(revoteGroupId, declarationId, recommended, notRecommened, expert.UserID.Value,
                    conn,tran);

                if (saved)
                {
                    tran.Commit();

                    var revoteGroups = this.BuildRevoteGroupViews(prize, expert, conn);
                    string message = "投票成功!";

                    var result = new {Views = revoteGroups, Message = message};

                    context.Response.Write(JsonConvert.SerializeObject(result));
                }
                else
                {
                    tran.Rollback();
                    context.Response.Write(JsonConvert.SerializeObject(new { Message = "投票错误" }));
                }
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(JsonConvert.SerializeObject(new { Message= ex.Message }));
            }
        }

        private void GetVoteResult(HttpContext context, OleDbConnection conn)
        {
            int iPrizeID = 0;
            int.TryParse(context.Request["PrizeID"], out iPrizeID);

            Dal.Models.Prize prize = BLL.Prize.GetPrize(iPrizeID, conn);
            List<Dal.Models.VoteResult> lstVoteResult = BLL.Vote.GetVoteResult(iPrizeID, prize.MultipleVoteRound ?? 1, conn);
            List<Dal.Models.VoteResult> lstSelected = BLL.Vote.GetSelectedResult(iPrizeID, prize.MultipleVoteRound ?? 1, conn);
            
            object[] obj = { prize, lstVoteResult, lstSelected };

            context.Response.Write(JsonConvert.SerializeObject(obj));
        }

        public void GetAwardResult(HttpContext context, OleDbConnection conn)
        {
            int iPrizeID = 0;
            int.TryParse(context.Request["PrizeID"], out iPrizeID);
            Dal.Models.Prize prize = BLL.Prize.GetPrize(iPrizeID, conn);

            List<Dal.Models.AwardResult> listAwardResult = BLL.Vote.GetPrizeAwardResult(iPrizeID, conn);

            object[] obj = { prize, listAwardResult };

            context.Response.Write(JsonConvert.SerializeObject(obj));
        }

        public void GetRevoteResult(HttpContext context, OleDbConnection conn)
        {
            int iPrizeID = 0;
            int.TryParse(context.Request["PrizeID"], out iPrizeID);
            Dal.Models.Prize prize = BLL.Prize.GetPrize(iPrizeID, conn);

            BLL.Revote revote=new Revote();

            List<RevoteResultView> views = revote.GenerateRevoteResultViews(prize.PrizeID ?? 0, conn);
            bool isIndividual = prize.PrizeTypeCode == "0302" || prize.PrizeTypeCode == "0303";
            dynamic response = new
            {
                Views = views,
                Awards = isIndividual
                    ? (dynamic) new {Recommended = prize.AwardCount??0}
                    : (dynamic) new
                    {
                        FirstPrize = prize.FirstPrize ?? 0,
                        SecondPrize = prize.SecondPrize ?? 0,
                        ThirdPrize = prize.ThirdPrize ?? 0
                    },
                IsIndividual = isIndividual
            };

            context.Response.Write(JsonConvert.SerializeObject(response));

            // 获取复投结果表数据, RevoteResult
        }

        private void SetVoteResult(HttpContext context, OleDbConnection conn)
        {
            int iPrizeID = 0;
            int.TryParse(context.Request["PrizeID"], out iPrizeID);

            Dal.Models.Prize prize = BLL.Prize.GetPrize(iPrizeID, conn);

            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                BLL.Vote.SetVoteResult(prize, context.Request["DeclarationID"], conn, tran);
                prize.IsStopVote = false;
                BLL.Prize.StopPrizeVote(prize, conn, tran);
                tran.Commit();
                context.Response.Write(JsonConvert.SerializeObject("保存成功！"));
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(JsonConvert.SerializeObject(ex.Message));
            }
        }

        private void SetAwardCode(HttpContext context, OleDbConnection conn)
        {
            int iDeclarationID = 0;
            int.TryParse(context.Request["DeclarationID"], out iDeclarationID);
            string strAwardCode = context.Request["AwardCode"];

            OleDbTransaction tran = conn.BeginTransaction();

            try
            {
                BLL.Vote.SetAwardResult(iDeclarationID,strAwardCode, conn, tran);
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        private void SetInnerOrdinal(HttpContext context, OleDbConnection conn)
        {
            int iDeclarationID = 0;
            int.TryParse(context.Request["DeclarationID"], out iDeclarationID);
            int iInnerOrdinal = 0;
            int.TryParse(context.Request["InnerOrdinal"], out iInnerOrdinal);

            OleDbTransaction tran = conn.BeginTransaction();

            try
            {
                BLL.Vote.SetInnerOrdinal(iDeclarationID, iInnerOrdinal, conn, tran);
                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        //private void SetAwardResult(HttpContext context, OleDbConnection conn)
        //{
        //    int iPrizeID = 0;
        //    int.TryParse(context.Request["PrizeID"], out iPrizeID);
        //    OleDbTransaction tran = conn.BeginTransaction();

        //    try
        //    {
        //        BLL.Vote.SetAwardResult(iPrizeID, conn, tran);
        //        tran.Commit();
        //        context.Response.Write("提交成功！");
        //    }
        //    catch (Exception ex)
        //    {
        //        tran.Rollback();
        //        context.Response.Write(ex.Message);
        //    }
        //}

        private void ResetAwardResult(HttpContext context, OleDbConnection conn)
        {
            int iPrizeID = 0;
            int.TryParse(context.Request["PrizeID"], out iPrizeID);
            OleDbTransaction tran = conn.BeginTransaction();

            try
            {
                BLL.Vote.DeleteAwardResult(iPrizeID, conn, tran);
                tran.Commit();
                context.Response.Write("提交成功！");
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }

        private void ResetVoteResult(HttpContext context, OleDbConnection conn) {
            int iPrizeID = 0;
            int.TryParse(context.Request["PrizeID"], out iPrizeID);

            int iMultipleVoteRound = 0;
            int.TryParse(context.Request["MultipleVoteRound"], out iMultipleVoteRound);

            OleDbTransaction tran = conn.BeginTransaction();

            try
            {
                BLL.Vote.DeleteVoteResult(iPrizeID, iMultipleVoteRound, conn, tran);
                tran.Commit();
                context.Response.Write("提交成功！");
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }
        /// <summary>
        /// 计算复投分组
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        private void Revote(HttpContext context, OleDbConnection conn)
        {
            // inital variables from request context
            int iPrizeID = 0;
            int.TryParse(context.Request["PrizeID"], out iPrizeID);
            string strData = context.Request["data"];

            Dal.Models.Prize prize = BLL.Prize.GetPrize(iPrizeID, conn);


            // 生成复投分组
            Revote revote=new Revote();
            string result= revote.GenerateRevoting(strData, prize, conn);

            /* 5.
             * 返回响应
             *
             */
            context.Response.Write(result);
        }

        /// <summary>
        /// 继续复投
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        private void RevoteMore(HttpContext context, OleDbConnection conn)
        {
            // 解析回传变量
            int iPrizeID = 0;
            int.TryParse(context.Request["PrizeID"], out iPrizeID);

            // 获取所有复投分组
            Revote revote = new Revote();

            // 计算新复投分组
            string result = revote.GenerateRevoting(iPrizeID, conn);

            context.Response.Write(result);
        }

        /// <summary>
        /// 提交复投分组结果
        /// </summary>
        /// <param name="context"></param>
        /// <param name="conn"></param>
        private void SubmitRevoteResult(HttpContext context, OleDbConnection conn)
        {
            // inital variables from request context
            int iPrizeID = 0;
            int.TryParse(context.Request["PrizeID"], out iPrizeID);
            string strViews = context.Request["Views"];

            // 生成复投分组
            Revote revote = new Revote();
            revote.SubmitRevoteResults(strViews,iPrizeID, conn);

            /* 5.
             * 返回响应
             *
             */
            context.Response.Write("复投结果已提交!");
        }

        private void GetPrizeResultLevel(HttpContext context, OleDbConnection conn)
        {
            List<Dal.Models.SysConstant> prizeResultLevel = BLL.SysConstant.GetSysConstantList("04", conn);
            prizeResultLevel = (from c in prizeResultLevel select c).Take(3).ToList();
            context.Response.Write(JsonConvert.SerializeObject(prizeResultLevel));
        }
        private void GetAwardCode(HttpContext context, OleDbConnection conn)
        {
            List<Dal.Models.SysConstant> lstAwardCode = BLL.SysConstant.GetSysConstantList("23", conn);
            //lstAwardCode = (from c in lstAwardCode select c).Take(3).ToList();
            context.Response.Write(JsonConvert.SerializeObject(lstAwardCode));
        }

        private void StopPrizeVote(HttpContext context, OleDbConnection conn)
        {
            int iPrizeID = 0;
            int.TryParse(context.Request["PrizeID"], out iPrizeID);

            bool bIsStopVote;
            bool.TryParse(context.Request["StopVote"], out bIsStopVote);

            Dal.Models.Prize prize = BLL.Prize.GetPrize(iPrizeID, conn);

            OleDbTransaction tran = conn.BeginTransaction();
            try
            {
                prize.IsStopVote = bIsStopVote;
                BLL.Prize.StopPrizeVote(prize, conn, tran);
                tran.Commit();
                //if (bIsStopVote)
                //{
                //    context.Response.Write("当前奖项已停止投票。");
                //}
                //else
                //{
                //    context.Response.Write("当前奖项已开始投票。");
                //}
                context.Response.Write(JsonConvert.SerializeObject(bIsStopVote));
            }
            catch (Exception ex)
            {
                tran.Rollback();
                context.Response.Write(ex.Message);
            }
        }
    }
}