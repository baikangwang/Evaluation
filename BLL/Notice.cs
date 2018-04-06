using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Linq;
using System.IO;
//using Pechkin;

namespace BLL
{
    public static class Notice
    {
        public static Dal.Models.Notice GetNotice(int iNoticeID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from Notice where NoticeID = ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@NoticeID", OleDbType.Integer) { Value = iNoticeID });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Notice>(reader);
        }

        public static List<Dal.Models.Notice> GetNoticeList(int iActiveID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "select N.*,U.FileName NoticeFileName from Notice N  left join UploadFile U on N.NoticeID=U.OwnerID and U.TypeCode='NoticeAppendix' where ActivityID = ?  ORDER BY Ordinal";
            return Dal.OleDbHlper.GetList<Dal.Models.Notice>(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActiveID });
        }

        public static int CreateNotice(Dal.Models.Notice notice, int iActivityID, OleDbConnection conn, OleDbTransaction tran)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("INSERT INTO NOTICE ( ");
            sbSql.Append("  ActivityID");
            sbSql.Append("  ,Title");
            sbSql.Append("  ,NoticeContent");
            sbSql.Append("  ,EffectTime");
            sbSql.Append("  ,Ordinal");
            sbSql.Append("  ,LastEditTime");
            sbSql.Append("  ,Clicks )");
            sbSql.Append(" VALUES ( ?, ?, ?, ?, ?,? ,?)");
            int iResult = Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = notice.ActivityID }
                , new OleDbParameter("@Title", OleDbType.VarWChar) { Value = notice.Title }
                , new OleDbParameter("@NoticeContent", OleDbType.VarWChar) { Value = notice.NoticeContent }
                , new OleDbParameter("@EffectTime", OleDbType.DBDate) { Value = notice.EffectTime }
                , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = notice.Ordinal }
                , new OleDbParameter("@LastEditTime", OleDbType.DBDate) { Value = notice.CreateTime }
                , new OleDbParameter("@Clicks", OleDbType.Integer) { Value = 0 });

            if (iResult != 1)
            {
                throw new Exception("添加公告失败!");
            }
            else
            {
                int noticeID = BLL.Notice.maxNoticeID(notice, conn, tran);
                notice.NoticeID = noticeID;
                SetNoticeOrdinal(notice, conn, tran);
                return noticeID;
            }
        }

        //取序号的最大值
        public static int maxNoticeID(Dal.Models.Notice notice, OleDbConnection conn, OleDbTransaction tran)
        {
            string strSql = "select max(NoticeID) from Notice where ActivityID=" + notice.ActivityID;
            string currentNoticeID = Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran).ToString();
            currentNoticeID = currentNoticeID == "" ? "0" : currentNoticeID;
            return Convert.ToInt32(currentNoticeID);
        }

        public static int UpdateNotice(Dal.Models.Notice notice, int NoticeID, OleDbConnection conn, OleDbTransaction tran)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" Update NOTICE  ");
            sbSql.Append(" set ActivityID=?,");
            sbSql.Append(" Title=?,");
            sbSql.Append(" NoticeContent=?,");
            sbSql.Append(" EffectTime=?,");
            sbSql.Append(" Ordinal=?,");
            sbSql.Append(" LastEditTime=?");
            sbSql.Append(" where NoticeID=?");
            int iResult = Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = notice.ActivityID }
                , new OleDbParameter("@Title", OleDbType.VarWChar) { Value = notice.Title }
                , new OleDbParameter("@NoticeContent", OleDbType.VarWChar) { Value = notice.NoticeContent }
                , new OleDbParameter("@EffectTime", OleDbType.DBDate) { Value = notice.EffectTime }
                , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = notice.Ordinal }
                , new OleDbParameter("@LastEditTime", OleDbType.DBDate) { Value = notice.CreateTime }
                , new OleDbParameter("@NoticeID", OleDbType.Integer) { Value = NoticeID });
            if (iResult != 1)
            {
                throw new Exception("修改失败!");
            }
            else
            {
                notice.NoticeID = NoticeID;
                SetNoticeOrdinal(notice, conn, tran);
                return iResult;
            }
        }

        public static int DelNotice(int iNoticeID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            Dal.Models.Notice n = GetNotice(iNoticeID, conn, tran);
            string strSql = "DELETE FROM NOTICE where NoticeID = ? ";

            int iResult = Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@NoticeID", OleDbType.Integer) { Value = iNoticeID });
            if(iResult!=1)
            {
                throw new Exception("删除失败！");
            }
            else
            {
                ResetOrdinal(n.ActivityID.Value, conn, tran);
                return iResult;
            }
        }

        public static int UpdateClicks(int noticeId, OleDbConnection conn, OleDbTransaction tran)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("Update Notice set Clicks = Clicks+1 where NoticeID = ?");
            return Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@NoticeID", OleDbType.Integer) { Value = noticeId });
        }

        //设定公告顺序
        public static void SetNoticeOrdinal(Dal.Models.Notice notice, OleDbConnection conn, OleDbTransaction trans = null)
        {
            if (notice == null || notice.NoticeID == null)
            {
                throw new Exception("参数错误!");
            }

            List<Dal.Models.Notice> lstNotice = GetNoticeList(notice.ActivityID.Value, conn, trans).Where(n => n.NoticeID != notice.NoticeID).ToList();
            if (notice.Ordinal == null || notice.Ordinal > lstNotice.Count)
            {
                lstNotice.Add(notice);
            }
            else if (notice.Ordinal <= 0)
            {
                lstNotice.Insert(0, notice);
            }
            else
            {
                lstNotice.Insert(notice.Ordinal.Value - 1, notice);
            }

            string strSql = " UPDATE Notice set Ordinal = ? where NoticeID = ? ";
            for (int i = 0; i < lstNotice.Count; i++)
            {
                Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                 , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = i + 1 }
                 , new OleDbParameter("@NoticeID", OleDbType.Integer) { Value = lstNotice[i].NoticeID.Value });
            }
        }

        public static void ResetOrdinal(int iActivityID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            // 重排内部序号
            string strSql = @"WITH CTE AS(SELECT *, rn = ROW_NUMBER() OVER(ORDER BY Ordinal) FROM Notice WHERE ActivityID = ? ) 
                              UPDATE CTE SET Ordinal = rn ";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });
        }

        public static int CountNotice(int ActivityID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " SELECT COUNT(*) FROM Notice WHERE ActivityID = ? ";
            int iResult = Common.ToInt32(Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = ActivityID })).Value;
            return iResult;
        }

        public static Dal.Models.Notice GetNotice(int ActivityID, int Ordinal, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " SELECT * FROM Notice WHERE ActivityID = ? and Ordinal = ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, trans
                 , new OleDbParameter("@NoticeID", OleDbType.Integer) { Value = ActivityID }
                 , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = Ordinal });
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Notice>(reader);
        }
        public static Dal.Models.Notice GetLastNotice(int ActivityID,OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " SELECT * FROM Notice WHERE ActivityID = ?";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, trans
                 , new OleDbParameter("@NoticeID", OleDbType.Integer) { Value = ActivityID });
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Notice>(reader);
        }
    }
}
