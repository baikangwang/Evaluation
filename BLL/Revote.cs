using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using Dal;
using Dal.Models;
using Newtonsoft.Json.Linq;
using ReVote;

namespace BLL
{
    public class Revote
    {
        /// <summary>
        ///     等票复投
        /// </summary>
        /// <param name="rawData"></param>
        /// <param name="prize"></param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        public string GenerateRevoting(string rawData, Dal.Models.Prize prize, OleDbConnection conn,
            OleDbTransaction tran = null)
        {
            var metaData = MetaDataParser.Factory.Parse(rawData, prize);

            if (metaData.Awards.Length == 0)
            {
                return "目前仅支持综合奖和单项奖复投，请确认奖项类型和奖项数量配置";
            }

            var recorder = new VoteRecorder();
            // 单项奖和中小创的票数可直接用于排名，类似复投投票，所以视为推荐/不推荐投票类型
            // 0302 : 单项奖
            // 0303 : 中小创，与单项奖等同

            bool isRevote = prize.PrizeTypeCode == "0302" || prize.PrizeTypeCode == "0303";
            var orgRank = recorder.InitRank(metaData.Projects, metaData.Votes, metaData.Awards, isRevote);

            var notPass = new List<VerifyResult>();
            foreach (var subRank in orgRank.SubRanks)
            {
                var vResult = recorder.VerifyRank(subRank.Ranks, subRank.Awards);
                if (!vResult.Pass)
                {
                    notPass.Add(vResult);
                }
            }
            // clear sub ranks
            orgRank.Verfied();

            if (notPass.Count == 0)
            {
                // response message
                return "已满足评奖名额，无需再复投。";
            }

            orgRank.Update(recorder.UpdateRank(orgRank.OrgRanks, orgRank.OrgRanks));

            // keep the sequnce order as has been sorted by score
            //orgRank.Update(recorder.SortRank(orgRank.OrgRanks));

            /* 
             * 3. 
             * 计算分组
             */
            var voteGroups = new List<VoteGroup>();

            foreach (var vResult in notPass)
            {
                var rankGroups = recorder.GroupRank(vResult.ActAwards, vResult.ActRankNoMatrix,
                    vResult.DiffMatrix);

                var subVoteGroups = recorder.GroupRevote(orgRank.OrgRanks, vResult.OrgRanks, vResult.ActAwards,
                    vResult.ExpAwards,
                    rankGroups);

                voteGroups.AddRange(subVoteGroups);
            }

            /* 4.
             * 保存分组
             */
            int prizeId = prize.PrizeID??0;
            int prizeRound = prize.MultipleVoteRound??1;
            // Save RevotePrize
            RevotePrize revotePrize = CreateRevotePrize(prizeId, prizeRound, conn, tran);
            int revotePrizeId = revotePrize.RevotePrizeId;
            // Save VoteGroups
            SaveReVotingGroups(voteGroups, revotePrizeId, conn, tran);

            // 初始化复投结果表
            InitRevoteResults(orgRank.OrgRanks, revotePrizeId, conn, tran);

            return "复投开始！";
        }

        /// <summary>
        ///     继续复投
        /// </summary>
        /// <param name="prizeId"></param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        public string GenerateRevoting(int prizeId, OleDbConnection conn, OleDbTransaction tran = null)
        {
            // initial prize
            var prize = Prize.GetPrize(prizeId, conn);

            // load whole ranks

            var oldRevotePrize = GetLastRevotePrize(prize, conn);

            var revoteResultViews = GetRevoteResultViewsByRevotePrizeId(oldRevotePrize.RevotePrizeId, conn);

            double[,] orgRanks;

            List<VerifyResult> notPass = this.CheckRevotingVotes(revoteResultViews, prize,out orgRanks, conn);


            if (notPass.Count == 0)
            {
                // response message
                return "已满足评奖名额，无需再复投。";
            }

            // Generating New Group

            // orgRanks = recorder.SortRank(orgRanks);

            /* 
             * 3. 
             * 计算分组
             */
            var voteGroups = new List<VoteGroup>();
            var recorder = new VoteRecorder();
            foreach (var vResult in notPass)
            {
                var rankGroups = recorder.GroupRank(vResult.ActAwards, vResult.ActRankNoMatrix,
                    vResult.DiffMatrix);

                var subVoteGroups = recorder.GroupRevote(orgRanks, vResult.OrgRanks, vResult.ActAwards,
                    vResult.ExpAwards,
                    rankGroups);

                voteGroups.AddRange(subVoteGroups);
            }

            /* 4.
             * 保存分组
             */
            // int prizeId = this._prize.PrizeID.Value;
            int prizeRound = prize.MultipleVoteRound??0;
            // Save RevotePrize
            RevotePrize newRevotePrize = CreateRevotePrize(prizeId, prizeRound, conn, tran);
            int revotePrizeId = newRevotePrize.RevotePrizeId;

            // Save VoteGroups
            SaveReVotingGroups(voteGroups, revotePrizeId, conn, tran);

            // update ranks
            foreach (var view in revoteResultViews)
            {
                for (var i = 0; i < orgRanks.GetUpperBound(0) + 1; i++)
                {
                    var projectId = (int) orgRanks[i, 0];
                    if (view.DeclarationId == projectId)
                    {
                        view.PrizeLevelId = (int) orgRanks[i, 1];
                        // view.Index = i;
                        break;
                    }
                }
            }

            revoteResultViews = revoteResultViews.OrderBy(v => v.Index).ToList();

            // Update RevoteResult
            UpdateRevoteResults(revotePrizeId, revoteResultViews, conn, tran);

            return "复投开始！";
        }
        public List<RevoteResultView> GenerateRevoteResultViews(int prizeId, OleDbConnection conn)
        {
            // initial prize
            var prize = Prize.GetPrize(prizeId, conn);

            // load whole ranks

            var revotePrize = GetLastRevotePrize(prize, conn);

            var revoteResultViews = GetRevoteResultViewsByRevotePrizeId(revotePrize.RevotePrizeId, conn);

            double[,] orgRanks;

            this.CheckRevotingVotes(revoteResultViews, prize, out orgRanks, conn);
            
            // orgRanks = recorder.SortRank(orgRanks);

            // update ranks
            foreach (var view in revoteResultViews)
            {
                for (var i = 0; i < orgRanks.GetUpperBound(0) + 1; i++)
                {
                    var projectId = (int)orgRanks[i, 0];
                    if (view.DeclarationId == projectId)
                    {
                        view.PrizeLevelId = (int)orgRanks[i, 1];
                        // view.Index = i;
                        break;
                    }
                }
            }

            revoteResultViews = revoteResultViews.OrderBy(v => v.Index).ToList();

            return revoteResultViews;
        }

