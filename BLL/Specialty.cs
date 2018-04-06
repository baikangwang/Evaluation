using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Linq;

namespace BLL
{
    public class Specialty
    {
        /// <summary>
        /// 根据专业编码获取专业信息
        /// </summary>
        /// <param name="strSpecialtyCode"></param>
        /// <returns></returns>
        public static Dal.Models.Specialty GetSpecialty(int iActivityID, string strSpecialtyCode, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " SELECT * FROM V_Specialty WHERE ActivityID = ? and SpecialtyCode = ? ";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID }
                , new OleDbParameter("@SpecialtyCode", OleDbType.VarWChar) { Value = strSpecialtyCode });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Specialty>(reader);
        }

        /// <summary>
        /// 根据专业编号获取专业信息
        /// </summary>
        /// <param name="iSpecialtyID"></param>
        /// <returns></returns>
        public static Dal.Models.Specialty GetSpecialty(int iSpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " SELECT * FROM V_Specialty WHERE SpecialtyID = ? ";
             IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID });

             return Dal.Models.BaseEntity.GetEntity<Dal.Models.Specialty>(reader);
        }

        public static int Count(int iActivityID, int? iParentID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            int? iResult = 0;
            string strSql = " SELECT COUNT(*) FROM Specialty WHERE ActivityID = ? ";
            if (iParentID == null)
            {
                strSql += " and ParentID is null ";

               iResult = Common.ToInt32(Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text
                    , tran, new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID }));
            }
            else
            {
                strSql += " AND ParentID = ? ";

                iResult = Common.ToInt32(Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran
                    , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID }
                    , new OleDbParameter("@ParentID", OleDbType.Integer) { Value = iParentID }));
            }

            return iResult ?? 0;
        }

        public static List<Dal.Models.Specialty> GetDirectlyChildList(int iActivityID, int? iParentID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            if (iParentID == null)
            {
                return GetSpecialtyList(iActivityID, true, conn, tran);
            }
            else
            {
                return GetDirectlyChildList(iParentID.Value, conn, tran);
            }
        }

        public static List<Dal.Models.Specialty> GetDirectlyChildList(int iParentID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " SELECT * FROM V_Specialty WHERE ParentID = ? ORDER BY Ordinal ";
            return Dal.OleDbHlper.GetList<Dal.Models.Specialty>(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@ParentID", OleDbType.Integer) { Value = iParentID });
        }

        public static List<Dal.Models.Specialty> GetDirectlyChildTowList(int? iSpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            if (iSpecialtyID == null)
            {
                string strSql = " SELECT SpecialtyID FROM Specialty WHERE ParentID is null ORDER BY Ordinal ";
                return Dal.OleDbHlper.GetList<Dal.Models.Specialty>(strSql, conn, CommandType.Text, tran);
            }
            else
            {
                string strSql = " SELECT * FROM V_Specialty WHERE ParentID = ? and SpecialtyLevel != '三级' ORDER BY Ordinal ";
                return Dal.OleDbHlper.GetList<Dal.Models.Specialty>(strSql, conn, CommandType.Text, tran
                     , new OleDbParameter("@ParentID", OleDbType.Integer) { Value = iSpecialtyID });
            }
        }

        /// <summary>
        /// 获取指定专业的所有子专业
        /// </summary>
        /// <param name="iSpecialtyID"></param>
        /// <returns></returns>
        public static List<Dal.Models.Specialty> GetChildList(int iParentID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " SELECT * FROM V_Specialty WHERE ParentID = ? ORDER BY Ordinal ";
            List<Dal.Models.Specialty> lstChildSpecialty = Dal.OleDbHlper.GetList<Dal.Models.Specialty>(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@ParentID", OleDbType.Integer) { Value = iParentID });


            List<Dal.Models.Specialty> lst = new List<Dal.Models.Specialty>();
            foreach (Dal.Models.Specialty item in lstChildSpecialty)
            {
                lst.Add(item);
                List<Dal.Models.Specialty> lstChild = GetChildList(item.SpecialtyID.Value, conn, tran);
                if (lstChild.Count > 0)
                {
                    lst.AddRange(lstChild);
                }
            }

            return lst;
        }

        /// <summary>
        /// 删除专业和专业的子专业（递归）(已有申报奖项的专业，不允许删除)
        /// </summary>
        /// <param name="iSpecialtyID"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        public static void DeleteSpecialty(int iSpecialtyID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            StringBuilder sbSql = new StringBuilder();

            // 已有申报奖项的专业，不允许删除
            Dal.Models.Specialty mSpecialty = GetSpecialty(iSpecialtyID, conn, trans);

            if ((mSpecialty.PrizeCount ?? 0) > 0 || (mSpecialty.ChildCount ?? 0) > 0 || Declaration.CountInSpecialty(mSpecialty.SpecialtyID.Value,conn, trans) > 0)
            {
                throw new Exception("当前专业已有申报奖项，不能删除！");
            }
            else
            {
                // 删除专业、子专业奖项
                string strSql = " delete FROM Prize WHERE SpecialtyID = ? or SpecialtyID in (select SpecialtyID from dbo.Fn_GetChildSpecialty(?)) ";
                Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                     , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID }
                     , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID });

                // 删除专业、子专业附件
                strSql = "delete from Appendix where SpecialtyID = ? or SpecialtyID in (select SpecialtyID from dbo.Fn_GetChildSpecialty(?)) ";
                Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                     , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID }
                     , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID });

                // 删除专业、子专业图集
                strSql = "delete from Atlas where SpecialtyID = ? or SpecialtyID in (select SpecialtyID from dbo.Fn_GetChildSpecialty(?)) ";
                Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                     , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID }
                     , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID });

                // 删除专业、子专业
                strSql = " delete FROM Specialty WHERE SpecialtyID = ? or SpecialtyID in (select SpecialtyID from dbo.Fn_GetChildSpecialty(?)) ";
                Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                     , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID }
                     , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID });

                // 重排序号
                ResetOrdinal(mSpecialty.ActivityID.Value, mSpecialty.ParentID, conn, trans);
            }
        }

        /// <summary>
        /// 重排专业内部序号和整体序号
        /// </summary>
        /// <param name="iActivityID">活动编号</param>
        /// <param name="iParentSpecialtyID">父专业编号</param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        public static void ResetOrdinal(int iActivityID, int? iParentSpecialtyID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            // 重排专业内部序号
            string strSql = @"WITH CTE AS(SELECT *, rn = ROW_NUMBER() OVER(ORDER BY Ordinal) FROM Specialty WHERE ParentID = ? ) 
                              UPDATE CTE SET Ordinal = rn ";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
             , new OleDbParameter("@ParentID", OleDbType.Integer) { Value = iParentSpecialtyID });

            // 重拍整体序号
            strSql = @"WITH CTE AS(SELECT *, rn = ROW_NUMBER() OVER(ORDER BY TotalOrdinal) FROM Specialty WHERE ActivityID = ? ) 
                       UPDATE CTE SET TotalOrdinal = rn ";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
             , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });
        }

        public static Dal.Models.Specialty GetSpecialtyByCode(string strSpecialtyCode, int iActivityID, OleDbConnection conn, OleDbTransaction tran = null)
        {
           string strSql = " SELECT * FROM V_Specialty WHERE SpecialtyCode = ? and ActivityID = ? ";

           IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
               , new OleDbParameter("@SpecialtyCode", OleDbType.VarWChar) { Value = strSpecialtyCode }
               , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

           return Dal.Models.BaseEntity.GetEntity<Dal.Models.Specialty>(reader);
        }

        public static Dal.Models.Specialty GetSpecialtyByName(string strSpecialtyName, int iActivityID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " SELECT * FROM Specialty WHERE SpecialtyName = ? and ActivityID = ?  ";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@SpecialtyName", OleDbType.VarWChar) { Value = strSpecialtyName }
                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Specialty>(reader);
        }

        public static Dal.Models.Specialty GetSpecialtyByTotalOrdinal(int iTotalOrdinal, int iActivityID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from V_Specialty where ActivityID = ? and TotalOrdinal = ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID }
                 , new OleDbParameter("@TotalOrdinal", OleDbType.Integer) { Value = iTotalOrdinal });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Specialty>(reader);
        }

        public static Dal.Models.Specialty GetSpecialtyByOrdinal(int iOrdinal, int? iParentID, int iActivityID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "";
            IDataReader reader = null;
            if (iParentID == null)
            {
                strSql = " select * from V_Specialty where ActivityID = ? and ParentID is null and Ordinal = ? ";
                reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                     , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID }
                     , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = iOrdinal });
            }
            else
            {
                strSql = " select * from V_Specialty where ActivityID = ? and ParentID = ? and Ordinal = ? ";
                reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                     , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID }
                     , new OleDbParameter("@ParentID", OleDbType.Integer) { Value = iParentID }
                     , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = iOrdinal });
            }

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Specialty>(reader);
        }

        public static string GetTempletCode(int iSpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            Dal.Models.Specialty specialty = Specialty.GetSpecialty(iSpecialtyID, conn, tran);

            // 默认继承模版
            if (specialty.IsInheritTemplet == null)
            {
                specialty.IsInheritTemplet = true;
            }

            if (specialty.IsInheritTemplet.Value && specialty.ParentID.HasValue)
            {
                return GetTempletCode(specialty.ParentID.Value, conn, tran);
            }

            return specialty.TemplateCode;
        }

        public static string GetSpecialtyCode(int iActivityID, int? iParentID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " select max(SpecialtyCode) from Specialty where ActivityID = ? ";
            object objResult = null;
            if (iParentID == null)
            {
                strSql += " and ParentID is null ";
                objResult = Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, trans
                           , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });
            }
            else
            {
                strSql += " and ParentID = ? ";
                objResult = Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, trans
                  , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID }
                  , new OleDbParameter("@ParentID", OleDbType.Integer) { Value = iParentID });
            }

            if (iParentID == null)
            {
                return (Convert.ToInt32(objResult == null || objResult == DBNull.Value ? "00" : objResult ) + 10000).ToString("D6");
            }
            else
            {
                // 获取父专业
                Dal.Models.Specialty spec = GetSpecialty(iParentID.Value, conn, trans);

                if (spec.ParentID == null)
                {
                    // 二级专业
                    return (Convert.ToInt32(objResult == null || objResult == DBNull.Value ? spec.SpecialtyCode : objResult) + 100).ToString("D6");
                }
                else
                {
                    // 第一个三级专业
                    return (Convert.ToInt32(objResult == null || objResult == DBNull.Value ? spec.SpecialtyCode : objResult) + 1).ToString("D6");
                }
            }
        }

        public static void SetOrdinal(Dal.Models.Specialty specialty, OleDbConnection conn, OleDbTransaction trans = null)
        {
            if (specialty == null || specialty.ActivityID == null || specialty.SpecialtyID == null)
            {
                throw new Exception("参数错误!");
            }

            List<Dal.Models.Specialty> lstSpecialty = GetDirectlyChildList(
                specialty.ActivityID.Value, specialty.ParentID, conn, trans).Where(s => s.SpecialtyID != specialty.SpecialtyID).ToList();

            if (specialty.Ordinal == null || specialty.Ordinal > lstSpecialty.Count)
            {
                lstSpecialty.Add(specialty);
            }
            else if (specialty.Ordinal <= 0)
            {
                lstSpecialty.Insert(0, specialty);
            }
            else
            {
                lstSpecialty.Insert(specialty.Ordinal.Value - 1, specialty);
            }

            string strSql = " UPDATE Specialty set Ordinal = ? where SpecialtyID = ? "; 
            for (int i = 0; i < lstSpecialty.Count; i++)
            {
                Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                    , new OleDbParameter("@Ordinal", OleDbType.VarWChar) { Value = i + 1 }
                    , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = lstSpecialty[i].SpecialtyID.Value });
            }

            List<Dal.Models.Specialty> lstTotalSpecialty = GetSpecialtyList(specialty.ActivityID.Value, false, conn, trans);
            strSql = " UPDATE Specialty set TotalOrdinal = ? where SpecialtyID = ? ";
            for (int i = 0; i < lstTotalSpecialty.Count; i++)
            {
                Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                    , new OleDbParameter("@TotalOrdinal", OleDbType.VarWChar) { Value = i + 1 }
                    , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = lstTotalSpecialty[i].SpecialtyID.Value });
            }
        }

        /// <summary>
        /// 创建、删除时需要的传入参数检查以及缺省值设定
        /// </summary>
        /// <param name="specialty"></param>
        /// <returns></returns>
        public static void PreCheck(Dal.Models.Specialty specialty, OleDbConnection conn, OleDbTransaction trans = null)
        {
            // 必须项检查
            if (specialty.ActivityID == null
                || string.IsNullOrEmpty(specialty.SpecialtyName))
            {
                throw new Exception("参数错误!");
            }

            //需要查询奖项有没有
            if(specialty.ParentID !=null)
            {
                int iPrize = Prize.Count(specialty.ParentID.Value, conn, trans);
                if(iPrize>0)
                {
                    throw new Exception("已有奖项的专业不允许修改本专业和创建子专业!");
                }
            }

            // 重名检查
            Dal.Models.Specialty specialtyOriginal = GetSpecialtyByName(specialty.SpecialtyName, specialty.ActivityID.Value, conn, trans);
            if (specialtyOriginal!=null)
            {
                if (specialtyOriginal.SpecialtyID != specialty.SpecialtyID)
                {
                    throw new Exception("本次活动已有同名专业!");
                }
            }

            if (string.IsNullOrEmpty(specialty.SpecialtyCode))
            {
                // 获取专业编码
                specialty.SpecialtyCode = GetSpecialtyCode(specialty.ActivityID.Value, specialty.ParentID, conn, trans);
            }

            if (specialty.CreateTime == null || specialty.LastUpdateTime == null)
            {
                specialty.CreateTime = DateTime.Now;
                specialty.LastUpdateTime = specialty.CreateTime;
            }

            // 默认继承时间节点
            if (specialty.IsInheritSchedule == null)
            {
                specialty.IsInheritSchedule = true;
            }

            // 默认继承模板
            if (specialty.IsInheritTemplet == null)
            {
                if (specialty.ParentID != null)
                {
                    specialty.IsInheritTemplet = true;
                    specialty.TemplateCode = GetTempletCode(specialty.ParentID.Value, conn, trans);
                }
                else
                {
                    specialty.IsInheritTemplet = false;
                }
            }
            else
            {
                if (specialty.ParentID == null)
                {
                    specialty.IsInheritTemplet = false;
                }
                else
                {
                    if (specialty.IsInheritTemplet.Value)
                    {
                        specialty.TemplateCode = GetTempletCode(specialty.ParentID.Value, conn, trans);
                    }
                }
            }

            if (string.IsNullOrEmpty(specialty.TemplateCode))
            {
                throw new Exception("请选择模板!");
            }

            // 默认不共享获奖名额
            if (specialty.IsShareQuota == null)
            {
                specialty.IsShareQuota = false;
            }
        }

        //是否已经存在该专业名称
        public static int IsExist(string strSpecialtyName)
        {
            string strsql = "SELECT COUNT(SpecialtyID) AS  num  FROM    Specialty  where SpecialtyName='" + strSpecialtyName+"'";
            OleDbConnection conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
            conn.Open();
            OleDbTransaction trans = null;
            int num = Convert.ToInt32(Dal.OleDbHlper.ExecuteScalar(strsql,conn,CommandType.Text, trans));
            return num;
        }

        /// <summary>
        /// 创建专业
        /// </summary>
        /// <param name="specialty"></param>
        /// <returns></returns>
        public static int CreateSpecialty(Dal.Models.Specialty specialty, OleDbConnection conn, OleDbTransaction trans = null)
        {
            PreCheck(specialty, conn, trans);

            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" INSERT INTO Specialty ( ");
            sbSql.Append("  ActivityID ");
            sbSql.Append(" ,SpecialtyCode ");
            sbSql.Append(" ,SpecialtyName ");
            sbSql.Append(" ,SpecialtyLevel ");
            sbSql.Append(" ,SpecialtyIcon ");
            sbSql.Append(" ,TemplateCode ");
            sbSql.Append(" ,IsShareQuota ");
            sbSql.Append(" ,IsInheritSchedule ");
            sbSql.Append(" ,IsInheritTemplet ");
            sbSql.Append(" ,IsAllowUpdate");
            sbSql.Append(" ,IsAllowSubmit");
            sbSql.Append(" ,ParentID ");
            sbSql.Append(" ,CreateTime ");
            sbSql.Append(" ,LastUpdateTime ");
            sbSql.Append(" ,IsSendReceivePost");
            sbSql.Append(" ,IsSendUpdatePost");
            sbSql.Append(" ,IsSendDeletePost");
            sbSql.Append(" ) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?,?,?,?,?,?,?)");

            // 创建专业
            Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                 , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = specialty.ActivityID }
                 , new OleDbParameter("@SpecialtyCode", OleDbType.VarWChar) { Value = specialty.SpecialtyCode }
                 , new OleDbParameter("@SpecialtyName", OleDbType.VarWChar) { Value = specialty.SpecialtyName }
                 , new OleDbParameter("@SpecialtyLevel", OleDbType.VarWChar) { Value = specialty.SpecialtyLevel }
                 , new OleDbParameter("@SpecialtyIcon", OleDbType.VarWChar) { Value = specialty.SpecialtyIcon }
                 , new OleDbParameter("@TemplateCode", OleDbType.VarWChar) { Value = specialty.TemplateCode }
                 , new OleDbParameter("@IsShareQuota", OleDbType.Boolean) { Value = specialty.IsShareQuota }
                 , new OleDbParameter("@IsInheritSchedule", OleDbType.Boolean) { Value = specialty.IsInheritSchedule }
                 , new OleDbParameter("@IsInheritTemplet", OleDbType.Boolean) { Value = specialty.IsInheritTemplet }
                 , new OleDbParameter("@IsAllowUpdate",OleDbType.Boolean){ Value= specialty.IsAllowUpdate }
                 , new OleDbParameter("@IsAllowSubmit", OleDbType.Boolean) { Value = specialty.IsAllowSubmit }
                 , new OleDbParameter("@ParentID", OleDbType.Integer) { Value = specialty.ParentID }
                 , new OleDbParameter("@CreateTime", OleDbType.DBDate) { Value = specialty.CreateTime }
                 , new OleDbParameter("@LastUpdateTime", OleDbType.DBDate) { Value = specialty.LastUpdateTime }
                 , new OleDbParameter("@IsSendReceivePost", OleDbType.Boolean) { Value = specialty.IsSendReceivePost }
                 , new OleDbParameter("@IsSendUpdatePost", OleDbType.Boolean) { Value = specialty.IsSendUpdatePost }
                 , new OleDbParameter("@IsSendDeletePost", OleDbType.Boolean) { Value = specialty.IsSendDeletePost });

            specialty.SpecialtyID = GetSpecialtyByCode(specialty.SpecialtyCode, specialty.ActivityID.Value, conn, trans).SpecialtyID;

            // 对专业重新排序，设定专业内部序号
            SetOrdinal(specialty, conn, trans);

            return specialty.SpecialtyID.Value;
        }

        /// <summary>
        /// 更新专业信息(调整序号请调用SetOrdinal)
        /// </summary>
        /// <param name="specialty"></param>
        /// <returns></returns>
        public static int UpdateSpecialty(Dal.Models.Specialty specialty, OleDbConnection conn, OleDbTransaction trans = null)
        {
            // 必须项检查
            if (specialty.SpecialtyID == null)
            {
                throw new Exception("参数错误!");
            }

            PreCheck(specialty, conn, trans);

            Dal.Models.Specialty specialtyOriginal = GetSpecialty(specialty.SpecialtyID.Value, conn, trans);

            // 如果原始状态不继承时间表，修改为继承时间表的，需要删除时间表
            if (!specialtyOriginal.IsInheritSchedule.Value && specialty.IsInheritSchedule.Value)
            {
                string strSql = "  DELETE FROM Schedule WHERE SpecialtyID = ? ";
                Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                    , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = specialty.SpecialtyID });
            }

            StringBuilder sbSql = new StringBuilder();
            sbSql.Append("  UPDATE Specialty SET ");
            sbSql.Append("  SpecialtyCode = ? ");
            sbSql.Append(" ,SpecialtyName = ? ");
            sbSql.Append(" ,SpecialtyIcon = ? ");
            sbSql.Append(" ,TemplateCode = ? ");
            sbSql.Append(" ,IsShareQuota = ? ");
            sbSql.Append(" ,IsInheritSchedule = ? ");
            sbSql.Append(" ,IsInheritTemplet = ? ");
            sbSql.Append(" ,IsAllowUpdate = ? ");
            sbSql.Append(" ,IsAllowSubmit = ? ");
            sbSql.Append(" ,ParentID = ? ");
            sbSql.Append(" ,LastUpdateTime = ? ");
            sbSql.Append(" ,IsSendReceivePost = ? ");
            sbSql.Append(" ,IsSendUpdatePost = ? ");
            sbSql.Append(" ,IsSendDeletePost = ? ");
            sbSql.Append(" WHERE SpecialtyID = ? ");
            int iResult = Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                  , new OleDbParameter("@SpecialtyCode", OleDbType.VarWChar) { Value = specialty.SpecialtyCode }
                  , new OleDbParameter("@SpecialtyName", OleDbType.VarWChar) { Value = specialty.SpecialtyName }
                  , new OleDbParameter("@SpecialtyIcon", OleDbType.VarWChar) { Value = specialty.SpecialtyIcon }
                  , new OleDbParameter("@TemplateCode", OleDbType.VarWChar) { Value = specialty.TemplateCode }
                  , new OleDbParameter("@IsShareQuota", OleDbType.Boolean) { Value = specialty.IsShareQuota }
                  , new OleDbParameter("@IsInheritSchedule", OleDbType.Boolean) { Value = specialty.IsInheritSchedule }
                  , new OleDbParameter("@IsInheritTemplet", OleDbType.Boolean) { Value = specialty.IsInheritTemplet }
                  , new OleDbParameter("@IsAllowUpdate", OleDbType.Boolean) { Value = specialty.IsAllowUpdate }
                  , new OleDbParameter("@IsAllowSubmit", OleDbType.Boolean) { Value = specialty.IsAllowSubmit }
                  , new OleDbParameter("@ParentID", OleDbType.Integer) { Value = specialty.ParentID }
                  , new OleDbParameter("@LastUpdateTime", OleDbType.DBDate) { Value = specialty.LastUpdateTime }
                  , new OleDbParameter("@IsSendReceivePost", OleDbType.Boolean) { Value = specialty.IsSendReceivePost }
                  , new OleDbParameter("@IsSendUpdatePost", OleDbType.Boolean) { Value = specialty.IsSendUpdatePost }
                  , new OleDbParameter("@IsSendDeletePost", OleDbType.Boolean) { Value = specialty.IsSendDeletePost }
                  , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = specialty.SpecialtyID });

            SetOrdinal(specialty, conn, trans);

            return iResult;
        }

        /// <summary>
        /// 根据专业编号获取该专业所属在的顶层专业
        /// </summary>
        /// <param name="iPrizeID"></param>
        /// <returns></returns>
        public static Dal.Models.Specialty GetTopSpecialty(int iSpecialtyID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            Dal.Models.Specialty specialty = GetSpecialty(iSpecialtyID, conn, trans);
            if (specialty.ParentID == null)
            {
                return specialty;
            }
            else
            {
                return GetTopSpecialty(specialty.ParentID.Value, conn, trans);
            }
        }

        public static List<Dal.Models.Specialty> GetSpecialtyList(int iActivityID, bool bJustTop, string specialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " SELECT * FROM V_SPECIALTY WHERE ACTIVITYID = ? ";
            if (specialtyID != null && specialtyID.Length > 0)
            {
                strSql += " AND SpecialtyID in (" + specialtyID + ")";
            }
            strSql += "AND PARENTID IS NULL ORDER BY ORDINAL ";

            List<Dal.Models.Specialty> lstSpecialty = Dal.OleDbHlper.GetList<Dal.Models.Specialty>(
                strSql, conn, CommandType.Text, tran, new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

            if (bJustTop)
            {
                return lstSpecialty;
            }
            else
            {
                List<Dal.Models.Specialty> lstAllSpecialty = new List<Dal.Models.Specialty>();
                foreach (Dal.Models.Specialty item in lstSpecialty)
                {
                    lstAllSpecialty.Add(item);
                    List<Dal.Models.Specialty> lstChild = Specialty.GetChildList(item.SpecialtyID.Value, conn, tran);
                    if (lstChild.Count > 0)
                    {
                        lstAllSpecialty.AddRange(lstChild);
                    }
                }

                return lstAllSpecialty;
            }
        }

        public static string GetSpecialtyByUserType(int iActivityID, int iUserID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " SELECT  STUFF((SELECT ','+ CONVERT(varchar,SpecialtyID)  from SPECIALTY  ";
            strSql += " WHERE ACTIVITYID = ? and SpecialtyID in (SELECT  SpecialtyID FROM   UserSpecialty   where UserID = ?) ";
            strSql += " FOR XML PATH('')), 1, 1, '') ";

            string lstSpecialty = Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID }
                , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID }).ToString();

            return lstSpecialty;
        }

        public static List<Dal.Models.Specialty> GetSpecialtyListByUserType(int iActivityID,string iUserType,int iUserID, bool bJustTop, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " SELECT * FROM V_SPECIALTY WHERE ACTIVITYID = ? ";
            if (iUserType == "0804")
            {
                strSql += " and SpecialtyID in  (SELECT  SpecialtyID FROM   UserSpecialty   where UserID = " + iUserID + ") ";
            }
            strSql += " AND PARENTID IS NULL ORDER BY ORDINAL ";

            List<Dal.Models.Specialty> lstSpecialty = Dal.OleDbHlper.GetList<Dal.Models.Specialty>(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

            if (bJustTop)
            {
                return lstSpecialty;
            }
            else
            {
                List<Dal.Models.Specialty> lstAllSpecialty = new List<Dal.Models.Specialty>();
                foreach (Dal.Models.Specialty item in lstSpecialty)
                {
                    lstAllSpecialty.Add(item);
                    List<Dal.Models.Specialty> lstChild = Specialty.GetChildList(item.SpecialtyID.Value, conn, tran);
                    if (lstChild.Count > 0)
                    {
                        lstAllSpecialty.AddRange(lstChild);
                    }
                }

                return lstAllSpecialty;
            }
        }

        public static List<Dal.Models.Specialty> GetUserSpecialtyList(int iActivityID, int iUserID, bool bJustTop, OleDbConnection conn, string strSelectedSpecialties = "", OleDbTransaction tran = null)
        {
            if (bJustTop)
            {
                string strSql = " SELECT s.* FROM V_SPECIALTY s inner join UserSpecialty us on us.SpecialtyID = s.SpecialtyID WHERE s.ACTIVITYID = ? AND us.UserID = ?";
                if (!string.IsNullOrEmpty(strSelectedSpecialties))
                {
                    strSql += " and s.SpecialtyID in (" + strSelectedSpecialties + ")";
                }
                return Dal.OleDbHlper.GetList<Dal.Models.Specialty>(
                    strSql, conn, CommandType.Text, tran
                    , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID }
                    , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID });
            }
            else
            {
                List<Dal.Models.Specialty> lstUserSpecialty = GetUserSpecialtyList(iActivityID, iUserID, true, conn,strSelectedSpecialties, tran);
                List<Dal.Models.Specialty> lstResult = new List<Dal.Models.Specialty>();
                foreach (Dal.Models.Specialty item in lstUserSpecialty)
                {
                    lstResult.Add(item);
                    lstResult.AddRange(GetChildList(item.SpecialtyID.Value, conn, tran));
                }

                return lstResult;
            }
        }

        public static List<Dal.Models.Specialty> GetSpecialtyList(int iActivityID, bool bJustTop, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " SELECT * FROM V_SPECIALTY WHERE ACTIVITYID = ? AND PARENTID IS NULL ORDER BY ORDINAL ";

            List<Dal.Models.Specialty> lstSpecialty = Dal.OleDbHlper.GetList<Dal.Models.Specialty>(
                strSql, conn, CommandType.Text, tran, new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

            if (bJustTop)
            {
                return lstSpecialty;
            }
            else
            {
                List<Dal.Models.Specialty> lstAllSpecialty = new List<Dal.Models.Specialty>();
                foreach (Dal.Models.Specialty item in lstSpecialty)
                {
                    lstAllSpecialty.Add(item);
                    List<Dal.Models.Specialty> lstChild = Specialty.GetChildList(item.SpecialtyID.Value, conn, tran);
                    if (lstChild.Count > 0)
                    {
                        lstAllSpecialty.AddRange(lstChild);
                    }
                }

                return lstAllSpecialty;
            }
        }

        public static List<Dal.Models.Specialty> GetSpecialtyDropList(int iActivityID,string strUserType,int iUserID,  bool bJustTop, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " SELECT s.* FROM V_SPECIALTY s WHERE ACTIVITYID = ? ";
            strSql += " and s.SpecialtyID not in (SELECT  SpecialtyID FROM  Prize)";
            if (strUserType == "0804")
            {
                strSql += " and s.SpecialtyID in  (SELECT  u.SpecialtyID FROM UserSpecialty u  where UserID = " + iUserID + ") ";
            }
            strSql += " AND PARENTID IS NULL ORDER BY ORDINAL";

            List<Dal.Models.Specialty> lstSpecialty = Dal.OleDbHlper.GetList<Dal.Models.Specialty>(
                strSql, conn, CommandType.Text, tran, new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

            if (bJustTop)
            {
                return lstSpecialty;
            }
            else
            {
                List<Dal.Models.Specialty> lstAllSpecialty = new List<Dal.Models.Specialty>();
                foreach (Dal.Models.Specialty item in lstSpecialty)
                {
                    lstAllSpecialty.Add(item);
                    List<Dal.Models.Specialty> lstChild = Specialty.GetChildList(item.SpecialtyID.Value, conn, tran);
                    if (lstChild.Count > 0)
                    {
                        lstAllSpecialty.AddRange(lstChild);
                    }
                }

                return lstAllSpecialty;
            }
        }

        public static List<Dal.Models.Specialty> GetSpecialtyList(int iActivityID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " SELECT * FROM V_SPECIALTY WHERE ACTIVITYID = ? ORDER BY TotalOrdinal ";
            List<Dal.Models.Specialty> lstSpecialty = Dal.OleDbHlper.GetList<Dal.Models.Specialty>(strSql, conn, CommandType.Text, tran,
                new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });
            return lstSpecialty;
        }
    }
}
