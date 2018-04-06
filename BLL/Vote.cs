using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// 投票
    /// </summary>
    public static class Vote
    {
        /// <summary>
        /// 获取当前用户的投票项目
        /// </summary>
        /// <param name="iUserID"></param>
        /// <param name="iPrizeID"></param>
        /// <param name="iVoteRound"></param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public static List<Dal.Models.Vote> GetVoteDeclarationList(
            Dal.Models.Expert expert, Dal.Models.Prize prize,
            OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Clear();
            strSql.Append(" SELECT d.DeclarationID, d.DeclarationName ");
            //strSql.Append(" , tmp.TypeEx , tmp.BigOrdinal");
            strSql.Append(" , d.OrganizationName, v.VoteID, isnull(v.IsSubmit,0)IsSubmit ");
            strSql.Append(" , CAST(CASE WHEN v.VoteCode = '0601' AND v.PrizeLevelCode = '0401' ");
            strSql.Append("             THEN 1 ELSE 0 END as bit) AS FirstPrize  ");
            strSql.Append(" , CAST(CASE WHEN v.VoteCode = '0601' AND v.PrizeLevelCode = '0402' ");
            strSql.Append("             THEN 1 ELSE 0 END as bit) AS SecondPrize ");
            strSql.Append(" , CAST(CASE WHEN v.VoteCode = '0601' AND v.PrizeLevelCode = '0403' ");
            strSql.Append("             THEN 1 ELSE 0 END as bit) AS ThirdPrize ");
            strSql.Append(" , CAST(CASE WHEN v.VoteCode = '0601' ");
            strSql.Append("             THEN 1 ELSE 0 END as bit) AS Recommended ");
            strSql.Append(" , CAST(CASE WHEN v.VoteCode = '0602' ");
            strSql.Append("             THEN 1 ELSE 0 END as bit) AS NotRecommended ");
            strSql.Append(" , CAST(CASE WHEN v.VoteCode = '0603' ");
            strSql.Append("             THEN 1 ELSE 0 END as bit) AS SlowRating ");
            strSql.Append(" , CAST(CASE WHEN v.VoteCode = '0604' ");
            strSql.Append("             THEN 1 ELSE 0 END as bit) AS TurnOut ");
            strSql.Append(" FROM V_Declaration AS d  ");
            strSql.Append(" INNER JOIN Prize p on p.PrizeID = d.AdjustedPrize ");
            //strSql.Append(" left  JOIN V_Tmp tmp on tmp.SpecialtyName = d.SpecialtyName ");
            //strSql.Append("  and tmp.PrizeName = d.PrizeName and tmp.DeclarationName = d.DeclarationName ");

            int iVoteRound = prize.MultipleVoteRound ?? 1;
            if (iVoteRound > 1)
            {
                strSql.Append(" inner join VoteResult vr on vr.DeclarationID = d.DeclarationID ");
                strSql.Append("   and vr.PrizeID = p.PrizeID and vr.MultipleVoteRound = (p.MultipleVoteRound - 1) ");
            }
            strSql.Append(" LEFT JOIN Vote AS v ON v.DeclarationID = d.DeclarationID ");
            strSql.Append(" and v.UserID = ? and v.MultipleVoteRound = isnull(p.MultipleVoteRound, 1) ");
            strSql.Append(" WHERE d.PrizeID = ? and d.DeclarationStatus = '1803' ");
            //strSql.Append(" order by tmp.BigOrdinal, d.OrganizationName, d.OrganizationOrdinal ");
            strSql.Append(" order by d.OrganizationName, d.OrganizationOrdinal ");

            return Dal.OleDbHlper.GetList<Dal.Models.Vote>(strSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@UserID", OleDbType.Integer) { Value = expert.UserID.Value }
                , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = prize.PrizeID.Value });
        }

        /// <summary>
        /// 找到同一奖项下投票结果为0601（推荐），投票轮次是第一次的投票结果
        /// </summary>
        /// <param name="iPrizeID"></param>
        /// <param name="strVoteCode"></param>
        /// <param name="iMultipleVoteRound"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        public static List<Dal.Models.Vote> GetVoteList(int iPrizeID, string strVoteCode, int iMultipleVoteRound, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "SELECT * FROM Vote WHERE PrizeID = ? and VoteCode = ? and MultipleVoteRound = ? ";
            return Dal.OleDbHlper.GetList<Dal.Models.Vote>(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID }
                , new OleDbParameter("@VoteCode", OleDbType.VarWChar) { Value = strVoteCode }
                , new OleDbParameter("@MultipleVoteRound", OleDbType.Integer) { Value = iMultipleVoteRound });
        }

        /// <summary>
        /// 根据专家和奖项获取投票列表
        /// </summary>
        /// <param name="iExpertID"></param>
        /// <param name="iPrizeID"></param>
        /// <param name="iVoteRound"></param>
        /// <param name="iMultipleVoteRound"></param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public static List<Dal.Models.Vote> GetVoteListByExpertAndPrize(int iExpertID, int iPrizeID, int iVoteRound, int iMultipleVoteRound, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "SELECT * FROM Vote WHERE Votor = ? and PrizeID = ? and VoteRound = ? and MultipleVoteRound = ? ";
            return Dal.OleDbHlper.GetList<Dal.Models.Vote>(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@Votor", OleDbType.Integer) { Value = iExpertID }
                , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID }
                , new OleDbParameter("@VoteRound", OleDbType.Integer) { Value = iVoteRound }
                , new OleDbParameter("@MultipleVoteRound", OleDbType.Integer) { Value = iMultipleVoteRound });
        }

        //获取当前轮的投票数
        public static int GetCurrentVoteCount(int iPrizeID, int iMultipleVoteRound, OleDbConnection conn, OleDbTransaction tran = null)
        {
            int count = 0;
            string strSql = "SELECT COUNT(VoteID) AS voteCount FROM Vote WHERE PrizeID = ? AND MultipleVoteRound = ?";
            object obj = Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID }
                , new OleDbParameter("@MultipleVoteRound", OleDbType.Integer) { Value = iMultipleVoteRound });
            if (obj != null && obj.ToString() != "")
            {
                count = Convert.ToInt32(obj);
            }
            return count;
        }

        public static List<Dal.Models.Vote> GetExpertVoteList(int iActivityID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = @"select Votor,DeclarationID,Vote.PrizeID,UserID,VoteCode,IsSubmit 
                                   from dbo.Vote 
                                   inner join dbo.Prize on Vote.PrizeID=Prize.PrizeID 
                                   inner join dbo.Specialty on Prize.SpecialtyID=Specialty.SpecialtyID 
                                   where Specialty.ActivityID= ? and IsSubmit = 1 
                                   group by Votor,DeclarationID,Vote.PrizeID,UserID,VoteCode,IsSubmit";
            return Dal.OleDbHlper.GetList<Dal.Models.Vote>(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@Specialty.ActivityID", OleDbType.Integer) { Value = iActivityID });
        }

        public static List<Dal.Models.Vote> GetExpertVoteStatus(int iActivityID, int iPrizeID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = @"select p.PrizeID, p.PrizeName, e.ExpertID, e.ExpertName
                                   , case when count( distinct v.DeclarationID) = 0 then '未投票' else '已投票' end as VoteStatus
                                   ,case v.IsSubmit when 1 then '是' when 0 then '否' else '' end as IsSubmitText
                               from prize p
                               inner join declaration d on d.adjustedprize = p.prizeid
                               INNER join expertgroup eg on eg.groupid in (
                                    select groupid from dbo.Fn_GetParentGroupByGroupID(d.ExpertReviewGroupID))
                               inner join groupmember gm on gm.GroupID = eg.GroupID
                               inner join expert e on e.ExpertID = gm.ExpertID
                               left  join Vote v on p.PrizeID = v.PrizeID and v.Votor = e.ExpertID
                                                and v.MultipleVoteRound = ISNULL(p.MultipleVoteRound, 1)
                               where p.PrizeID = ?
                               group by p.PrizeID, p.PrizeName, e.ExpertID, e.ExpertName, v.IsSubmit
                               order by e.ExpertName";
            return Dal.OleDbHlper.GetList<Dal.Models.Vote>(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@p.PrizeID", OleDbType.Integer) { Value = iPrizeID });
        }

        public static List<Dal.Models.Vote> GetExpertVoteList(OleDbConnection conn, int ActivityID, OleDbTransaction tran = null)
        {
            string strSql = " SELECT v.DeclarationID, v.PrizeID,DeclarationName,PrizeName,OrganizationName,vd.PrizeType,e.ExpertName,vd.UserID,";
            strSql += " SUM(FirstPrize) FirstPrize, SUM(SecondPrize) SecondPrize, SUM(ThirdPrize) ThirdPrize, SUM(Recommended) Recommended,SUM(NotRecommended) NotRecommended, SUM(SlowRating) SlowRating, SUM(TurnOut) TurnOut";
            strSql += " FROM VoteResult v";
            strSql += " left join V_Declaration vd on vd.DeclarationID = v.DeclarationID";
            strSql += " left join Expert e on e.UserID = vd.UserID";
            strSql += " group by v.DeclarationID, v.PrizeID,DeclarationName,PrizeName,OrganizationName,vd.PrizeType,e.ExpertName,vd.UserID";
            strSql += " order by e.ExpertName";
            return Dal.OleDbHlper.GetList<Dal.Models.Vote>(strSql, conn, CommandType.Text, tran);
        }

        ///// <summary>
        ///// 获取本次活动奖项下的所有投票结果
        ///// </summary>
        ///// <param name="iPrizeID"></param>
        ///// <param name="conn"></param>
        ///// <param name="tran"></param>
        ///// <returns></returns>
        //public static List<Dal.Models.Vote> GetActivityPrizeVoteList(int iPrizeID, OleDbConnection conn, OleDbTransaction tran = null)
        //{
        //    string strSql = "SELECT * FROM Vote WHERE PrizeID = ? ";
        //    return Dal.OleDbHlper.GetList<Dal.Models.Vote>(strSql, conn, CommandType.Text, tran
        //        , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID });
        //}

        /// <summary>
        /// 更改综合奖多伦投票轮次
        /// </summary>
        /// <param name="iScheduleID"></param>
        /// <param name="iMultipleVoteRound"></param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public static int UpdateMultipleVoteRound(int iPrizeID, int iMultipleVoteRound, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" update Prize set MultipleVoteRound = ? where PrizeID = ?");

            return Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                  , new OleDbParameter("@MultipleVoteRound", OleDbType.Integer) { Value = iMultipleVoteRound }
                  , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID });

        }
        //public static int UpdateScheduleVoteFinish(int iScheduleID, Boolean isFinish, OleDbConnection conn, OleDbTransaction tran = null)
        //{
        //    StringBuilder sbSql = new StringBuilder();
        //    sbSql.Append(" update Schedule set IsExpertReviewStart = ? where ScheduleID = ?");

        //    return Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //          , new OleDbParameter("@IsExpertReviewStart", OleDbType.Boolean) { Value = isFinish }
        //          , new OleDbParameter("@ScheduleID", OleDbType.Integer) { Value = iScheduleID });

        //}

        //public static void SubmitVote(int iVoteID, string strIsSubmit, OleDbConnection conn, OleDbTransaction tran = null)
        //{
        //    string strSql = " update Vote set IsSubmit = ? where VoteID = ? ";
        //    Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
        //        , new OleDbParameter("@IsSubmit", OleDbType.VarWChar) { Value = strIsSubmit }
        //        , new OleDbParameter("@VoteID", OleDbType.Integer) { Value = iVoteID });
        //}

        public static void SubmitVote(Dal.Models.Expert expert, Dal.Models.Prize prize, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder strSql = new StringBuilder();

            strSql.Append("  Update Vote set IsSubmit = 1 ");
            strSql.Append(" WHERE PrizeID = ? and MultipleVoteRound = ? and UserID = ?  ");

            Dal.OleDbHlper.ExecuteNonQuery(strSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = prize.PrizeID.Value }
                , new OleDbParameter("@MultipleVoteRound", OleDbType.Integer) { Value = (prize.MultipleVoteRound ?? 1) }
                , new OleDbParameter("@UserID", OleDbType.Integer) { Value = expert.UserID.Value });
        }

