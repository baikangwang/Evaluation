using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Atlas
    {
        public static Dal.Models.Atlas GetAtlas(int iAtlasID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from Atlas  where AtlasID = ? ";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@AtlasID", OleDbType.Integer) { Value = iAtlasID });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Atlas>(reader);
        }

        public static void DeleteAtlas(int iSpecialtyID, int iAtlasID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " delete from Atlas where AtlasID = ?";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@AtlasID", OleDbType.Integer) { Value = iAtlasID });
            ResetOrdinal(iSpecialtyID, conn, tran);
        }

        public static void ResetOrdinal(int iSpecialtyID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            // 重排内部序号
            string strSql = @"WITH CTE AS(SELECT *, rn = ROW_NUMBER() OVER(ORDER BY Ordinal) FROM Atlas WHERE SpecialtyID = ? ) 
                              UPDATE CTE SET Ordinal = rn ";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID });
        }

        public static List<Dal.Models.Atlas> GetAtlasList(int iSpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from Atlas where SpecialtyID = ? order by Ordinal ";

            return Dal.OleDbHlper.GetList<Dal.Models.Atlas>(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID });
        }

        public static Dal.Models.Atlas GetAtlas(int iOwnerID, Dal.Models.AtlasType type, string strAtlasName, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strRecord = type == Dal.Models.AtlasType.Specialty ? "SpecialtyID" : "PrizeID";
            string strSql = " select * from Atlas where " + strRecord + " = ? and AtlasName = ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = iOwnerID }
                , new OleDbParameter("@AtlasName", OleDbType.VarWChar) { Value = strAtlasName });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Atlas>(reader);
        }

        public static Dal.Models.Atlas GetAtlas(int iOwnerID, Dal.Models.AtlasType type, int iOrdinal, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strRecord = type == Dal.Models.AtlasType.Specialty ? "SpecialtyID" : "PrizeID";
            string strSql = " select * from Atlas where " + strRecord + " = ? and Ordinal = ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = iOwnerID }
                , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = iOrdinal });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Atlas>(reader);
        }

        public static List<Dal.Models.Atlas> GetAtlasList(int iOwnerID, Dal.Models.AtlasType type, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strRecord = type == Dal.Models.AtlasType.Specialty ? "SpecialtyID" : "PrizeID";
            string strSql = " select * from Atlas where " + strRecord + " = ? order by Ordinal ";

            return Dal.OleDbHlper.GetList<Dal.Models.Atlas>(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = iOwnerID });
        }

        public static void SetOrdinal(Dal.Models.Atlas atlas, OleDbConnection conn, OleDbTransaction trans = null)
        {
            if (atlas == null || atlas.AtlasID == null)
            {
                throw new Exception("参数错误!");
            }

            Dal.Models.AtlasType type = atlas.SpecialtyID == null ? Dal.Models.AtlasType.Prize : Dal.Models.AtlasType.Specialty;
            int iOwnerID = type == Dal.Models.AtlasType.Specialty ? atlas.SpecialtyID.Value : atlas.PrizeID.Value;
            List<Dal.Models.Atlas> lstAtlas = GetAtlasList(iOwnerID, type, conn, trans).Where(a => a.AtlasID != atlas.AtlasID).ToList();
            if (atlas.Ordinal == null || atlas.Ordinal > lstAtlas.Count)
            {
                lstAtlas.Add(atlas);
            }
            else if (atlas.Ordinal <= 0)
            {
                lstAtlas.Insert(0, atlas);
            }
            else
            {
                lstAtlas.Insert(atlas.Ordinal.Value - 1, atlas);
            }

            string strSql = " UPDATE Atlas set Ordinal = ? where AtlasID = ? ";
            for (int i = 0; i < lstAtlas.Count; i++)
            {
                Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                    , new OleDbParameter("@Ordinal", OleDbType.VarWChar) { Value = i + 1 }
                    , new OleDbParameter("@AtlasID", OleDbType.Integer) { Value = lstAtlas[i].AtlasID.Value });
            }
        }

        public static void SetAtlas(Dal.Models.Atlas atlas, OleDbConnection conn, OleDbTransaction tran = null)
        {
            if (string.IsNullOrEmpty(atlas.AtlasName) 
                || atlas.UploadLimitMax == null
                || (atlas.PrizeID != null && atlas.SpecialtyID != null)
                || (atlas.PrizeID == null && atlas.SpecialtyID == null))
            {
                throw new Exception("图集信息不全!");
            }

            if (atlas.UploadLimitMin == null)
            {
                atlas.UploadLimitMin = 0;
            }

            Dal.Models.AtlasType type = atlas.SpecialtyID == null ? Dal.Models.AtlasType.Prize : Dal.Models.AtlasType.Specialty;
            int iOwnerID = type == Dal.Models.AtlasType.Specialty ? atlas.SpecialtyID.Value : atlas.PrizeID.Value;
            string strRecord = type == Dal.Models.AtlasType.Specialty ? "SpecialtyID" : "PrizeID";

            Dal.Models.Atlas atlasOriginal = GetAtlas(iOwnerID, type, atlas.AtlasName, conn, tran);
            if (atlasOriginal != null && atlasOriginal.AtlasID != atlas.AtlasID)
            {
                throw new Exception("图集重名!");
            }

            if (atlas.AtlasID == null)
            {
                string strSql = " insert into Atlas (" + strRecord + ", Ordinal, AtlasName, UploadLimitMax, UploadLimitMin, SizeLimit, IsRequired) values (?, ?, ?, ?, ?, ?, ?) ";
                Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
                    , new OleDbParameter("@OwnerID", OleDbType.Integer) { Value = iOwnerID }
                    , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = atlas.Ordinal }
                    , new OleDbParameter("@AtlasName", OleDbType.VarWChar) { Value = atlas.AtlasName }
                    , new OleDbParameter("@UploadLimitMax", OleDbType.Integer) { Value = atlas.UploadLimitMax }
                    , new OleDbParameter("@UploadLimitMin", OleDbType.Integer) { Value = atlas.UploadLimitMin }                    
                    , new OleDbParameter("@SizeLimit", OleDbType.Integer) { Value = atlas.SizeLimit }
                    , new OleDbParameter("@IsRequired", OleDbType.Boolean) { Value = atlas.IsRequired });

                atlas.AtlasID = GetAtlas(iOwnerID, type, atlas.AtlasName, conn, tran).AtlasID;
            }
            else
            {
                string strSql = " update Atlas set Ordinal = ?, AtlasName = ?, UploadLimitMax = ?, UploadLimitMin = ?, SizeLimit = ?, IsRequired = ? where AtlasID = ?";
                Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, tran
                    , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = atlas.Ordinal }
                    , new OleDbParameter("@AtlasName", OleDbType.VarWChar) { Value = atlas.AtlasName }
                    , new OleDbParameter("@UploadLimitMax", OleDbType.Integer) { Value = atlas.UploadLimitMax }
                    , new OleDbParameter("@UploadLimitMin", OleDbType.Integer) { Value = atlas.UploadLimitMin }
                    , new OleDbParameter("@SizeLimit", OleDbType.Integer) { Value = atlas.SizeLimit }
                    , new OleDbParameter("@IsRequired", OleDbType.Boolean) { Value = atlas.IsRequired }
                    , new OleDbParameter("@AtlasID", OleDbType.Integer) { Value = atlas.AtlasID });
            }

            SetOrdinal(atlas, conn, tran);
        }
    }
}
