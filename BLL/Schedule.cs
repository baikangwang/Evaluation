using System.Data;
using System.Data.OleDb;
using System.Text;

namespace BLL
{
    public class Schedule
    {
        public static Dal.Models.Schedule GetActivitySchedule(int iActivityID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " SELECT * FROM Schedule WHERE ActivityID = ?  ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Schedule>(reader);
        }

        /// <summary>
        /// 获取专业的时间表
        /// </summary>
        /// <param name="iSpecialtyID"></param>
        /// <returns></returns>
        public static Dal.Models.Schedule GetSpecialtySchedule(int iSpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {

            Dal.Models.Specialty specialty = null;

            specialty = Specialty.GetSpecialty(iSpecialtyID, conn, tran);

            // 默认继承时间节点
            if (specialty.IsInheritSchedule == null)
            {
                specialty.IsInheritSchedule = true;
            }

            if (specialty.IsInheritSchedule.Value)
            {
                if (specialty.ParentID.HasValue)
                {
                    return GetSpecialtySchedule(specialty.ParentID.Value, conn, tran);
                }
                else
                {
                    return GetActivitySchedule(specialty.ActivityID.Value, conn, tran);
                }
            }
            else
            {
                string strSql = "SELECT * FROM Schedule WHERE SpecialtyID = ? ";
                IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                    , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID });

                return Dal.Models.BaseEntity.GetEntity<Dal.Models.Schedule>(reader);
            }
        }

        /// <summary>
        /// 设定时间表
        /// </summary>
        /// <param name="schedule"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        public static int SetSchedule(Dal.Models.Schedule schedule, OleDbConnection conn, OleDbTransaction trans = null)
        {
            if (schedule == null
                || (schedule.SpecialtyID == null && schedule.ActivityID == null)
                || (schedule.SpecialtyID != null && schedule.ActivityID != null))
            {
                return -1;
            }

            // 专业一旦设定了时间表，则自动修改其继承状态为否
            int iResult = 0;
            if (schedule.SpecialtyID != null)
            {
                Dal.Models.Specialty specialty = Specialty.GetSpecialty(schedule.SpecialtyID.Value, conn, trans);

                if (specialty.IsInheritSchedule == null || specialty.IsInheritSchedule.Value)
                {
                    specialty.IsInheritSchedule = false;
                    Specialty.UpdateSpecialty(specialty, conn, trans);
                    iResult = CreateSchedule(schedule, conn, trans);
                }
                else
                {
                    Dal.Models.Schedule sc = GetSpecialtySchedule(schedule.SpecialtyID.Value, conn, trans);
                    if (sc != null)
                    {
                        schedule.ScheduleID = sc.ScheduleID;
                        iResult = UpdateSchedule(schedule, conn, trans);
                    }
                    else
                    {
                        iResult = CreateSchedule(schedule, conn, trans);
                    }
                }
            }
            else
            {
                Dal.Models.Schedule sc = GetActivitySchedule(schedule.ActivityID.Value, conn, trans);
                if (sc != null)
                {
                    schedule.ScheduleID = sc.ScheduleID;
                    iResult = UpdateSchedule(schedule, conn, trans);
                }
                else
                {
                    iResult = CreateSchedule(schedule, conn, trans);
                }
            }

            return iResult;
        }

        public static int UpdateSchedule(Dal.Models.Schedule schedule, OleDbConnection conn, OleDbTransaction trans = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" UPDATE Schedule ");
            sbSql.Append("    SET ActivityID = ? ");
            sbSql.Append("       ,SpecialtyID = ? ");
            sbSql.Append("       ,DeclarationBeginDate = ? ");
            sbSql.Append("       ,DeclarationEndDate = ? ");
            sbSql.Append("       ,IsDeclarationAutoStart = ? ");
            sbSql.Append("       ,IsDeclarationAutoEnd = ? ");
            sbSql.Append("       ,IsDeclarationStart = ? ");
            sbSql.Append("       ,PrimaryElectionBeginDate = ? ");
            sbSql.Append("       ,PrimaryElectionEndDate = ? ");
            sbSql.Append("       ,IsPrimaryElectionAutoStart = ? ");
            sbSql.Append("       ,IsPrimaryElectionAutoEnd = ? ");
            sbSql.Append("       ,IsPrimaryElectionStart = ? ");
            sbSql.Append("       ,ExpertReviewBeginDate = ? ");
            sbSql.Append("       ,ExpertReviewEndDate = ? ");
            sbSql.Append("       ,IsExpertReviewAutoStart = ? ");
            sbSql.Append("       ,IsExpertReviewAutoEnd = ? ");
            sbSql.Append("       ,IsExpertReviewStart = ? ");
            sbSql.Append("       ,DownloadBeginDate = ? ");
            sbSql.Append("       ,DownloadEndDate = ? ");
            sbSql.Append("       ,IsDownloadAutoStart = ? ");
            sbSql.Append("       ,IsDownloadAutoEnd = ? ");
            sbSql.Append("       ,IsDownloadStart = ? ");
            sbSql.Append("       ,VoteBeginDate = ? ");
            sbSql.Append("       ,VoteEndDate = ? ");
            sbSql.Append("       ,IsVoteAutoStart = ? ");
            sbSql.Append("       ,IsVoteAutoEnd = ? ");
            sbSql.Append("       ,IsVoteStart = ? ");
            sbSql.Append("       ,IsReVoteStart = ? ");
            sbSql.Append("  WHERE ScheduleID = ? ");

