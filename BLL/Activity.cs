using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Activity
    {
        public static Dal.Models.Activity GetActivity(int iActivityID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "select * from Activity where ActivityID = ?";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Activity>(reader);
        }

        /// <summary>
        /// 获取当前激活的活动编号
        /// </summary>
        /// <param name="iUserID">用户编号</param>
        /// <param name="strActivityType">活动类型</param>
        /// <returns>-1:没有找到该类型的活动编号（该类型还没有创建过活动）</returns>
        public static Dal.Models.Activity GetActivity(string strActivityType, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("select * from Activity where ActivityTypeCode = ? and ActivityStatus<>'1110'");
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@ActivityTypeCode", OleDbType.VarWChar) { Value = strActivityType });
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Activity>(reader);
        }

        public static List<Dal.Models.Activity> GetActivityList(string strActivityType, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();

            sbSql.Append(" select a.*, stp.ConstantValue ActivityTypeName, sst.ConstantValue ActivityStatusName ");
            sbSql.Append(" from  Activity a ");
            sbSql.Append(" inner join SysConstant stp on stp.ConstantCode = a.ActivityTypeCode ");
            sbSql.Append(" inner join SysConstant sst on sst.ConstantCode = a.ActivityStatus ");
            sbSql.Append(" where a.ActivityTypeCode = ? ");

            return Dal.OleDbHlper.GetList<Dal.Models.Activity>(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@ActivityTypeCode", OleDbType.VarWChar) { Value = strActivityType });
        }

        /// <summary>
        /// 创建活动
        /// </summary>
        /// <param name="activity"></param>
        /// <returns>活动编号</returns>
        public static int CreateActivity(Dal.Models.Activity activity, OleDbConnection conn, OleDbTransaction trans = null)
        {
            if (string.IsNullOrEmpty(activity.ActivityTypeCode))
            {
                throw new Exception("参数错误");
            }

            if (GetActivity(activity.ActivityTypeCode, conn, trans) != null)
            {
                throw new Exception("当前活动类型已经有激活的活动，不能重复创建");
            }

            if (activity.CreateTime == null || activity.LastUpdateTime == null)
            {
                activity.CreateTime = DateTime.Now;
                activity.LastUpdateTime = activity.CreateTime;
            }

            if (string.IsNullOrEmpty(activity.ActivityName))
            {
                activity.ActivityName = activity.CreateTime.Value.ToString("yyyy届")
                    + SysConstant.GetConstant(activity.ActivityTypeCode, conn, trans).ConstantValue
                    + "评选活动";
            }

            activity.ActivityStatus = "1101";

            StringBuilder sbSql = new StringBuilder();
            int? iResult = 0;

            sbSql.Append(" INSERT INTO Activity ( ");
            sbSql.Append("        ActivityName ");
            sbSql.Append("       ,ActivityTypeCode ");
            sbSql.Append("       ,ActivityStatus ");
            sbSql.Append("       ,CreateTime ");
            sbSql.Append("       ,LastUpdateTime ");
            sbSql.Append(" )VALUES(?, ?, '1101', GETDATE(), GETDATE()) ");
            iResult = Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                , new OleDbParameter("@ActivityName", OleDbType.VarWChar) { Value = activity.ActivityName }
                , new OleDbParameter("@ActivityTypeCode", OleDbType.VarWChar) { Value = activity.ActivityTypeCode });

            if (iResult != 1)
            {
                throw new Exception("创建失败");
            }
            else
            {
                activity.ActivityID = GetActivity(activity.ActivityTypeCode, conn, trans).ActivityID;
            }

            // 创建活动的同时，创建基础专业
            sbSql.Clear();
            sbSql.Append(" INSERT INTO Specialty ( ");
            sbSql.Append("   ActivityID ,SpecialtyCode ,SpecialtyName ,SpecialtyLevel ,SpecialtyIcon ");
            sbSql.Append(" , TemplateCode, IsShareQuota, IsInheritSchedule, IsInheritTemplet, IsAllowUpdate ");
            sbSql.Append(" , ParentID, CreateTime, LastUpdateTime ");
            sbSql.Append(" , IsSendReceivePost, IsSendUpdatePost, IsSendDeletePost, IsInheritAppendix,IsInheritAtlas ");
            sbSql.Append(" , Ordinal, TotalOrdinal) ");
            sbSql.Append(" SELECT ? , SubString(ConstantCode, 3, 2) + '0000', ConstantValue, '一级', CorrelationValue ");
            sbSql.Append(" , '02' + SubString(ConstantCode, 3, 2), 0, 1, 1, 0 ");
            sbSql.Append(" , NULL, GETDATE(), GETDATE() ");
            sbSql.Append(" , 0, 0, 0, 1, 1 ");
            sbSql.Append(" , SubString(ConstantCode,3,2) , SubString(ConstantCode,3,2) ");
            sbSql.Append(" FROM SysConstant where ConstantType = '17' ");
            Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                 , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = activity.ActivityID });

            return activity.ActivityID.Value;
        }

        /// <summary>
        /// 修改活动信息
        /// </summary>
        /// <param name="activity"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        public static int UpdateActivity(Dal.Models.Activity activity, OleDbConnection conn, OleDbTransaction trans)
        {
            if (activity.ActivityID == null || string.IsNullOrEmpty(activity.ActivityName) || string.IsNullOrEmpty(activity.ActivityStatus))
            {
                return -1;
            }

            if (activity.LastUpdateTime == null)
            {
                activity.LastUpdateTime = DateTime.Now;
            }

            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" UPDATE Activity SET");
            sbSql.Append("        ActivityName = ? ");
            sbSql.Append("       ,ActivityStatus = ? ");
            sbSql.Append("       ,LastUpdateTime = GETDATE() ");
            sbSql.Append(" WHERE ActivityID = ? ");

            return Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                , new OleDbParameter("@ActivityName", OleDbType.VarWChar) { Value = activity.ActivityName }
                , new OleDbParameter("@ActivityStatus", OleDbType.VarWChar) { Value = activity.ActivityStatus }
                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = activity.ActivityID });
        }

        /// <summary>
        /// 删除活动
        /// </summary>
        /// <param name="iActivityID"></param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        /// <remarks>删除活动，则活动关联的专业、奖项、申报表、投票信息、获奖信息、通知、专家、专家组都将被删除</remarks>
        /// <returns></returns>
        //public static void DeleteActivity(int iActivityID, OleDbConnection conn, OleDbTransaction tran)
        //{
        //    StringBuilder sbSql = new StringBuilder();

        //    // 1、已上传文件
        //    sbSql.Append(" delete from UploadFile where ( ");
        //    sbSql.Append(" TypeCode = 'NoticeImage' ");
        //    sbSql.Append(" and OwnerID in ( select NoticeID from Notice where ActivityID = ? ) ");
        //    sbSql.Append("  ) or ( ");
        //    sbSql.Append(" TypeCode like 'Declaration%' ");
        //    sbSql.Append(" and OwnerID in ( ");
        //    sbSql.Append(" select DeclarationID from Declaration d ");
        //    sbSql.Append(" inner join Prize p on p.PrizeID = d.PrizeID ");
        //    sbSql.Append(" inner join Specialty s on s.SpecialtyID = p.SpecialtyID ");
        //    sbSql.Append("  where s.ActivityID = ? )");
        //    sbSql.Append("  )");
        //    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID }
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

        //    // 2、通知
        //    sbSql.Clear();
        //    sbSql.Append(" delete from Notice where ActivityID = ? ");
        //    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

        //    // 3、获奖信息
        //    sbSql.Clear();
        //    sbSql.Append(" delete from WinnerList where PrizeID in ");
        //    sbSql.Append(" ( select PrizeID from Prize p ");
        //    sbSql.Append(" inner join Specialty s on  s.SpecialtyID = p.SpecialtyID ");
        //    sbSql.Append(" where s.ActivityID = ?) ");
        //    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

        //    // 4、复投申报表
        //    sbSql.Clear();
        //    sbSql.Append(" delete from ReVoteDeclaration where ReVoteBatch in ");
        //    sbSql.Append(" ( select ReVoteBatch from ReVoteBatch r ");
        //    sbSql.Append(" inner join Prize p on p.PrizeID = r.PrizeID ");
        //    sbSql.Append(" inner join Specialty s on s.SpecialtyID = p.SpecialtyID ");
        //    sbSql.Append(" where s.ActivityID = ? )");
        //    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

        //    // 5、复投批次
        //    sbSql.Clear();
        //    sbSql.Append(" delete from ReVoteBatch where PrizeID in ");
        //    sbSql.Append(" ( select PrizeID from Prize p ");
        //    sbSql.Append(" inner join Specialty s on s.SpecialtyID = p.SpecialtyID ");
        //    sbSql.Append(" where s.ActivityID = ? ) ");
        //    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

        //    // 6、投票信息
        //    sbSql.Clear();
        //    sbSql.Append(" delete from Vote where DeclarationID in ");
        //    sbSql.Append(" ( select DeclarationID from Declaration d ");
        //    sbSql.Append(" inner join Prize p on p.PrizeID = d.PrizeID ");
        //    sbSql.Append(" inner join Specialty s on s.SpecialtyID = p.SpecialtyID ");
        //    sbSql.Append(" where s.ActivityID = ? )");
        //    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

        //    // 7、评审信息
        //    sbSql.Clear();
        //    sbSql.Append(" delete from Review where DeclarationID in ");
        //    sbSql.Append(" ( select DeclarationID from Declaration d ");
        //    sbSql.Append(" inner join Prize p on p.PrizeID = d.PrizeID ");
        //    sbSql.Append(" inner join Specialty s on s.SpecialtyID = p.SpecialtyID ");
        //    sbSql.Append(" where s.ActivityID = ? )");
        //    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

        //    // 8、申报表_数据
        //    sbSql.Clear();
        //    sbSql.Append(" delete from Declaration_Data where DeclarationID in ");
        //    sbSql.Append(" ( select DeclarationID from Declaration d ");
        //    sbSql.Append(" inner join Prize p on p.PrizeID = d.PrizeID ");
        //    sbSql.Append(" inner join Specialty s on s.SpecialtyID = p.SpecialtyID ");
        //    sbSql.Append(" where s.ActivityID = ? )");
        //    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

        //    // 9、申报表
        //    sbSql.Clear();
        //    sbSql.Append(" delete from Declaration where PrizeID in ");
        //    sbSql.Append(" ( select PrizeID from Prize p ");
        //    sbSql.Append(" inner join Specialty s on s.SpecialtyID = p.SpecialtyID ");
        //    sbSql.Append(" where s.ActivityID = ? ) ");
        //    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

        //    // 10、专家组成员
        //    sbSql.Clear();
        //    sbSql.Append(" delete from GroupMember where GroupID in ");
        //    sbSql.Append(" ( select GroupID from ExpertGroup where ActivityID = ? )");
        //    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

        //    // 11、专家组
        //    sbSql.Clear();
        //    sbSql.Append(" delete from ExpertGroup where ActivityID = ? ");
        //    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

        //    // 12、活动节点设置
        //    sbSql.Clear();
        //    sbSql.Append(" delete from Schedule where ");
        //    sbSql.Append(" SpecialtyID in (select SpecialtyID from Specialty where ActivityID = ? ) or ActivityID = ? ");
        //    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID }
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

        //    // 14、图集
        //    sbSql.Clear();
        //    sbSql.Append(" delete from Atlas where  ");
        //    sbSql.Append(" SpecialtyID in (select SpecialtyID from Specialty where ActivityID = ? ) ");
        //    sbSql.Append(" or PrizeID in  ");
        //    sbSql.Append(" ( select PrizeID from Prize p ");
        //    sbSql.Append(" inner join Specialty s on s.SpecialtyID = p.SpecialtyID ");
        //    sbSql.Append(" where s.ActivityID = ? ) ");
        //    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID }
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

        //    // 15、附件列表
        //    sbSql.Clear();
        //    sbSql.Append(" delete from Appendix where ");
        //    sbSql.Append(" SpecialtyID in (select SpecialtyID from Specialty where ActivityID = ? ) ");
        //    sbSql.Append(" or PrizeID in  ");
        //    sbSql.Append(" ( select PrizeID from Prize p ");
        //    sbSql.Append(" inner join Specialty s on s.SpecialtyID = p.SpecialtyID ");
        //    sbSql.Append(" where s.ActivityID = ? ) ");
        //    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID }
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

        //    // 16、奖项等级
        //     sbSql.Clear();
        //     sbSql.Append(" delete from PrizeLevel where PrizeID in  ");
        //     sbSql.Append(" (select PrizeID from Prize p inner join Specialty s on s.SpecialtyID = p.SpecialtyID where s.ActivityID = ? ) ");
        //     Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

        //    // 17、奖项
        //    sbSql.Clear();
        //    sbSql.Append(" delete from Prize where SpecialtyID in (select SpecialtyID from Specialty where ActivityID = ? ) ");
        //     Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

        //    // 18、用户专业信息
        //    sbSql.Clear();
        //    sbSql.Append(" delete from UserSpecialty where SpecialtyID in (select SpecialtyID from Specialty where ActivityID = ?) ");
        //    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

        //    // 19、专业
        //    sbSql.Clear();
        //    sbSql.Append(" delete from Specialty where ActivityID = ? ");
        //    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

        //    // 20、活动
        //    sbSql.Clear();
        //    sbSql.Append(" delete from Activity where ActivityID = ? ");
        //    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
        //        , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });
        //}
    }
}