        private List<VerifyResult> CheckRevotingVotes(List<RevoteResultView> revoteResultViews,Dal.Models.Prize prize,out double[,] orgRanks, OleDbConnection conn)
        {
            // init orgRanks double[,]
            orgRanks = new double[revoteResultViews.Count, 2];
            for (var i = 0; i < revoteResultViews.Count; i++)
            {
                var result = revoteResultViews[i];
                orgRanks[i, 0] = result.DeclarationId;
                orgRanks[i, 1] = result.PrizeLevelId;
            }

            // retrieve votes from revteGroups
            var revoteGroups = GetRevoteGroups(prize, conn);

            var notPass = new List<VerifyResult>();

            var recorder = new VoteRecorder();

            // update revote result view
            foreach (var revoteGroup in revoteGroups)
            {
                var revotingVotes = GetRevotingVotesByGroupId(revoteGroup.RevoteGroupId, conn);
                var revotingAwards = GetRevotePrizeLevelsByGroupId(revoteGroup.RevoteGroupId,
                    conn);

                var projects = new int[revotingVotes.Count]; // the project id
                var sorting_projects = new int[revotingVotes.Count]; // used to sorting
                var sorting_scores = new double[projects.Length]; // used to sorting
                var votes = new double[revotingVotes.Count, 1]; // votes used to calculating RevoteGroups
                var awards = new double[revotingAwards.Count, 2];
                var indexes = new int[projects.Length]; // the original indexes

                for (var i = 0; i < revotingVotes.Count; i++)
                {
                    projects[i] = revotingVotes[i].DeclarationId;
                    votes[i, 0] = revotingVotes[i].RevoteRecommended;
                    sorting_scores[i] = revotingVotes[i].RevoteRecommended; // used to sorting
                    sorting_projects[i] = revotingVotes[i].DeclarationId;

                    // update revotingVotes to revoteResult
                    foreach (var result in revoteResultViews)
                    {
                        if (result.DeclarationId == revotingVotes[i].DeclarationId)
                        {
                            result.RevoteRecommended += revotingVotes[i].RevoteRecommended;
                            result.RevoteNotRecommended += revotingVotes[i].RevoteNotRecommended;
                            indexes[i] = result.Index; // obtain the original index
                            break;
                        }
                    }
                }

                // desc sorting
                Array.Sort(sorting_scores, sorting_projects, Comparer<double>.Create((a, b) =>
                {
                    if (a > b) return -1;
                    else if (a < b) return 1;
                    return 0;
                }));

                // apply new index
                for (int i = 0; i < sorting_projects.Length; i++)
                {
                    // update revotingVotes to revoteResult
                    foreach (var result in revoteResultViews)
                    {
                        if (result.DeclarationId == sorting_projects[i])
                        {
                            result.Index = indexes[i];
                            break;
                        }
                    }
                }

                for (var i = 0; i < revotingAwards.Count; i++)
                {
                    awards[i, 0] = revotingAwards[i].PrizeLevelId;
                    awards[i, 1] = revotingAwards[i].LevelLimitNumber;
                }

                var orgRevoteRanks = recorder.InitRank(projects, votes, awards, true);

                foreach (var subRevoteRanks in orgRevoteRanks.SubRanks)
                {
                    var v = recorder.VerifyRank(subRevoteRanks.Ranks, subRevoteRanks.Awards);
                    if (!v.Pass)
                    {
                        notPass.Add(v);
                    }
                }

                orgRanks = recorder.UpdateRank(orgRanks, orgRevoteRanks.OrgRanks);
            }

            return notPass;
        }

        [Obsolete]
        public List<RevoteResultView> GenerateRevoteResultViewsOld(int prizeId, OleDbConnection conn)
        {
            // initial prize
            var prize = Prize.GetPrize(prizeId, conn);

            // load whole ranks

            var revotePrize = GetLastRevotePrize(prize, conn);

            var revoteResultViews = GetRevoteResultViewsByRevotePrizeId(revotePrize.RevotePrizeId, conn);

            // init orgRanks double[,]
            var orgRanks = new double[revoteResultViews.Count, 2];
            for (var i = 0; i < revoteResultViews.Count; i++)
            {
                var result = revoteResultViews[i];
                orgRanks[i, 0] = result.DeclarationId;
                orgRanks[i, 1] = result.PrizeLevelId;
            }

            // retrieve votes from revteGroups
            var revoteGroups = GetRevoteGroups(prize, conn);

            var recorder = new VoteRecorder();

            // update revote result view
            foreach (var revoteGroup in revoteGroups)
            {
                var revotingVotes = GetRevotingVotesByGroupId(revoteGroup.RevoteGroupId, conn);
                var revotingAwards = GetRevotePrizeLevelsByGroupId(revoteGroup.RevoteGroupId,
                    conn);

                var projects = new int[revotingVotes.Count];
                var votes = new double[revotingVotes.Count, 1];
                var awards = new double[revotingAwards.Count, 2];

                for (var i = 0; i < revotingVotes.Count; i++)
                {
                    projects[i] = revotingVotes[i].DeclarationId;
                    votes[i, 0] = revotingVotes[i].RevoteRecommended;

                    // update revotingVotes to revoteResult
                    foreach (var result in revoteResultViews)
                    {
                        if (result.DeclarationId == revotingVotes[i].DeclarationId)
                        {
                            result.RevoteRecommended += revotingVotes[i].RevoteRecommended;
                            result.RevoteNotRecommended += revotingVotes[i].RevoteNotRecommended;
                            break;
                        }
                    }
                }

                for (var i = 0; i < revotingAwards.Count; i++)
                {
                    awards[i, 0] = revotingAwards[i].PrizeLevelId;
                    awards[i, 1] = revotingAwards[i].LevelLimitNumber;
                }

                var orgRevoteRanks = recorder.InitRank(projects, votes, awards, true);

                orgRanks = recorder.UpdateRank(orgRanks, orgRevoteRanks.OrgRanks);
            }

            // orgRanks = recorder.SortRank(orgRanks);

            // update ranks
            foreach (var view in revoteResultViews)
            {
                for (var i = 0; i < orgRanks.GetUpperBound(0) + 1; i++)
                {
                    var projectId = (int)orgRanks[i, 0];
                    if (view.DeclarationId == projectId)
                    {
                        view.PrizeLevelId = (int)orgRanks[i, 1];
                        // view.Index = i;
                        break;
                    }
                }
            }

            return revoteResultViews.OrderBy(v => v.Index).ToList();
        }