            int iResult = Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = schedule.ActivityID }
                , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = schedule.SpecialtyID }
                , new OleDbParameter("@DeclarationBeginDate", OleDbType.DBDate) { Value = schedule.DeclarationBeginDate }
                , new OleDbParameter("@DeclarationEndDate", OleDbType.DBDate) { Value = schedule.DeclarationEndDate }
                , new OleDbParameter("@IsDeclarationAutoStart", OleDbType.Boolean) { Value = schedule.IsDeclarationAutoStart }
                , new OleDbParameter("@IsDeclarationAutoEnd", OleDbType.Boolean) { Value = schedule.IsDeclarationAutoEnd }
                , new OleDbParameter("@IsDeclarationStart", OleDbType.Boolean) { Value = schedule.IsDeclarationStart }
                , new OleDbParameter("@PrimaryElectionBeginDate", OleDbType.DBDate) { Value = schedule.PrimaryElectionBeginDate }
                , new OleDbParameter("@PrimaryElectionEndDate", OleDbType.DBDate) { Value = schedule.PrimaryElectionEndDate }
                , new OleDbParameter("@IsPrimaryElectionAutoStart", OleDbType.Boolean) { Value = schedule.IsPrimaryElectionAutoStart }
                , new OleDbParameter("@IsPrimaryElectionAutoEnd", OleDbType.Boolean) { Value = schedule.IsPrimaryElectionAutoEnd }
                , new OleDbParameter("@IsPrimaryElectionStart", OleDbType.Boolean) { Value = schedule.IsPrimaryElectionStart }
                , new OleDbParameter("@ExpertReviewBeginDate", OleDbType.DBDate) { Value = schedule.ExpertReviewBeginDate }
                , new OleDbParameter("@ExpertReviewEndDate", OleDbType.DBDate) { Value = schedule.ExpertReviewEndDate }
                , new OleDbParameter("@IsExpertReviewAutoStart", OleDbType.Boolean) { Value = schedule.IsExpertReviewAutoStart }
                , new OleDbParameter("@IsExpertReviewAutoEnd", OleDbType.Boolean) { Value = schedule.IsExpertReviewAutoEnd }
                , new OleDbParameter("@IsExpertReviewStart", OleDbType.Boolean) { Value = schedule.IsExpertReviewStart }
                , new OleDbParameter("@DownloadBeginDate", OleDbType.DBDate) { Value = schedule.DownloadBeginDate }
                , new OleDbParameter("@DownloadEndDate", OleDbType.DBDate) { Value = schedule.DownloadEndDate }
                , new OleDbParameter("@IsDownloadAutoStart", OleDbType.Boolean) { Value = schedule.IsDownloadAutoStart }
                , new OleDbParameter("@IsDownloadAutoEnd", OleDbType.Boolean) { Value = schedule.IsDownloadAutoEnd }
                , new OleDbParameter("@IsDownloadStart", OleDbType.Boolean) { Value = schedule.IsDownloadStart }
                , new OleDbParameter("@VoteBeginDate", OleDbType.DBDate) { Value = schedule.VoteBeginDate }
                , new OleDbParameter("@VoteEndDate", OleDbType.DBDate) { Value = schedule.VoteEndDate }
                , new OleDbParameter("@IsVoteAutoStart", OleDbType.Boolean) { Value = schedule.IsVoteAutoStart }
                , new OleDbParameter("@IsVoteAutoEnd", OleDbType.Boolean) { Value = schedule.IsVoteAutoEnd }
                , new OleDbParameter("@IsVoteStart", OleDbType.Boolean) { Value = schedule.IsVoteStart }
                , new OleDbParameter("@IsReVoteStart", OleDbType.Boolean) { Value = schedule.IsReVoteStart }
                , new OleDbParameter("@ScheduleID", OleDbType.Integer) { Value = schedule.ScheduleID });
            return iResult;
        }

        public static int CreateSchedule(Dal.Models.Schedule schedule, OleDbConnection conn, OleDbTransaction trans = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" INSERT INTO Schedule ( ");
            sbSql.Append("         ActivityID ");
            sbSql.Append("        ,SpecialtyID ");
            sbSql.Append("        ,DeclarationBeginDate ");
            sbSql.Append("        ,DeclarationEndDate ");
            sbSql.Append("        ,IsDeclarationAutoStart");
            sbSql.Append("        ,IsDeclarationAutoEnd ");
            sbSql.Append("        ,IsDeclarationStart ");
            sbSql.Append("        ,PrimaryElectionBeginDate ");
            sbSql.Append("        ,PrimaryElectionEndDate ");
            sbSql.Append("        ,IsPrimaryElectionAutoStart ");
            sbSql.Append("        ,IsPrimaryElectionAutoEnd ");
            sbSql.Append("        ,IsPrimaryElectionStart ");
            sbSql.Append("        ,ExpertReviewBeginDate ");
            sbSql.Append("        ,ExpertReviewEndDate ");
            sbSql.Append("        ,IsExpertReviewAutoStart ");
            sbSql.Append("        ,IsExpertReviewAutoEnd ");
            sbSql.Append("        ,IsExpertReviewStart ");
            sbSql.Append("        ,DownloadBeginDate ");
            sbSql.Append("        ,DownloadEndDate ");
            sbSql.Append("        ,IsDownloadAutoStart ");
            sbSql.Append("        ,IsDownloadAutoEnd ");
            sbSql.Append("        ,IsDownloadStart ");
            sbSql.Append("        ,VoteBeginDate ");
            sbSql.Append("        ,VoteEndDate ");
            sbSql.Append("        ,IsVoteAutoStart ");
            sbSql.Append("        ,IsVoteAutoEnd ");
            sbSql.Append("        ,IsVoteStart ");
            sbSql.Append("        ,IsReVoteStart             ");
            sbSql.Append(" ) VALUES ( ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?) ");

            int iResult = Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
             , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = schedule.ActivityID }
             , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = schedule.SpecialtyID }
             , new OleDbParameter("@DeclarationBeginDate", OleDbType.DBDate) { Value = schedule.DeclarationBeginDate }
             , new OleDbParameter("@DeclarationEndDate", OleDbType.DBDate) { Value = schedule.DeclarationEndDate }
             , new OleDbParameter("@IsDeclarationAutoStart", OleDbType.Boolean) { Value = schedule.IsDeclarationAutoStart }
             , new OleDbParameter("@IsDeclarationAutoEnd", OleDbType.Boolean) { Value = schedule.IsDeclarationAutoEnd }
             , new OleDbParameter("@IsDeclarationStart", OleDbType.Boolean) { Value = schedule.IsDeclarationStart }
             , new OleDbParameter("@PrimaryElectionBeginDate", OleDbType.DBDate) { Value = schedule.PrimaryElectionBeginDate }
             , new OleDbParameter("@PrimaryElectionEndDate", OleDbType.DBDate) { Value = schedule.PrimaryElectionEndDate }
             , new OleDbParameter("@IsPrimaryElectionAutoStart", OleDbType.Boolean) { Value = schedule.IsPrimaryElectionAutoStart }
             , new OleDbParameter("@IsPrimaryElectionAutoEnd", OleDbType.Boolean) { Value = schedule.IsPrimaryElectionAutoEnd }
             , new OleDbParameter("@IsPrimaryElectionStart", OleDbType.Boolean) { Value = schedule.IsPrimaryElectionStart }
             , new OleDbParameter("@ExpertReviewBeginDate", OleDbType.DBDate) { Value = schedule.ExpertReviewBeginDate }
             , new OleDbParameter("@ExpertReviewEndDate", OleDbType.DBDate) { Value = schedule.ExpertReviewEndDate }
             , new OleDbParameter("@IsExpertReviewAutoStart", OleDbType.Boolean) { Value = schedule.IsExpertReviewAutoStart }
             , new OleDbParameter("@IsExpertReviewAutoEnd", OleDbType.Boolean) { Value = schedule.IsExpertReviewAutoEnd }
             , new OleDbParameter("@IsExpertReviewStart", OleDbType.Boolean) { Value = schedule.IsExpertReviewStart }
             , new OleDbParameter("@DownloadBeginDate", OleDbType.DBDate) { Value = schedule.DownloadBeginDate }
             , new OleDbParameter("@DownloadEndDate", OleDbType.DBDate) { Value = schedule.DownloadEndDate }
             , new OleDbParameter("@IsDownloadAutoStart", OleDbType.Boolean) { Value = schedule.IsDownloadAutoStart }
             , new OleDbParameter("@IsDownloadAutoEnd", OleDbType.Boolean) { Value = schedule.IsDownloadAutoEnd }
             , new OleDbParameter("@IsDownloadStart", OleDbType.Boolean) { Value = schedule.IsDownloadStart }
             , new OleDbParameter("@VoteBeginDate", OleDbType.DBDate) { Value = schedule.VoteBeginDate }
             , new OleDbParameter("@VoteEndDate", OleDbType.DBDate) { Value = schedule.VoteEndDate }
             , new OleDbParameter("@IsVoteAutoStart", OleDbType.Boolean) { Value = schedule.IsVoteAutoStart }
             , new OleDbParameter("@IsVoteAutoEnd", OleDbType.Boolean) { Value = schedule.IsVoteAutoEnd }
             , new OleDbParameter("@IsVoteStart", OleDbType.Boolean) { Value = schedule.IsVoteStart }
             , new OleDbParameter("@IsReVoteStart", OleDbType.Boolean) { Value = schedule.IsReVoteStart });

            return iResult;
        }
    }
}
