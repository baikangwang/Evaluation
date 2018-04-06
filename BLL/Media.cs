using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Media
    {
        public static List<Dal.Models.Media> GetMediaListPrize(int iPrizeID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "select * from Media where PrizeID = ? ";

            return Dal.OleDbHlper.GetList<Dal.Models.Media>(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iPrizeID });
        }

        public static List<Dal.Models.Media> GetMediaListSpecialty(int iSpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "select * from Media where SpecialtyID = ? ORDER BY Ordinal";

            return Dal.OleDbHlper.GetList<Dal.Models.Media>(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID });
        }

        public static void DeleteMedia(int iSpecialtyID, int iMediaID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " delete from Media where MediaID = ?";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@MediaID", OleDbType.Integer) { Value = iMediaID });

            ResetOrdinal(iSpecialtyID,conn,tran);
        }

        public static void ClearMedia(int iOwnerID, Dal.Models.MediaType type, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strRecord = type == Dal.Models.MediaType.Specialty ? "SpecialtyID" : "PrizeID";
            string strSql = " delete from Media where " + strRecord + " = ?";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = iOwnerID });
        }

        public static int Count(int iOwnerID, Dal.Models.MediaType type, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strRecord = type == Dal.Models.MediaType.Specialty ? "SpecialtyID" : "PrizeID";
            string strSql = " select count(*) from Media where " + strRecord + " = ?";
            return Common.ToInt32(Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = iOwnerID })) ?? 0;
        }

        public static Dal.Models.Media GetMedia(int iMediaID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from Media where  MediaID = ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@MediaID", OleDbType.Integer) { Value = iMediaID });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Media>(reader);
        }
        public static Dal.Models.Media GetMedia(int iOwnerID, Dal.Models.MediaType type, string strMediaName, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strRecord = type == Dal.Models.MediaType.Specialty ? "SpecialtyID" : "PrizeID";
            string strSql = " select * from Media where " + strRecord + " = ? and MediaName = ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = iOwnerID }
                , new OleDbParameter("@MediaName", OleDbType.VarWChar) { Value = strMediaName });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Media>(reader);
        }

        public static Dal.Models.Media GetMedia(int iOwnerID, Dal.Models.MediaType type, int iOrdinal, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strRecord = type == Dal.Models.MediaType.Specialty ? "SpecialtyID" : "PrizeID";
            string strSql = " select * from Media where " + strRecord + " = ? and Ordinal = ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = iOwnerID }
                , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = iOrdinal });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Media>(reader);
        }

        public static List<Dal.Models.Media> GetMediaList(int iOwnerID, Dal.Models.MediaType type, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strRecord = type == Dal.Models.MediaType.Specialty ? "SpecialtyID" : "PrizeID";
            string strSql = " select * from Media where " + strRecord + " = ? order by Ordinal ";

            return Dal.OleDbHlper.GetList<Dal.Models.Media>(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = iOwnerID });
        }

        public static void SetOrdinal(Dal.Models.Media Media, OleDbConnection conn, OleDbTransaction trans = null)
        {
            if (Media == null || Media.MediaID == null)
            {
                throw new Exception("参数错误!");
            }

            Dal.Models.MediaType tp = Media.SpecialtyID == null ? Dal.Models.MediaType.Prize : Dal.Models.MediaType.Specialty;
            int iOwnerID = tp == Dal.Models.MediaType.Specialty ? Media.SpecialtyID.Value : Media.PrizeID.Value;
            List<Dal.Models.Media> lstMedia = GetMediaList(iOwnerID, tp, conn, trans).Where(s => s.MediaID != Media.MediaID).ToList();
            if (Media.Ordinal == null || Media.Ordinal > lstMedia.Count)
            {
                lstMedia.Add(Media);
            }
            else if (Media.Ordinal <= 0)
            {
                lstMedia.Insert(0, Media);
            }
            else
            {
                lstMedia.Insert(Media.Ordinal.Value - 1, Media);
            }

            string strSql = " UPDATE Media set Ordinal = ? where MediaID = ? ";
            for (int i = 0; i < lstMedia.Count; i++)
            {
                Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                    , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = i + 1 }
                    , new OleDbParameter("@MediaID", OleDbType.Integer) { Value = lstMedia[i].MediaID.Value });
            }
        }

        public static void ResetOrdinal(int iSpecialtyID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            // 重排内部序号
            string strSql = @"WITH CTE AS(SELECT *, rn = ROW_NUMBER() OVER(ORDER BY Ordinal) FROM Media WHERE SpecialtyID = ? ) 
                              UPDATE CTE SET Ordinal = rn ";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
             , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID });
        }

        public static void SetMedia(Dal.Models.Media Media, OleDbConnection conn, OleDbTransaction tran = null)
        {
            if (string.IsNullOrEmpty(Media.MediaName)
                || (Media.PrizeID != null && Media.SpecialtyID != null)
                || (Media.PrizeID == null && Media.SpecialtyID == null))
            {
                throw new Exception("视频信息不全!");
            }

            Dal.Models.MediaType type = Media.SpecialtyID == null ? Dal.Models.MediaType.Prize : Dal.Models.MediaType.Specialty;
            int iOwnerID = type == Dal.Models.MediaType.Specialty ? Media.SpecialtyID.Value : Media.PrizeID.Value;
            string strRecord = type == Dal.Models.MediaType.Specialty ? "SpecialtyID" : "PrizeID";
            Dal.Models.Media MediaOriginal = GetMedia(iOwnerID, type, Media.MediaName, conn, tran);

            if (Media.MediaID != null && Media.MediaID > 0)//编辑
            {
                string strSql = " update Media set Ordinal = ?, MediaName = ?, SizeLimit = ?, IsRequired = ? where MediaID = ?";
                Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
                    , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = Media.Ordinal }
                    , new OleDbParameter("@MediaName", OleDbType.VarWChar) { Value = Media.MediaName }
                    , new OleDbParameter("@SizeLimit", OleDbType.Integer) { Value = Media.SizeLimit }
                    , new OleDbParameter("@IsRequired", OleDbType.Boolean) { Value = Media.IsRequired }
                    , new OleDbParameter("@MediaID", OleDbType.Integer) { Value = Media.MediaID });
            }
            else
            {
                if (MediaOriginal != null && MediaOriginal.MediaID != Media.MediaID)
                {
                    throw new Exception("视频重名!");
                }
                else
                {
                    string strSql = " insert into Media (" + strRecord + ", Ordinal, MediaName, SizeLimit, IsRequired) values (?, ?, ?, ?, ?) ";
                    Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
                        , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = iOwnerID }
                        , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = Media.Ordinal }
                        , new OleDbParameter("@MediaName", OleDbType.VarWChar) { Value = Media.MediaName }
                        , new OleDbParameter("@SizeLimit", OleDbType.Integer) { Value = Media.SizeLimit }
                        , new OleDbParameter("@IsRequired", OleDbType.Boolean) { Value = Media.IsRequired });

                    Media.MediaID = GetMedia(iOwnerID, type, Media.MediaName, conn, tran).MediaID;
                }
            }

            SetOrdinal(Media, conn, tran);
        }
    }
}