//        /// <summary>
//        /// 修改中....
//        /// </summary>
//        /// <param name="conn"></param>
//        /// <param name="tran"></param>
//        public static List<Dal.Models.Vote> GetNeedRevoteSetVoteList(OleDbConnection conn, OleDbTransaction tran = null)
//        {
//            string strSql = @"select DeclarationID, VoteRound, VoteCode, PrizeID ,MultipleVoteRound ,Count(VoteCode) as VoteNum from Vote
//                            where IsSubmit = '1' Group By  DeclarationID, VoteRound, VoteCode, PrizeID, MultipleVoteRound  ORDER BY VoteNum DESC";
//            return Dal.OleDbHlper.GetList<Dal.Models.Vote>(strSql, conn, CommandType.Text, tran);
//        }
//        public static List<Dal.Models.Vote> GetVoteList(int iActivityID, OleDbConnection conn, OleDbTransaction tran = null)
//        {
//            string strSql = @"select * from Vote v inner
//                                join Prize p on v.PrizeID = P.PrizeID
//                                INNER JOIN Specialty s on s.SpecialtyID = p.SpecialtyID
//                                inner join Activity a on s.ActivityID = a.ActivityID where a.ActivityID = ?";
//            return Dal.OleDbHlper.GetList<Dal.Models.Vote>(strSql, conn, CommandType.Text, tran
//                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });
//        }

        //public static List<Dal.Models.VoteResult> GetVoteResult(int iPrizeID, OleDbConnection conn, OleDbTransaction tran = null)
        //{
        //    Dal.Models.Prize prize = Prize.GetPrize(iPrizeID, conn, tran);
        //    string strSql = "";
        //    if (prize.VoteType == "2203")
        //    {
        //        strSql = "update Vote set PrizeLevelCode = '' where PrizeID = ? ;";
        //    }
        //    else if (prize.VoteType == "2202")
        //    {
        //        strSql = "update Vote set PrizeLevelCode = '' where PrizeID = ? and MultipleVoteRound = 1;";
        //    }
        //    Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
        //        , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID });

        //    return Dal.OleDbHlper.GetList<Dal.Models.VoteResult>("select * from dbo.Fn_GetVoteResult(?, ?)"
        //        , conn, CommandType.Text, tran
        //        , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID }
        //        , new OleDbParameter("@MultipleVoteRound", OleDbType.Integer) { Value = prize.MultipleVoteRound });
        //}

        public static void DeleteVoteResult(int iPrizeID, int iMultipleVoteRound, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "delete from MidVoteResult where PrizeID = ? and MultipleVoteRound = ? ";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID }
                , new OleDbParameter("@MultipleVoteRound", OleDbType.Integer) { Value = iMultipleVoteRound });
        }

        public static List<Dal.Models.VoteResult> GetVoteResult(int iPrizeID, int iMultipleVoteRound, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("select * from MidVoteResult where PrizeID = ? and MultipleVoteRound = ? ");
            sbSql.Append(" order by Recommended desc, RevoteNumber desc ");

            List<Dal.Models.VoteResult> lstVoteResult = Dal.OleDbHlper.GetList<Dal.Models.VoteResult>(
                sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID }
                , new OleDbParameter("@MultipleVoteRound", OleDbType.Integer) { Value = iMultipleVoteRound });

            if (lstVoteResult != null && lstVoteResult.Count > 0)
            {
                return lstVoteResult;
            }
            else
            {
                return Dal.OleDbHlper.GetList<Dal.Models.VoteResult>("Proc_GetVoteResult", conn, CommandType.StoredProcedure, tran
                    , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID }
                    , new OleDbParameter("@MultipleVoteRound", OleDbType.Integer) { Value = iMultipleVoteRound });
            }
        }


        public static List<Dal.Models.Vote> GetVoteList(
            string strDeclarationName, string strOrganizationName, string intPrizeIDs,
            string intPrizeType, int ActivityID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " SELECT v.*,DeclarationName,PrizeName,OrganizationName,vd.PrizeType FROM VoteResult v";
            strSql += " left join V_Declaration vd on vd.DeclarationID = v.DeclarationID";
            strSql += " where v.VoteType = '0502'";
            if (!string.IsNullOrEmpty(strDeclarationName))
            {
                strSql += " and DeclarationName like '%" + strDeclarationName + "%'";
            }
            if (!string.IsNullOrEmpty(strOrganizationName))
            {
                strSql += " and OrganizationName like '%" + strOrganizationName + "%'";
            }
            if (!string.IsNullOrEmpty(intPrizeIDs))
            {
                strSql += " and v.PrizeID in (" + intPrizeIDs + ")";
            }
            if (!string.IsNullOrEmpty(intPrizeType))
            {
                strSql += " and PrizeTypeCode in (" + intPrizeType + ")";
            }
            return Dal.OleDbHlper.GetList<Dal.Models.Vote>(strSql, conn, CommandType.Text, tran);
        }

        public static List<Dal.Models.Vote> GetAllVoteList(string strDeclarationName, string strOrganizationName, string intPrizeIDs, string intPrizeType, int ActivityID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " SELECT  v.DeclarationID, v.PrizeID, SUM(FirstPrize) FirstPrize, SUM(SecondPrize) SecondPrize, SUM(ThirdPrize) ThirdPrize, SUM(Recommended) Recommended,";
            strSql += " SUM(NotRecommended) NotRecommended, SUM(SlowRating) SlowRating, SUM(TurnOut) TurnOut, DeclarationName,PrizeName,OrganizationName,vd.PrizeType FROM VoteResult v";
            strSql += " left join V_Declaration vd on vd.DeclarationID = v.DeclarationID";
            strSql += " group by v.DeclarationID, v.PrizeID,DeclarationName,PrizeName,OrganizationName,vd.PrizeType";
            if (!string.IsNullOrEmpty(strDeclarationName))
            {
                strSql += " and DeclarationName like '%" + strDeclarationName + "%'";
            }
            if (!string.IsNullOrEmpty(strOrganizationName))
            {
                strSql += " and OrganizationName like '%" + strOrganizationName + "%'";
            }
            if (!string.IsNullOrEmpty(intPrizeIDs))
            {
                strSql += " and v.PrizeID in (" + intPrizeIDs + ")";
            }
            if (!string.IsNullOrEmpty(intPrizeType))
            {
                strSql += " and PrizeTypeCode in (" + intPrizeType + ")";
            }
            return Dal.OleDbHlper.GetList<Dal.Models.Vote>(strSql, conn, CommandType.Text, tran);
        }

        public static List<Dal.Models.Vote> GetReVoteList(string strDeclarationName, string strOrganizationName, string intPrizeIDs, string intPrizeType, int ActivityID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select CONVERT(int, rank() OVER (ORDER BY a.num desc)) AS Ordinal,";
            strSql += " DeclarationID, PrizeID, FirstPrize, SecondPrize, ThirdPrize, Recommended, NotRecommended, SlowRating, TurnOut,DeclarationName,PrizeName,OrganizationName,PrizeType from ";
            strSql += " (SELECT v.DeclarationID, v.PrizeID, FirstPrize, SecondPrize, ThirdPrize, Recommended, NotRecommended, SlowRating, TurnOut,DeclarationName,PrizeName,OrganizationName,vd.PrizeType,";
            strSql += " (FirstPrize*(select COUNT(VoteID) from Vote where PrizeID = v.PrizeID)*(select COUNT(VoteID) from Vote where PrizeID = v.PrizeID) + ";
            strSql += " SecondPrize*(select COUNT(VoteID) from Vote where PrizeID = v.PrizeID)+ThirdPrize+Recommended+NotRecommended+SlowRating+TurnOut) as num";
            strSql += " FROM VoteResult v";
            strSql += " left join V_Declaration vd on vd.DeclarationID = v.DeclarationID";
            strSql += " where v.VoteType = '0502'";
            if (!string.IsNullOrEmpty(strDeclarationName))
            {
                strSql += " and DeclarationName like '%" + strDeclarationName + "%'";
            }
            if (!string.IsNullOrEmpty(strOrganizationName))
            {
                strSql += " and OrganizationName like '%" + strOrganizationName + "%'";
            }
            if (!string.IsNullOrEmpty(intPrizeIDs))
            {
                strSql += " and v.PrizeID in (" + intPrizeIDs + ")";
            }
            if (!string.IsNullOrEmpty(intPrizeType))
            {
                strSql += " and PrizeTypeCode in (" + intPrizeType + ")";
            }
            strSql += " ) as a";
            return Dal.OleDbHlper.GetList<Dal.Models.Vote>(strSql, conn, CommandType.Text, tran);
        }

        public static List<Dal.Models.Vote> GetVoteDetail(int DeclarationID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "SELECT distinct v.VoteCode,s.ConstantValue as VoteType,";
            strSql += "(select count(VoteCode) FROM Vote vt where vt.VoteCode = v.VoteCode and vt.DeclarationID = v.DeclarationID) as VoteNum,";
            strSql += "(select stuff((select ','+ d.ExpertName from";
            strSql += "(select e.ExpertName from Expert e where e.UserID in (select UserID from Vote uv where uv.DeclarationID = v.DeclarationID and uv.VoteCode = v.VoteCode))as d";
            strSql += " for xml path('')),1,1,'')) as ExpertName";
            strSql += " FROM Vote v";
            strSql += " left join SysConstant s on s.ConstantCode = v.VoteCode";
            if (DeclarationID > 0)
            {
                strSql += " where v.DeclarationID=" + DeclarationID;
            }

            return Dal.OleDbHlper.GetList<Dal.Models.Vote>(strSql, conn, CommandType.Text, tran);
        }

        public static List<Dal.Models.Declaration> GetReVoteList(int intPrizeID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " SELECT d.*,v.VoteCode FROM ReVoteDeclaration AS rvd";
            strSql += " LEFT OUTER JOIN ReVoteBatch AS rvb ON rvb.ReVoteBatchID = rvd.ReVoteBatchID";
            strSql += " left join V_Declaration d on d.DeclarationID = rvd.DeclarationID";
            strSql += " left join Vote v on v.PrizeID=rvb.PrizeID and v.VoteRound = rvb.Round and v.MultipleVoteRound = rvb.Round and v.VoteType='0503' and v.DeclarationID = d.DeclarationID";
            strSql += " where rvb.PrizeID =" + intPrizeID;
            return Dal.OleDbHlper.GetList<Dal.Models.Declaration>(strSql, conn, CommandType.Text, tran);
        }

        //管理员选定等票复投的项目
        public static int SetReVote(Dal.Models.ReVoteBatch ReVoteBatch, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "insert into ReVoteBatch(PrizeID, PrizeLevelCode,Round) values (?, ?,(select ISNULL(max(Round),0) +1 from ReVoteBatch))";
            int rs = Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = ReVoteBatch.PrizeID.Value }
                , new OleDbParameter("@PrizeLevelCode", OleDbType.VarWChar) { Value = ReVoteBatch.PrizeLevelCode });
            int intReVoteBatch = 0;
            if (rs > 0)
            {
                intReVoteBatch = GetReVoteBatchID(conn, tran);
            }
            return intReVoteBatch;
        }

        public static int SetReVoteDeclaration(Dal.Models.ReVoteDeclaration ReVoteDeclaration, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "insert into ReVoteDeclaration(ReVoteBatchID, DeclarationID) values (?, ?)";
            return Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@ReVoteBatch", OleDbType.Integer) { Value = ReVoteDeclaration.ReVoteBatchID.Value }
                , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = ReVoteDeclaration.DeclarationID });
        }

        //获取最大的ReVoteBatch
        public static int GetReVoteBatchID(OleDbConnection conn, OleDbTransaction tran = null)
        {
            int ReVoteBatchID = 0;
            string strSql = "select max(ReVoteBatchID) from ReVoteBatch";
            object obj = Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran);
            if (obj != null)
            {
                ReVoteBatchID = Convert.ToInt32(obj);
            }
            return ReVoteBatchID;
        }

        //获取最大的ReVoteBatch的所有数据
        public static Dal.Models.ReVoteBatch GetReVoteBatch(int prizeId, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "SELECT PrizeID, PrizeLevelCode,Round FROM ReVoteBatch";
            strSql += " where Round= (select max(Round) from ReVoteBatch where PrizeID=" + prizeId + ")";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran);
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.ReVoteBatch>(reader);
        }

        //用项目编号获取等票复投_批次编号
        //public static int GetReVoteBatchID(int DeclarationID, OleDbConnection conn, OleDbTransaction tran = null)
        //{
        //    int ReVoteBatchID = 0;
        //    string strSql = "select ReVoteBatchID from ReVoteDeclaration where DeclarationID=" + DeclarationID;
        //    object obj = Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran);
        //    if (obj != null)
        //    {
        //        ReVoteBatchID = Convert.ToInt32(obj);
        //    }
        //    return ReVoteBatchID;
        //}

        public static void Ballot(Dal.Models.Vote Vote, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();

            sbSql.Append(" select * from Vote where DeclarationID = ? and Votor = ? and MultipleVoteRound = ? and RevoteRound = ? ");

            Dal.Models.Vote voteOriginal = Dal.Models.BaseEntity.GetEntity<Dal.Models.Vote>(
                Dal.OleDbHlper.ExecuteReader(sbSql.ToString(), conn, CommandType.Text, tran
                    , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = Vote.DeclarationID.Value }
                    , new OleDbParameter("@Votor", OleDbType.Integer) { Value = Vote.Votor.Value }
                    , new OleDbParameter("@MultipleVoteRound", OleDbType.Integer) { Value = Vote.MultipleVoteRound ?? 1 }
                    , new OleDbParameter("@RevoteRound", OleDbType.Integer) { Value = Vote.RevoteRound ?? 0 }
                )
            );

            if (voteOriginal != null)
            {
                if (voteOriginal.IsSubmit ?? false)
                {
                    sbSql.Clear();
                    sbSql.Append(" Update Vote set IsSubmit = 0 ");
                    sbSql.Append(" WHERE PrizeID = ? and MultipleVoteRound = ? and UserID = ? ");

                    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                        , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = Vote.PrizeID.Value }
                        , new OleDbParameter("@MultipleVoteRound", OleDbType.Integer) { Value = Vote.MultipleVoteRound ?? 1 }
                        , new OleDbParameter("@UserID", OleDbType.VarWChar) { Value = Vote.UserID.Value });
                }

                sbSql.Clear();
                sbSql.Append(" update Vote set VoteCode = ?, PrizeLevelCode = ?, VoteTime = GETDATE() where VoteID = ? ");
                Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                    , new OleDbParameter("@VoteCode", OleDbType.VarWChar) { Value = Vote.VoteCode }
                    , new OleDbParameter("@PrizeLevelCode", OleDbType.VarWChar) { Value = Vote.PrizeLevelCode }
                    , new OleDbParameter("@VoteID", OleDbType.Integer) { Value = voteOriginal.VoteID.Value });
            }
            else
            {
                sbSql.Clear();
                sbSql.Append(" INSERT INTO Vote( ");
                sbSql.Append(" UserID, DeclarationID, VoteType, VoteRound, ");
                sbSql.Append(" VoteCode, PrizeID, PrizeLevelCode, Votor, ");
                sbSql.Append(" IsSubmit, VoteTime, MultipleVoteRound, RevoteRound) ");
                sbSql.Append(" values( ?, ?, ?, ?, ");
                sbSql.Append(" ?, ?, ?, ?, ");
                sbSql.Append(" 0, GETDATE(), ?, ? ) ");
                Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                    , new OleDbParameter("@UserID", OleDbType.Integer) { Value = Vote.UserID.Value }
                    , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = Vote.DeclarationID.Value }
                    , new OleDbParameter("@VoteType", OleDbType.VarWChar) { Value = Vote.VoteType }
                    , new OleDbParameter("@VoteRound", OleDbType.Integer) { Value = Vote.MultipleVoteRound ?? 1 }
                    , new OleDbParameter("@VoteCode", OleDbType.VarWChar) { Value = Vote.VoteCode }
                    , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = Vote.PrizeID.Value }
                    , new OleDbParameter("@PrizeLevelCode", OleDbType.VarWChar) { Value = Vote.PrizeLevelCode }
                    , new OleDbParameter("@Votor", OleDbType.Integer) { Value = Vote.Votor.Value }
                    , new OleDbParameter("@MultipleVoteRound", OleDbType.Integer) { Value = Vote.MultipleVoteRound ?? 1 }
                    , new OleDbParameter("@RevoteRound", OleDbType.Integer) { Value = Vote.RevoteRound ?? 0 }
                );
            }
        }

        public static void BatchBallot(Dal.Models.Vote vote, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();

            if ((vote.MultipleVoteRound ?? 1) == 1)
            {
                sbSql.Append(" INSERT INTO Vote( ");
                sbSql.Append(" UserID, DeclarationID, VoteType, VoteRound, ");
                sbSql.Append(" VoteCode, PrizeID, PrizeLevelCode, Votor, ");
                sbSql.Append(" IsSubmit, VoteTime, MultipleVoteRound, RevoteRound) ");
                sbSql.Append(" SELECT ?, d.DeclarationID, '0502', isnull(p.MultipleVoteRound, 1), ");
                sbSql.Append(" ?, p.PrizeID, ?, ?, ");
                sbSql.Append(" 0, GETDATE(), isnull(p.MultipleVoteRound, 1), isnull(p.RevoteRound, 0) ");
                sbSql.Append(" FROM  Declaration d ");
                sbSql.Append(" inner join prize p on p.PrizeID = d.AdjustedPrize ");
                sbSql.Append(" LEFT JOIN Vote AS v ON v.DeclarationID = d.DeclarationID and v.UserID = ? ");
                sbSql.Append(" and v.MultipleVoteRound = isnull(p.MultipleVoteRound, 1) ");
                sbSql.Append(" and isnull(v.RevoteRound, 0) = isnull(p.RevoteRound, 0) ");
                sbSql.Append(" WHERE d.PrizeID = ? and d.DeclarationStatus = '1803' and v.VoteID is null; ");

                Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                    , new OleDbParameter("@UserID", OleDbType.Integer) { Value = vote.UserID.Value }
                    , new OleDbParameter("@VoteCode", OleDbType.VarWChar) { Value = vote.VoteCode }
                    , new OleDbParameter("@PrizeLevelCode", OleDbType.VarWChar) { Value = vote.PrizeLevelCode }
                    , new OleDbParameter("@Votor", OleDbType.Integer) { Value = vote.Votor.Value }
                    , new OleDbParameter("@UserID", OleDbType.Integer) { Value = vote.UserID.Value }
                    , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = vote.PrizeID.Value });
            }
            else
            {
                sbSql.Append(" INSERT INTO Vote( ");
                sbSql.Append(" UserID, DeclarationID, VoteType, VoteRound, ");
                sbSql.Append(" VoteCode, PrizeID, PrizeLevelCode, Votor, ");
                sbSql.Append(" IsSubmit, VoteTime, MultipleVoteRound, RevoteRound) ");
                sbSql.Append(" SELECT ?, d.DeclarationID, '0502', isnull(p.MultipleVoteRound, 1), ");
                sbSql.Append(" ?, p.PrizeID, ?, ?, ");
                sbSql.Append(" 0, GETDATE(), isnull(p.MultipleVoteRound, 1), isnull(p.RevoteRound, 0) ");
                sbSql.Append(" FROM  VoteResult d ");
                sbSql.Append(" inner join prize p on p.PrizeID = d.PrizeID ");
                sbSql.Append(" LEFT JOIN Vote AS v ON v.DeclarationID = d.DeclarationID and v.UserID = ? ");
                sbSql.Append(" and v.MultipleVoteRound = isnull(p.MultipleVoteRound, 1) ");
                sbSql.Append(" and isnull(v.RevoteRound, 0) = isnull(p.RevoteRound, 0) ");
                sbSql.Append(" WHERE d.PrizeID = ? ");
                sbSql.Append(" and d.MultipleVoteRound = (p.MultipleVoteRound - 1) and v.VoteID is null; ");

                Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                    , new OleDbParameter("@UserID", OleDbType.Integer) { Value = vote.UserID.Value }
                    , new OleDbParameter("@VoteCode", OleDbType.VarWChar) { Value = vote.VoteCode }
                    , new OleDbParameter("@PrizeLevelCode", OleDbType.VarWChar) { Value = vote.PrizeLevelCode }
                    , new OleDbParameter("@Votor", OleDbType.Integer) { Value = vote.Votor.Value }
                    , new OleDbParameter("@UserID", OleDbType.Integer) { Value = vote.UserID.Value }
                    , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = vote.PrizeID.Value });
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="iPrizeID"></param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public static List<Dal.Models.VoteResult> GetSelectedResult(int iPrizeID, int iMultipleVoteRound, OleDbConnection conn, OleDbTransaction tran=null)
        {
            StringBuilder sbSql = new StringBuilder();
             sbSql.Append(" select d.DeclarationName, d.OrganizationName, vr.* ");
             sbSql.Append(" from VoteResult vr "); 
             sbSql.Append(" inner join V_Declaration d on d.DeclarationID=vr.DeclarationID ");
             sbSql.Append(" inner join Prize p on p.PrizeID = d.AdjustedPrize ");
             sbSql.Append(" where vr.PrizeID = ? and vr.MultipleVoteRound = isnull(p.MultipleVoteRound, 1) and vr.MultipleVoteRound = ?");
             return Dal.OleDbHlper.GetList<Dal.Models.VoteResult>(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID }
                , new OleDbParameter("@MultipleVoteRound", OleDbType.Integer) { Value = iMultipleVoteRound});

        }

        public static void SetVoteResult(Dal.Models.Prize prize, string strSelectedDeclarationID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" delete from VoteResult where PrizeID = ? and MultipleVoteRound = ? ");
            Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = prize.PrizeID.Value }
                , new OleDbParameter("@MultipleVoteRound", OleDbType.Integer) { Value = prize.MultipleVoteRound ?? 1 });

            if (!string.IsNullOrEmpty(strSelectedDeclarationID))
            {
                sbSql.Clear();
                sbSql.Append(" INSERT INTO VoteResult(Ordinal, DeclarationID,PrizeID,MultipleVoteRound ");
                sbSql.Append(" ,FirstPrize,SecondPrize,ThirdPrize,Recommended,NotRecommended,SlowRating,TurnOut) ");
                sbSql.Append(" select RANK() over(order by FirstPrize desc, SecondPrize desc, ThirdPrize desc, Recommended desc) Ordinal, * from ( ");
                sbSql.Append(" select d.DeclarationID, p.PrizeID, ISNULL(p.MultipleVoteRound, 1) MultipleVoteRound ");
                sbSql.Append(" , sum(CASE WHEN v.VoteCode = '0601' AND v.PrizeLevelCode = '0401' THEN 1 ELSE 0 END) FirstPrize  ");
                sbSql.Append(" , sum(CASE WHEN v.VoteCode = '0601' AND v.PrizeLevelCode = '0402' THEN 1 ELSE 0 END) SecondPrize  ");
                sbSql.Append(" , sum(CASE WHEN v.VoteCode = '0601' AND v.PrizeLevelCode = '0403' THEN 1 ELSE 0 END) ThirdPrize  ");
                sbSql.Append("  , sum(CASE WHEN v.VoteCode = '0601' THEN 1 ELSE 0 END) Recommended  ");
                sbSql.Append("  , sum(CASE WHEN v.VoteCode = '0602' THEN 1 ELSE 0 END) NotRecommended  ");
                sbSql.Append("  , sum(CASE WHEN v.VoteCode = '0603' THEN 1 ELSE 0 END) SlowRating  ");
                sbSql.Append("  , sum(CASE WHEN v.VoteCode = '0604' THEN 1 ELSE 0 END) TurnOut  ");
                sbSql.Append("  from Declaration d  ");
                sbSql.Append("  inner join Vote v on v.DeclarationID=d.DeclarationID ");
                sbSql.Append("  inner join Prize p on p.PrizeID = d.AdjustedPrize  ");
                sbSql.Append("  inner join Organization o on o.OrganizationID = d.OrganizationID  ");
                sbSql.Append("  inner join SysConstant st on st.ConstantCode = p.PrizeTypeCode  ");
                sbSql.Append("  inner join SysConstant sv on sv.ConstantCode = p.VoteType  ");
                sbSql.AppendFormat("  where p.PrizeID = ? and d.DeclarationID in ({0}) ", strSelectedDeclarationID);
                sbSql.Append("  group by d.DeclarationID, p.PrizeID,  ISNULL(p.MultipleVoteRound, 1))t ");

                Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                  , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = prize.PrizeID.Value });
            }
        }

        public static int DeleteAwardResult(int PrizeID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "delete from AwardResult where   PrizeID = ? ";
            return Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = PrizeID });
        }

        public static void SetAwardResult(int iDeclarationID, string strAwardCode, OleDbConnection conn, OleDbTransaction tran = null)
        {
            Dal.OleDbHlper.ExecuteNonQuery("Pr_SetAwardResult", conn, CommandType.StoredProcedure, tran
                , new OleDbParameter("@DeclarateID", OleDbType.Integer) { Value = iDeclarationID }
                , new OleDbParameter("@AwardCode", OleDbType.VarWChar) { Value = strAwardCode });
        }

        public static void SetInnerOrdinal(int iDeclarationID, int iInnerOrdinal, OleDbConnection conn, OleDbTransaction tran = null)
        {
            Dal.OleDbHlper.ExecuteNonQuery("Pr_SetInnerOrdinal", conn, CommandType.StoredProcedure, tran
                , new OleDbParameter("@DeclarateID", OleDbType.Integer) { Value = iDeclarationID }
                , new OleDbParameter("@InnerOrdinal", OleDbType.Integer) { Value = iInnerOrdinal });
        }

        //public static void SetAwardResult(int iPrizeID, OleDbConnection conn, OleDbTransaction tran = null)
        //{
        //    StringBuilder sbSql = new StringBuilder();
        //    sbSql.Append(" delete from AwardResult where prizeID = ? ;");
        //    sbSql.Append(" insert into AwardResult (");
        //    sbSql.Append(" PrizeID, DeclarationID, Idx, Ordinal,");
        //    sbSql.Append(" FirstPrize, SecondPrize, ThirdPrize, Recommended, NotRecommended, SlowRating, TurnOut,");
        //    sbSql.Append(" OutRound, VoteCode, PrizeLevelCode, AwardCode) ");
        //    sbSql.Append(" select PrizeID, DeclarationID, Idx, Ordinal,");
        //    sbSql.Append(" FirstPrize, SecondPrize, ThirdPrize, Recommended, NotRecommended, SlowRating, TurnOut,");
        //    sbSql.Append(" OutRound, VoteCode, PrizeLevelCode, AwardCode ");
        //    sbSql.Append(" from MidAwardResult where prizeID = ? ");

        //    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //       , new OleDbParameter("@prizeID", OleDbType.Integer) { Value = iPrizeID }
        //       , new OleDbParameter("@prizeID", OleDbType.Integer) { Value = iPrizeID });
        //}

        //public static int SetAwardResult(Dal.Models.AwardResult awardResult, OleDbConnection conn, OleDbTransaction tran = null)
        //{
        //    if (awardResult.VoteCode == "0401")
        //    {
        //        //throw new Exception("请设定投票结果!");
        //    }

        //    string strSql = "insert into AwardResult (PrizeID, DeclarationID, Idx, Ordinal, FirstPrize, "
        //         + "SecondPrize, ThirdPrize, Recommended, NotRecommended, SlowRating, TurnOut, OutRound, VoteCode, PrizeLevelCode, AwardCode) "
        //         + " values (" + awardResult.PrizeID + " , " + awardResult.DeclarationID + " , " + awardResult.Idx 
        //         + " , " + awardResult.Ordinal + " , " + awardResult.FirstPrize + " , " + awardResult.SecondPrize
        //         + " , " + awardResult.ThirdPrize + " , " + awardResult.Recommended + " , " + awardResult.NotRecommended
        //         + " , " + awardResult.SlowRating + " , " + awardResult.TurnOut + " , " + " null "
        //         + " , " + (awardResult.VoteCode == null ? " null " : ("'" + awardResult.VoteCode + "'")) + " , "
        //         + (awardResult.PrizeLevelCode == null ? " null " : ("'" + awardResult.PrizeLevelCode + "'"))
        //         + "," + (string.IsNullOrEmpty(awardResult.AwardCode) ? " null " : "'" + awardResult.AwardCode + "'")
        //         + " ) ";

        //    return Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran);
        //}

        public static Dal.Models.AwardResult GetAwardResult(int iDeclarationID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "select * from AwardResult where DeclarationID = ? ";
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.AwardResult>(Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarationID }));
        }

        public static List<Dal.Models.AwardResult> GetAwardResultReport(int iPrizeID, OleDbConnection conn)
        {
            string strSql = " select * from AwardResult m  "
                + "inner join V_Declaration d on d.DeclarationID = m.DeclarationID where m.PrizeID = ?"
                + " order by m.AwardCode, m.InnerOrdinal";
            List<Dal.Models.AwardResult> lstResult = Dal.OleDbHlper.GetList<Dal.Models.AwardResult>(strSql, conn, CommandType.Text, null
                , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID });

            return lstResult;
        }

        public static List<Dal.Models.AwardResult> GetPrizeAwardResult(int iPrizeID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            List<Dal.Models.AwardResult> lstResult = GetAwardResultReport(iPrizeID, conn);

            if (lstResult.Count > 0)
            {
                return lstResult;
            }

            lstResult = Dal.OleDbHlper.GetList<Dal.Models.AwardResult>(
                "Proc_GetAwardResult", conn, CommandType.StoredProcedure, null
               , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID });

            return lstResult;
        }

        //public static string GetAwardsStatus(string VoteCode, string PrizeLevelCode)
        //{
        //    if (VoteCode == "0601" && PrizeLevelCode == "0401")
        //    {
        //        return "一等奖";
        //    }
        //    else if (VoteCode == "0601" && PrizeLevelCode == "0402")
        //    {
        //        return "二等奖";
        //    }
        //    else if (VoteCode == "0601" && PrizeLevelCode == "0403")
        //    {
        //        return "三等奖";
        //    }
        //    else if (VoteCode == "0601")
        //    {
        //        return "获奖";
        //    }
        //    else
        //    {
        //        return "不入围";
        //    }
        //}

        //public static void ResetResultIndex(int iPrizeID, string strAward, OleDbConnection conn, OleDbTransaction tran)
        //{
        //    StringBuilder sbSql = new StringBuilder();

        //    sbSql.Append(" update m set ");
        //    sbSql.Append(" m.idx = t.idx, m.Ordinal = t.Ordinal ");
        //    sbSql.AppendFormat(" from {0} m inner join ( ", strAward);
        //    sbSql.Append("     select ROW_NUMBER() over(order by FirstPrize desc, SecondPrize desc, ThirdPrize desc, Recommended desc) idx ");
        //    sbSql.Append("       , RANK() over(order by FirstPrize desc, SecondPrize desc, ThirdPrize desc, Recommended desc) Ordinal,  ");
        //    sbSql.Append("         PrizeID, DeclarationID,FirstPrize,SecondPrize,ThirdPrize ");
        //    sbSql.Append("          , Recommended, NotRecommended, SlowRating, TurnOut  ");
        //    sbSql.AppendFormat("     from {0} where PrizeID = ? ", strAward);
        //    sbSql.Append(" ) t on t.PrizeID = m.PrizeID and t.DeclarationID = m.DeclarationID;  ");

        //    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID });

        //}
    }
}