        public bool UpdateRevotePrizeStatus(int iPrizeId, int revoteStatus, OleDbConnection conn, OleDbTransaction tran = null)
        {

            string strSql = @"update RevotePrize set RevoteStatus = ? 
                            where PrizeId= ? ";

            int iResult = Dal.OleDbHlper.ExecuteNonQuery(
                strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@RevoteStatus", OleDbType.Integer)
                {
                    Value = revoteStatus
                }
                , new OleDbParameter("@PrizeId", OleDbType.Integer)
                {
                    Value = iPrizeId
                }
            );

            return true;
        }

        private bool UpdateRevoteResults(int newRevotePrizeId, List<RevoteResultView> revoteResultViews,
            OleDbConnection conn, OleDbTransaction tran = null)
        {
            tran = conn.BeginTransaction();
            try
            {
                foreach (var view in revoteResultViews)
                {
                    var result = new RevoteResult
                    {
                        RevotePrizeId = newRevotePrizeId,
                        DeclarationId = view.DeclarationId,
                        Index = view.Index,
                        RevoteRecommended = view.RevoteRecommended,
                        RevoteNotRecommended = view.RevoteNotRecommended,
                        PrizeLevelId = view.PrizeLevelId
                    };

                    UpdateRevoteResult(view.RevotePrizeId, result, conn, tran);
                }

                tran.Commit();
            }
            catch (Exception ex)
            {
                tran.Rollback();
                return false;
            }

            return true;
        }

        private bool UpdateRevoteResult(int oldRevotePrizeId, RevoteResult revoteResult, OleDbConnection conn,
            OleDbTransaction tran = null)
        {
            var strSql =
                @"update RevoteResult set RevotePrizeId = ?, [Index]= ? , PrizeLevelId= ? ,RevoteRecommended= ? ,RevoteNotRecommended= ? 
                            where RevotePrizeId= ? and DeclarationId= ? ";

            var iResult = OleDbHlper.ExecuteNonQuery(
                strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@NewRevotePrizeId", OleDbType.Integer)
                {
                    Value = revoteResult.RevotePrizeId
                }
                , new OleDbParameter("@Index", OleDbType.Integer)
                {
                    Value = revoteResult.Index
                }
                , new OleDbParameter("@PrizeLevelId", OleDbType.Integer)
                {
                    Value = revoteResult.PrizeLevelId
                }
                , new OleDbParameter("@RevoteRecommended", OleDbType.Integer)
                {
                    Value = revoteResult.RevoteRecommended
                }
                , new OleDbParameter("@RevoteNotRecommended", OleDbType.Integer)
                {
                    Value = revoteResult.RevoteNotRecommended
                },
                new OleDbParameter("@OldRevotePrizeId", OleDbType.Integer)
                {
                    Value = oldRevotePrizeId
                },
                new OleDbParameter("@DeclarationId", OleDbType.Integer)
                {
                    Value = revoteResult.DeclarationId
                });

            return iResult > 0;
        }

        public RevotePrize GetLastRevotePrize(Dal.Models.Prize prize, OleDbConnection conn, OleDbTransaction tran = null)
        {
            var prizeId = prize.PrizeID.Value;
            var prizeRound = prize.MultipleVoteRound.Value;

            return GetLastRevotePrize(prizeId, prizeRound, conn, tran);
        }

