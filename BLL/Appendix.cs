using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Appendix
    {
        public static List<Dal.Models.Appendix> GetAppendixListPrize(int iPrizeID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "select * from Appendix where PrizeID = ? ";

            return Dal.OleDbHlper.GetList<Dal.Models.Appendix>(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iPrizeID });
        }

        public static List<Dal.Models.Appendix> GetAppendixListSpecialty(int iSpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "select * from Appendix where SpecialtyID = ? ORDER BY Ordinal";

            return Dal.OleDbHlper.GetList<Dal.Models.Appendix>(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID });
        }

        public static void DeleteAppendix(int iSpecialtyID, int iAppendixID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " delete from Appendix where AppendixID = ?";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@AppendixID", OleDbType.Integer) { Value = iAppendixID });

            ResetOrdinal(iSpecialtyID,conn,tran);
        }

        public static void ClearAppendix(int iOwnerID, Dal.Models.AppendixType type, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strRecord = type == Dal.Models.AppendixType.Specialty ? "SpecialtyID" : "PrizeID";
            string strSql = " delete from Appendix where " + strRecord + " = ?";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = iOwnerID });
        }

        public static int Count(int iOwnerID, Dal.Models.AppendixType type, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strRecord = type == Dal.Models.AppendixType.Specialty ? "SpecialtyID" : "PrizeID";
            string strSql = " select count(*) from Appendix where " + strRecord + " = ?";
            return Common.ToInt32(Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = iOwnerID })) ?? 0;
        }

        public static Dal.Models.Appendix GetAppendix(int iAppendixID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from Appendix where  AppendixID = ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@AppendixID", OleDbType.Integer) { Value = iAppendixID });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Appendix>(reader);
        }
        public static Dal.Models.Appendix GetAppendix(int iOwnerID, Dal.Models.AppendixType type, string strAppendixName, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strRecord = type == Dal.Models.AppendixType.Specialty ? "SpecialtyID" : "PrizeID";
            string strSql = " select * from Appendix where " + strRecord + " = ? and AppendixName = ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = iOwnerID }
                , new OleDbParameter("@AppendixName", OleDbType.VarWChar) { Value = strAppendixName });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Appendix>(reader);
        }

        public static Dal.Models.Appendix GetAppendix(int iOwnerID, Dal.Models.AppendixType type, int iOrdinal, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strRecord = type == Dal.Models.AppendixType.Specialty ? "SpecialtyID" : "PrizeID";
            string strSql = " select * from Appendix where " + strRecord + " = ? and Ordinal = ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = iOwnerID }
                , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = iOrdinal });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Appendix>(reader);
        }

        public static List<Dal.Models.Appendix> GetAppendixList(int iOwnerID, Dal.Models.AppendixType type, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strRecord = type == Dal.Models.AppendixType.Specialty ? "SpecialtyID" : "PrizeID";
            string strSql = " select * from Appendix where " + strRecord + " = ? order by Ordinal ";

            return Dal.OleDbHlper.GetList<Dal.Models.Appendix>(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = iOwnerID });
        }

        public static void SetOrdinal(Dal.Models.Appendix appendix, OleDbConnection conn, OleDbTransaction trans = null)
        {
            if (appendix == null || appendix.AppendixID == null)
            {
                throw new Exception("参数错误!");
            }

            Dal.Models.AppendixType tp = appendix.SpecialtyID == null ? Dal.Models.AppendixType.Prize : Dal.Models.AppendixType.Specialty;
            int iOwnerID = tp == Dal.Models.AppendixType.Specialty ? appendix.SpecialtyID.Value : appendix.PrizeID.Value;
            List<Dal.Models.Appendix> lstAppendix = GetAppendixList(iOwnerID, tp, conn, trans).Where(s => s.AppendixID != appendix.AppendixID).ToList();
            if (appendix.Ordinal == null || appendix.Ordinal > lstAppendix.Count)
            {
                lstAppendix.Add(appendix);
            }
            else if (appendix.Ordinal <= 0)
            {
                lstAppendix.Insert(0, appendix);
            }
            else
            {
                lstAppendix.Insert(appendix.Ordinal.Value - 1, appendix);
            }

            string strSql = " UPDATE Appendix set Ordinal = ? where AppendixID = ? ";
            for (int i = 0; i < lstAppendix.Count; i++)
            {
                Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                    , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = i + 1 }
                    , new OleDbParameter("@AppendixID", OleDbType.Integer) { Value = lstAppendix[i].AppendixID.Value });
            }
        }

        public static void ResetOrdinal(int iSpecialtyID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            // 重排内部序号
            string strSql = @"WITH CTE AS(SELECT *, rn = ROW_NUMBER() OVER(ORDER BY Ordinal) FROM Appendix WHERE SpecialtyID = ? ) 
                              UPDATE CTE SET Ordinal = rn ";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
             , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID });
        }

        public static void SetAppendix(Dal.Models.Appendix appendix, OleDbConnection conn, OleDbTransaction tran = null)
        {
            if (string.IsNullOrEmpty(appendix.AppendixName)
                || appendix.UploadLimitMax == null
                || (appendix.PrizeID != null && appendix.SpecialtyID != null)
                || (appendix.PrizeID == null && appendix.SpecialtyID == null))
            {
                throw new Exception("附件集信息不全!");
            }

            if (appendix.UploadLimitMin == null)
            {
                appendix.UploadLimitMin = 0;
            }

            Dal.Models.AppendixType type = appendix.SpecialtyID == null ? Dal.Models.AppendixType.Prize : Dal.Models.AppendixType.Specialty;
            int iOwnerID = type == Dal.Models.AppendixType.Specialty ? appendix.SpecialtyID.Value : appendix.PrizeID.Value;
            string strRecord = type == Dal.Models.AppendixType.Specialty ? "SpecialtyID" : "PrizeID";
            Dal.Models.Appendix appendixOriginal = GetAppendix(iOwnerID, type, appendix.AppendixName, conn, tran);
            if (appendix.AppendixID != null && appendix.AppendixID > 0)//编辑
            {
                string strSql = " update Appendix set Ordinal = ?, AppendixName = ?, UploadLimitMax = ?, UploadLimitMin = ?, SizeLimit = ?, IsRequired = ? where AppendixID = ?";
                Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
                    , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = appendix.Ordinal }
                    , new OleDbParameter("@AppendixName", OleDbType.VarWChar) { Value = appendix.AppendixName }
                    , new OleDbParameter("@UploadLimitMax", OleDbType.Integer) { Value = appendix.UploadLimitMax }
                    , new OleDbParameter("@UploadLimitMin", OleDbType.Integer) { Value = appendix.UploadLimitMin }
                    , new OleDbParameter("@SizeLimit", OleDbType.Integer) { Value = appendix.SizeLimit }
                    , new OleDbParameter("@IsRequired", OleDbType.Boolean) { Value = appendix.IsRequired }
                    , new OleDbParameter("@AppendixID", OleDbType.Integer) { Value = appendix.AppendixID });
            }
            else
            {
                if (appendixOriginal != null && appendixOriginal.AppendixID != appendix.AppendixID)
                {
                    throw new Exception("附件重名!");
                }
                else
                {
                    string strSql = " insert into Appendix (" + strRecord + ", Ordinal, AppendixName, UploadLimitMax, UploadLimitMin, SizeLimit, IsRequired) values (?, ?, ?, ?, ?, ?, ?) ";
                    Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
                        , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = iOwnerID }
                        , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = appendix.Ordinal }
                        , new OleDbParameter("@AppendixName", OleDbType.VarWChar) { Value = appendix.AppendixName }
                        , new OleDbParameter("@UploadLimitMax", OleDbType.Integer) { Value = appendix.UploadLimitMax }
                        , new OleDbParameter("@UploadLimitMin", OleDbType.Integer) { Value = appendix.UploadLimitMin }
                        , new OleDbParameter("@SizeLimit", OleDbType.Integer) { Value = appendix.SizeLimit }
                        , new OleDbParameter("@IsRequired", OleDbType.Boolean) { Value = appendix.IsRequired });

                    appendix.AppendixID = GetAppendix(iOwnerID, type, appendix.AppendixName, conn, tran).AppendixID;
                }
            }

            SetOrdinal(appendix, conn, tran);
        }
    }
}
