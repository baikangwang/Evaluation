using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using NotesFor.HtmlToOpenXml;
using Novacode;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace BLL
{
    public static class Declaration
    {
        /// <summary>
        /// 根据申报表编码获取申报表
        /// </summary>
        /// <param name="strCode"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        public static Dal.Models.Declaration GetDeclaration(string strCode, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " SELECT * FROM V_Declaration WHERE DeclarationCode = ? ";

            IDataReader reader;
            reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, trans
               , new OleDbParameter("@DeclarationCode", OleDbType.VarWChar) { Value = strCode });
            if (reader.RecordsAffected == 0)
            {
                throw new Exception("没有找到该申报表");
            }
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Declaration>(reader);
        }

        /// <summary>
        /// 根据项目名获取项目
        /// </summary>
        /// <param name="strDeclarationName"></param>
        /// <param name="iPrizeID"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        public static Dal.Models.Declaration GetDeclaration(string strDeclarationName, int iPrizeID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " SELECT * FROM V_Declaration WHERE PrizeID = ? and DeclarationName = ?";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID }
                , new OleDbParameter("@DeclarationName", OleDbType.VarWChar) { Value = strDeclarationName });
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Declaration>(reader);
        }

        /// <summary>
        /// 模版信息
        /// </summary>
        /// <param name="strPartCode"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        public static Dal.Models.TemplateInfo GetTemplateInfo(string strPartCode, OleDbConnection conn, OleDbTransaction trans = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" select TemplateCode, PartCode, TemplateClass, PartClass, TemplateUrl, NewTemplateUrl, Anchor ");
            sbSql.Append(" from TemplateInfo where PartCode = ? ");

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(sbSql.ToString(), conn, CommandType.Text, trans
                 , new OleDbParameter("@PartCode", OleDbType.Integer) { Value = strPartCode });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.TemplateInfo>(reader);
        }

        /// <summary>
        /// 模版字段信息
        /// </summary>
        /// <param name="strPartCode"></param>
        /// <param name="strRecordNameEn"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        public static Dal.Models.TemplateRecord GetTemplateRecord(string strPartCode, string strRecordNameEn, OleDbConnection conn, OleDbTransaction trans = null)
        {
            Dal.Models.TemplateRecord obj = new Dal.Models.TemplateRecord();

            string strSelectRecordCode = "SELECT * FROM  TemplateRecord  WHERE PartCode = ? and RecordNameEn = ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSelectRecordCode, conn, CommandType.Text, trans
                , new OleDbParameter("@PartCode", OleDbType.VarWChar) { Value = strPartCode }
                , new OleDbParameter("@RecordNameEn", OleDbType.VarWChar) { Value = strRecordNameEn });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.TemplateRecord>(reader);
        }

        /// <summary>
        /// 模版字段信息
        /// </summary>
        /// <param name="TemplateCode"></param>
        /// <param name="strRecordNameEn"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        public static Dal.Models.TemplateRecord GetTemplateRecordByNameEn(string TemplateCode, string strRecordNameEn, OleDbConnection conn, OleDbTransaction trans = null)
        {
            Dal.Models.TemplateRecord obj = new Dal.Models.TemplateRecord();

            string strSelectRecordCode = "SELECT * FROM  TemplateRecord  WHERE TemplateCode = ? and RecordNameEn = ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSelectRecordCode, conn, CommandType.Text, trans
                , new OleDbParameter("@TemplateCode", OleDbType.VarWChar) { Value = TemplateCode }
                , new OleDbParameter("@RecordNameEn", OleDbType.VarWChar) { Value = strRecordNameEn });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.TemplateRecord>(reader);
        }
        /// <summary>
        /// 查询项目列表
        /// </summary>
        /// <param name="user"></param>
        /// <param name="iActiveID"></param>
        /// <returns></returns>
        public static List<Dal.Models.Declaration> GetDeclarationList(Dal.Models.UserInfo user, int iActivityID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            if (user == null)
            {
                throw new Exception("参数错误!");
            }

            StringBuilder sbSql = new StringBuilder();
            List<OleDbParameter> lstPara = new List<OleDbParameter>();

            sbSql.Append(" SELECT D.* FROM V_Declaration AS D ");
            sbSql.Append(" WHERE D.ActivityID = ? ");
            lstPara.Add(new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

            switch (user.UserType)
            {
                case "0801": // 超级管理员可以看所有项目
                case "0802": // 系统管理员可以看所有项目
                case "0803": // 协会管理员可以看所有项目
                    break;
                case "0804": // 分会用户可以看数据权限范围内的项目
                case "0805": // 专家可以看数据权限范围内的项目 
                    sbSql.Append(" AND DeclarationStatus = '1803' ");
                    sbSql.Append(" AND d.ExpertReviewGroupID in ( ");
                    sbSql.Append(" select GroupID from dbo.Fn_GetGroupByUserID(?)) ");
                    lstPara.Add(new OleDbParameter("@UserID", OleDbType.Integer) { Value = user.UserID });
                    break;
                case "0806": // 一级用户可以看本单位的所有项目
                    sbSql.Append(" AND D.OrganizationUserID = ? ");
                    lstPara.Add(new OleDbParameter("@UserID", OleDbType.Integer) { Value = user.UserID });
                    break;
                case "0807": // 二级用户可以看本人所创建的所有项目
                    sbSql.Append(" AND D.UserID = ? ");
                    lstPara.Add(new OleDbParameter("@UserID", OleDbType.Integer) { Value = user.UserID });
                    break;
                case "0808":// 地方协会用户可以看该协会推荐的所有项目
                case "0809":// 地方协会用户可以看该协会推荐的所有项目
                    sbSql.Append(" AND d.RecommendFrom = ? ");
                    lstPara.Add(new OleDbParameter("@UserID", OleDbType.Integer) { Value = user.UserID });
                    break;
            }

            return Dal.OleDbHlper.GetList<Dal.Models.Declaration>(sbSql.ToString(), conn, CommandType.Text, tran, lstPara.ToArray());
        }

        public static List<Dal.Models.Declaration> GetDeclarationExList(Dal.Models.DeclarationSearchCondition condition, OleDbConnection conn, OleDbTransaction tran = null)
        {
            if (condition == null)
            {
                throw new Exception("参数错误!");
            }

            StringBuilder sbSql = new StringBuilder();
            List<OleDbParameter> lstPara = new List<OleDbParameter>();

            //sbSql.Append(" SELECT D.*, tmp.BigOrdinal, tmp.TypeEx FROM V_Declaration AS D ");
            //sbSql.Append(" left join V_Tmp tmp on tmp.SpecialtyName = d.SpecialtyName ");
            //sbSql.Append("  and tmp.PrizeName = d.PrizeName and tmp.DeclarationName = d.DeclarationName ");
            sbSql.Append(" SELECT D.* from V_Declaration AS D ");
            sbSql.AppendFormat(" WHERE D.ActivityID = {0} ", condition.ActivityID);
            if (condition.UserID != null && condition.UserType != null)
            {
                switch (condition.UserType)
                {
                    case "0801": // 超级管理员可以看所有项目
                    case "0802": // 系统管理员可以看所有项目
                    case "0803": // 协会管理员可以看所有项目
                        break;
                    case "0804": // 分会用户可以看数据权限范围内的项目
                        sbSql.AppendFormat(" AND dbo.Fn_IsSpecialtyInAuthority(d.SpecialtyID, {0}) = 1 ", condition.UserID);
                        break;
                    case "0805": // 专家可以看数据权限范围内的收件封存项目
                        sbSql.Append(" AND DeclarationStatus = '1803' ");
                        sbSql.Append(" AND d.ExpertReviewGroupID in ( ");
                        sbSql.AppendFormat(" select GroupID from dbo.Fn_GetGroupByUserID({0})) ", condition.UserID);
                        break;
                    case "0806": // 一级用户可以看本单位的所有项目
                        sbSql.AppendFormat(" AND D.OrganizationUserID = {0} ", condition.UserID);
                        break;
                    case "0807": // 二级用户可以看本人所创建的所有项目
                        sbSql.AppendFormat(" AND D.UserID = {0} ", condition.UserID);
                        break;
                    case "0808":// 地方协会用户可以看该协会推荐的所有项目
                    case "0809":// 同业协会用户可以看该协会推荐的所有项目
                        sbSql.AppendFormat(" AND d.RecommendFrom = ? ", condition.UserID);
                        break;
                }
            }

            //项目名称查询
            if (!string.IsNullOrEmpty(condition.DeclarationName))
            {
                condition.DeclarationName = condition.DeclarationName.Trim();
                sbSql.Append(" and D.DeclarationName like ?");
                lstPara.Add(new OleDbParameter("@DeclarationName", OleDbType.VarWChar) { Value = "%" + condition.DeclarationName + "%" });
            }

            //申报单位查询
            if (!string.IsNullOrEmpty(condition.OrganizationName))
            {
                sbSql.Append(" and d.OrganizationName like ? ");
                lstPara.Add(new OleDbParameter("@OrganizationName", OleDbType.VarWChar) { Value = "%" + condition.OrganizationName + "%" });
            }

            if (!string.IsNullOrEmpty(condition.SpecialtyID))
            {
                sbSql.AppendFormat(" and d.SpecialtyID in ({0}) ", condition.SpecialtyID);
            }

            //申报奖项查询
            if (!string.IsNullOrEmpty(condition.PrizeID))
            {
                sbSql.AppendFormat(" and d.PrizeID in ({0}) ", condition.PrizeID);
            }

            //奖项类别查询
            if (!string.IsNullOrEmpty(condition.PrizeType))
            {
                sbSql.AppendFormat(" and d.PrizeTypeCode in ({0}) ", condition.PrizeType);
                //lstPara.Add(new OleDbParameter("@PrizeTypeCode", OleDbType.VarWChar) { Value = condition.PrizeType });
            }

            //申报时间查询
            if (condition.DeclarationBeginDate != null)
            {
                sbSql.Append(" and D.DeclareDate >= ? ");
                lstPara.Add(new OleDbParameter("@DeclareDateBegin", OleDbType.Date) { Value = condition.DeclarationBeginDate });
            }

            if (condition.DeclarationEndDate != null)
            {
                sbSql.Append(" and D.DeclareDate <= ? ");
                lstPara.Add(new OleDbParameter("@DeclareDateEnd", OleDbType.Date) { Value = condition.DeclarationEndDate });
            }

            //修改时间查询
            if (condition.EditBeginDate != null)
            {
                sbSql.Append(" and D.LastUpdateTime >= ? ");
                lstPara.Add(new OleDbParameter("@LastUpdateTimeBegin", OleDbType.Date) { Value = condition.EditBeginDate });
            }

            if (condition.EditEndDate != null)
            {
                sbSql.Append(" and D.LastUpdateTime <= ? ");
                lstPara.Add(new OleDbParameter("@LastUpdateTimeEnd", OleDbType.Date) { Value = condition.EditEndDate });
            }

            //申报状态查询
            if (!string.IsNullOrEmpty(condition.DeclarationStatus))
            {
                sbSql.Append(" and CHARINDEX( d.DeclarationStatus, ?, 1) > 0 ");
                lstPara.Add(new OleDbParameter("@DeclarationStatus", OleDbType.VarWChar) { Value = condition.DeclarationStatus });
            }

            //sbSql.Append(" order by tmp.BigOrdinal, d.OrganizationName, d.OrganizationOrdinal ");
            sbSql.Append(" order by d.OrganizationName, d.OrganizationOrdinal ");

            return Dal.OleDbHlper.GetList<Dal.Models.Declaration>(sbSql.ToString(), conn, CommandType.Text, tran, lstPara.ToArray());
        }

        public static List<Dal.Models.Declaration> GetReviewList(Dal.Models.UserInfo user, int iActivityID,
            string strDeclarationName, string strOrganizationName, string strPrizeIDs, string strExpertName, string strAwardCodes,
            OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            List<OleDbParameter> lstPara = new List<OleDbParameter>();
            sbSql.Append(" SELECT d.DeclarationID, d.DeclarationName, o.OrganizationName, s.TemplateCode, s.SpecialtyName, p.PrizeName ");
            sbSql.Append(" , d.ExpertReviewTime , e.ExpertName as ExpertReviewerName, d.ExpertReviewComment ");
            sbSql.Append(" , a.AwardCode, a.InnerOrdinal, c.ConstantValue AwardCodeText ");
            sbSql.Append(" FROM Declaration d ");
            sbSql.Append(" inner join Organization o on o.OrganizationID = d.OrganizationID ");
            sbSql.Append(" inner join Prize p on p.PrizeID = d.AdjustedPrize ");
            sbSql.Append(" inner join Specialty s on s.SpecialtyID = p.SpecialtyID ");
            sbSql.Append(" left join Expert e on e.ExpertID = d.ExpertReviewer ");
            sbSql.Append(" left join AwardResult a on a.DeclarationID = d.DeclarationID ");
            sbSql.Append(" left join SysConstant c on c.ConstantCode = a.AwardCode ");
            sbSql.Append(" WHERE s.ActivityID = ? ");
            lstPara.Add(new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });

            if (user.UserType == "0808" || user.UserType == "0809")
            {
                sbSql.Append(" and d.RecommendFrom = ? ");
            }
            else if (user.UserType == "0805")
            {
                sbSql.Append(" and d.ExpertReviewGroupID in (select GroupID from dbo.Fn_GetGroupByUserID(?)) ");
            }
            else
            {
                sbSql.Append(" and dbo.Fn_IsSpecialtyInAuthority(s.SpecialtyID, ?) = 1 ");
            }
            lstPara.Add(new OleDbParameter("@UserID", OleDbType.Integer) { Value = user.UserID });

            if (!string.IsNullOrEmpty(strDeclarationName))
            {
                sbSql.Append(" and d.DeclarationName like ? ");
                lstPara.Add(new OleDbParameter("@DeclarationName", OleDbType.VarWChar) { Value = "%" + strDeclarationName + "%" });
            }

            if (!string.IsNullOrEmpty(strOrganizationName))
            {
                sbSql.Append(" and o.OrganizationName like ? ");
                lstPara.Add(new OleDbParameter("@OrganizationName", OleDbType.VarWChar) { Value = "%" + strOrganizationName + "%" });
            }

            if (!string.IsNullOrEmpty(strPrizeIDs))
            {
                sbSql.Append(" and CHARINDEX(CAST(p.PrizeID as nvarchar), ?) > 0 ");
                lstPara.Add(new OleDbParameter("@PrizeIDs", OleDbType.VarWChar) { Value = strPrizeIDs });
            }

            if (!string.IsNullOrEmpty(strExpertName))
            {
                sbSql.Append(" and e.ExpertName like ?  ");
                lstPara.Add(new OleDbParameter("@ExpertName", OleDbType.VarWChar) { Value = "%" + strExpertName + "%" });
            }

            if (!string.IsNullOrEmpty(strAwardCodes))
            {
                sbSql.Append(" and CHARINDEX(a.AwardCode, ?) > 0 ");
                lstPara.Add(new OleDbParameter("@PrizeIDs", OleDbType.VarWChar) { Value = strAwardCodes });
            }

            sbSql.Append(" order by s.TemplateCode, p.PrizeName, a.AwardCode, a.InnerOrdinal, e.ExpertName, d.DeclarationName ");


            return Dal.OleDbHlper.GetList<Dal.Models.Declaration>(sbSql.ToString(), conn, CommandType.Text, tran, lstPara.ToArray());
        }

        public static List<Dal.Models.Declaration> GetDeclarationList(Dal.Models.DeclarationSearchCondition condition, OleDbConnection conn, OleDbTransaction tran = null)
        {
            if (condition == null)
            {
                throw new Exception("参数错误!");
            }

            StringBuilder sbSql = new StringBuilder();
            List<OleDbParameter> lstPara = new List<OleDbParameter>();

            sbSql.Append(" SELECT D.* FROM V_Declaration AS D ");
            sbSql.AppendFormat(" WHERE D.ActivityID = {0} ", condition.ActivityID);
            if (condition.UserID != null && condition.UserType != null)
            {
                switch (condition.UserType)
                {
                    case "0801": // 超级管理员可以看所有项目
                    case "0802": // 系统管理员可以看所有项目
                    case "0803": // 协会管理员可以看所有项目
                        break;
                    case "0804": // 分会用户可以看数据权限范围内的项目
                        sbSql.AppendFormat(" AND dbo.Fn_IsSpecialtyInAuthority(d.SpecialtyID, {0}) = 1 ", condition.UserID);
                        break;
                    case "0805": // 专家可以看数据权限范围内的收件封存项目
                        sbSql.Append(" AND DeclarationStatus = '1803' ");
                        sbSql.Append(" AND d.ExpertReviewGroupID in ( ");
                        sbSql.AppendFormat(" select GroupID from dbo.Fn_GetGroupByUserID({0})) ", condition.UserID);
                        break;
                    case "0806": // 一级用户可以看本单位的所有项目
                        sbSql.AppendFormat(" AND D.OrganizationUserID = {0} ", condition.UserID);
                        break;
                    case "0807": // 二级用户可以看本人所创建的所有项目
                        sbSql.AppendFormat(" AND D.UserID = {0} ", condition.UserID);
                        break;
                    case "0808":// 地方协会用户可以看该协会推荐的所有项目
                    case "0809":// 同业协会用户可以看该协会推荐的所有项目
                        sbSql.AppendFormat(" AND d.RecommendFrom = {0} ", condition.UserID);
                        break;
                }
            }

            //项目名称查询
            if (!string.IsNullOrEmpty(condition.DeclarationName))
            {
                condition.DeclarationName = condition.DeclarationName.Trim();
                sbSql.Append(" and D.DeclarationName like ?");
                lstPara.Add(new OleDbParameter("@DeclarationName", OleDbType.VarWChar) { Value = "%" + condition.DeclarationName + "%" });
            }

            //申报单位查询
            if (!string.IsNullOrEmpty(condition.OrganizationName))
            {
                sbSql.Append(" and OrganizationName like ? ");
                lstPara.Add(new OleDbParameter("@OrganizationName", OleDbType.VarWChar) { Value = "%" + condition.OrganizationName + "%" });
            }

            if (!string.IsNullOrEmpty(condition.SpecialtyID))
            {
                sbSql.AppendFormat(" and d.SpecialtyID in ({0}) ", condition.SpecialtyID);
            }

            //申报奖项查询
            if (!string.IsNullOrEmpty(condition.PrizeID))
            {
                sbSql.AppendFormat(" and d.PrizeID in ({0}) ", condition.PrizeID);
            }

            //奖项类别查询
            if (!string.IsNullOrEmpty(condition.PrizeType))
            {
                sbSql.AppendFormat(" and d.PrizeTypeCode in ({0}) ", condition.PrizeType);
                //lstPara.Add(new OleDbParameter("@PrizeTypeCode", OleDbType.VarWChar) { Value = condition.PrizeType });
            }

            //申报时间查询
            if (condition.DeclarationBeginDate != null)
            {
                sbSql.Append(" and D.DeclareDate >= ? ");
                lstPara.Add(new OleDbParameter("@DeclareDateBegin", OleDbType.Date) { Value = condition.DeclarationBeginDate });
            }

            if (condition.DeclarationEndDate != null)
            {
                sbSql.Append(" and D.DeclareDate <= ? ");
                lstPara.Add(new OleDbParameter("@DeclareDateEnd", OleDbType.Date) { Value = condition.DeclarationEndDate });
            }

            //修改时间查询
            if (condition.EditBeginDate != null)
            {
                sbSql.Append(" and D.LastUpdateTime >= ? ");
                lstPara.Add(new OleDbParameter("@LastUpdateTimeBegin", OleDbType.Date) { Value = condition.EditBeginDate });
            }

            if (condition.EditEndDate != null)
            {
                sbSql.Append(" and D.LastUpdateTime <= ? ");
                lstPara.Add(new OleDbParameter("@LastUpdateTimeEnd", OleDbType.Date) { Value = condition.EditEndDate });
            }

            //申报状态查询
            if (!string.IsNullOrEmpty(condition.DeclarationStatus))
            {
                sbSql.Append(" and CHARINDEX( d.DeclarationStatus, ?, 1) > 0 ");
                lstPara.Add(new OleDbParameter("@DeclarationStatus", OleDbType.VarWChar) { Value = condition.DeclarationStatus });
            }

            sbSql.Append(" order by d.OrganizationName, d.OrganizationOrdinal ");

            return Dal.OleDbHlper.GetList<Dal.Models.Declaration>(sbSql.ToString(), conn, CommandType.Text, tran, lstPara.ToArray());
        }

        public static List<Dal.Models.Declaration> GetDeclarationList(int iOrganizationID, int iPrizeID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" SELECT D.* FROM V_Declaration AS D ");
            sbSql.Append(" WHERE D.OrganizationID = ? AND D.PrizeID = ? ");
            sbSql.Append(" order by d.SpecialtyTotalOrdinal, d.PrizeOrdinal, d.OrganizationName, d.OrganizationOrdinal ");

            return Dal.OleDbHlper.GetList<Dal.Models.Declaration>(
                sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@OrganizationID", OleDbType.Integer) { Value = iOrganizationID }
                , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID });
        }

        public static List<Dal.Models.Declaration> GetDeclarationList(int iPrizeID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " SELECT * FROM V_Declaration WHERE PrizeID = ? ";
            strSql += " order by SpecialtyTotalOrdinal, PrizeOrdinal, AssociationOrdinal ";
            return Dal.OleDbHlper.GetList<Dal.Models.Declaration>(
                strSql, conn, CommandType.Text, tran, new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID });
        }

        public static string GetDeclarationCode(int iSpecialtyID, string strCodeHead, OleDbConnection conn, OleDbTransaction tran = null)
        {

            string strSql = " SELECT Max(substring(DeclarationCode,11,4)) FROM Declaration WHERE SubString(DeclarationCode,1,6) = ? ";

            string strCode = Convert.ToString(Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@CodeHead", OleDbType.VarWChar) { Value = strCodeHead.Substring(0, 6) }));

            if (string.IsNullOrEmpty(strCode))
            {
                return strCodeHead + "0001";
            }
            else
            {
                return strCodeHead + (Convert.ToInt32(strCode) + 1).ToString("D4");
            }
        }

        public static int DeclarationExsitUserCount(int iActiveID, string iuserID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();

            sbSql.Append(" SELECT count(D.DeclarationID) FROM Declaration AS D ");
            sbSql.Append(" INNER JOIN Prize AS P ON P.PrizeID = D.PrizeID ");
            sbSql.Append(" INNER JOIN Specialty AS S ON S.SpecialtyID = P.SpecialtyID ");
            sbSql.Append(" WHERE S.ActivityID = ? AND D.UserID in (" + iuserID + ") ");
            object obj = Dal.OleDbHlper.ExecuteScalar(
                        sbSql.ToString(), conn, CommandType.Text, tran
                         , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActiveID });
            int count = obj == null ? 0 : Convert.ToInt32(obj);
            return count;
        }

        public static List<Dal.Models.Declaration_Data> GetDeclarationDivisionList(int iDeclarationID, string strRecordCodeStart, string strRecordCodeEnd, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from Declaration_Data Where DeclarationID = ? and RecordCode between ? and ? order by RecordCode asc";

            return Dal.OleDbHlper.GetList<Dal.Models.Declaration_Data>(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarationID }
                 , new OleDbParameter("@RecordCode", OleDbType.VarWChar) { Value = strRecordCodeStart }
                 , new OleDbParameter("@RecordCode", OleDbType.VarWChar) { Value = strRecordCodeEnd });
        }

        public static Dal.Models.Declaration GetDeclaration(int iDeclarationID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" SELECT D.* FROM V_Declaration AS D WHERE D.DeclarationID = ? ");

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarationID });
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Declaration>(reader);
        }

        /// <summary>
        /// 读取申报表数据
        /// </summary>
        /// <typeparam name="T">模板类</typeparam>
        /// <param name="iDeclarationID">申报表编号</param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        /// <remarks>画面填充数据用</remarks>
        /// <returns></returns>
        public static T GetDeclarationData<T>(int iDeclarationID, OleDbConnection conn, OleDbTransaction tran = null) where T : Dal.Models.TemplateBase, new()
        {
            T t = new T();
            t.Load<T>(GetDeclarationData(iDeclarationID, conn, tran));
            return t;
        }

        public static string GetDeclarationData(int iDeclarationID, string strRecordCode, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" select isnull(Data, '') Data ");
            sbSql.Append(" FROM Declaration_Data ");
            sbSql.Append(" WHERE DeclarationID = ? and RecordCode = ?   ");

            object objData = Dal.OleDbHlper.ExecuteScalar(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarationID }
                , new OleDbParameter("@RecordCode", OleDbType.VarWChar) { Value = strRecordCode });

            if (objData == DBNull.Value || objData == null)
            {
                return "";
            }
            else
            {
                return objData.ToString();
            }
        }

        /// <summary>
        /// 读取申报表数据
        /// </summary>
        /// <param name="iDeclarationID">申报表编号</param>
        /// <param name="strTemplateCode">模版编号</param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        /// <remarks>因为需要替换模版中的所有标记，所以需要将模版中的所有字段都读出来</remarks>
        /// <returns></returns>
        public static DataTable GetDeclarationData(int iDeclarationID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" select t.TemplateClass, t.PartClass, ");
            sbSql.Append(" r.RecordType, r.RecordCode, r.RecordNameCn, r.RecordNameEn, r.IsRequired, r.RecordLen, ");
            sbSql.Append(" d.IsPublic, isnull(d.Data, '') Data, ");
            sbSql.Append(" STUFF(( SELECT ',' + ConstantValue FROM SysConstant ");
            sbSql.Append("     WHERE CHARINDEX(ConstantCode, d.Data, 1) > 0   ");
            sbSql.Append("     FOR XML PATH('')   ),1,1,'') as ConstantValue  ");
            sbSql.Append(" from TemplateRecord r  ");
            sbSql.Append(" inner join TemplateInfo t on t.PartCode = r.PartCode ");
            sbSql.Append(" inner join V_Declaration v on v.TemplateCode = r.TemplateCode and v.DeclarationID = ? ");
            sbSql.Append(" left join Declaration_Data d on d.RecordCode = r.RecordCode and d.DeclarationID = v.DeclarationID");
            sbSql.Append(" left join SysConstant s on s.ConstantCode = d.Data and r.RecordType = 'select' ");
            sbSql.Append(" order by r.RecordCode ");

            return Dal.OleDbHlper.GetDataTable(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarationID });
        }

        public static void SetCollaborative(Novacode.DocX docx, DataTable dtDeclaration, Dictionary<string, string> dictConst)
        {
            List<Novacode.Table> lstTb = docx.Tables.Where(t => t.RowCount == 6
                && t.Rows[0].Cells[0].Paragraphs[0].Text == "排序"
                && t.Rows[0].Cells[1].Paragraphs[0].Text == dictConst["CollaborativeUnit"]).ToList();

            if (lstTb.Count > 0)
            {
                Novacode.Table tblDocx = lstTb[0];
                string strCollaborativeIDs = dictConst["CollaborativeIDs"];
                string[] arrCollaborative = strCollaborativeIDs.Split(',');
                string strHasCollaborative = dictConst["HasCollaborative"];
                string strHasAbord = dictConst["HasAbord"];
                int iStep = strHasAbord == "TRUE" ? 2 : 1;

                for (int i = 0; i < arrCollaborative.Count(); i++)
                {
                    SetCollaborative(arrCollaborative[i], tblDocx, i + 2, iStep, dtDeclaration, dictConst);
                }
            }
        }

        /// <summary>
        /// 在模版中设定合作单位信息
        /// </summary>
        /// <param name="strRecordCode"></param>
        /// <param name="tb"></param>
        /// <param name="iRowIdx"></param>
        /// <param name="dtDeclaration"></param>
        /// <param name="conn"></param>
        private static void SetCollaborative(string strRecordCode, Novacode.Table tb, int iRowIdx, int iStep
            , DataTable dtDeclaration, Dictionary<string, string> dictTemplateConst)
        {
            DataRow row = dtDeclaration.Select("RecordCode='" + strRecordCode + "'")[0];
            DataRow rowPhase = null;

            string strCollaborativePhase = row["Data"].ToString();
            if (!string.IsNullOrEmpty(strCollaborativePhase))
            {
                tb.Rows[iRowIdx].Cells[1].Paragraphs[0].Append(strCollaborativePhase);
                rowPhase = dtDeclaration.Rows[dtDeclaration.Rows.IndexOf(row) + iStep];
                if (rowPhase["RecordType"].ToString() == "select")
                {
                    string[] split = rowPhase["ConstantValue"].ToString().Split(',');
                    if (split.Count() > 0)
                    {
                        for (int i = 2; i < tb.Rows[iRowIdx].Cells.Count; i++)
                        {
                            if (tb.Rows[0].Cells[i].Paragraphs.Where(p => split.Contains(p.Text)).Count() > 0)
                            {
                                tb.Rows[iRowIdx].Cells[i].Paragraphs[0].Append(
                                    dictTemplateConst["IsCollaborativePhase"]);
                            }
                            else
                            {
                                tb.Rows[iRowIdx].Cells[i].Paragraphs[0].Append(
                                    dictTemplateConst["NotCollaborativePhase"]);
                            }
                        }
                    }
                }
                else
                {
                    tb.Rows[iRowIdx].Cells[2].Paragraphs[0].Append(rowPhase["Data"].ToString());
                }
            }
        }

        public static DataTable GetCollaborative(Dal.Models.Declaration decl, DataTable dtData, OleDbConnection conn, OleDbTransaction trans = null)
        {
            Dictionary<string, string> dictConstant = SysConstant.GetTemplateConstantDict(decl.TemplateCode, conn, trans);
            string strCollaborativeIDs = dictConstant["CollaborativeIDs"];
            string[] arrCollaborativeCode = strCollaborativeIDs.Split(',');
            string strIsCollaborativePhase = dictConstant["IsCollaborativePhase"];
            string strNotCollaborativePhase = dictConstant["NotCollaborativePhase"];
            bool bHasCollaborative = dictConstant["HasCollaborative"] == "TRUE";
            bool bHasAbord = dictConstant["HasAbord"] == "TRUE";

            DataTable dtCollaborative = new DataTable();
            DataRow row;
            dtCollaborative.Columns.Add("排序");
            dtCollaborative.Columns.Add("勘察设计单位");

            int iStep = 1;
            if (bHasAbord)
            {
                iStep = 2;
            }

            if (!string.IsNullOrEmpty(dictConstant["CollaborativeConstantType"]))
            {
                List<Dal.Models.SysConstant> lstSysConstant = SysConstant.GetConstantList(
                    dictConstant["CollaborativeConstantType"], conn, trans);
                foreach (Dal.Models.SysConstant cnst in lstSysConstant)
                {
                    dtCollaborative.Columns.Add(cnst.ConstantValue);
                }
                string strPhaseRecordCode = "";
                for (int i = 0; i < 5; i++)
                {
                    row = dtCollaborative.NewRow();

                    row["排序"] = i + 1;

                    if (i == 0)
                    {
                        row["勘察设计单位"] = decl.OrganizationName;

                        for (int j = 2; j < dtCollaborative.Columns.Count; j++)
                        {
                            row[j] = strIsCollaborativePhase;
                        }
                    }
                    else
                    {
                        row["勘察设计单位"] = dtData.Select("RecordCode='" + arrCollaborativeCode[i - 1] + "'")[0]["Data"];
                        if (row["勘察设计单位"] != null && row["勘察设计单位"] != DBNull.Value)
                        {
                            strPhaseRecordCode = (Convert.ToInt32(arrCollaborativeCode[i - 1]) + iStep).ToString("D7");
                            string[] arrPhase = dtData.Select("RecordCode='" + strPhaseRecordCode + "'")[0]["ConstantValue"].ToString().Split(',');
                            for (int j = 2; j < dtCollaborative.Columns.Count; j++)
                            {
                                if (arrPhase.Contains(dtCollaborative.Columns[j].ColumnName))
                                {
                                    row[j] = strIsCollaborativePhase;
                                }
                                else
                                {
                                    row[j] = strNotCollaborativePhase;
                                }
                            }
                        }
                    }
                    dtCollaborative.Rows.Add(row);
                }
            }
            else
            {
                dtCollaborative.Columns.Add("承担工作");

                for (int i = 0; i < 5; i++)
                {
                    row = dtCollaborative.NewRow();
                    row["排序"] = i + 1;

                    if (i == 0)
                    {
                        row["勘察设计单位"] = decl.OrganizationName;
                        row["承担工作"] = "主申报单位";
                    }
                    else
                    {
                        row["勘察设计单位"] = dtData.Select("RecordCode='" + arrCollaborativeCode[i - 1] + "'")[0]["Data"];
                        if (row["勘察设计单位"] != null && row["勘察设计单位"] != DBNull.Value)
                        {
                            row["承担工作"] = dtData.Select("RecordCode='"
                                + (Convert.ToInt32(arrCollaborativeCode[i - 1]) + iStep).ToString() + "'")
                                [0]["Data"].ToString();
                        }
                    }
                    dtCollaborative.Rows.Add(row);
                }
            }

            return dtCollaborative;
        }

        /// <summary>
        /// 导出审批意见表 按奖项、专家、项目名排序，整合到一个文件
        /// </summary>
        /// <param name="strSelctedDeclarationID"></param>
        /// <param name="strServerMapPath"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static string ExportOpinion(string strSelctedDeclarationID, string strServerMapPath, OleDbConnection conn)
        {
            List<Dal.Models.Declaration> lstSelctedDeclaration;

            string strSql = @"select * from V_Declaration d where d.DeclarationID in (" + strSelctedDeclarationID
                + ") order by d.PrizeName, d.ExpertReviewerName, d.DeclarationName";

            lstSelctedDeclaration = Dal.OleDbHlper.GetList<Dal.Models.Declaration>(strSql, conn);

            DocX docx = null;
            string strSaveFile = strServerMapPath + "Content\\Temp\\Opinion\\评审表_" + DateTime.Now.ToFileTime().ToString() + ".docx";
            string strTmpFile;

            foreach (Dal.Models.Declaration decl in lstSelctedDeclaration)
            {
                strTmpFile = ExportOpinion(decl, strServerMapPath, conn);
                if (docx == null)
                {
                    docx = DocX.Load(strTmpFile);
                    docx.SaveAs(strSaveFile);
                }
                else
                {
                    docx.InsertSectionPageBreak();//分页符
                    docx.InsertDocument(DocX.Load(strTmpFile), true);

                    docx.SaveAs(strSaveFile);
                }

                Directory.Delete(Path.GetDirectoryName(strTmpFile), true);
            }

            return strSaveFile;
        }

        /// <summary>
        /// 导出审批意见表
        /// </summary>
        /// <param name="use"></param>
        /// <param name="strActivityType"></param>
        /// <param name="strSelctedDeclarationID"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static string ExportOpinion(Dal.Models.Declaration decl, string strServerMapPath, OleDbConnection conn)
        {
            string strTemplateFile = strServerMapPath + "Content\\Template\\北京市优秀工程勘察设计奖评审表.docx";
            string strSavePath = strServerMapPath + "Content\\Temp\\Opinion\\"
                + decl.DeclarationName.Trim().Replace(':', '：').Replace('|', '｜')
                .Replace('/', '╱').Replace('\\', '＼').Replace('*', '＊')
                .Replace('<', '《').Replace('>', '》').Replace('?', '？')
                .Replace('\"', '_').Replace('+', '＋').Replace('.', '·')
                + "\\";

            if (!Directory.Exists(strSavePath))
            {
                Directory.CreateDirectory(strSavePath);
            }

            Dal.Models.ExpertGroup gp = null;
            Dal.Models.ExpertGroup prnt = null;
            if (decl.ExpertReviewGroupID != null)
            {
                gp = BLL.ExpertGroup.GetExpertGroup(decl.ExpertReviewGroupID.Value, conn);
            }

            if (gp != null && gp.ParentID != null)
            {
                prnt = BLL.ExpertGroup.GetExpertGroup(gp.ParentID.Value, conn);
            }

            string strSaveFile = "评审表_" + decl.DeclarationName.Trim()
                      .Replace(':', '：').Replace('|', '｜')
                      .Replace('/', '╱').Replace('\\', '＼').Replace('*', '＊')
                      .Replace('<', '《').Replace('>', '》').Replace('?', '？')
                      .Replace('\"', '_').Replace('+', '＋').Replace('.', '·') + ".docx";

            strSaveFile = System.IO.Path.Combine(strSavePath, strSaveFile);

            if (!File.Exists(strTemplateFile))
            {
                throw new Exception("模版不存在");
            }

            // 读取模版
            DocX docx = DocX.Load(strTemplateFile);

            List<Dal.Models.Participant> lstParticipant = GetParticipant(decl.DeclarationID.Value, conn);
            StringBuilder sbParticipant = new StringBuilder();
            for (int i = 0; i < lstParticipant.Count; i++)
            {
                if (!string.IsNullOrEmpty(lstParticipant[i].ParticipantName))
                {
                    sbParticipant.AppendFormat("{0}. {1} ", i + 1, lstParticipant[i].ParticipantName);
                }
            }

            Dal.Models.AwardResult award = Vote.GetAwardResult(decl.DeclarationID.Value, conn);
			//Dal.Models.Vote  vote = Vote .GetReVoteList (decl .DeclarationID .Value ,conn);

            // 申报单位法人代表人声明
            docx.ReplaceText("Year", DateTime.Now.Year.ToString());
            docx.ReplaceText("AwardName", SysConstant.GetAppSettings("AwardName", conn));
            docx.ReplaceText("DeclarationName", decl.DeclarationName);
            docx.ReplaceText("OrganizationName", decl.OrganizationName);
            docx.ReplaceText("PrizeName", decl.PrizeName);
            docx.ReplaceText("AwardResult", award == null ? "" : award.AwardCodeText);
            docx.ReplaceText("InnerOrdinal", award == null ? "" : award.InnerOrdinal.ToString());
            docx.ReplaceText("GroupLeaderName", gp == null ? "" : gp.LeaderName ?? "");
            docx.ReplaceText("DeputyNames", gp == null ? "" : gp.DeputyNames ?? "");
            docx.ReplaceText("ParentLeaderName", (prnt == null ? "" : prnt.LeaderName ?? ""));
            docx.ReplaceText("ParticipantNames", sbParticipant.ToString());

            // 富文本转Word模板
            StringBuilder sbHtmltext = new StringBuilder();
            sbHtmltext.Append("<html xmlns:v=\"urn:schemas-microsoft-com:vml\"");
            sbHtmltext.Append("xmlns:o=\"urn:schemas-microsoft-com:office:office\"");
            sbHtmltext.Append("xmlns:w=\"urn:schemas-microsoft-com:office:word\"");
            sbHtmltext.Append("xmlns:m=\"http://schemas.microsoft.com/office/2004/12/omml\"");
            sbHtmltext.Append("xmlns = \"http://www.w3.org/TR/REC-html40\">");
            sbHtmltext.Append("$htmldata");
            sbHtmltext.Append("</html>");

            InsertRichtext(docx, strServerMapPath, sbHtmltext.ToString()
                , decl.DeclarationCode, "ExpertReviewComment"
                , decl.ExpertReviewComment ?? "");

            if (decl.PrizeTypeCode == "0302" || decl.PrizeTypeCode == "0303")
            {
                docx.ReplaceText("FirstPrize", "");
                docx.ReplaceText("SecondPrize","");
                docx.ReplaceText("ThirdPrize", "");

                // 必须先替换不推荐，然后替换推荐否则，替换推荐的时候会影响不推荐
                docx.ReplaceText("NotRecommended", award == null ? "" : award.NotRecommended.ToString());
                docx.ReplaceText("Recommended", award == null ? "" : award.Recommended.ToString());
                docx.ReplaceText("SlowRating", award == null ? "" : award.SlowRating.ToString());
                docx.ReplaceText("TurnOut", award == null ? "" : award.TurnOut.ToString());

                // 列标题
                docx.ReplaceText("First", "");
                docx.ReplaceText("Second", "");
                docx.ReplaceText("Third", "");
                docx.ReplaceText("Recom", "推荐");
            }
            else if (decl.VoteType == "2201")
            {
                docx.ReplaceText("FirstPrize", award == null ? "" : award.FirstPrize.ToString());
                docx.ReplaceText("SecondPrize", award == null ? "" : award.SecondPrize.ToString());
                docx.ReplaceText("ThirdPrize", award == null ? "" : award.ThirdPrize.ToString());
                docx.ReplaceText("NotRecommended", award == null ? "" : award.NotRecommended.ToString());
                docx.ReplaceText("SlowRating", award == null ? "" : award.SlowRating.ToString());
                docx.ReplaceText("TurnOut", award == null ? "" : award.TurnOut.ToString());

                // 列标题
                docx.ReplaceText("First", "一等奖");
                docx.ReplaceText("Second", "二等奖");
                docx.ReplaceText("Third", "三等奖");
                docx.ReplaceText("Recom", "");
            }
            else if (decl.VoteType == "2202")
            {
                docx.ReplaceText("FirstPrize", award == null ? "" : award.FirstPrize.ToString());
                docx.ReplaceText("SecondPrize", award == null ? "" : award.SecondPrize.ToString());
                docx.ReplaceText("ThirdPrize", award == null ? "" : award.ThirdPrize.ToString());

                // 必须先替换不推荐，然后替换推荐否则，替换推荐的时候会影响不推荐
                docx.ReplaceText("NotRecommended", award == null ? "" : award.NotRecommended.ToString());
                docx.ReplaceText("Recommended", award == null ? "" : award.Recommended.ToString());

                docx.ReplaceText("SlowRating", award == null ? "" : award.SlowRating.ToString());
                docx.ReplaceText("TurnOut", award == null ? "" : award.TurnOut.ToString());

                //设置评审结果各项为变量
                docx.ReplaceText("First", "一等奖");
                docx.ReplaceText("Second", "二等奖");
                docx.ReplaceText("Third", "三等奖");
                docx.ReplaceText("Recom", "推荐");
            }
            else
            {
                docx.ReplaceText("FirstPrize", award == null ? "" : award.FirstPrize.ToString());
                docx.ReplaceText("SecondPrize", award == null ? "" : award.SecondPrize.ToString());
                docx.ReplaceText("ThirdPrize", award == null ? "" : award.ThirdPrize.ToString());

                // 必须先替换不推荐，然后替换推荐否则，替换推荐的时候会影响不推荐
                docx.ReplaceText("NotRecommended", award == null ? "" : award.NotRecommended.ToString());
                docx.ReplaceText("Recommended", award == null ? "" : award.Recommended.ToString());

                docx.ReplaceText("SlowRating", award == null ? "" : award.SlowRating.ToString());
                docx.ReplaceText("TurnOut", award == null ? "" : award.TurnOut.ToString());

                docx.ReplaceText("First", "一等奖");
                docx.ReplaceText("Second", "二等奖以上");
                docx.ReplaceText("Third", "三等奖以上");
                docx.ReplaceText("Recom", "");
            }

            // 保存
            docx.RemoveProtection();
            docx.SaveAs(strSaveFile);

            return strSaveFile;
        }

        /// <summary>
        /// 导出申报项目汇总表表
        /// </summary>
        /// <param name="iDeclarationID"></param>
        /// <param name="strServerMapPath"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static string ExportSummaryTable(Dal.Models.UserInfo user, string strActivityType, string strSelctedDeclarationID, OleDbConnection conn)
        {
            Dal.Models.Organization org = BLL.User.GetOrganization(user.UserID.Value, conn);
            Dal.Models.Activity act = BLL.Activity.GetActivity(strActivityType, conn);

            string strServerMapPath = System.Web.HttpContext.Current.Request.PhysicalApplicationPath;
            string strTemplateFile = strServerMapPath + "Content\\Template\\申报项目汇总表.docx";
            string strDocSavePath = strServerMapPath + "Content\\Temp\\Summary\\" + org.OrganizationName + "\\";
            if (!Directory.Exists(strDocSavePath))
            {
                Directory.CreateDirectory(strDocSavePath);
            }

            string strSaveFile = string.Format("{0}_申报项目汇总表_{1}.docx",
                org.OrganizationName, DateTime.Now.ToString("yyyy-MM-dd"));
            strSaveFile = System.IO.Path.Combine(strDocSavePath, strSaveFile);
            try
            {
                // 读取模版
                DocX docx = DocX.Load(strTemplateFile);

                docx.ReplaceText("OrganizationName", org.OrganizationName);
                docx.ReplaceText("Date", DateTime.Now.ToString("yyyy年MM月dd日"));

                //申报项目次序表
                #region 申报项目次序表
                List<Dal.Models.Declaration> lstDeclaration = GetDeclarationList(user, act.ActivityID.Value, conn);

                lstDeclaration = lstDeclaration.Where(d => !(new string[] { "1805", "1806" }).Contains(d.DeclarationStatus)
                    && strSelctedDeclarationID.Split(',').Contains(d.DeclarationID.ToString())).OrderBy(d=>d.OrganizationOrdinal).ToList();

                Dal.Models.Declaration declOrdinal = null;
                Novacode.Table tblDocx = docx.Tables[0];

                Row rowDocx = null;
                for (int i = 0; i < lstDeclaration.Count; )
                {
                    declOrdinal = lstDeclaration[i];
                    i++;
                    rowDocx = tblDocx.InsertRow();
                    rowDocx.Cells[0].Paragraphs[0].InsertText(i.ToString());
                    rowDocx.Cells[0].Paragraphs[0].Alignment = Alignment.center;
                    rowDocx.Cells[0].VerticalAlignment = Novacode.VerticalAlignment.Center;

                    rowDocx.Cells[1].Paragraphs[0].InsertText(declOrdinal.DeclarationName);
                    rowDocx.Cells[1].VerticalAlignment = Novacode.VerticalAlignment.Center;

                    rowDocx.Cells[2].Paragraphs[0].InsertText(declOrdinal.SpecialtyName);
                    rowDocx.Cells[2].VerticalAlignment = Novacode.VerticalAlignment.Center;

                    rowDocx.Cells[3].Paragraphs[0].InsertText(declOrdinal.PrizeName);
                    rowDocx.Cells[3].VerticalAlignment = Novacode.VerticalAlignment.Center;
                }

                tblDocx.AutoFit = AutoFit.Fixed;
                SetBorder(tblDocx);

                #endregion

                // 保存
                docx.RemoveProtection();
                docx.SaveAs(strSaveFile);

                //AddWatermark(strSaveFile, strActivityType, conn);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return strSaveFile;
        }

        public static string ExportRecommendSummary(Dal.Models.UserInfo user, string strActivityType, string strSelctedDeclarationID, string strServerMapPath, OleDbConnection conn)
        {
            Dal.Models.Activity act = BLL.Activity.GetActivity(strActivityType, conn);
            string strTemplateFile = strServerMapPath + "Content\\Template\\评选项目推荐表.docx";
            string strDocSavePath = strServerMapPath + "Content\\Temp\\RecommendSummary\\" + user.UserName + "\\";

            if (!Directory.Exists(strDocSavePath))
            {
                Directory.CreateDirectory(strDocSavePath);
            }

            string strSaveFile = string.Format("{0}_评选项目推荐表_{1}.docx", user.UserName, DateTime.Now.ToFileTime().ToString());
            strSaveFile = System.IO.Path.Combine(strDocSavePath, strSaveFile);

            try
            {
                // 读取模版
                DocX docx = DocX.Load(strTemplateFile);

                docx.ReplaceText("RecommendFrom", user.UserName);
                docx.ReplaceText("EmailAddress", string.IsNullOrEmpty(user.Email) ? "" : user.Email);

                List<Dal.Models.Declaration> lstDeclaration = GetDeclarationList(user, act.ActivityID.Value, conn);

                lstDeclaration = lstDeclaration.Where(
                    d => !(new string[] { "1805", "1806" }).Contains(d.DeclarationStatus)
                    && strSelctedDeclarationID.Split(',').Contains(d.DeclarationID.ToString())
                ).OrderBy(d => d.AssociationOrdinal).OrderBy(d=>d.TemplateCode)
                .OrderBy(d=>d.SpecialtyTotalOrdinal).ToList();

                Dal.Models.Declaration declOrdinal = null;
                Novacode.Table tblDocx = docx.Tables[1];

                Row rowDocx = null;
                int iRowIdx = 2;
                for (int i = 0; i < lstDeclaration.Count; )
                {
                    declOrdinal = lstDeclaration[i];
                    i++;
                    rowDocx = tblDocx.InsertRow(iRowIdx++);

                    rowDocx.Height = 56.0;

                    // 序号
                    rowDocx.Cells[0].Paragraphs[0].InsertText(i.ToString());
                    rowDocx.Cells[0].Paragraphs[0].Alignment = Alignment.center;
                    rowDocx.Cells[0].VerticalAlignment = Novacode.VerticalAlignment.Center;
                    rowDocx.Cells[0].Width = 19.4;

                    // 项目名称
                    rowDocx.Cells[1].Paragraphs[0].InsertText(declOrdinal.DeclarationName);
                    rowDocx.Cells[1].VerticalAlignment = Novacode.VerticalAlignment.Center;
                    rowDocx.Cells[1].Width = 80.0;

                    // 申报单位
                    rowDocx.Cells[2].Paragraphs[0].InsertText(declOrdinal.OrganizationName);
                    rowDocx.Cells[2].VerticalAlignment = Novacode.VerticalAlignment.Center;
                    rowDocx.Cells[1].Width = 50.9;
                }

                // 保存
                docx.SaveAs(strSaveFile);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return strSaveFile;
        }

        /// <summary>
        /// 导出推荐意见表
        /// </summary>
        /// <param name="user"></param>
        /// <param name="strServerMapPath"></param>
        /// <param name="iDeclarationID"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static string ExportRecommendOpinion(int iDeclarationID, string strServerMapPath, OleDbConnection conn)
        {
            Dal.Models.Declaration decl = GetDeclaration(iDeclarationID, conn);
            Dictionary<string, string> dicTemplateConstant = SysConstant.GetTemplateConstantDict(decl.TemplateCode, conn);

            string strTemplateFile = strServerMapPath + "Content\\Template\\推荐意见表.docx";
            string strSavePath = strServerMapPath + "Content\\Temp\\RecommendOpinion\\" + decl.OrganizationName + "\\";

            if (!Directory.Exists(strSavePath))
            {
                Directory.CreateDirectory(strSavePath);
            }

            string strSaveFile = string.Format("推荐意见_{0}_{1}_{2}.docx"
                , decl.DeclarationCode
                , decl.DeclarationName.Trim().Replace(':', '：').Replace('|', '｜')
                .Replace('/', '╱').Replace('\\', '＼').Replace('*', '＊')
                .Replace('<', '《').Replace('>', '》').Replace('?', '？')
                .Replace('\"', '_').Replace('+', '＋').Replace('.', '·')
                , DateTime.Now.ToFileTime().ToString());
            strSaveFile = System.IO.Path.Combine(strSavePath, strSaveFile);

            try
            {
                if (!File.Exists(strTemplateFile))
                {
                    throw new Exception("模版不存在");
                }

                // 读取模版
                DocX docx = DocX.Load(strTemplateFile);

                // 富文本转Word模板
                StringBuilder sbHtmltext = new StringBuilder();
                sbHtmltext.Append("<html xmlns:v=\"urn:schemas-microsoft-com:vml\"");
                sbHtmltext.Append("xmlns:o=\"urn:schemas-microsoft-com:office:office\"");
                sbHtmltext.Append("xmlns:w=\"urn:schemas-microsoft-com:office:word\"");
                sbHtmltext.Append("xmlns:m=\"http://schemas.microsoft.com/office/2004/12/omml\"");
                sbHtmltext.Append("xmlns = \"http://www.w3.org/TR/REC-html40\">");
                sbHtmltext.Append("$htmldata");
                sbHtmltext.Append("</html>");

                // 申报单位法人代表人声明
                docx.ReplaceText("DeclarationName", decl.DeclarationName);
                docx.ReplaceText("OrganizationName", decl.OrganizationName);
                docx.ReplaceText("PrizeName", decl.PrizeName);
                InsertRichtext(docx, strServerMapPath, sbHtmltext.ToString()
                    , decl.DeclarationCode, "Awards"
                    , GetDeclarationData(iDeclarationID, dicTemplateConstant["Awards"], conn));
                InsertRichtext(docx, strServerMapPath, sbHtmltext.ToString()
                    , decl.DeclarationCode, "UnitOpinion"
                    , GetDeclarationData(iDeclarationID, dicTemplateConstant["UnitOpinion"], conn));
                InsertRichtext(docx, strServerMapPath, sbHtmltext.ToString()
                   , decl.DeclarationCode, "RecommendOpinion"
                   , GetDeclarationData(iDeclarationID, dicTemplateConstant["RecommendOpinion"], conn));

                // 保存
                docx.SaveAs(strSaveFile);

                return strSaveFile;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 导出法人申明
        /// </summary>
        /// <param name="iDeclarationID"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static string ExportCertificate(int iDeclarationID, string strServerMapPath, OleDbConnection conn)
        {
            Dal.Models.Declaration decl = GetDeclaration(iDeclarationID, conn);
            Dal.Models.SysConstant cnstTemplate = SysConstant.GetConstant(decl.TemplateCode, conn);

            string strTemplateFile = strServerMapPath + cnstTemplate.CorrelationValue;
            string strSavePath = strServerMapPath + "Content\\Temp\\Certificate\\" + decl.OrganizationName + "\\";

            if (!Directory.Exists(strSavePath))
            {
                Directory.CreateDirectory(strSavePath);
            }

            string strSaveFile = string.Format("法人声明_{0}_{1}_{2}.docx", decl.DeclarationCode
                , decl.DeclarationName.Trim()
                      .Replace(':', '：').Replace('|', '｜')
                      .Replace('/', '╱').Replace('\\', '＼').Replace('*', '＊')
                      .Replace('<', '《').Replace('>', '》').Replace('?', '？')
                      .Replace('\"', '_').Replace('+', '＋').Replace('.', '·')
                , DateTime.Now.ToFileTime().ToString());
            strSaveFile = System.IO.Path.Combine(strSavePath, strSaveFile);

            try
            {
                if (!File.Exists(strTemplateFile))
                {
                    throw new Exception("模版不存在");
                }

                DataTable dtDeclaration = GetDeclarationData(iDeclarationID, conn);

                // 读取模版
                DocX docx = DocX.Load(strTemplateFile);

                #region 定位
                // 移除声明之前的元素
                Novacode.Paragraph pCertificate = null;
                while (true)
                {
                    pCertificate = docx.Paragraphs[0];
                    if (!pCertificate.Text.Contains("申报单位法人代表人声明"))
                    {
                        if (pCertificate.ParentContainer.ToString() == "Cell")
                        {
                            if (docx.Tables[0].Paragraphs.Where(
                                p => p.Text.Contains("申报单位法人代表人声明")).Count() > 0)
                            {
                                if (docx.Tables[0].Rows[0].Paragraphs.Where(
                                    p => p.Text.Contains("申报单位法人代表人声明")).Count() > 0)
                                {
                                    pCertificate.Remove(false);
                                }
                                else
                                {
                                    docx.Tables[0].Rows[0].Remove();
                                }
                            }
                            else
                            {
                                docx.Tables[0].Remove();
                            }

                        }
                        else
                        {
                            pCertificate.Remove(false);
                        }
                    }
                    else
                    {
                        if (pCertificate.Text.Contains("\n"))
                        {
                            pCertificate.ReplaceText("\n", "");
                        }

                        break;
                    }
                }

                // 移除声明之后的元素
                Novacode.Paragraph pLegalTime = null;
                while (true)
                {
                    pLegalTime = docx.Paragraphs.Last();
                    if (!pLegalTime.Text.Contains("LegalTime"))
                    {
                        if (pLegalTime.ParentContainer.ToString() == "Cell")
                        {
                            if (docx.Tables.Last().Paragraphs.Where(
                                p => p.Text.Contains("LegalTime")).Count() > 0)
                            {
                                if (docx.Tables.Last().Rows.Last().Paragraphs.Where(
                                    p => p.Text.Contains("LegalTime")).Count() > 0)
                                {
                                    pLegalTime.Remove(false);
                                }
                                else
                                {
                                    docx.Tables.Last().Rows.Last().Remove();
                                }
                            }
                            else
                            {
                                docx.Tables.Last().Remove();
                            }
                        }
                        else
                        {
                            pLegalTime.Remove(false);
                        }
                    }
                    else
                    {
                        if (pCertificate.Text.Contains("\n"))
                        {
                            pCertificate.ReplaceText("\n", "");
                        }

                        break;
                    }
                }
                #endregion

                // 申报单位法人代表人声明
                docx.ReplaceText("LegalPersonName", decl.LegalPersonName ?? "");
                docx.ReplaceText("LegalPersonIDNo", decl.LegalPersonIDNo ?? "");
                docx.ReplaceText("PrizeName", decl.PrizeName);
                docx.ReplaceText("AwardName", SysConstant.GetAppSettings("AwardName", conn));
                docx.ReplaceText("LegalTime", decl.DeclareDate.Value.ToString("yyyy年MM月dd日"));
                docx.ReplaceText("ExportTime", decl.LastUpdateTime.Value.ToString("yyyy年MM月dd日hh时mm分"));

                // 保存
                docx.RemoveProtection();
                docx.SaveAs(strSaveFile);

                // 水印
                //AddWatermark(strSaveFile, ConfigurationManager.AppSettings["ActivityType"], conn);

                return strSaveFile;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string ExportDivision(int iDeclarationID, string strServerMapPath, OleDbConnection conn)
        {
            Dal.Models.Declaration decl = GetDeclaration(iDeclarationID, conn);
            Dal.Models.SysConstant cnstTemplate = SysConstant.GetConstant(decl.TemplateCode, conn);
            Dictionary<string, string> dictTemplateConst
                = SysConstant.GetTemplateConstantDict(decl.TemplateCode, conn);

            string strTemplateFile = strServerMapPath + cnstTemplate.CorrelationValue;
            string strSavePath = strServerMapPath + "Content\\Temp\\Division\\" + decl.OrganizationName + "\\";

            if (!Directory.Exists(strSavePath))
            {
                Directory.CreateDirectory(strSavePath);
            }

            string strSaveFile = string.Format("合作分工表_{0}_{1}.docx", decl.DeclarationCode
                , decl.DeclarationName.Trim()
                      .Replace(':', '：').Replace('|', '｜')
                      .Replace('/', '╱').Replace('\\', '＼').Replace('*', '＊')
                      .Replace('<', '《').Replace('>', '》').Replace('?', '？')
                      .Replace('\"', '_').Replace('+', '＋').Replace('.', '·')
                );
            strSaveFile = System.IO.Path.Combine(strSavePath, strSaveFile);

            try
            {
                if (!File.Exists(strTemplateFile))
                {
                    throw new Exception("模版不存在");
                }

                // 读取模版
                DocX docx = DocX.Load(strTemplateFile);

                #region 定位
                // 移除合作声明之前的元素 因合作声明是最后一部分，因此无需移除后面的元素
                Novacode.Paragraph pDivision = null;
                string strCollaborativeTitle = dictTemplateConst["CollaborativeTitle"];
                while (true)
                {
                    pDivision = docx.Paragraphs[0];
                    if (!pDivision.Text.Contains(strCollaborativeTitle))
                    {
                        if (pDivision.ParentContainer.ToString() == "Cell")
                        {
                            if (docx.Tables[0].Paragraphs.Where(
                                p => p.Text.Contains(strCollaborativeTitle)).Count() > 0)
                            {
                                if (docx.Tables[0].Rows[0].Paragraphs.Where(
                                    p => p.Text.Contains(strCollaborativeTitle)).Count() > 0)
                                {
                                    pDivision.Remove(false);
                                }
                                else
                                {
                                    docx.Tables[0].Rows[0].Remove();
                                }
                            }
                            else
                            {
                                docx.Tables[0].Remove();
                            }

                        }
                        else
                        {
                            pDivision.Remove(false);
                        }
                    }
                    else
                    {
                        if (pDivision.Text.Contains("\n"))
                        {
                            pDivision.ReplaceText("\n", "");
                        }

                        break;
                    }
                }
                #endregion

                // 合作勘察设计项目申报证明
                docx.ReplaceText("DeclarationName", decl.DeclarationName);
                docx.ReplaceText("OrganizationName", decl.OrganizationName);
                docx.ReplaceText("PrizeName", decl.PrizeName);
                docx.ReplaceText("ExportTime", decl.LastUpdateTime.Value.ToString("yyyy年MM月dd日hh时mm分"));

                // 合作设计项目分工表
                #region 合作设计项目分工表
                DataTable dtDeclaration = GetDeclarationData(iDeclarationID, conn);
                Dictionary<string, string> dictConstant
                    = SysConstant.GetTemplateConstantDict(decl.TemplateCode, conn);

                SetCollaborative(docx, dtDeclaration, dictConstant);
                #endregion

                // 保存
                docx.RemoveProtection();
                docx.SaveAs(strSaveFile);

                // 添加水印
                //AddWatermark(strSaveFile, ConfigurationManager.AppSettings["ActivityType"], conn);

                return strSaveFile;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //private static void AddWatermark(string strSaveFile, string strActivityType, OleDbConnection conn)
        //{
        //    // doc转pdf
        //    Spire.Doc.Document docTemp = new Spire.Doc.Document();
        //    docTemp.LoadFromFile(strSaveFile);

        //    string RootPath = System.Web.HttpContext.Current.Request.PhysicalApplicationPath;
        //    Spire.Doc.PictureWatermark picWatermark = new Spire.Doc.PictureWatermark();
        //    string strWatermarkImgUrl = BLL.SysConstant.GetAppSettings("WaterMarkPicture_" + strActivityType, conn);
        //    picWatermark.Picture = System.Drawing.Image.FromFile(RootPath + strWatermarkImgUrl);
        //    if (strActivityType == "0101")
        //    {
        //        picWatermark.Scaling = 250;
        //    }
        //    else
        //    {
        //        picWatermark.Scaling = 15;
        //    }
        //    docTemp.Watermark = picWatermark;
        //    docTemp.SaveToFile(strSaveFile);

        //    DocX docx = DocX.Load(strSaveFile);
        //    docx.RemoveParagraphAt(0);
        //    docx.Save();
        //}

        private static void SetBorder(Novacode.Table table)
        {
            table.SetBorder(Novacode.TableBorderType.Left, new Novacode.Border()
            {
                Color = System.Drawing.Color.Black,
                Size = Novacode.BorderSize.three,
                Tcbs = Novacode.BorderStyle.Tcbs_single
            });
            table.SetBorder(Novacode.TableBorderType.Right, new Novacode.Border()
            {
                Color = System.Drawing.Color.Black,
                Size = Novacode.BorderSize.three,
                Tcbs = Novacode.BorderStyle.Tcbs_single
            });
            table.SetBorder(Novacode.TableBorderType.Top, new Novacode.Border()
            {
                Color = System.Drawing.Color.Black,
                Size = Novacode.BorderSize.three,
                Tcbs = Novacode.BorderStyle.Tcbs_single
            });
            table.SetBorder(Novacode.TableBorderType.Bottom, new Novacode.Border()
            {
                Color = System.Drawing.Color.Black,
                Size = Novacode.BorderSize.three,
                Tcbs = Novacode.BorderStyle.Tcbs_single
            });
            foreach (Novacode.Row row in table.Rows)
            {
                foreach (Novacode.Cell cell in row.Cells)
                {
                    cell.SetBorder(Novacode.TableCellBorderType.Left, new Novacode.Border()
                    {
                        Color = System.Drawing.Color.Black,
                        Size = Novacode.BorderSize.three,
                        Tcbs = Novacode.BorderStyle.Tcbs_single
                    });
                    cell.SetBorder(Novacode.TableCellBorderType.Right, new Novacode.Border()
                    {
                        Color = System.Drawing.Color.Black,
                        Size = Novacode.BorderSize.three,
                        Tcbs = Novacode.BorderStyle.Tcbs_single
                    });
                    cell.SetBorder(Novacode.TableCellBorderType.Top, new Novacode.Border()
                    {
                        Color = System.Drawing.Color.Black,
                        Size = Novacode.BorderSize.three,
                        Tcbs = Novacode.BorderStyle.Tcbs_single
                    });
                    cell.SetBorder(Novacode.TableCellBorderType.Bottom, new Novacode.Border()
                    {
                        Color = System.Drawing.Color.Black,
                        Size = Novacode.BorderSize.three,
                        Tcbs = Novacode.BorderStyle.Tcbs_single
                    });
                }
            }
        }

        private static void WriteDoc(string strHtmlContent, string strFileName)
        {
            using (MemoryStream generatedDocument = new MemoryStream())
            {
                using (WordprocessingDocument package = WordprocessingDocument.Create(generatedDocument, WordprocessingDocumentType.Document))
                {
                    MainDocumentPart mainPart = package.MainDocumentPart;
                    if (mainPart == null)
                    {
                        mainPart = package.AddMainDocumentPart();
                        new DocumentFormat.OpenXml.Wordprocessing.Document(new DocumentFormat.OpenXml.Wordprocessing.Body()).Save(mainPart);
                    }

                    NotesFor.HtmlToOpenXml.HtmlConverter converter = new HtmlConverter(mainPart);
                    converter.ParseHtml(strHtmlContent);

                    mainPart.Document.Save();
                }

                if (!Directory.Exists(Path.GetDirectoryName(strFileName)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(strFileName));
                }

                File.WriteAllBytes(strFileName, generatedDocument.ToArray());
            }
        }

        public static void InsertRichtext(DocX docx,
            string strServerMapPath,
            string strTemplateHtml,
            string strDeclarationCode,
            string strReplaceText,
            string strRichtext)
        {
            List<Novacode.Paragraph> lstParagraph;
            lstParagraph = docx.Paragraphs.Where(x => x.Text.Trim() == strReplaceText).ToList();
            Novacode.Paragraph pRecord = null;

            if (lstParagraph.Count > 0)
            {
                // 临时文件
                string strTempDocx = strServerMapPath + "Content\\Temp\\DownLoad" + strDeclarationCode + "\\" + strReplaceText + ".docx";

                // 替换相应的内容到指定的位置
                string strHtml = strTemplateHtml.Replace("$htmldata", System.Web.HttpUtility.HtmlDecode(strRichtext));
                strHtml = strHtml.Replace("\"/Content/Temp/DeclarationImage/", "\"" + strServerMapPath + "Content/Temp/DeclarationImage/");

                // 将Html转存为Docx
                try
                {
                    WriteDoc(strHtml, strTempDocx);

                    DocX docxTemp = DocX.Load(strTempDocx);
                    pRecord = lstParagraph[0];
                    pRecord.ReplaceText(strReplaceText, "");

                    // 获取除了分页符号之外的子对象
                    List<System.Xml.Linq.XElement> lstChild = docxTemp.Xml.Elements().Where(x => !x.ToString().EndsWith("</w:sectPr>")).ToList();

                    // 去除列表对象(ul ol)
                    foreach (System.Xml.Linq.XElement e in lstChild)
                    {
                        foreach (System.Xml.Linq.XElement n in e.Elements().ElementAt(0).Elements())
                        {
                            if (n.ToString().EndsWith("</w:numPr>"))
                            {
                                n.Remove();
                            }
                        }
                    }
                    pRecord.Xml.AddAfterSelf(lstChild);
                    docxTemp.Dispose();
                }
                catch
                {
                    pRecord.ReplaceText(strReplaceText, "");
                }

                File.Delete(strTempDocx);
            }
        }

        public static void SetParticipant(Dal.Models.Declaration decl, DocX docx, OleDbConnection conn)
        {
            List<Novacode.Table> lst = docx.Tables.Where(t => t.Rows.Count == 1&& t.Rows[0].Cells[0].Paragraphs[0].Text == "序号").ToList();
            if (lst.Count > 0)
            {
                Novacode.Table tb = lst[0];

                List<Dal.Models.Participant> lstParticipant = Declaration.GetParticipant(
                    decl.DeclarationID.Value, conn);

                Row rowDocx = null;
                int iRowIdx = 0;
                foreach (Dal.Models.Participant p in lstParticipant)
                {
                    rowDocx = tb.InsertRow(++iRowIdx);
                    rowDocx.Cells[0].Paragraphs[0].Append(iRowIdx.ToString());
                    rowDocx.Cells[0].Paragraphs[0].Alignment = Alignment.center;
                    rowDocx.Cells[0].MarginLeft = 5;
                    rowDocx.Cells[0].MarginRight = 5;
                    rowDocx.Cells[1].Paragraphs[0].Append(p.ParticipantName);
                    rowDocx.Cells[1].Paragraphs[0].Alignment = Alignment.center;
                    rowDocx.Cells[1].MarginLeft = 5;
                    rowDocx.Cells[1].MarginRight = 5;
                    rowDocx.Cells[2].Paragraphs[0].Append(p.AcademicTitle);
                    rowDocx.Cells[2].MarginLeft = 5;
                    rowDocx.Cells[2].MarginRight = 5;
                    rowDocx.Cells[3].Paragraphs[0].Append(p.Workplace);
                    rowDocx.Cells[3].MarginLeft = 5;
                    rowDocx.Cells[3].MarginRight = 5;
                    rowDocx.Cells[4].Paragraphs[0].Append(p.Speciality);
                    rowDocx.Cells[4].Paragraphs[0].Alignment = Alignment.center;
                    rowDocx.Cells[4].MarginLeft = 5;
                    rowDocx.Cells[4].MarginRight = 5;
                    rowDocx.Cells[5].Paragraphs[0].Append(p.Duties);
                    rowDocx.Cells[5].MarginLeft = 5;
                    rowDocx.Cells[5].MarginRight = 5;
                }
                SetBorder(tb);
                docx.ReplaceText("ParticipantLimit", decl.ParticipantLimit.ToString());
            }            
        }

        /// <summary>
        /// 导出申报表
        /// </summary>
        /// <param name="iDeclarationID"></param>
        /// <param name="strServerMapPath"></param>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static string ExportDeclaration(int iDeclarationID, string strServerMapPath, OleDbConnection conn)
        {
            Dal.Models.Declaration decl = GetDeclaration(iDeclarationID, conn);
            Dal.Models.SysConstant cnstTemplate = SysConstant.GetConstant(decl.TemplateCode, conn);

            string strTemplateFile = strServerMapPath + cnstTemplate.CorrelationValue;
            string strSavePath = strServerMapPath + "Content\\Temp\\DownLoad" + decl.DeclarationCode + "\\";

            if (Directory.Exists(strSavePath))
            {
                Directory.Delete(strSavePath, true);
            }

            Directory.CreateDirectory(strSavePath);

            #region 下载附件图集视频
            List<Dal.Models.UploadFileInfo> lstAppendix = BLL.UploadFileInfo.GetAppendixList(decl.DeclarationID.Value, conn);
            List<Dal.Models.UploadFileInfo> lstAtlas = BLL.UploadFileInfo.GetAtlasList(decl.DeclarationID.Value, conn);
            List<Dal.Models.UploadFileInfo> lstMedia = BLL.UploadFileInfo.GetMediaList(decl.DeclarationID.Value, conn);
            List<Dal.Models.UploadFileInfo> lstFile = lstAppendix.Union(lstAtlas).Union(lstMedia).Where(f => f.UploadFileID != null).ToList();

            Dal.Models.UploadFileInfo fi = null;
            string strOriginalFileName = "";
            string strNewFileName = "";
            for (int i = 0; i < lstFile.Count; i++)
            {
                fi = new Dal.Models.UploadFileInfo()
                {
                    UploadFileID = lstFile[i].UploadFileID,
                    URL = lstFile[i].URL.Replace("/", "\\")
                };

                if (fi.URL.Contains("Evaluation\\WebSite\\Content"))
                {
                    fi.URL = fi.URL.Substring(fi.URL.IndexOf("Evaluation\\WebSite\\Content") + "Evaluation\\WebSite".Length + 1);
                }

                if (lstFile[i].TypeCode == "DeclarationAtlas")
                {
                    fi.URL = "Content\\Temp\\DownLoad" + decl.DeclarationCode + "\\图集\\"
                        + lstFile[i].CorrelationName.Trim() + "\\" + lstFile[i].FileName;
                }
                else if (lstFile[i].TypeCode == "DeclarationAppendix")
                {
                    fi.URL = "Content\\Temp\\DownLoad" + decl.DeclarationCode + "\\附件\\"
                        + lstFile[i].CorrelationName.Trim() + "\\" + lstFile[i].FileName;
                }
                else
                {
                    fi.URL = "Content\\Temp\\DownLoad" + decl.DeclarationCode + "\\视频\\"
                        + lstFile[i].CorrelationName.Trim() + "\\" + lstFile[i].FileName;
                }

                strOriginalFileName = strServerMapPath + lstFile[i].URL.Replace("/", "\\");

                if (!File.Exists(strOriginalFileName))
                {
                    BLL.UploadFileInfo.LoadFile(fi, conn);
                }
                else
                {
                    strNewFileName = strServerMapPath + fi.URL;
                    if(!Directory.Exists(Path.GetDirectoryName(strNewFileName)))
                    {
                        Directory.CreateDirectory(Path.GetDirectoryName(strNewFileName));
                    }

                    System.IO.File.Copy(strOriginalFileName,strNewFileName );
                }
            }

            #endregion

            // 文件名中不允许出现的字符需要替换掉
            // 不允许的字符：冒号 ：分隔符 | 正反斜杠 \ / 星号 * 左右尖括号 < > 问号 ？英语里的双引号 "
            string strSaveFile = string.Format(
                "[{0}][{1}][{2}][{3}].docx",
                decl.PrizeName.Trim(),
                decl.DeclarationName.Trim().Replace(':', '：').Replace('|', '｜')
                    .Replace('/', '╱').Replace('\\', '＼')
                    .Replace('*', '＊')
                    .Replace('<', '《').Replace('>', '》').Replace('?', '？')
                    .Replace('\"', '_').Replace('+', '＋').Replace('.', '·')
                    .Replace('\t',' '),
                decl.OrganizationName.Trim(),
                DateTime.Now.ToString("yyyy-MM-dd"));
            strSaveFile = System.IO.Path.Combine(strSavePath, strSaveFile);

            try
            {
                if (!File.Exists(strTemplateFile))
                {
                    throw new Exception("模版不存在");
                }

                DataTable dtDeclaration = GetDeclarationData(iDeclarationID, conn);

                // 读取模版
                DocX docx = DocX.Load(strTemplateFile);

                // 申报数据
                #region 申报数据
                Dictionary<string, string> dictConstant = SysConstant.GetTemplateConstantDict(decl.TemplateCode, conn);
                string strCollaborativeStart = dictConstant["CollaborativeStart"];
                string strCollaborativeEnd = dictConstant["CollaborativeEnd"];

                DataRow row = null;
                DataRow[] rows = dtDeclaration.Select("RecordCode < '" + strCollaborativeStart
                    + "' or RecordCode > '" + strCollaborativeEnd + "'");

                // 富文本转Word模板
                StringBuilder sbHtmltext = new StringBuilder();
                sbHtmltext.Append("<html xmlns:v=\"urn:schemas-microsoft-com:vml\"");
                sbHtmltext.Append("xmlns:o=\"urn:schemas-microsoft-com:office:office\"");
                sbHtmltext.Append("xmlns:w=\"urn:schemas-microsoft-com:office:word\"");
                sbHtmltext.Append("xmlns:m=\"http://schemas.microsoft.com/office/2004/12/omml\"");
                sbHtmltext.Append("xmlns = \"http://www.w3.org/TR/REC-html40\">");
                sbHtmltext.Append("$htmldata");
                sbHtmltext.Append("</html>");

                //string strTemplateFileName = strServerMapPath + "/Content/Template/富文本转Word.html";

                //StreamReader sr = new StreamReader(strTemplateFileName);
                //StringBuilder sbHtmltext = new StringBuilder();
                //String line;
                //while ((line = sr.ReadLine()) != null)
                //{
                //    // 读取到html模板的内容
                //    sbHtmltext.Append(line);
                //}
                //sr.Close();
                //sr.Dispose();

                string strTemplateHtml = sbHtmltext.ToString();

                for (int i = 0; i < rows.Count(); i++)
                {
                    row = rows[i];
                    switch (row["RecordType"].ToString().ToLower())
                    {
                        case "select":
                            docx.ReplaceText(row["RecordCode"].ToString(), row["ConstantValue"].ToString());
                            break;
                        case "richtext":
                            InsertRichtext(docx,
                                strServerMapPath, strTemplateHtml, decl.DeclarationCode,
                                row["RecordCode"].ToString(), row["Data"].ToString());
                            break;
                        default:
                            docx.ReplaceText(row["RecordCode"].ToString(), row["Data"].ToString());
                            break;
                    }
                }
                #endregion

                // 合作单位
                #region 合作单位
                DataRow[] rowsCollaborative = dtDeclaration.Select("RecordCode >= '" + strCollaborativeStart + "' and RecordCode <= '" + strCollaborativeEnd + "'");
                string strHasCollaborative = dictConstant["HasCollaborative"];
                string strHasAbord = dictConstant["HasAbord"];
                int iStep = strHasAbord == "TRUE" ? 2 : 1;
                if (strHasCollaborative == "TRUE")
                {
                    string strCollaborativePhase = "";
                    string strCollaborative = "";
                    for (int i = 0; i < rowsCollaborative.Count(); )
                    {
                        row = rowsCollaborative[i];
                        int iPhaseIdx = i + iStep;
                        strCollaborativePhase = "";

                        if (!string.IsNullOrEmpty(row["Data"].ToString()))
                        {
                            if (rowsCollaborative[iPhaseIdx]["RecordType"].ToString() == "select")
                            {
                                // 合作阶段
                                string[] split = rowsCollaborative[iPhaseIdx]["ConstantValue"].ToString().Split(',');
                                if (split.Count() > 0)
                                {
                                    foreach (string str in split)
                                    {
                                        strCollaborativePhase += str + ", ";
                                    }
                                }
                                strCollaborativePhase = strCollaborativePhase.TrimEnd(", ".ToCharArray());
                            }
                            else
                            {
                                strCollaborativePhase = rowsCollaborative[iPhaseIdx]["Data"].ToString();
                            }

                            strCollaborative = row["Data"].ToString() + "(" + strCollaborativePhase + ")";
                            if (strHasAbord == "TRUE")
                            {
                                strCollaborative = "(" + rowsCollaborative[i + 1]["ConstantValue"].ToString() + ")" + strCollaborative;
                            }

                            docx.ReplaceText(row["RecordCode"].ToString(), strCollaborative);
                        }
                        else
                        {
                            docx.ReplaceText(row["RecordCode"].ToString(), "");
                        }
                        i = iPhaseIdx + 1;
                    }
                }
                else
                {
                    for (int i = 0; i < rowsCollaborative.Count(); i++)
                    {
                        row = rowsCollaborative[i];
                        docx.ReplaceText(row["RecordCode"].ToString(), row["Data"].ToString());
                    }
                }
                #endregion

                // 申报信息
                #region 申报信息
                Dal.Models.Review Review = BLL.Review.GetReview(
                    decl.DeclarationID.Value, decl.ExpertReviewGroupID.ToString(), conn);
                Dal.Models.ExpertGroup ExpertGroup = null;
                if (Review != null)
                {
                    docx.ReplaceText("PreReviewComment", Review.Comment);
                }
                else
                {
                    docx.ReplaceText("PreReviewComment", "");
                }
                if (decl.ExpertReviewGroupID != null)
                {
                    ExpertGroup = BLL.ExpertGroup.GetExpertGroup(decl.ExpertReviewGroupID.Value, conn);
                }

                if (ExpertGroup != null)
                {
                    if (ExpertGroup.ParentID.HasValue)
                    {
                        Dal.Models.Review ParentReview = BLL.Review.GetReview(
                            decl.DeclarationID.Value, ExpertGroup.ParentID.ToString(), conn);
                        if (ParentReview != null)
                        {
                            docx.ReplaceText("JuryReviewComment", ParentReview.Comment);
                        }
                        else
                        {
                            docx.ReplaceText("JuryReviewComment", "");
                        }
                    }
                }
                else
                {
                    docx.ReplaceText("JuryReviewComment", "");
                }

                docx.ReplaceText("PrizeName", decl.PrizeName);
                docx.ReplaceText("DeclarationName", decl.DeclarationName);
                docx.ReplaceText("OrganizationName", decl.OrganizationName);
                docx.ReplaceText("DeclareDate", decl.DeclareDate.Value.ToString("yyyy年MM月dd日"));
                docx.ReplaceText("ExportTime", decl.LastUpdateTime.Value.ToString("yyyy年MM月dd日hh时mm分"));

                //附件信息
                if (string.IsNullOrEmpty(BLL.SysConstant.GetTemplateConstant(decl.TemplateCode, "FileCatalogDefaultText", conn)))
                {
                    //系统中上传附件
                    List<Dal.Models.UploadFileInfo> lstUpFileInfo = lstFile.Where(f => f.TypeCode == "DeclarationAppendix").ToList();

                    if (lstUpFileInfo.Count() != 0)
                    {
                        string aa = "";
                        for (int i = 0; i < lstUpFileInfo.Count(); i++)
                        {
                            aa = aa + "[" + (i + 1) + "]" + lstUpFileInfo[i].CorrelationName + "\x0a";
                        }
                        docx.ReplaceText("AppendixDiscription", aa);
                    }
                    else
                    {
                        docx.ReplaceText("AppendixDiscription", "");
                    }
                }
                else
                {
                    //不在系统中上传附件，仅以文本形式维护附件列表
                    Dal.Models.TemplateRecord fileCatalogRecord = BLL.Declaration.GetTemplateRecordByNameEn(decl.TemplateCode, "FileCatalog", conn);
                    if (fileCatalogRecord != null)
                    {
                        DataRow[] drFileCatalogRecords = dtDeclaration.Select("RecordCode = '" + fileCatalogRecord.RecordCode + "'");
                        if (drFileCatalogRecords.Length > 0)
                        {
                            docx.ReplaceText("AppendixDiscription", drFileCatalogRecords[0]["Data"].ToString().Replace("\n", "\x0a"));
                        }
                    }
                }
                #endregion

                // 参与人员
                #region 参与人员
                SetParticipant(decl, docx, conn);
                #endregion

                // 设置协会名称
                string strActivityType = ConfigurationManager.AppSettings["ActivityType"];
                docx.ReplaceText("AssociationName", BLL.SysConstant.GetAppSettings("AssociationName_" + strActivityType, conn));

                // 申报单位法人代表人声明
                docx.ReplaceText("LegalPersonName", decl.LegalPersonName ?? "");
                docx.ReplaceText("LegalPersonIDNo", decl.LegalPersonIDNo ?? "");
                docx.ReplaceText("PrizeName", decl.PrizeName);
                docx.ReplaceText("AwardName", SysConstant.GetAppSettings("AwardName", conn));
                docx.ReplaceText("LegalTime", decl.DeclareDate.Value.ToString("yyyy年MM月dd日"));

                // 合作设计项目分工表
                #region 合作设计项目分工表
                //string strCollaborativeIDs = dictConstant["CollaborativeIDs"];
                //string[] arrCollaborative = strCollaborativeIDs.Split(',');
                //iTableIndex = Convert.ToInt32(dictConstant["Collaborative"]);
                //tblDocx = docx.Tables[iTableIndex];
                //for (int i = 0; i < arrCollaborative.Count(); i++)
                //{
                //    SetCollaborative(arrCollaborative[i], tblDocx, i + 2, iStep, dtDeclaration, dictConstant);
                //}
                SetCollaborative(docx, dtDeclaration, dictConstant);
                #endregion

                //给文档添加1个图像
                //string strZxingUrl = BLL.Declaration.CreatQRcode(decl.DeclarationCode, conn);
                //Novacode.Image img = doc.AddImage(strRootDirectory + "Temp/" + decl.DeclarationCode + "/QRcode" + decl.DeclarationCode + ".jpg");
                ////将图像插入到段落后面 
                //Novacode.Picture pic = img.CreatePicture(150, 150);
                //Novacode.Table tab = doc.Paragraphs[3].InsertTableBeforeSelf(1, 1);                
                ////tab.SetTableCellMargin(Novacode.TableCellMarginType.left, 250);
                //tab.Alignment = Novacode.Alignment.center;
                ////float[] aaa={12.33f,12.5f};
                ////tab.SetWidths(aaa);
                //doc.Paragraphs[3].InsertPicture(pic, 0);

                // 保存
                docx.SaveAs(strSaveFile);

                // 添加水印
                //AddWatermark(strSaveFile, strActivityType, conn);

                return strSaveFile;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 调整申报表作者
        /// </summary>
        /// <param name="iOriginalOwner"></param>
        /// <param name="iNewOwner"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        public static int AdjustOwner(int iOriginalOwner, int iNewOwner, int iActivityID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            StringBuilder sbSql = new StringBuilder();

            sbSql.Append(" update Declaration set UserID = ? where UserID = ? ");
            sbSql.Append(" and DeclarationID in (select d.DeclarationID from Declaration d ");
            sbSql.Append(" inner join Prize p on p.PrizeID = d.PrizeID ");
            sbSql.Append(" inner join Specialty s on s.SpecialtyID = p.SpecialtyID and s.ActivityID = ? ) ");

            return Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iNewOwner }
                , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iOriginalOwner }
                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });
        }

        public static int AdjustPrize(int iDeclarateID, int iAdjustedPrizeID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " update Declaration set AdjustedPrizeID = ? where DeclarateID =? ";
            return Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                 , new OleDbParameter("@AdjustedPrizeID", OleDbType.Integer) { Value = iAdjustedPrizeID }
                 , new OleDbParameter("@DeclarateID", OleDbType.Integer) { Value = iDeclarateID });
        }

        public static void ResetOrganizationOrdinal(int iPrizeID, int iOrganizationID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            // 重排内部序号
            string strSql = @"WITH CTE AS(SELECT *, rn = ROW_NUMBER() OVER(ORDER BY OrganizationOrdinal) FROM Declaration WHERE OrganizationID = ? ) 
                              UPDATE CTE SET OrganizationOrdinal = rn ";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
             , new OleDbParameter("@OrganizationID", OleDbType.Integer) { Value = iOrganizationID });

            // 重排内部序号
            strSql = @"WITH CTE AS(SELECT *, rn = ROW_NUMBER() OVER(ORDER BY AssociationOrdinal) FROM Declaration WHERE PrizeID = ? ) 
                              UPDATE CTE SET AssociationOrdinal = rn ";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
             , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID });
        }

        /// <summary>
        /// 设定企业推荐顺序
        /// </summary>
        /// <param name="declaration"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        public static void SetOrganizationOrdinal(Dal.Models.Declaration declaration, OleDbConnection conn, OleDbTransaction trans = null)
        {
            if (declaration == null || declaration.DeclarationID == null || declaration.OrganizationID == null || declaration.PrizeID == null)
            {
                throw new Exception("参数错误!");
            }
            #region
            //Dal.Models.Organization org = Organization.GetOrganization(declaration.OrganizationID.Value, conn, trans);
            //Dal.Models.UserInfo userOrg = User.GetUserInfo(org.UserID.Value,conn,trans);
            //List<Dal.Models.Declaration> lstDeclaration = GetDeclarationList(userOrg, declaration.ActivityID.Value, conn, trans).
            //    Where(d => d.DeclarationID != declaration.DeclarationID).OrderBy(d => d.OrganizationOrdinal).ToList();

            //if (declaration.DeclarationStatus == "1805" || declaration.DeclarationStatus == "1806")
            //{
            //    lstDeclaration = lstDeclaration.Where(d => d.DeclarationStatus == "1805" || d.DeclarationStatus == "1806").ToList();
            //}
            //else
            //{
            //    lstDeclaration = lstDeclaration.Where(d => d.DeclarationStatus != "1805" && d.DeclarationStatus != "1806").ToList();
            //}

            //if (declaration.OrganizationOrdinal == null || declaration.OrganizationOrdinal > lstDeclaration.Count)
            //{
            //    lstDeclaration.Add(declaration);
            //}
            //else if (declaration.OrganizationOrdinal <= 0)
            //{
            //    lstDeclaration.Insert(0, declaration);
            //}
            //else
            //{
            //    lstDeclaration.Insert(declaration.OrganizationOrdinal.Value - 1, declaration);
            //}

            //string strSql = " UPDATE Declaration set OrganizationOrdinal = ? where DeclarationID = ? ";
            //for (int i = 0; i < lstDeclaration.Count; i++)
            //{
            //    Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
            //         , new OleDbParameter("@OrganizationOrdinal", OleDbType.Integer) { Value = i + 1 }
            //         , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = lstDeclaration[i].DeclarationID.Value });
            //}
            #endregion

            Dal.OleDbHlper.ExecuteNonQuery("Pr_SetOrganizationOrdinal", conn, CommandType.StoredProcedure, trans
                , new OleDbParameter("@DeclarateID", OleDbType.Integer) { Value = declaration.DeclarationID }
                , new OleDbParameter("@OrganizationOrdinal", OleDbType.Integer) { Value = declaration.OrganizationOrdinal });

        }

        public static void SetAssociationOrdinal(Dal.Models.Declaration declaration, OleDbConnection conn, OleDbTransaction trans = null)
        {
            if (declaration == null || declaration.DeclarationID == null || declaration.PrizeID == null)
            {
                throw new Exception("参数错误!");
            }

            #region

            //List<Dal.Models.Declaration> lstDeclaration = GetDeclarationList(
            //    declaration.PrizeID.Value, conn, trans)
            //    .Where(d => d.DeclarationID != declaration.DeclarationID)
            //    .OrderBy(d=>d.AssociationOrdinal).ToList();
            //if (declaration.AssociationOrdinal == null || declaration.AssociationOrdinal > lstDeclaration.Count)
            //{
            //    lstDeclaration.Add(declaration);
            //}
            //else if (declaration.AssociationOrdinal <= 0)
            //{
            //    lstDeclaration.Insert(0, declaration);
            //}
            //else
            //{
            //    lstDeclaration.Insert(declaration.AssociationOrdinal.Value - 1, declaration);
            //}

            //string strSql = " UPDATE Declaration set AssociationOrdinal = ? where DeclarationID = ? ";
            //for (int i = 0; i < lstDeclaration.Count; i++)
            //{
            //    Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
            //         , new OleDbParameter("@AssociationOrdinal", OleDbType.Integer) { Value = i + 1 }
            //         , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = lstDeclaration[i].DeclarationID.Value });
            //}
            #endregion

            Dal.OleDbHlper.ExecuteNonQuery("Pr_SetOrganizationOrdinal", conn, CommandType.StoredProcedure, trans
                , new OleDbParameter("@DeclarateID", OleDbType.Integer) { Value = declaration.DeclarationID }
                , new OleDbParameter("@AssociationOrdinal", OleDbType.Integer) { Value = declaration.AssociationOrdinal });
        }

        /// <summary>
        /// 保存申报表数据
        /// </summary>
        /// <param name="iDeclarateID"></param>
        /// <param name="tempData"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        public static void SaveDeclarateData(int iDeclarateID, object tempData, OleDbConnection conn, OleDbTransaction trans = null)
        {
            if (tempData == null)
            {
                throw new Exception("参数错误");
            }

            string strIsExists = "SELECT Data FROM  Declaration_Data WHERE DeclarationID = ? and RecordCode = ? ";
            string strUpdate = "Update Declaration_Data set Data = ? WHERE DeclarationID = ? AND RecordCode = ? ";
            string strInsertSql = "INSERT INTO Declaration_Data (DeclarationID, RecordCode, Data) VALUES (?, ?, ?)";

            PropertyInfo[] pisData = tempData.GetType().GetProperties();
            string strPartCode = tempData.GetType().Name.TrimStart("Template_".ToArray());
            object objData = null;
            object objResult = null;
            Dal.Models.TemplateRecord objTemplateRecord;
            PropertyInfo piItem;
            for (int i = 0; i < pisData.Length; i += 4)
            {
                piItem = pisData[i];
                objData = piItem.GetValue(tempData);

                objTemplateRecord = GetTemplateRecord(strPartCode, piItem.Name, conn, trans);
                if (objTemplateRecord.RecordType == "RichText" && objData !=null)
                {
                    objData = objData.ToString().
                        Replace("&lt;","<").
                        Replace("&gt;", ">").
                        Replace("&quot;", "\"").
                        Replace("&rsquo;", "'").
                        Replace("&frasl;", "/").
                        Replace("&nbsp;", " ");
                }

                objResult = Dal.OleDbHlper.ExecuteScalar(strIsExists, conn, CommandType.Text, trans
                    , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarateID }
                    , new OleDbParameter("@RecordCode", OleDbType.VarWChar) { Value = objTemplateRecord.RecordCode });

                if (objResult != null)
                {
                    if (objResult.ToString() != objData.ToString())
                    {
                        Dal.OleDbHlper.ExecuteNonQuery(strUpdate, conn, CommandType.Text, trans
                            , new OleDbParameter("@Data", OleDbType.VarWChar) { Value = objData }
                            , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarateID }
                            , new OleDbParameter("@RecordCode", OleDbType.VarWChar) { Value = objTemplateRecord.RecordCode });
                    }
                }
                else
                {
                    Dal.OleDbHlper.ExecuteNonQuery(strInsertSql, conn, CommandType.Text, trans
                        , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarateID }
                        , new OleDbParameter("@RecordCode", OleDbType.VarWChar) { Value = objTemplateRecord.RecordCode }
                        , new OleDbParameter("@Data", OleDbType.VarWChar) { Value = objData });
                }
            }
        }


        /// <summary>
        /// 读取页面控件值，保存到模版类中，然后存入数据库
        /// </summary>
        /// <param name="iDeclarationID"></param>
        /// <param name="ctrlAnchor"></param>
        /// <param name="strTempClassName"></param>
        /// <returns></returns>
        public static int SaveData(int iDeclarationID, string strTempClassName,
            List<KeyValuePair<string, string>> lstData, OleDbConnection conn)
        {
            int iResult = 0;

            DataTable dt = new DataTable();
            dt.Columns.Add("RecordNameEn");
            dt.Columns.Add("Data");
            dt.TableName = strTempClassName.Substring("Dal.Models.".Length);
            DataRow row = null;
            foreach (KeyValuePair<string, string> kp in lstData)
            {
                row = dt.NewRow();
                row["RecordNameEn"] = kp.Key.Trim();
                row["Data"] = kp.Value.Trim();
                dt.Rows.Add(row);
            }

            OleDbTransaction trans = conn.BeginTransaction();

            try
            {
                Dal.OleDbHlper.ExecuteNonQuery("Proc_SaveDeclarationData", conn, CommandType.StoredProcedure, trans, new OleDbParameter[]{
                    new OleDbParameter("@DeclarationID", OleDbType.Integer){ Value=iDeclarationID },
                    new OleDbParameter("@PartCode", OleDbType.VarWChar){ Value= "/DocumentElement/" + dt.TableName },
                    new OleDbParameter("@XmlText", OleDbType.VarWChar){ Value= Common.ConvertDataTableToXML(dt) }
                });
                trans.Commit();
                iResult = 1;
            }
            catch (Exception ex)
            {
                trans.Rollback();
                throw ex;
            }

            return iResult;
        }

        /// <summary>
        /// 保存申报表中的参与人员信息
        /// </summary>
        /// <param name="iDeclarateID"></param>
        /// <param name="lstParticipant"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        public static int SaveParticipant(int iDeclarateID, List<Dal.Models.Participant> lstParticipant, OleDbConnection conn)
        {
            #region 
            //if (lstParticipant == null)
            //{
            //    throw new Exception("没有参与者！");
            //}

            //StringBuilder sbSql = new StringBuilder();
            //sbSql.Append(" DELETE FROM Participant ");
            //sbSql.Append(" WHERE DeclarationID = ? ");

            //Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
            //    , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarateID });

            //foreach (Dal.Models.Participant item in lstParticipant)
            //{
            //    if (!string.IsNullOrEmpty(item.ParticipantName))
            //    {
            //        sbSql.Clear();
            //        sbSql.Append(" INSERT INTO Participant( ");
            //        sbSql.Append("             DeclarationID ");
            //        sbSql.Append("            ,ParticipantName ");
            //        sbSql.Append("            ,AcademicTitle ");
            //        sbSql.Append("            ,Speciality ");
            //        sbSql.Append("            ,Duties ");
            //        sbSql.Append("            ,IDType ");
            //        sbSql.Append("            ,IDNumber ");
            //        sbSql.Append("            ,Workplace ");
            //        sbSql.Append("            ,LastUpdateTime ");
            //        sbSql.Append("            ,LastUpdateUser ");
            //        sbSql.Append(" ) VALUES ( ?, ?, ?, ?, ?, ?, ?, ?, ?, ? ) ");

            //        Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
            //             , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarateID }
            //             , new OleDbParameter("@ParticipantName", OleDbType.VarWChar) { Value = item.ParticipantName }
            //             , new OleDbParameter("@AcademicTitle", OleDbType.VarWChar) { Value = item.AcademicTitle }
            //             , new OleDbParameter("@Speciality", OleDbType.VarWChar) { Value = item.Speciality }
            //             , new OleDbParameter("@Duties", OleDbType.VarWChar) { Value = item.Duties }
            //             , new OleDbParameter("@IDType", OleDbType.VarWChar) { Value = item.IDType }
            //             , new OleDbParameter("@IDNumber", OleDbType.VarWChar) { Value = item.IDNumber }
            //             , new OleDbParameter("@Workplace", OleDbType.VarWChar) { Value = item.Workplace }
            //             , new OleDbParameter("@LastUpdateTime", OleDbType.DBDate) { Value = item.LastUpdateTime }
            //             , new OleDbParameter("@LastUpdateUser", OleDbType.Integer) { Value = item.LastUpdateUser });
            //    }
            //}
            #endregion

            DataTable dtParticipant = Dal.DataTableExtensions.ToDataTable(lstParticipant);
            dtParticipant.TableName = "Participant";
            string strXml = Common.ConvertDataTableToXML(dtParticipant);

            Dal.OleDbHlper.ExecuteNonQuery("Pr_SaveParticipant", conn, CommandType.StoredProcedure, null
                , new OleDbParameter("@DeclarateID", OleDbType.Integer) { Value = iDeclarateID }
                , new OleDbParameter("@PartCode", OleDbType.VarWChar) { Value = "/DocumentElement/Participant" }
                , new OleDbParameter("@ParticipantXml", OleDbType.VarWChar) { Value = strXml });

            return lstParticipant.Count;
        }

        public static int SaveDeclarationReview(int iDeclarateID, List<Dal.Models.Declaration> lstReview, OleDbConnection conn, OleDbTransaction trans = null)
        {
            if (lstReview == null)
            {
                throw new Exception("没有评审内容！");
            }
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" update Declaration set ExpertReviewComment=?,ExpertReviewTime=?");
            sbSql.Append(" WHERE DeclarationID = ? ");

            Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                , new OleDbParameter("@ExpertReviewComment", OleDbType.VarWChar) { Value = lstReview[0].ExpertReviewComment }
                , new OleDbParameter("@ExpertReviewTime", OleDbType.Date) { Value = lstReview[0].ExpertReviewTime }
                , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarateID });

            return lstReview.Count;
        }

        public static void SetReviewComment(int iDeclarateID, string strReviewComment, OleDbConnection conn, OleDbTransaction trans = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" update Declaration set ExpertReviewComment = ?");
            sbSql.Append(" , ExpertReviewTime = GETDATE()");
            sbSql.Append(" WHERE DeclarationID = ? ");

            Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                , new OleDbParameter("@ExpertReviewComment", OleDbType.VarWChar) { Value = strReviewComment }
                , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarateID });
        }


        /// <summary>
        /// 申报 导入模板申报信息
        /// </summary>
        /// <param name="iDeclarationID">新申报的编号</param>
        /// <param name="iImportDeclarationID">待导入的申报编号</param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        public static void ImportDeclarate(int iDeclarationID, int iImportDeclarationID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" INSERT INTO  Declaration_Data (    ");
            sbSql.Append("              DeclarationID         ");
            sbSql.Append("            , RecordCode            ");
            sbSql.Append("            , Data                  ");
            sbSql.Append("            , IsPublic )            ");
            sbSql.AppendFormat(" ( select {0}                 ", iDeclarationID);
            sbSql.Append("            , RecordCode            ");
            sbSql.Append("            , Data                  ");
            sbSql.Append("            , IsPublic              ");
            sbSql.Append("            from  Declaration_Data  ");
            sbSql.Append("            where DeclarationID=?)  ");

            Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                     , new OleDbParameter("@DeclarationID", OleDbType.VarWChar) { Value = iImportDeclarationID });

            ImportParticipant(iDeclarationID, iImportDeclarationID, conn, trans);
        }

        /// <summary>
        /// 导入模板参与人员信息
        /// </summary>
        /// <param name="iDeclarationID">新申报的编号</param>
        /// <param name="iImportDeclarationID">待导入的申报编号</param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        public static void ImportParticipant(int iDeclarationID, int iImportDeclarationID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" INSERT INTO  Participant (         ");
            sbSql.Append("              DeclarationID         ");
            sbSql.Append("            , ParticipantName       ");
            sbSql.Append("            , AcademicTitle         ");
            sbSql.Append("            , Speciality            ");
            sbSql.Append("            , Duties                ");
            sbSql.Append("            , IDType                ");
            sbSql.Append("            , IDNumber              ");
            sbSql.Append("            , Workplace             ");
            sbSql.Append("            , LastUpdateTime        ");
            sbSql.Append("            , LastUpdateUser )      ");
            sbSql.AppendFormat(" ( SELECT {0}                 ", iDeclarationID);
            sbSql.Append("            , ParticipantName       ");
            sbSql.Append("            , AcademicTitle         ");
            sbSql.Append("            , Speciality            ");
            sbSql.Append("            , Duties                ");
            sbSql.Append("            , IDType                ");
            sbSql.Append("            , IDNumber              ");
            sbSql.Append("            , Workplace             ");
            sbSql.Append("            , LastUpdateTime=?      ");
            sbSql.Append("            , LastUpdateUser        ");
            sbSql.Append("            from  Participant       ");
            sbSql.Append("            where DeclarationID=?)  ");

            Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                 , new OleDbParameter("@LastUpdateTime", OleDbType.Date) { Value = DateTime.Now }
                 , new OleDbParameter("@DeclarationID", OleDbType.VarWChar) { Value = iImportDeclarationID });
        }

        /// <summary>
        /// 导入模板附件信息
        /// </summary>
        /// <param name="iDeclarationID">新申报的编号</param>
        /// <param name="iImportDeclarationID">待导入的申报编号</param>
        /// <param name="strDeclarationCode">新申报的编码</param>
        /// <param name="strImportDeclarationCode">待导入的申报编码</param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        public static void ImportUploadFile(int iDeclarationID, int iImportDeclarationID
            , string strDeclarationCode, string strImportDeclarationCode
            , OleDbConnection conn, OleDbTransaction trans = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" INSERT INTO  UploadFile (         ");
            sbSql.Append("              OwnerID              ");
            sbSql.Append("            , TypeCode             ");
            sbSql.Append("            , CorrelationID        ");
            sbSql.Append("            , FileName             ");
            sbSql.Append("            , FileContent          ");
            sbSql.Append("            , URL                  ");
            sbSql.Append("            , UploadTime   )       ");
            sbSql.AppendFormat(" SELECT {0}                 ", iDeclarationID);
            sbSql.Append("            , TypeCode             ");
            sbSql.Append("            , CorrelationID        ");
            sbSql.Append("            , FileName             ");
            sbSql.Append("            , FileContent          ");
            sbSql.AppendFormat("      , URL= replace(URL,'{0}','{1}')", strImportDeclarationCode, strDeclarationCode);// 替换URL
            sbSql.Append("            , UploadTime= ?        ");
            sbSql.Append("            from  UploadFile       ");
            sbSql.Append("            where OwnerID= ? and TypeCode like 'Declaration%' ");

            Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                 , new OleDbParameter("@UploadTime", OleDbType.Date) { Value = DateTime.Now }
                 , new OleDbParameter("@OwnerID", OleDbType.VarWChar) { Value = iImportDeclarationID });

            string strFileUrl = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + "Content\\Temp" ;
            string strFileUrl2 = System.Web.HttpContext.Current.Request.PhysicalApplicationPath + "Content\\Temp\\" + strImportDeclarationCode;
            CopyDirectory(strFileUrl2, strFileUrl, strDeclarationCode, strImportDeclarationCode);
            
        }
        /// <summary>
        /// 拷贝文件夹
        /// </summary>
        /// <param name="srcdir"></param>
        /// <param name="desdir"></param>
        public static void CopyDirectory(string srcdir, string desdir, string strDeclarationCode, string strImportDeclarationCode)
        {
            string folderName = srcdir.Substring(srcdir.LastIndexOf("\\") + 1);

            string desfolderdir = desdir + "\\" + folderName;

            if (desdir.LastIndexOf("\\") == (desdir.Length - 1))
            {
                desfolderdir = desdir + folderName;
            }

            if (Directory.Exists(srcdir))
            {
                string[] filenames = Directory.GetFileSystemEntries(srcdir);

                foreach (string file in filenames)// 遍历所有的文件和目录
                {
                    if (Directory.Exists(file))// 先当作目录处理如果存在这个目录就递归Copy该目录下面的文件
                    {

                        string currentdir = desfolderdir.Replace(strImportDeclarationCode, strDeclarationCode) + "\\" + file.Substring(file.LastIndexOf("\\") + 1);

                        if (!Directory.Exists(currentdir))
                        {
                            Directory.CreateDirectory(currentdir);
                        }

                        CopyDirectory(file, desfolderdir, strDeclarationCode, strImportDeclarationCode);
                    }

                    else // 否则直接copy文件
                    {
                        string srcfileName = file.Substring(file.LastIndexOf("\\") + 1);

                        srcfileName = desfolderdir.Replace(strImportDeclarationCode, strDeclarationCode) + "\\" + srcfileName;
                        if (!Directory.Exists(desfolderdir))
                        {
                            Directory.CreateDirectory(desfolderdir);
                        }
                        File.Copy(file, srcfileName);
                    }
                }//foreach 
            }
        }

        public static bool IsPermitedDeclaration(string strDeclarationName, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "SELECT DeclarationName FROM RecommendedDeclaration where DeclarationName = ? ";

            object objData = Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@DeclarationName", OleDbType.VarWChar) { Value = strDeclarationName });

            if (objData == DBNull.Value || objData == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static int Declarate(ref Dal.Models.Declaration declaration, OleDbConnection conn, OleDbTransaction trans = null)
        {
            // 判断输入合法性
            if (string.IsNullOrEmpty(declaration.DeclarationName))
            {
                throw new Exception("未填写申报名称!");
            }
            if (declaration.UserID == null || declaration.PrizeID == null)
            {
                throw new Exception("参数错误，请稍候重试!");
            }
            if (declaration.OrganizationID == null)
            {
                Dal.Models.Organization org = User.GetOrganization(declaration.UserID.Value, conn, trans);
                if (org == null)
                {
                    throw new Exception("参数错误,请重试!");
                }
                declaration.OrganizationID = org.OrganizationID;
            }

            Dal.Models.Declaration declNamed = GetDeclaration(declaration.DeclarationName, declaration.PrizeID.Value, conn, trans);
            if (declNamed != null && declNamed.DeclarationID != declaration.DeclarationID)
            {
                throw new Exception("该奖项下已存在同名申报,不能重复创建!");
            }

            if (declaration.DeclarationID == null && !IsPermitedDeclaration(declaration.DeclarationName, conn, trans))
            {
                throw new Exception("此项目名称不在协会推荐名单中，不能创建此项目。");
            }

            StringBuilder sbSql = new StringBuilder();

            if (declaration.DeclarationID == null)
            {
                Dal.Models.Prize prize = Prize.GetPrize(declaration.PrizeID.Value, conn, trans);
                declaration.TemplateCode = prize.TemplateCode;
                Dal.Models.Specialty specialty = Specialty.GetSpecialty(prize.SpecialtyID.Value, conn, trans);
                Dal.Models.Activity activity = Activity.GetActivity(prize.ActivityID.Value, conn, trans);

                string strCodeHead = DateTime.Now.ToString("yy")
                    + activity.ActivityTypeCode.Substring(2, 2) + specialty.SpecialtyCode;
                declaration.DeclarationCode = BLL.Declaration.GetDeclarationCode(prize.SpecialtyID.Value, strCodeHead, conn, trans);

                sbSql.Append(" INSERT INTO  Declaration (       ");
                sbSql.Append("              DeclarationCode     ");
                sbSql.Append("            , DeclarationName     ");
                sbSql.Append("            , OrganizationID      ");
                sbSql.Append("            , PrizeID             ");
                sbSql.Append("            , UserID              ");
                sbSql.Append("            , DeclareDate         ");
                sbSql.Append("            , CreateTime          ");
                sbSql.Append("            , LastUpdateTime      ");
                sbSql.Append("            , DeclarationStatus   ");
                sbSql.Append("            , AdjustedPrize       ");
                sbSql.Append("            , RecommendFrom       ");
                sbSql.Append(" ) VALUES (?, ?, ?, ?, ?, ?, GetDate(), GetDate(), '1801', ?, ?) ");

                Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                     , new OleDbParameter("@DeclarationCode", OleDbType.VarWChar) { Value = declaration.DeclarationCode }
                     , new OleDbParameter("@DeclarationName", OleDbType.VarWChar) { Value = declaration.DeclarationName }
                     , new OleDbParameter("@OrganizationID", OleDbType.Integer) { Value = declaration.OrganizationID }
                     , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = declaration.PrizeID }
                     , new OleDbParameter("@UserID", OleDbType.Integer) { Value = declaration.UserID }
                     , new OleDbParameter("@DeclareDate", OleDbType.DBDate) { Value = declaration.DeclareDate }
                     , new OleDbParameter("@AdjustedPrize", OleDbType.Integer) { Value = declaration.PrizeID }
                     , new OleDbParameter("@RecommendFrom", OleDbType.VarWChar) { Value = declaration.RecommendFrom });

                declaration.DeclarationID = GetDeclaration(declaration.DeclarationCode, conn, trans).DeclarationID;
                SetOrganizationOrdinal(declaration, conn, trans);
            }
            else
            {
                sbSql.Append(" UPDATE Declaration ");
                sbSql.Append("   SET DeclarationName = ? ");
                sbSql.Append("      ,PrizeID = ? ");
                sbSql.Append("      ,AdjustedPrize = ? ");
                sbSql.Append("      ,DeclareDate = ? ");
                sbSql.Append("      ,LastUpdateTime = GetDate() ");
                sbSql.Append("      ,RecommendFrom = ? ");
                sbSql.Append(" WHERE DeclarationID = ? ");

                Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                    , new OleDbParameter("@DeclarationName", OleDbType.VarWChar) { Value = declaration.DeclarationName }
                    , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = declaration.PrizeID }
                    , new OleDbParameter("@AdjustedPrize", OleDbType.Integer) { Value = declaration.PrizeID }
                    , new OleDbParameter("@DeclareDate", OleDbType.DBDate) { Value = declaration.DeclareDate }
                    , new OleDbParameter("@RecommendFrom", OleDbType.VarWChar) { Value = declaration.RecommendFrom }
                    , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = declaration.DeclarationID });
            }

            return declaration.DeclarationID.Value;
        }

        public static void RecoveryDeclaration(int iDeclarateID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            Dal.Models.Declaration decl = GetDeclaration(iDeclarateID, conn, trans);

            Dal.Models.Declaration declNamed = GetDeclaration(decl.DeclarationName, decl.AdjustedPrize.Value, conn, trans);
            if (declNamed.DeclarationID != decl.DeclarationID)
            {
                throw new Exception("存在与此项目同名的项目，项目恢复失败！");
            }
            string strSql = " UPDATE Declaration set DeclarationStatus = DeclarationStatusBackup, DeclarationStatusBackup = null, DeleteTime = null where DeclarationID = ? ";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                 , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarateID });

            decl.DeclarationStatus = decl.DeclarationStatusBackup;
            decl.OrganizationOrdinal = int.MaxValue;
            SetOrganizationOrdinal(decl, conn, trans);
        }

        public static void DeleteDeclaration(int iDeclarateID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            Dal.Models.Declaration declDelete = GetDeclaration(iDeclarateID, conn, trans);
            string strDeclarationStatus = declDelete.DeclarationStatus;
            if (strDeclarationStatus == "1802" || strDeclarationStatus == "1803")
            {
                throw new Exception("已经提交的申报表不允许删除!");
            }

            string strSql = "";

            // 删除文件
            strSql = " delete from UploadFile where OwnerID = ? and TypeCode like 'Declaration%' ";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarateID });

            // 删除参与人员
            strSql = " delete from Participant where DeclarationID = ? ";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarateID });

            // 删除数据
            strSql = " delete from Declaration_Data where DeclarationID = ? ";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarateID });

            // 删除申报表
            strSql = " delete from Declaration where DeclarationID = ? ";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarateID });

            ResetOrganizationOrdinal(declDelete.PrizeID.Value, declDelete.OrganizationID.Value, conn, trans);
        }

        //public static Dal.Models.Participant GetParticipant(string strIDType, string strIDNumber, OleDbConnection conn, OleDbTransaction trans = null) {
        //    string strSql = "SELECT p.*,s.ConstantValue IDTypeName FROM Participant p inner join SysConstant s on s.ConstantCode=p.IDType WHERE p.IDType = ? and p.IDNumber = ? ";
        //    return Dal.Models.BaseEntity.GetEntity<Dal.Models.Participant>((Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, trans
        //        , new OleDbParameter("@IDType", OleDbType.VarWChar) { Value = strIDType }
        //        , new OleDbParameter("@IDNumber", OleDbType.VarWChar) { Value = strIDNumber })));
        //}

        public static List<Dal.Models.Participant> GetParticipant(int iDeclarateID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = "SELECT p.*,s.ConstantValue IDTypeName FROM Participant p inner join SysConstant s on s.ConstantCode=p.IDType WHERE DeclarationID = ? ";
            return Dal.OleDbHlper.GetList<Dal.Models.Participant>(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarateID });
        }

        //public static void SetParticipant(Dal.Models.Participant parti, OleDbConnection conn, OleDbTransaction trans = null)
        //{
        //    Dal.Models.Participant partiOriginal = GetParticipant(parti.IDType, parti.IDNumber, conn, trans);

        //    StringBuilder sbSql = new StringBuilder();
        //    if (partiOriginal == null)
        //    {
        //        sbSql.Append(" INSERT INTO Participant ");
        //        sbSql.Append("        (DeclarationID ");
        //        sbSql.Append("        ,Ordinal ");
        //        sbSql.Append("        ,ParticipantName ");
        //        sbSql.Append("        ,AcademicTitle ");
        //        sbSql.Append("        ,Speciality ");
        //        sbSql.Append("        ,Duties ");
        //        sbSql.Append("        ,IDType ");
        //        sbSql.Append("        ,IDNumber ");
        //        sbSql.Append("        ,Workplace ");
        //        sbSql.Append("        ,LastUpdateTime ");
        //        sbSql.Append("        ,LastUpdateUser )");
        //        sbSql.Append("  VALUES( ?, ?, ?, ?, ?, ?, ?, ?, ?, GETDATE(), ?)");
        //        Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
        //            , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = parti.DeclarationID }
        //            , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = parti.Ordinal }
        //            , new OleDbParameter("@ParticipantName", OleDbType.VarWChar) { Value = parti.ParticipantName }
        //            , new OleDbParameter("@AcademicTitle", OleDbType.VarWChar) { Value = parti.AcademicTitle }
        //            , new OleDbParameter("@Speciality", OleDbType.VarWChar) { Value = parti.Speciality }
        //            , new OleDbParameter("@Duties", OleDbType.VarWChar) { Value = parti.Duties }
        //            , new OleDbParameter("@IDType", OleDbType.VarWChar) { Value = parti.IDType }
        //            , new OleDbParameter("@IDNumber", OleDbType.VarWChar) { Value = parti.IDNumber }
        //            , new OleDbParameter("@Workplace", OleDbType.VarWChar) { Value = parti.Workplace }
        //            , new OleDbParameter("@LastUpdateUser", OleDbType.VarWChar) { Value = parti.LastUpdateUser });
        //    }
        //    else
        //    {
        //        sbSql.Append(" UPDATE Participant");
        //        sbSql.Append("   SET DeclarationID = ? ");
        //        sbSql.Append("      ,Ordinal = ? ");
        //        sbSql.Append("      ,ParticipantName = ? ");
        //        sbSql.Append("      ,AcademicTitle = ? ");
        //        sbSql.Append("      ,Speciality = ? ");
        //        sbSql.Append("      ,Duties = ? ");
        //        sbSql.Append("      ,IDType = ? ");
        //        sbSql.Append("      ,IDNumber = ? ");
        //        sbSql.Append("      ,Workplace = ? ");
        //        sbSql.Append("      ,LastUpdateTime =  GETDATE() ");
        //        sbSql.Append("      ,LastUpdateUser = ? ");
        //        sbSql.Append(" WHERE ParticipantID = ? ");
        //        Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
        //            , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = parti.DeclarationID }
        //            , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = parti.Ordinal }
        //            , new OleDbParameter("@ParticipantName", OleDbType.VarWChar) { Value = parti.ParticipantName }
        //            , new OleDbParameter("@AcademicTitle", OleDbType.VarWChar) { Value = parti.AcademicTitle }
        //            , new OleDbParameter("@Speciality", OleDbType.VarWChar) { Value = parti.Speciality }
        //            , new OleDbParameter("@Duties", OleDbType.VarWChar) { Value = parti.Duties }
        //            , new OleDbParameter("@IDType", OleDbType.VarWChar) { Value = parti.IDType }
        //            , new OleDbParameter("@IDNumber", OleDbType.VarWChar) { Value = parti.IDNumber }
        //            , new OleDbParameter("@Workplace", OleDbType.VarWChar) { Value = parti.Workplace }
        //            , new OleDbParameter("@LastUpdateUser", OleDbType.VarWChar) { Value = parti.LastUpdateUser }
        //            , new OleDbParameter("@ParticipantID", OleDbType.Integer) { Value = partiOriginal.ParticipantID });
        //    }

        //    parti.ParticipantID = GetParticipant(parti.IDType, parti.IDNumber, conn, trans).ParticipantID;

        //    SetParticipantOrdinal(parti, conn, trans);
        //}

        //public static void SetParticipantOrdinal(Dal.Models.Participant parti, OleDbConnection conn, OleDbTransaction trans = null) 
        //{
        //    List<Dal.Models.Participant> lstParticipant = GetParticipant(parti.DeclarationID.Value, conn, trans)
        //        .Where(p=>p.ParticipantID != parti.ParticipantID)
        //        .OrderBy(d => d.Ordinal).ToList();

        //    if (parti.Ordinal == null || parti.Ordinal > lstParticipant.Count)
        //    {
        //        lstParticipant.Add(parti);
        //    }
        //    else if (parti.Ordinal <= 0)
        //    {
        //        lstParticipant.Insert(0, parti);
        //    }
        //    else
        //    {
        //        lstParticipant.Insert(parti.Ordinal.Value - 1, parti);
        //    }

        //    string strSql = " UPDATE Participant set Ordinal = ? where ParticipantID = ? ";
        //    for (int i = 0; i < lstParticipant.Count; i++)
        //    {
        //        Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
        //             , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = i + 1 }
        //             , new OleDbParameter("@ParticipantID", OleDbType.Integer) { Value = lstParticipant[i].ParticipantID.Value });
        //    }
        //}

        //public static void DeleteParticipant(int iParticipantID, OleDbConnection conn, OleDbTransaction trans = null) {
        //    string strSql = " delete from Participant WHERE ParticipantID = ? ";
        //    Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
        //        , new OleDbParameter("@ParticipantID", OleDbType.Integer) { Value = iParticipantID });
        //}

        public static int GetWeeklyNewDeclarationCount(int iActiveID, int iSpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" SELECT count(*) FROM Declaration d ");
            sbSql.Append(" inner join Prize p on p.PrizeID = d.PrizeID ");
            sbSql.Append(" inner join Specialty s on s.SpecialtyID = p.SpecialtyID ");
            sbSql.Append(" WHERE s.ActivityID = ? ");
            sbSql.Append(" and datepart(week, getdate()) = datepart(week, d.CreateTime) AND d.DeclarationStatus NOT IN ('1805','1806') ");

            object objResult;
            if (iSpecialtyID > 0)
            {
                sbSql.Append(" and s.SpecialtyID = ? ");
                objResult = Dal.OleDbHlper.ExecuteScalar(sbSql.ToString(), conn, CommandType.Text, tran
                 , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActiveID }
                 , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID });
            }
            else
            {
                objResult = Dal.OleDbHlper.ExecuteScalar(sbSql.ToString(), conn, CommandType.Text, tran
                    , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActiveID });
            }

            int? iResult = Common.ToInt32(objResult);

            if (iResult == null)
            {
                iResult = 0;
            }

            return iResult.Value;
        }

        public static int GetDeclarationCount(int iActiveID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" SELECT count(*) FROM Declaration d ");
            sbSql.Append(" inner join Prize p on p.PrizeID = d.PrizeID ");
            sbSql.Append(" inner join Specialty s on s.SpecialtyID = p.SpecialtyID ");
            sbSql.Append(" WHERE s.ActivityID = ? AND d.DeclarationStatus NOT IN ('1805','1806')");

            object objResult = Dal.OleDbHlper.ExecuteScalar(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActiveID });

            int? iResult = Common.ToInt32(objResult);

            if (iResult == null)
            {
                iResult = 0;
            }

            return iResult.Value;
        }

        public static int CountInSpecialty(int iSpecialtyID, string strStatus, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" SELECT COUNT(*) FROM Declaration D ");
            sbSql.Append(" inner join Prize P on P.PrizeID = D.PrizeID ");
            sbSql.Append(" WHERE P.SpecialtyID = ? ");
            sbSql.AppendFormat(" and d.DeclarationStatus = '{0}' ", strStatus);

            int iResult = Common.ToInt32(Dal.OleDbHlper.ExecuteScalar(sbSql.ToString(), conn, CommandType.Text, tran
          , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID })).Value;

            List<Dal.Models.Specialty> lstSpecialty = Specialty.GetDirectlyChildList(iSpecialtyID, conn, tran);
            if (lstSpecialty.Count > 0)
            {
                foreach (Dal.Models.Specialty item in lstSpecialty)
                {
                    iResult += CountInSpecialty(item.SpecialtyID.Value, strStatus, conn, tran);
                }
            }

            return iResult;
        }

        public static int CountInSpecialty(int iSpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            Dal.Models.Specialty spec = Specialty.GetTopSpecialty(iSpecialtyID, conn, tran);

			string strSql = " SELECT COUNT(*) FROM Declaration D inner join Prize P on P.PrizeID = D.PrizeID WHERE P.SpecialtyID = ? and D.DeclarationStatus='1803'";

            int iResult = Common.ToInt32(Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID })).Value;

            List<Dal.Models.Specialty> lstSpecialty = Specialty.GetDirectlyChildList(iSpecialtyID, conn, tran);
            if (lstSpecialty.Count > 0)
            {
                foreach (Dal.Models.Specialty item in lstSpecialty)
                {
                    iResult += CountInSpecialty(item.SpecialtyID.Value, conn, tran);
                }
            }

            return iResult;
        }

        //public static int CountInOrganization(int iOrganizationID, OleDbConnection conn, OleDbTransaction tran = null)
        //{
        //    string strSql = " SELECT COUNT(*) FROM Declaration WHERE OrganizationID = ? ";
        //    int iResult = Common.ToInt32(Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran
        //        , new OleDbParameter("@OrganizationID", OleDbType.Integer) { Value = iOrganizationID })).Value;
        //    return iResult;
        //}

        //public static int CountInPrize(int iPrizeID, OleDbConnection conn, OleDbTransaction tran = null)
        //{
        //    string strSql = " SELECT COUNT(*) FROM Declaration WHERE PrizeID = ? ";
        //    int iResult = Common.ToInt32(Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran
        //        , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID })).Value;
        //    return iResult;
        //}

        public static List<Dal.Models.Declaration> GetWeeklyCompleteDeclaration(int iActiveID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" SELECT * FROM dbo.V_Declaration d ");
            sbSql.Append(" WHERE datepart(week, getdate()) = datepart(week, LastUpdateTime) ");
            sbSql.Append(" and DeclarationStatus ='1802' and ActivityID = ? ");

            return Dal.OleDbHlper.GetList<Dal.Models.Declaration>(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActiveID });
        }

        /// <summary>
        /// 设定申报表状态
        /// </summary>
        /// <param name="iDeclarationID"></param>
        /// <param name="strStatus"></param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public static void SetDeclarationSataus(int iDeclarationID, int iUserID, string strStatus, string strDeclarationComment, OleDbConnection conn)
        {
            Dal.OleDbHlper.ExecuteNonQuery("Pr_SetDeclarationSataus", conn, CommandType.StoredProcedure, null
               , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarationID }
               , new OleDbParameter("@Operator", OleDbType.Integer) { Value = iUserID }
               , new OleDbParameter("@DeclarationSataus", OleDbType.VarWChar) { Value = strStatus }
               , new OleDbParameter("@DeclarationComment", OleDbType.VarWChar) { Value = strDeclarationComment });
        }

        public static void SetDeclarationSataus(string strSelectedDeclarationIDs, int iUserID, string strStatus, string strDeclarationComment, OleDbConnection conn)
        {
            Dal.OleDbHlper.ExecuteNonQuery("Pr_SetDeclarationSataus_Batch", conn, CommandType.StoredProcedure, null
               , new OleDbParameter("@SelectedDeclarationIDs", OleDbType.VarWChar) { Value = strSelectedDeclarationIDs }
               , new OleDbParameter("@Operator", OleDbType.Integer) { Value = iUserID }
               , new OleDbParameter("@DeclarationSataus", OleDbType.VarWChar) { Value = strStatus }
               , new OleDbParameter("@DeclarationComment", OleDbType.VarWChar) { Value = strDeclarationComment });
        }

        /// <summary>
        /// 为项目分配专家组
        /// </summary>
        /// <param name="iDeclarationID"></param>
        /// <param name="iGroupID"></param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        public static void AllocateDeclaration(int iDeclarationID, int? iGroupID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " update Declaration set ExpertReviewGroupID = ? where DeclarationID = ? ";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, System.Data.CommandType.Text, tran
                , new OleDbParameter("@ExpertReviewGroupID", OleDbType.Integer) { Value = iGroupID }
                , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarationID });
        }

        /// <summary>
        /// 为项目分配评审专家
        /// </summary>
        /// <param name="iDeclarationID"></param>
        /// <param name="iReviewerExpertID"></param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        public static void SetExpertReviewer(int iDeclarationID, int? iReviewerExpertID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " update Declaration set ExpertReviewer = ? where DeclarationID = ? ";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, System.Data.CommandType.Text, tran
                , new OleDbParameter("@ExpertReviewer", OleDbType.Integer) { Value = iReviewerExpertID }
                , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarationID });
        }

        //public static List<Dal.Models.Declaration> GetVoteListByPrize(int iPrizeID, OleDbConnection conn, OleDbTransaction tran = null)
        //{
        //    StringBuilder sbSql = new StringBuilder();
        //    sbSql.Append(" SELECT D.* ");
        //    sbSql.Append(" FROM V_Declaration AS D ");
        //    sbSql.Append(" where d.PrizeID = ? and d.DeclarationStatus='1803' ");

        //    return Dal.OleDbHlper.GetList<Dal.Models.Declaration>(sbSql.ToString(), conn, CommandType.Text, tran
        //            , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID });
        //}

        //public static List<Dal.Models.Declaration> GetVoteListByPrize(int iExpertID, int iPrizeID, OleDbConnection conn, OleDbTransaction tran = null)
        //{
        //    StringBuilder sbSql = new StringBuilder();
        //    sbSql.Append(" SELECT D.*, p.PrizeName, u.UserName Creator, o.OrganizationName, sc.ConstantValue DeclarationStatusText ");
        //    sbSql.Append("        , s.SpecialtyID, s.IsAllowUpdate, S.TotalOrdinal SpecialtyTotalOrdinal, P.Ordinal PrizeOrdinal, p.PrizeTypeCode, p.IsMultipleVoting ");
        //    sbSql.Append("        , case when p.PrizeTypeCode = '0301' or  p.PrizeTypeCode = '0304' ");
        //    sbSql.Append("               then scp.ConstantValue + '(' + case when p.IsMultipleVoting = 'True' then '多次' else '单次' end + ')' ");
        //    sbSql.Append("               else scp.ConstantValue end PrizeType ");
        //    sbSql.Append(" FROM Declaration AS D ");
        //    sbSql.Append(" INNER JOIN Prize AS P ON P.PrizeID = D.PrizeID ");
        //    sbSql.Append(" INNER JOIN Specialty AS S ON S.SpecialtyID = P.SpecialtyID ");
        //    sbSql.Append(" INNER JOIN Organization AS O ON O.OrganizationID = D.OrganizationID ");
        //    sbSql.Append(" INNER JOIN Users u ON u.UserID = D.UserID ");
        //    sbSql.Append(" INNER JOIN SysConstant sc ON sc.ConstantCode = D.DeclarationStatus");
        //    sbSql.Append(" INNER JOIN SysConstant scp on scp.ConstantCode = p.PrizeTypeCode");
        //    sbSql.Append(" INNER JOIN ExpertGroup e on e.GroupID = d.ExpertReviewGroupID ");
        //    sbSql.Append(" INNER JOIN GroupMember g on g.GroupID = e.GroupID ");
        //    sbSql.Append(" where g.ExpertID = ? and d.PrizeID = ? and DeclarationStatus='1803' ");

        //    return Dal.OleDbHlper.GetList<Dal.Models.Declaration>(sbSql.ToString(), conn, CommandType.Text, tran
        //            , new OleDbParameter("@ExpertID", OleDbType.Integer) { Value = iExpertID }
        //            , new OleDbParameter("@PrizeID", OleDbType.Integer) { Value = iPrizeID });
        //}


        /// <summary>
        /// 保存意见填写人
        /// </summary>
        /// <param name="DeclarationID"></param>
        /// <param name="ExpertReviewerID"></param>
        /// <param name="conn"></param>
        /// <param name="trans"></param>
        /// <returns></returns>
        public static int SaveExpertReviewer(int DeclarationID, int ExpertReviewerID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            StringBuilder sbSql = new StringBuilder();

            sbSql.Append(" update Declaration set ExpertReviewer = ? where DeclarationID = ? ");

            return Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                , new OleDbParameter("@ExpertReviewer", OleDbType.Integer) { Value = ExpertReviewerID }
                , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = DeclarationID });
        }

        public static void PackageDeclaration(int iPrizeID, string strServerMapPath, OleDbConnection conn)
        {
            List<Dal.Models.Declaration> lstDeclaration = GetDeclarationList(iPrizeID, conn);
            if (lstDeclaration.Count > 0)
            {
                string strPrizePath = strServerMapPath + "Content\\Temp\\PrizeSummary\\" + lstDeclaration[0].PrizeName + "\\";

                if (Directory.Exists(strPrizePath))
                {
                    Directory.Delete(strPrizePath, true);
                }

                if (!Directory.Exists(strPrizePath))
                {
                    Directory.CreateDirectory(strPrizePath);
                }

                FileStream fs = File.OpenWrite(strPrizePath + lstDeclaration[0].PrizeName + "_log.txt");
                byte[] data = System.Text.Encoding.Default.GetBytes("开始整理，文件总数：" + lstDeclaration.Count.ToString() + "\r\n");
                fs.Write(data, 0, data.Length);

                try
                {
                    string strDeclarationPath, strDeclarationCodePath;
                    foreach (Dal.Models.Declaration d in lstDeclaration)
                    {
                        try
                        {
                            ExportDeclaration(d.DeclarationID.Value, strServerMapPath, conn);
                            strDeclarationCodePath = strServerMapPath + "Content\\Temp\\DownLoad" + d.DeclarationCode + "\\";
                            strDeclarationPath = strServerMapPath + "Content\\Temp\\PrizeSummary\\" + d.PrizeName + "\\"
                                + d.DeclarationName.Trim()
                                    .Replace(':', '：').Replace('|', '｜').Replace('/', '╱').Replace('\\', '＼')
                                    .Replace('*', '＊').Replace('<', '《').Replace('>', '》').Replace('?', '？')
                                    .Replace('\"', '_').Replace('+', '＋').Replace('.', '·').Replace('\t', ' ')
                                + "\\";
                            if (!Directory.Exists(strDeclarationCodePath))
                            {
                                continue;
                            }

                            if (Directory.Exists(strDeclarationPath))
                            {
                                Directory.Delete(strDeclarationPath, true);
                            }

                            Directory.Move(strDeclarationCodePath, strDeclarationPath);

                            if (Directory.Exists(strDeclarationCodePath))
                            {
                                Directory.Delete(strDeclarationCodePath, true);
                            }

                            data = System.Text.Encoding.Default.GetBytes("成功：  " + d.DeclarationName + "\r\n");
                            fs.Write(data, 0, data.Length);
                        }
                        catch (Exception ex)
                        {
                            data = System.Text.Encoding.Default.GetBytes("失败：  " + d.DeclarationName + "   失败原因：" + ex.Message + "\r\n");
                            fs.Write(data, 0, data.Length);
                        }
                    }
                }
                catch
                {
                }
                finally
                {
                    data = System.Text.Encoding.Default.GetBytes("结束" + "\r\n");
                    fs.Write(data, 0, data.Length);

                    fs.Flush();
                    fs.Close();
                }
                
            }
        }
    }
}