        public RevotePrize GetLastRevotePrize(int prizeId, int prizeRound, OleDbConnection conn,
            OleDbTransaction tran = null)
        {
            var strSql = @"select top 1 * from RevotePrize 
                            where PrizeId = ? and PrizeRound = ?
                            order by RevoteRound desc";
            var revotePrize = BaseEntity.GetEntity<RevotePrize>(
                OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                    , new OleDbParameter("@PrizeId", OleDbType.Integer) {Value = prizeId}
                    , new OleDbParameter("@PrizeRound", OleDbType.Integer) {Value = prizeRound}
                    )
                );
            return revotePrize;
        }

        public RevoteGroup GetRevoteGroup(int revotePrizeId, int index, OleDbConnection conn,
            OleDbTransaction tran = null)
        {
            var strSql = @"select * from RevoteGroup 
                            where RevotePrizeId = ? and [Index] = ? ";
            var revoteGroup = BaseEntity.GetEntity<RevoteGroup>(
                OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                    , new OleDbParameter("@RevotePrizeId", OleDbType.Integer) {Value = revotePrizeId}
                    , new OleDbParameter("@Index", OleDbType.Integer) {Value = index}
                    )
                );
            return revoteGroup;
        }

        public List<RevotePrizeLevel> GetRevotePrizeLevelsByGroupId(int revoteGroupId, OleDbConnection conn,
            OleDbTransaction tran = null)
        {
            var strSql = "SELECT * FROM RevotePrizeLevel WHERE RevoteGroupId = ? order by [Index] asc ";
            return OleDbHlper.GetList<RevotePrizeLevel>(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@RevoteGroupId", OleDbType.Integer) {Value = revoteGroupId});
        }

        public List<RevoteGroup> GetRevoteGroups(int revotePrizeId, OleDbConnection conn, OleDbTransaction tran = null)
        {
            var strSql = "SELECT * FROM RevoteGroup WHERE RevotePrizeId = ? order by [Index] asc ";
            return OleDbHlper.GetList<RevoteGroup>(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@RevotePrizeId", OleDbType.Integer) {Value = revotePrizeId});
        }

        public List<RevoteGroup> GetRevoteGroups(Dal.Models.Prize prize, OleDbConnection conn,
            OleDbTransaction tran = null)
        {
            var revotePrize = GetLastRevotePrize(prize, conn, tran);

            return GetRevoteGroups(revotePrize.RevotePrizeId, conn, tran);
        }

        private RevotePrize CreateRevotePrize(int prizeId, int prizeRound, OleDbConnection conn,
            OleDbTransaction tran = null)
        {
            var current = new RevotePrize
            {
                RevotePrizeId = 0,
                PrizeId = prizeId,
                PrizeRound = prizeRound,
                RevoteRound = 1
            };
            var last = GetLastRevotePrize(prizeId, prizeRound, conn, tran);
            if (last != null)
            {
                current.RevoteRound = last.RevoteRound + 1;
            }

            var sbSql = new StringBuilder();
            sbSql.Append(" INSERT INTO RevotePrize ( ");
            sbSql.Append(" PrizeId");
            sbSql.Append(", PrizeRound ");
            sbSql.Append(", RevoteRound ");
            sbSql.Append(" ) VALUES ( ?, ?, ?) ");

            var iResult = OleDbHlper.ExecuteNonQuery(
                sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@PrizeId", OleDbType.Integer)
                {
                    Value = current.PrizeId
                }
                , new OleDbParameter("@PrizeRound", OleDbType.Integer)
                {
                    Value = current.PrizeRound
                }
                , new OleDbParameter("@RevoteRound", OleDbType.Integer)
                {
                    Value = current.RevoteRound
                }
                );

            current = GetLastRevotePrize(prizeId, prizeRound, conn, tran);

            return current;
        }

        private void SaveReVotingGroups(List<VoteGroup> voteGroups, int revotePrizeId, OleDbConnection conn,
            OleDbTransaction tran = null)
        {
            for (var i = 0; i < voteGroups.Count; i++)
            {
                var group = voteGroups[i];

                // 保存复投分组
                var revoteGroup = SaveRevoteGroup(revotePrizeId, i, conn, tran);

                // 保存复投分组组内的奖项设置
                var awards = group.Awards;
                for (var j = 0; j < awards.GetUpperBound(0) + 1; j++)
                {
                    SaveRevotePrizeLevel(revoteGroup.RevoteGroupId, (int) awards[j, 0], (int) awards[j, 1], j, conn,
                        tran);
                }

                // 初始化复投分组的投票表
                var projects = group.Projects;

                for (var j = 0; j < projects.Length; j++)
                {
                    SaveRevoteApplication(projects[j], revoteGroup.RevoteGroupId, j, conn, tran);
                }
            }
        }

        public void InitRevoteResults(double[,] ranks, int revotePrizeId, OleDbConnection conn,
            OleDbTransaction tran = null)
        {
            for (var i = 0; i < ranks.GetUpperBound(0) + 1; i++)
            {
                //dynamic result = rawData.FirstOrDefault(r => ((dynamic) r).DeclarationID == (int) ranks[i, 0]);
                //if (result != null)
                //{
                var declarationId = (int) ranks[i, 0]; //Convert.ToInt32(result.DeclarationID);
                //int revoteRecommended = Convert.ToInt32(result.RevoteRecommended);
                //int revoteNotRecommended = Convert.ToInt32(result.RevoteNotRecommended);
                var award = (int) ranks[i, 1];
                // Save RevotingRanks, need to check
                InitRevoteResult(declarationId, revotePrizeId, award, i, 0, 0, conn, tran);
                //}
            }
        }

        public RevoteGroup SaveRevoteGroup(int revotePrizeId, int index, OleDbConnection conn,
            OleDbTransaction tran = null)
        {
            var group = new RevoteGroup
            {
                Index = index,
                RevoteGroupId = 0,
                RevotePrizeId = revotePrizeId
            };

            var sbSql = new StringBuilder();
            sbSql.Append(" INSERT INTO RevoteGroup ( ");
            sbSql.Append(" [Index] ");
            sbSql.Append(", RevotePrizeId ");
            sbSql.Append(" ) VALUES ( ?, ?) ");

            var iResult = OleDbHlper.ExecuteNonQuery(
                sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@Index", OleDbType.Integer)
                {
                    Value = group.Index
                }
                , new OleDbParameter("@RevotePrizeId", OleDbType.Integer)
                {
                    Value = group.RevotePrizeId
                }
                );

            group = GetRevoteGroup(revotePrizeId, index, conn, tran);

            return group;
        }

        public bool SaveRevotePrizeLevel(int revoteGroupId, int prizeLevelId, int number, int index,
            OleDbConnection conn, OleDbTransaction tran = null)
        {
            var level = new RevotePrizeLevel
            {
                RevoteGroupId = revoteGroupId,
                Index = index,
                LevelLimitNumber = number,
                PrizeLevelId = prizeLevelId
            };

            var sbSql = new StringBuilder();
            sbSql.Append(" INSERT INTO RevotePrizeLevel ( ");
            sbSql.Append(" RevoteGroupId ");
            sbSql.Append(", [Index] ");
            sbSql.Append(", LevelLimitNumber ");
            sbSql.Append(", PrizeLevelId ");
            sbSql.Append(" ) VALUES ( ?, ?, ?, ?) ");

            var iResult = OleDbHlper.ExecuteNonQuery(
                sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@RevoteGroupId", OleDbType.Integer)
                {
                    Value = level.RevoteGroupId
                }
                , new OleDbParameter("@Index", OleDbType.Integer)
                {
                    Value = level.Index
                }
                , new OleDbParameter("@LevelLimitNumber", OleDbType.Integer)
                {
                    Value = level.LevelLimitNumber
                }
                , new OleDbParameter("@PrizeLevelId", OleDbType.Integer)
                {
                    Value = level.PrizeLevelId
                }
                );

            return true;
        }

        public bool SaveRevoteApplication(int declarationId, int revoteGroupId, int index, OleDbConnection conn,
            OleDbTransaction tran = null)
        {
            var application = new RevoteApplication
            {
                DeclarationId = declarationId,
                RevoteGroupId = revoteGroupId,
                Index = index
            };

            var sbSql = new StringBuilder();
            sbSql.Append(" INSERT INTO RevoteApplication ( ");
            sbSql.Append(" DeclarationId ");
            sbSql.Append(", RevoteGroupId ");
            sbSql.Append(", [Index] ");
            sbSql.Append(" ) VALUES ( ?, ?, ?) ");

            var iResult = OleDbHlper.ExecuteNonQuery(
                sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@DeclarationId", OleDbType.Integer)
                {
                    Value = application.DeclarationId
                }
                , new OleDbParameter("@RevoteGroupId", OleDbType.Integer)
                {
                    Value = application.RevoteGroupId
                }
                , new OleDbParameter("@Index", OleDbType.Integer)
                {
                    Value = application.Index
                }
                );

            return true;
        }

        public List<RevotingVoteView> GetRevotingVoteViews(int revoteGroupId, int UserId, OleDbConnection conn,
            OleDbTransaction tran = null)
        {
            var strSql = new StringBuilder();

            strSql.Clear();
            strSql.Append(" select a.RevoteGroupId,a.DeclarationId,d.DeclarationName,d.OrganizationName, ");
            strSql.Append(" r.RevotingVoteId,r.RevoteRecommended,r.RevoteNotRecommended,r.IsSubmit ");
            strSql.Append(" from RevoteApplication a ");
            strSql.Append(" left join V_Declaration d on a.DeclarationId=d.DeclarationID ");
            strSql.Append(
                " left outer join RevotingVote r on a.RevoteGroupId=r.RevoteGroupId and a.DeclarationId=r.DeclarationId  and r.UserId = ? ");
            strSql.Append(" where a.RevoteGroupId= ? ");

            return OleDbHlper.GetList<RevotingVoteView>(strSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@UserId", OleDbType.Integer) {Value = UserId}
                , new OleDbParameter("@RevoteGroupId", OleDbType.Integer) {Value = revoteGroupId});
        }

        public RevotingVote GetRevotingVote(int revoteGroupId, int declarationId, int userid, OleDbConnection conn,
            OleDbTransaction tran = null)
        {
            var strSql = @"select * from RevotingVote 
                            where RevoteGroupId = ? and DeclarationId = ?
                            and Userid = ? ";
            var reVote = BaseEntity.GetEntity<RevotingVote>(
                OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                    , new OleDbParameter("@RevoteGroupId", OleDbType.Integer) {Value = revoteGroupId}
                    , new OleDbParameter("@DeclarationId", OleDbType.Integer) {Value = declarationId}
                    , new OleDbParameter("@Userid", OleDbType.Integer) {Value = userid}
                    )
                );
            return reVote;
        }

        public RevotingVote GetRevotingVote(RevotingVote reVote, OleDbConnection conn, OleDbTransaction tran = null)
        {
            return GetRevotingVote(reVote.RevoteGroupId, reVote.DeclarationId, reVote.UserId, conn, tran);
        }

        public bool SaveRevotingVote(int revoteGroupId, int declarationId, int revoteRecommended,
            int revoteNotRecommended, int userid, OleDbConnection conn, OleDbTransaction tran = null)
        {
            var curReVote = new RevotingVote
            {
                RevoteGroupId = revoteGroupId,
                DeclarationId = declarationId,
                RevoteRecommended = revoteRecommended,
                RevoteNotRecommended = revoteNotRecommended,
                UserId = userid
            };

            var oldReVote = GetRevotingVote(curReVote, conn, tran);
            if (oldReVote == null)
            {
                var sbSql = new StringBuilder();
                sbSql.Append(" INSERT INTO RevotingVote ( ");
                sbSql.Append(" RevoteGroupId ");
                sbSql.Append(", DeclarationId ");
                sbSql.Append(", RevoteRecommended ");
                sbSql.Append(", RevoteNotRecommended ");
                sbSql.Append(", UserId ");
                sbSql.Append(", IsSubmit ");
                sbSql.Append(" ) VALUES ( ?, ?, ?, ?, ?, 0) ");

                var iResult = OleDbHlper.ExecuteNonQuery(
                    sbSql.ToString(), conn, CommandType.Text, tran
                    , new OleDbParameter("@RevoteGroupId", OleDbType.Integer)
                    {
                        Value = curReVote.RevoteGroupId
                    }
                    , new OleDbParameter("@DeclarationId", OleDbType.Integer)
                    {
                        Value = curReVote.DeclarationId
                    }
                    , new OleDbParameter("@RevoteRecommended", OleDbType.Integer)
                    {
                        Value = curReVote.RevoteRecommended
                    }
                    , new OleDbParameter("@RevoteNotRecommended", OleDbType.Integer)
                    {
                        Value = curReVote.RevoteNotRecommended
                    }
                    , new OleDbParameter("@UserId", OleDbType.Integer)
                    {
                        Value = curReVote.UserId
                    }
                    );
            }
            else
            {
                //if (oldReVote.IsSubmit == false)
                //{
                var sbSql = new StringBuilder();
                sbSql.Append(" Update RevotingVote ");
                sbSql.Append(" Set RevoteRecommended = ? ");
                sbSql.Append(", RevoteNotRecommended = ? ");
                sbSql.Append(" Where RevotingVoteId = ? ");

                var iResult = OleDbHlper.ExecuteNonQuery(
                    sbSql.ToString(), conn, CommandType.Text, tran
                    , new OleDbParameter("@RevoteRecommended", OleDbType.Integer)
                    {
                        Value = curReVote.RevoteRecommended
                    }
                    , new OleDbParameter("@RevoteNotRecommended", OleDbType.Integer)
                    {
                        Value = curReVote.RevoteNotRecommended
                    }
                    , new OleDbParameter("@RevotingVoteId", OleDbType.Integer)
                    {
                        Value = oldReVote.RevotingVoteId
                    }
                    );
                //}
            }

            return true;
        }

        public bool SaveBatchRevotingVotes(int revotePrizeId, int userId, int revoteRecommended,
            int revoteNotRecommended, OleDbConnection conn, OleDbTransaction tran = null)
        {
            var sbSql = new StringBuilder();
            sbSql.Append(
                " insert into RevotingVote (RevoteGroupId,DeclarationId,RevoteRecommended,RevoteNotRecommended,UserId,IsSubmit) ");
            sbSql.Append(" select a.RevoteGroupId,a.DeclarationId, ? , ? , ? , 0 ");
            sbSql.Append(" from revoteApplication a ");
            sbSql.Append(
                " left outer join RevotingVote r on a.RevoteGroupId=r.RevoteGroupId and a.DeclarationId=r.DeclarationId  and r.UserId= ? ");
            sbSql.Append(
                " where a.RevoteGroupId in (select g.RevoteGroupId from RevoteGroup g where g.RevotePrizeId= ? ) and not exists(select * from revotingvote v where a.DeclarationId=v.DeclarationId and a.RevoteGroupId=v.RevoteGroupId and v.UserId= ? ) ");

            var iResult = OleDbHlper.ExecuteNonQuery(
                sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@RevoteRecommended", OleDbType.Integer)
                {
                    Value = revoteRecommended
                }
                , new OleDbParameter("@RevoteNotRecommended", OleDbType.Integer)
                {
                    Value = revoteNotRecommended
                }
                , new OleDbParameter("@UserId", OleDbType.Integer)
                {
                    Value = userId
                }
                , new OleDbParameter("@UserId", OleDbType.Integer)
                {
                    Value = userId
                }
                , new OleDbParameter("@RevotePrizeId", OleDbType.Integer)
                {
                    Value = revotePrizeId
                }
                , new OleDbParameter("@UserId", OleDbType.Integer)
                {
                    Value = userId
                }
                );

            return true;
        }

        public bool SubmitRevotingVote(int userid, int revotePrizeId, OleDbConnection conn, OleDbTransaction tran = null)
        {
            var strSql = new StringBuilder();

            strSql.Append("  Update RevotingVote set IsSubmit = 1 ");
            strSql.Append(
                " WHERE UserID = ?  and RevoteGroupId in (select RevoteGroupId from RevoteGroup where RevotePrizeID = ? )  ");

            OleDbHlper.ExecuteNonQuery(strSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@UserID", OleDbType.Integer) {Value = userid}
                , new OleDbParameter("@RevotePrizeID", OleDbType.Integer) {Value = revotePrizeId}
                );

            return true;
        }

        public List<RevoteResult> GenerateRevotingVoteResult(int revotePrizeId, OleDbConnection conn,
            OleDbTransaction tran = null)
        {
            var sbSql = new StringBuilder();
            sbSql.Append(
                " select rp.RevotePrizeId, rg.RevoteGroupId, ra.DeclarationId, sum(RevoteRecommended) as revoteRecommended, sum(RevoteNotRecommended) as revoteNotRecommended");
            sbSql.Append(" from RevotePrize rp");
            sbSql.Append(" inner join RevoteGroup rg on rp.RevotePrizeId = rg.RevotePrizeId");
            sbSql.Append(" inner join RevoteApplication ra on rg.RevoteGroupId = ra.RevoteGroupId");
            sbSql.Append(
                " inner join RevotingVote rv on rg.RevoteGroupId = rv.RevoteGroupId  and ra.DeclarationId = rv.DeclarationId");
            sbSql.Append(" where rp.RevotePrizeId = ? ");
            sbSql.Append(" group by  rp.RevotePrizeId, rg.RevoteGroupId, ra.DeclarationId");
            return OleDbHlper.GetList<RevoteResult>(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@RevotePrizeId", OleDbType.Integer) {Value = revotePrizeId});
        }

        /// <summary>
        ///     获取专家可见的等票复投列表
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="activityId"></param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public List<Dal.Models.RevotePrize> GetExpertRevotePrize(
            int userId, int activityId, OleDbConnection conn, OleDbTransaction tran = null)
        {
            var strSql = new StringBuilder();
            strSql.Append(" select distinct lrp.*, p.* from V_LastRevotePrize lrp ");
            strSql.Append(" inner join V_Prize p on lrp.PrizeID = p.PrizeID");
            strSql.Append(" inner join Declaration d ");
            strSql.Append(" on d.AdjustedPrize = p.PrizeID ");
            strSql.Append(" and d.DeclarationStatus = '1803' ");
            strSql.Append(" inner join dbo.Fn_GetGroupByUserID(?) f");
            strSql.Append(" on f.GroupID = d.ExpertReviewGroupID ");
            strSql.Append(" where p.ActivityID = ? and lrp.RevoteStatus = 0 ");

            return OleDbHlper.GetList<Dal.Models.RevotePrize>(
                strSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@UserID", OleDbType.Integer)
                {
                    Value = userId
                }
                , new OleDbParameter("@ActivityID", OleDbType.Integer)
                {
                    Value = activityId
                }
                );
        }

        /// <summary>
        ///     根据用户身份获取奖项列表
        /// </summary>
        /// <param name="user">用户</param>
        /// <param name="strActivityType">当前活动编号，目前已不用，可为空</param>
        /// <param name="strSpecialtyIDs">逗号分隔的专业编号，可为空</param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public List<Dal.Models.RevotePrize> GetRevotePrizeList(
            UserInfo user, string strActivityType,
            string strSpecialtyIDs, OleDbConnection conn, OleDbTransaction tran = null)
        {
            var sbSql = new StringBuilder();
            var strSql = "";

            if (user == null)
            {
                var lst = new List<Dal.Models.RevotePrize>();
                return lst;
            }
            strSql =
                @" select lrp.*, p.* from V_LastRevotePrize lrp inner join V_Prize p on lrp.PrizeID = p.PrizeID 
                where lrp.RevoteStatus = 0 and ActivityID = dbo.Fn_GetCurrentActivityID() and dbo.fn_IsSpecialtyInAuthority(p.SpecialtyID, ?) = 1 ";
            if (!string.IsNullOrEmpty(strSpecialtyIDs))
            {
                strSql += " AND p.SpecialtyID in (" + strSpecialtyIDs + ")";
            }

            strSql += " order by p.SpecialtyTotalOrdinal, p.Ordinal ";
            return OleDbHlper.GetList<Dal.Models.RevotePrize>(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@UserID", OleDbType.Integer) {Value = user.UserID});
        }

        public bool InitRevoteResult(int declarationId, int revotePrizeId, int prizeLevelId, int index
            , int revoteRecommended, int revoteNotRecommended, OleDbConnection conn, OleDbTransaction tran = null)
        {
            var result = new RevoteResult
            {
                DeclarationId = declarationId,
                RevotePrizeId = revotePrizeId,
                PrizeLevelId = prizeLevelId,
                Index = index,
                RevoteRecommended = revoteRecommended,
                RevoteNotRecommended = revoteNotRecommended
            };

            var sbSql = new StringBuilder();
            sbSql.Append(" INSERT INTO RevoteResult ( ");
            sbSql.Append(" DeclarationId ");
            sbSql.Append(", RevotePrizeId ");
            sbSql.Append(", PrizeLevelId ");
            sbSql.Append(", [Index] ");
            sbSql.Append(", RevoteRecommended ");
            sbSql.Append(", RevoteNotRecommended ");
            sbSql.Append(" ) VALUES ( ?, ?, ?, ?, ?, ?) ");

            var iResult = OleDbHlper.ExecuteNonQuery(
                sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@DeclarationId", OleDbType.Integer)
                {
                    Value = result.DeclarationId
                }
                , new OleDbParameter("@RevotePrizeId", OleDbType.Integer)
                {
                    Value = result.RevotePrizeId
                }
                , new OleDbParameter("@PrizeLevelId", OleDbType.Integer)
                {
                    Value = result.PrizeLevelId
                }
                , new OleDbParameter("@Index", OleDbType.Integer)
                {
                    Value = result.Index
                }
                , new OleDbParameter("@RevoteRecommended", OleDbType.Integer)
                {
                    Value = result.RevoteRecommended
                }
                , new OleDbParameter("@RevoteNotRecommended", OleDbType.Integer)
                {
                    Value = result.RevoteNotRecommended
                }
                );


            return true;
        }

        private List<RevoteResultView> GetRevoteResultViewsByRevotePrizeId(int revotePrizeId, OleDbConnection conn,
            OleDbTransaction tran = null)
        {
            var sbSql = new StringBuilder();
            sbSql.Append(
                " select rr.RevotePrizeId, rr.DeclarationId,d.DeclarationName,d.OrganizationName, rr.PrizeLevelId, ");
            sbSql.Append(" rr.RevoteRecommended,rr.RevoteNotRecommended,[Index] from RevoteResult rr ");
            sbSql.Append(" left join V_Declaration d on d.DeclarationID=rr.DeclarationId ");
            sbSql.Append(" where rr.RevotePrizeId= ? ");
            sbSql.Append(" order by rr.[Index] ");

            return OleDbHlper.GetList<RevoteResultView>(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@RevotePrizeId", OleDbType.Integer) {Value = revotePrizeId});
        }

        /// <summary>
        ///     获取一组复投的投票结果
        /// </summary>
        /// <param name="revoteGroupId"></param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public List<RevotingVote> GetRevotingVotesByGroupId(int revoteGroupId, OleDbConnection conn,
            OleDbTransaction tran = null)
        {
            var sbSql = new StringBuilder();
            sbSql.Append(" select a.RevoteGroupId,a.DeclarationId,rv.RevoteRecommended,a.[Index] ");
            sbSql.Append(" ,0 as RevotingVoteId ");
            sbSql.Append(" ,0 as UserId ");
            sbSql.Append(" ,rv.RevoteNotRecommended as revoteNotRecommended ");
            sbSql.Append(" ,0 as IsSubmit ");
            sbSql.Append(" from RevoteApplication a ");
            sbSql.Append(
                " left join (select RevoteGroupId,DeclarationId, Sum(RevoteRecommended) as revoteRecommended, Sum(RevoteNotRecommended) as revoteNotRecommended from Revotingvote ");
            sbSql.Append(" where RevoteGroupId= ? ");
            sbSql.Append(" group by RevoteGroupId,DeclarationId ");
            sbSql.Append(" ) as rv on rv.RevoteGroupId=a.RevoteGroupId and rv.DeclarationId=a.DeclarationId ");
            sbSql.Append(" where a.RevoteGroupId= ? order by a.[Index] ");


            return OleDbHlper.GetList<RevotingVote>(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@RevoteGroupId", OleDbType.Integer) {Value = revoteGroupId}
                , new OleDbParameter("@RevoteGroupId", OleDbType.Integer) {Value = revoteGroupId});
        }

        /// <summary>
        ///     提交复投结果
        /// </summary>
        /// <param name="strViews"></param>
        /// <param name="iPrizeId"></param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public bool SubmitRevoteResults(string strViews,int prizeId, OleDbConnection conn,OleDbTransaction tran = null)
        {
            var views = JArray.Parse(strViews);
            var results = new List<RevoteResult>();

            foreach (dynamic view in views)
            {
                var result = new RevoteResult
                {
                    RevotePrizeId = view.RevotePrizeId,
                    DeclarationId = view.DeclarationId,
                    Index = view.Index,
                    RevoteRecommended = view.RevoteRecommended,
                    RevoteNotRecommended = view.RevoteNotRecommended,
                    PrizeLevelId = view.Award
                };

                results.Add(result);
            }

            //results = results.OrderBy(r => r.PrizeLevelId, Comparer<int>.Create((a, b) =>
            //{
            //    if (a == 0 && b != 0) return 1;
            //    if (a != 0 && b == 0) return -1;
            //    if (a > b) return 1;
            //    if (a < b) return -1;
            //    return 0;
            //})).ToList();

            tran = conn.BeginTransaction();
            try
            {
                for (var i = 0; i < results.Count; i++)
                {
                    var result = results[i];
                    result.Index = i;
                    UpdateRevoteResult(result.RevotePrizeId, result, conn, tran);
                    ApplyResultToVoteResult(i, prizeId, result.DeclarationId, conn, tran);
                }
                UpdateRevotePrizeStatus(prizeId, 1, conn, tran);
                
                tran.Commit();
            }
            catch
            {
                tran.Rollback();
                return false;
            }

            return true;
        }

        private bool ApplyResultToVoteResult(int i, int prizeId, int declarationId, OleDbConnection conn, OleDbTransaction tran)
        {
            var strSql =
                @"update AwardResult set RevoteNumber = ? where PrizeId=? and DeclarationID=? ";

            var iResult = OleDbHlper.ExecuteNonQuery(
                strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@RevoteNumber", OleDbType.Integer)
                {
                    Value = i
                }
                , new OleDbParameter("@PrizeId", OleDbType.Integer)
                {
                    Value = prizeId
                },
                new OleDbParameter("@DeclarationId", OleDbType.Integer)
                {
                    Value = declarationId
                });

            return iResult > 0;
        }
    }

    public class InitMetaData
    {
        public double[,] Awards { get; set; }
        public double[,] Votes { get; set; }

        public int[] Projects { get; set; }

        public InitMetaData()
        {
            this.Awards=new double[,]{};
            this.Votes = new double[,] {};
            this.Projects = new int[] {};
        }
    }

    public class MetaDataParser
    {
        private static readonly MetaDataParser _factory = new MetaDataParser();

        public static MetaDataParser Factory
        {
            get { return _factory; }
        }

        public virtual InitMetaData Parse(string rawData, Dal.Models.Prize prize)
        {
            switch (prize.PrizeTypeCode)
            {
                case "0302": //单项奖
                case "0303": //中小创，与单项奖等同
                    return new IndividualMetaDataParser().Parse(rawData, prize);
                case "0301": //综合奖
                case "0304": //专项奖，与综合奖等同
                    return new MultipleMetaDataParser().Parse(rawData, prize);

                default:
                    return new InitMetaData();
            }
        }

        protected class MultipleMetaDataParser : MetaDataParser
        {
            public override InitMetaData Parse(string rawData, Dal.Models.Prize prize)
            {
                /*
                 * 1.
                 * 读取奖项设置,构建奖项设置数组 double[,]
                 * 第一维度是奖项名,第二维度是奖项个数
                 * 举例: 一等奖2名,二等奖2名,则奖项设置数组如下
                 * [
                 *  [1,2],
                 *  [2,2]
                 * ]
                 */

                /*
                 * 综合奖 0301，一二三等奖+数量
                 * 
                 */
                var awards = new double[3, 2]
            {
                {1, (double) (prize.FirstPrize ?? 0)}, {2, (double) (prize.SecondPrize ?? 0)},
                {3, (double) (prize.ThirdPrize ?? 0)}
            };

                /* 
                 * 2. 
                 * 从回传数据中解析投票信息，构建投票数组double[,]
                 * 数组第一维度是一个项目的投票项，第二维度是各奖项的票数 => [N_1st,N_2nd,N_3rd]
                 * 举例:某项目,一等奖 3票,二等奖2票,三等奖0票, 投票数组如下
                 * [
                 *  ...
                 *  [ 2 , 2 , 0 ]
                 *  ...
                 * ]
                 */

                var jarrRawData = JArray.Parse(rawData);
                var projects = new int[jarrRawData.Count];
                var votes = new double[projects.Length, awards.GetUpperBound(0) + 1];

                for (var i = 0; i < jarrRawData.Count; i++)
                {
                    dynamic vote = jarrRawData[i];
                    double firstPrize = vote.FirstPrize;
                    double secondPrize = vote.SecondPrize;
                    double thirdPrize = vote.ThirdPrize;
                    votes[i, 0] = firstPrize;
                    votes[i, 1] = secondPrize;
                    votes[i, 2] = thirdPrize;
                    // 初始化评审项目Id
                    projects[i] = vote.DeclarationID;
                }

                return new InitMetaData { Awards = awards, Projects = projects, Votes = votes };
            }
        }

        protected class IndividualMetaDataParser : MetaDataParser
        {
            public override InitMetaData Parse(string rawData, Dal.Models.Prize prize)
            {
                /*
                 * 1.
                 * 读取奖项设置,构建奖项设置数组 double[,]
                 * 第一维度是奖项名,第二维度是奖项个数
                 * 举例: 一等奖2名,二等奖2名,则奖项设置数组如下
                 * [
                 *  [1,2],
                 *  [2,2]
                 * ]
                 */

                /*
                 * 单项奖 0302，只有奖项数量
                 * 综合奖 0301，一二三等奖+数量
                 * 
                 */
                var awards = new double[1, 2] { { 4, (double)(prize.AwardCount ?? 0) } };

                /* 
                 * 2. 
                 * 从回传数据中解析投票信息，构建投票数组double[,]
                 * 数组第一维度是一个项目的投票项，第二维度是各奖项的票数 => [N_1st,N_2nd,N_3rd]
                 * 举例:某项目,一等奖 3票,二等奖2票,三等奖0票, 投票数组如下
                 * [
                 *  ...
                 *  [ 2 , 2 , 0 ]
                 *  ...
                 * ]
                 */

                var jarrRawData = JArray.Parse(rawData);
                var projects = new int[jarrRawData.Count];
                var votes = new double[projects.Length, awards.GetUpperBound(0) + 1];

                for (var i = 0; i < jarrRawData.Count; i++)
                {
                    dynamic vote = jarrRawData[i];
                    double recommended = vote.Recommended;
                    votes[i, 0] = recommended;
                    // 初始化评审项目Id
                    projects[i] = vote.DeclarationID;
                }

                return new InitMetaData { Awards = awards, Projects = projects, Votes = votes };
            }
        }
    }
}