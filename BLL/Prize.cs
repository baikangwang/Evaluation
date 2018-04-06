using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Linq;

namespace BLL
{
    public class Prize
    {
        public static Dal.Models.Prize GetPrize(
            int iPrizeID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from V_Prize  where PrizeID = ? ";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Prize>(reader);
        }

        public static Dal.Models.Prize GetPrize(
            string strPrizeName, int iSpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();

            sbSql.Append(" select * from V_Prize where SpecialtyID = ? and PrizeName = ? ");
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID }
                , new OleDbParameter("@PrizeName", OleDbType.VarWChar) { Value = strPrizeName });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Prize>(reader);
        }

        public static string GetPrizeCode(int iSpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            Dal.Models.Specialty specialty = BLL.Specialty.GetSpecialty(iSpecialtyID, conn);

            string strSql = "select max(PrizeCode) from Prize where SpecialtyID = ? ";

            object objPrizeCode = null;
            objPrizeCode = Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID });          

            return (Convert.ToInt32(objPrizeCode == null || objPrizeCode == DBNull.Value
                ? specialty.SpecialtyCode : objPrizeCode) + 1).ToString("D8");
        }

        /// <summary>
        /// 获取专业的奖项
        /// </summary>
        /// <param name="iSpecialtyID"></param>
        /// <returns></returns>
        public static List<Dal.Models.Prize> GetPrizeList(
            int iSpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from V_Prize  where SpecialtyID = ?  order by Ordinal ";

            return Dal.OleDbHlper.GetList<Dal.Models.Prize>(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID });
        }

        //受专业限制
        public static List<Dal.Models.Prize> GetPrizeListBySpecialty(
            string SpecialtyIDs, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from V_Prize ";
            if (!string.IsNullOrEmpty(SpecialtyIDs))
            {
                strSql += " where SpecialtyID in (" + SpecialtyIDs + ")";
            }
            strSql += " order by Ordinal  ";
            return Dal.OleDbHlper.GetList<Dal.Models.Prize>(strSql, conn, CommandType.Text, tran);
        }

        /// <summary>
        /// 根据用户身份获取奖项列表
        /// </summary>
        /// <param name="user">用户</param>
        /// <param name="strActivityType">当前活动编号，目前已不用，可为空</param>
        /// <param name="strSpecialtyIDs">逗号分隔的专业编号，可为空</param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public static List<Dal.Models.Prize> GetPrizeList(
            Dal.Models.UserInfo user, string strActivityType,
            string strSpecialtyIDs, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            string strSql = "";

            if (user == null)
            {
                List<Dal.Models.Prize> lst = new List<Dal.Models.Prize>();
                return lst;
            }
            else
            {
                strSql = " select * from V_Prize p where ActivityID = dbo.Fn_GetCurrentActivityID() and dbo.fn_IsSpecialtyInAuthority(p.SpecialtyID, ?) = 1 ";
                if (!string.IsNullOrEmpty(strSpecialtyIDs))
                {
                    strSql += " AND p.SpecialtyID in (" + strSpecialtyIDs + ")";
                }

                strSql += " order by p.SpecialtyTotalOrdinal, p.Ordinal ";
                return Dal.OleDbHlper.GetList<Dal.Models.Prize>(strSql, conn, CommandType.Text, tran
                    , new OleDbParameter("@UserID", OleDbType.Integer) { Value = user.UserID });
            }
        }

        /// <summary>
        /// 获取专业的最大奖项序号
        /// </summary>
        /// <param name="iSpecialtyID"></param>
        /// <returns></returns>
        public static int Count(int iSpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select COUNT(*) from Prize where SpecialtyID = ? ";

            int? iResult = Common.ToInt32(Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran
               , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID }));

            return iResult ?? 0;
        }
        public static int SearchSpecialtyChild(
            int iSpecialtyID, int iActivityID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "select count(*) from Specialty where ActivityID = ? and ParentID = ?";
            int? iResult = Common.ToInt32(Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran
                        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID },
                          new OleDbParameter("@ParentID", OleDbType.Integer) { Value = iSpecialtyID }));
            return iResult ?? 0;
        }

        public static int CheckPrize(Dal.Models.Prize prize, OleDbConnection conn, OleDbTransaction tran)
        {
            if (string.IsNullOrEmpty(prize.PrizeName) || prize.SpecialtyID == null || prize.SpecialtyID == null)
            {
                throw new Exception("参数错误！");
            }
            
            Dal.Models.Specialty specialty = Specialty.GetSpecialty(prize.SpecialtyID.Value, conn, tran);

            // 所选专业不存在
            if (specialty == null)
            {
                throw new Exception("所选专业不存在！");
            }
            if ((specialty.ChildCount??0)  > 0) 
            {
                throw new Exception("奖项创建失败,该专业下已存在子专业,无法创建奖项。");
            }

            // 同一专业中，奖项不允许重名
            Dal.Models.Prize prizeOriginal = GetPrize(prize.PrizeName, prize.SpecialtyID.Value, conn, tran);
            if (prize.PrizeID != prizeOriginal.PrizeID)
            {
                throw new Exception("同一专业中，奖项不允许重名！");
            }

            //奖项类别为空时，默认类别为综合奖
            if (string.IsNullOrEmpty(prize.PrizeTypeCode) ||
                !(new string[] { "0301", "0302", "0303", "0304" }).Contains(prize.PrizeTypeCode))
            {
                prize.PrizeTypeCode = "0301";
            }

            if (string.IsNullOrEmpty(prize.TemplateCode))
            {
                prize.TemplateCode = Specialty.GetTempletCode(prize.SpecialtyID.Value, conn, tran);
            }

            return specialty.ActivityID.Value;
        }

        public static int StopPrizeVote(Dal.Models.Prize prize, OleDbConnection conn, OleDbTransaction tran)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" UPDATE Prize ");
            sbSql.Append("   SET  IsStopVote = ? ");
            sbSql.Append("  WHERE PrizeID = ? ");

            int iResult = Dal.OleDbHlper.ExecuteNonQuery(
                sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@IsStopVote", OleDbType.Boolean)
                {
                    Value = prize.IsStopVote
                }
                , new OleDbParameter("@PrizeID", OleDbType.Integer)
                {
                    Value = prize.PrizeID
                }
            );
            return iResult;
        }

        public static int EnablePrizeVote(Dal.Models.Prize prize, OleDbConnection conn, OleDbTransaction tran)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" UPDATE Prize ");
            sbSql.Append("   SET  IsStopVote = ? ");
            sbSql.Append("  WHERE PrizeID = ? ");

            int iResult = Dal.OleDbHlper.ExecuteNonQuery(
                sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@IsStopVote", OleDbType.Boolean)
                {
                    Value = false
                }
                , new OleDbParameter("@PrizeID", OleDbType.Integer)
                {
                    Value = prize.PrizeID
                }
            );
            return iResult;
        }

        public static int SetPrize(
            Dal.Models.Prize prize, List<int> LstPrizeLimitNum, OleDbConnection conn, OleDbTransaction tran)
        {
            if (prize == null || string.IsNullOrEmpty(prize.PrizeName) || prize.SpecialtyID == null)
            {
                throw new Exception("参数错误！");
            }

            Dal.Models.Specialty specialty = Specialty.GetSpecialty(prize.SpecialtyID.Value, conn, tran);

            // 所选专业不存在
            if (specialty == null)
            {
                throw new Exception("所选专业不存在！");
            }
            if ((specialty.ChildCount ?? 0) > 0)
            {
                throw new Exception("奖项创建失败,该专业下已存在子专业,无法创建奖项。");
            }

            // 同一专业中，奖项不允许重名
            Dal.Models.Prize prizeOriginal = GetPrize(prize.PrizeName, prize.SpecialtyID.Value, conn, tran);
            if (prizeOriginal!=null && prize.PrizeID != prizeOriginal.PrizeID)
            {
                throw new Exception("同一专业中，奖项不允许重名！");
            }

            //奖项类别为空时，默认类别为综合奖
            if (string.IsNullOrEmpty(prize.PrizeTypeCode) ||
                !(new string[] { "0301", "0302", "0303", "0304" }).Contains(prize.PrizeTypeCode))
            {
                prize.PrizeTypeCode = "0301";
            }

            if (prize.ParticipantLimit == null)
            {
                prize.ParticipantLimit = Convert.ToInt32(
                    SysConstant.GetConstant(prize.PrizeTypeCode, conn, tran).CorrelationValue);
            }

            if (string.IsNullOrEmpty(prize.TemplateCode))
            {
                prize.TemplateCode = specialty.TemplateCode;
            }

            StringBuilder sbSql = new StringBuilder();

            if (prize.PrizeID == null)
            {
                sbSql.Append(" INSERT INTO Prize ( ");
                sbSql.Append("           PrizeName");
                sbSql.Append("          ,SpecialtyID ");
                sbSql.Append("          ,PrizeTypeCode ");
                sbSql.Append("          ,TemplateCode ");
                sbSql.Append("          ,IsMultipleVoting ");
                sbSql.Append("          ,VoteType ");
                sbSql.Append("          ,ParticipantLimit ");
                sbSql.Append("          ,AppendixDiscription ");
                sbSql.Append("          ,CreateTime ");
                sbSql.Append("          ,LastUpdateTime ");
                sbSql.Append(" ) VALUES ( ?, ?, ?, ?, ?, ?, ?, ?, GETDATE(), GETDATE() ) ");

                int iResult = Dal.OleDbHlper.ExecuteNonQuery(
                    sbSql.ToString(), conn, CommandType.Text, tran
                    , new OleDbParameter("@PrizeName", OleDbType.VarWChar)
                    {
                        Value = prize.PrizeName
                    }
                    , new OleDbParameter("@SpecialtyID", OleDbType.Integer)
                    {
                        Value = prize.SpecialtyID
                    }
                    , new OleDbParameter("@PrizeTypeCode", OleDbType.VarWChar)
                    {
                        Value = prize.PrizeTypeCode
                    }
                    , new OleDbParameter("@TemplateCode", OleDbType.VarWChar)
                    {
                        Value = prize.TemplateCode
                    }
                    , new OleDbParameter("@IsMultipleVoting", OleDbType.Boolean)
                    {
                        Value = prize.IsMultipleVoting
                    }
                    , new OleDbParameter("@VoteType", OleDbType.VarWChar)
                    {
                        Value = prize.VoteType
                    }
                    , new OleDbParameter("@ParticipantNumber", OleDbType.Integer)
                    {
                        Value = prize.ParticipantLimit
                    }
                    , new OleDbParameter("@AppendixDiscription", OleDbType.VarWChar)
                    {
                        Value = prize.AppendixDiscription
                    }
                );

                prize.PrizeID = GetPrize(prize.PrizeName, prize.SpecialtyID.Value, conn, tran).PrizeID;
            }
            else
            {
                sbSql.Append(" UPDATE Prize ");
                sbSql.Append("   SET  PrizeName = ? ");
                sbSql.Append("       ,IsMultipleVoting = ? ");
                sbSql.Append("       ,VoteType = ? ");
                sbSql.Append("       ,ParticipantLimit = ? ");
                sbSql.Append("       ,AppendixDiscription = ? ");
                sbSql.Append("       ,LastUpdateTime = GETDATE() ");
                sbSql.Append("  WHERE PrizeID = ? ");

                int iResult = Dal.OleDbHlper.ExecuteNonQuery(
                    sbSql.ToString(), conn, CommandType.Text, tran
                    , new OleDbParameter("@PrizeName", OleDbType.VarWChar)
                    {
                        Value = prize.PrizeName
                    }
                    , new OleDbParameter("@IsMultipleVoting", OleDbType.Boolean)
                    {
                        Value = prize.IsMultipleVoting
                    }
                    , new OleDbParameter("@VoteType", OleDbType.VarWChar)
                    {
                        Value = prize.VoteType
                    }
                    , new OleDbParameter("@ParticipantLimit", OleDbType.Integer)
                    {
                        Value = prize.ParticipantLimit
                    }
                    , new OleDbParameter("@AppendixDiscription", OleDbType.VarWChar)
                    {
                        Value = prize.AppendixDiscription
                    }
                    , new OleDbParameter("@PrizeID", OleDbType.Integer)
                    {
                        Value = prize.PrizeID
                    }
                );
            }

            //奖项数量
            SetPrizeLevel(prize, LstPrizeLimitNum, conn, tran);

            SetOrdinal(prize, conn, tran);

            return prize.PrizeID.Value;
        }

        public static void DeletePrize(
            int iSpecialtyID, int iPrizeID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            // 已有申报的奖项，不允许删除
            string strSql = "select COUNT(*) from Declaration where PrizeID = ? or AdjustedPrize = ? ";
            int? iResult = Common.ToInt32(Dal.OleDbHlper.ExecuteScalar(
                strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID }
                 , new OleDbParameter("@AdjustedPrize", OleDbType.Integer) { Value = iPrizeID }));

            if (iResult == null || iResult == 0)
            {
                iResult = 0;
                //先删除奖项对应的类别和获奖数量;
                DeletePrizeLevel(iPrizeID, conn, tran);

                strSql = " DELETE FROM Prize  where PrizeID = ? ";

                Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
                    , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID });
                ResetOrdinal(iSpecialtyID, conn, tran);
            }
            if (iResult > 0)
            {
                throw new Exception("已有申报的奖项，不允许删除");
            }
        }

        public static void ResetOrdinal(
            int iSpecialtyID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            // 重排专业内部序号
            string strSql = @"WITH CTE AS(SELECT *, rn = ROW_NUMBER() OVER(ORDER BY Ordinal)
                                          FROM Prize WHERE SpecialtyID = ? ) 
                              UPDATE CTE SET Ordinal = rn ";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
             , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID });
        }

        ///// <summary>
        ///// 更新奖项
        ///// </summary>
        ///// <param name="prize"></param>
        ///// <param name="tran"></param>
        ///// <returns></returns>
        //public static int UpdatePrize(
        //    Dal.Models.Prize prize, List<int> LstPrizeLimitNum,
        //    OleDbConnection conn, OleDbTransaction tran)
        //{
        //    int iActivityID = CheckPrize(prize, conn, tran);

        //    //人数限制为空时，默认为对应奖项类别的人数限制
        //    if (prize.ParticipantLimit == null)
        //    {
        //        Dal.Models.SysConstant cnstParticipant = SysConstant.GetConstant(
        //            prize.PrizeTypeCode, conn, tran);
        //        prize.ParticipantLimit = Convert.ToInt32(cnstParticipant.CorrelationValue);
        //    } 

        //    StringBuilder sbSql = new StringBuilder();
        //    sbSql.Append(" UPDATE Prize SET ");
        //    sbSql.Append("        PrizeName = ? ");
        //    sbSql.Append("       ,SpecialtyID = ? ");
        //    sbSql.Append("       ,PrizeTypeCode = ? ");
        //    sbSql.Append("       ,TemplateCode = ? ");
        //    sbSql.Append("       ,IsMultipleVoting = ? ");
        //    sbSql.Append("       ,ParticipantLimit = ? ");
        //    sbSql.Append("       ,AppendixDiscription = ? ");
        //    sbSql.Append("       ,Ordinal = ? ");
        //    sbSql.Append("       ,LastUpdateTime = ? ");
        //    sbSql.Append("  WHERE PrizeID = ? ");

        //    int iResult = Dal.OleDbHlper.ExecuteNonQuery(
        //        sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@PrizeName", OleDbType.VarWChar)
        //        {
        //            Value = prize.PrizeName
        //        }
        //        , new OleDbParameter("@SpecialtyID", OleDbType.Integer)
        //        {
        //            Value = prize.SpecialtyID
        //        }
        //        , new OleDbParameter("@PrizeTypeCode", OleDbType.VarWChar)
        //        {
        //            Value = prize.PrizeTypeCode
        //        }
        //        , new OleDbParameter("@TemplateCode", OleDbType.VarWChar)
        //        {
        //            Value = prize.TemplateCode
        //        }
        //        , new OleDbParameter("@IsMultipleVoting", OleDbType.Boolean)
        //        {
        //            Value = prize.IsMultipleVoting
        //        }
        //        , new OleDbParameter("@ParticipantLimit", OleDbType.Integer)
        //        {
        //            Value = prize.ParticipantLimit
        //        }
        //        , new OleDbParameter("@AppendixDiscription", OleDbType.VarWChar)
        //        {
        //            Value = prize.AppendixDiscription
        //        }
        //        , new OleDbParameter("@Ordinal", OleDbType.Boolean)
        //        {
        //            Value = prize.Ordinal
        //        }
        //        , new OleDbParameter("@LastUpdateTime", OleDbType.Date)
        //        {
        //            Value = prize.LastUpdateTime
        //        }
        //        , new OleDbParameter("@PrizeID", OleDbType.Integer)
        //        {
        //            Value = prize.PrizeID
        //        }
        //    );

        //    SetPrizeLevel(prize, LstPrizeLimitNum, conn, tran);

        //    SetOrdinal(prize, conn, tran);

        //    return iResult;
        //}

        public static Dal.Models.Prize GetPrize(
            int iOrdinal, int iSpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from V_Prize where SpecialtyID = ? and Ordinal = ? ";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(
                strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID }
                , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = iOrdinal });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Prize>(reader);
        }

        public static void SetOrdinal(
            Dal.Models.Prize prize, OleDbConnection conn, OleDbTransaction tran = null)
        {
            if (prize == null || prize.PrizeID == null || prize.SpecialtyID == null)
            {
                throw new Exception("参数错误!");
            }

            List<Dal.Models.Prize> lstPrize = GetPrizeList(
                prize.SpecialtyID.Value, conn, tran).Where(p => p.PrizeID != prize.PrizeID).ToList();
            if (prize.Ordinal == null || prize.Ordinal > lstPrize.Count)
            {
                lstPrize.Add(prize);
            }
            else if (prize.Ordinal <= 0)
            {
                lstPrize.Insert(0, prize);
            }
            else
            {
                lstPrize.Insert(prize.Ordinal.Value - 1, prize);
            }

            string strSql = " UPDATE Prize set Ordinal = ? where PrizeID = ? ";
            for (int i = 0; i < lstPrize.Count; i++)
            {
                Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
                    , new OleDbParameter("@Ordinal", OleDbType.VarWChar)
                    {
                        Value = i + 1
                    }
                    , new OleDbParameter("@PrizeID", OleDbType.Integer)
                    {
                        Value = lstPrize[i].PrizeID.Value
                    }
                );
            }
        }

        public static void SetPrizeLevel(
            Dal.Models.PrizeLevel pl, OleDbConnection conn, OleDbTransaction tran = null)
        {
            if (pl.PrizeID == null || string.IsNullOrEmpty(pl.LevelCode))
            {
                throw new NoNullAllowedException("参数错误！");
            }

            Dal.Models.PrizeLevel plOriginal = GetPrizeLevel(
                pl.PrizeID.Value, pl.LevelCode, conn, tran);

            StringBuilder sbSql = new StringBuilder();
            if (plOriginal != null)
            {
                sbSql.Append(" UPDATE PrizeLevel");
                sbSql.Append(" SET LevelLimitNumber = ? ");
                sbSql.Append(" WHERE PrizeID = ? AND LevelCode = ? ");
            }
            else
            {
                sbSql.Append(" INSERT INTO PrizeLevel");
                sbSql.Append(" ( LevelLimitNumber, PrizeID, LevelCode )");
                sbSql.Append(" VALUES( ?, ?, ?)");
            }

            Dal.OleDbHlper.ExecuteNonQuery(
                sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@LevelLimitNumber", OleDbType.Integer)
                {
                    Value = pl.LevelLimitNumber
                }
                , new OleDbParameter("@PrizeID", OleDbType.Integer)
                {
                    Value = pl.PrizeID
                }
                , new OleDbParameter("@LevelCode", OleDbType.VarWChar)
                {
                    Value = pl.LevelCode
                }
            );
        }

        public static void SetPrizeLevel(
            Dal.Models.Prize prize, List<int> LstPrizeLimitNum,
            OleDbConnection conn, OleDbTransaction tran = null)
        {
            if (prize == null
                || LstPrizeLimitNum == null
                || LstPrizeLimitNum.Count < 1)
            {
                throw new NoNullAllowedException("参数错误！");
            }

            switch (prize.PrizeTypeCode)
            {
                case "0301": //当奖项为综合奖时
                case "0304":
                    if (LstPrizeLimitNum.Count < 3)
                    {
                        throw new NoNullAllowedException("参数错误！");
                    }

                    for (int i = 0; i < LstPrizeLimitNum.Count; i++)
                    {
                        SetPrizeLevel(new Dal.Models.PrizeLevel()
                        {
                            LevelCode = "040" + (i + 1).ToString(),
                            PrizeID = prize.PrizeID,
                            LevelLimitNumber = LstPrizeLimitNum[i]
                        }, conn, tran);
                    }
                    break;
                case "0302": //当奖项为单项奖时
                        SetPrizeLevel(new Dal.Models.PrizeLevel()
                        {
                            LevelCode = "0404",
                            PrizeID = prize.PrizeID,
                            LevelLimitNumber = LstPrizeLimitNum[0]
                        }, conn, tran);
                    break;
                case "0303": //当奖项为中小创时
                    SetPrizeLevel(new Dal.Models.PrizeLevel()
                    {
                        LevelCode = "0405",
                        PrizeID = prize.PrizeID,
                        LevelLimitNumber = LstPrizeLimitNum[0]
                    }, conn, tran);
                    break;
                default: break;
            }
        }

        public static List<Dal.Models.PrizeLevel> GetPrizeLimitNumList(
            int iPrizeID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "SELECT * FROM PRIZELEVEL WHERE PRIZEID = ? ";
            return Dal.OleDbHlper.GetList<Dal.Models.PrizeLevel>(
                strSql, conn, CommandType.Text, tran
                    , new OleDbParameter("@PRIZEID", OleDbType.VarWChar)
                    {
                        Value = iPrizeID
                    }
            );
        }
        
        public static Dal.Models.PrizeLevel GetPrizeLevel(
            int iPrizeID, string LevelCode,
            OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "SELECT * FROM PRIZELEVEL WHERE PRIZEID = ? and LevelCode = ?";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(
                strSql, conn, CommandType.Text, tran
                    , new OleDbParameter("@PRIZEID", OleDbType.Integer)
                    {
                        Value = iPrizeID
                    }
                    , new OleDbParameter("@LevelCode", OleDbType.VarWChar)
                    {
                        Value = LevelCode
                    }
            );
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.PrizeLevel>(reader);
        }

        public static int DeletePrizeLevel(
            int iPrizeID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " DELETE FROM PrizeLevel  where PrizeID = ? ";

            return Dal.OleDbHlper.ExecuteNonQuery(
                strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@PrizeID", OleDbType.Integer)
                {
                    Value = iPrizeID
                }
            );
        }

        public static List<Dal.Models.Prize> GetPrizeList(
            string specialtys, string prizeType, string prizeName,
            OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select p.* from V_Prize p ");
            if (!string.IsNullOrEmpty(specialtys))
            {
                strSql.Append(" and p.SpecialtyID in (" + specialtys + ")");
            }
            if (!string.IsNullOrEmpty(prizeType))
            {
                strSql.Append(" and p.PrizeTypeCode in (" + prizeType + ")");
            }
            if (!string.IsNullOrEmpty(prizeName))
            {
                strSql.Append(" and p.PrizeName like '%" + prizeName + "%'");
            }

            return Dal.OleDbHlper.GetList<Dal.Models.Prize>(
                strSql.ToString(), conn, CommandType.Text, tran);
        }

        public static List<Dal.Models.Prize> GetExpertVotePrize(
            int iUserID, int iActivityID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append(" select distinct p.* from V_Prize p ");
            strSql.Append(" inner join Declaration d ");
            strSql.Append(" on d.AdjustedPrize = p.PrizeID ");
            strSql.Append(" and d.DeclarationStatus = '1803' ");
            strSql.Append(" inner join dbo.Fn_GetGroupByUserID(?) f");
            strSql.Append(" on f.GroupID = d.ExpertReviewGroupID ");

            strSql.Append(" where p.ActivityID = ? ");

            return Dal.OleDbHlper.GetList<Dal.Models.Prize>(
                strSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@UserID", OleDbType.Integer)
                {
                    Value = iUserID
                }
                , new OleDbParameter("@ActivityID", OleDbType.Integer)
                {
                    Value = iActivityID
                }
            );
        }

        public static void BeginRevote(int iPrizeID, int iRevoteRound, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql =" UPDATE Prize SET RevoteRound = ? WHERE PrizeID = ? ";

            int iResult = Dal.OleDbHlper.ExecuteNonQuery(
                strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@RevoteRound", OleDbType.Integer)
                {
                    Value = iRevoteRound
                }
                , new OleDbParameter("@PrizeID", OleDbType.Integer)
                {
                    Value = iPrizeID
                }
            );
        }
    }
}
