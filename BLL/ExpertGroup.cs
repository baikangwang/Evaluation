using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Linq;

namespace BLL
{
    public class ExpertGroup
    {
        public static List<Dal.Models.ExpertGroup> GetExpertGroup(OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from ExpertGroup";
            return Dal.OleDbHlper.GetList<Dal.Models.ExpertGroup>(strSql, conn, CommandType.Text, tran);
        }

        public static List<Dal.Models.ExpertGroup> GetExpertGroupBySpecialtyID(int iActiveID, int SpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from ExpertGroup";
            strSql += " where ActivityID = " + iActiveID;
            if (SpecialtyID != 0)
            {
                strSql += " and SpecialtyID = " + SpecialtyID;
            }
            return Dal.OleDbHlper.GetList<Dal.Models.ExpertGroup>(strSql, conn, CommandType.Text, tran);
        }
        
        //包括副组长
        public static Dal.Models.ExpertGroup GetExpertGroupAll(int iGroupID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "SELECT eg.*, e1.ExpertName as DeputyNames,e1.ExpertID as DeputyLeaderID,e2.ExpertName as LeaderName FROM ExpertGroup AS eg ";
            strSql += "left join Expert e1 on  e1.ExpertID = (SELECT ExpertID  FROM GroupMember AS gm WHERE GroupID = eg.GroupID AND Grade = 1202) ";
            strSql += "left join Expert e2 on e2.ExpertID = eg.GroupLeader ";
            strSql += "WHERE GroupID = ?";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = iGroupID });
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.ExpertGroup>(reader);
        }

        public static Dal.Models.ExpertGroup GetExpertGroup(int iGroupID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "SELECT * from V_Group where GroupID = ? ";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = iGroupID });
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.ExpertGroup>(reader);
        }

        public static Dal.Models.ExpertGroup GetParentExpertGroup(int iParentID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from ExpertGroup where ParentID = ? ";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@ParentID", OleDbType.Integer) { Value = iParentID });
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.ExpertGroup>(reader);
        }

        public static Dal.Models.ExpertGroup GetExpertGroup(string strGroupName, int iSpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from V_Group where SpecialtyID = ? and GroupName = ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                  , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID }
                  , new OleDbParameter("@GroupName", OleDbType.VarWChar) { Value = strGroupName });
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.ExpertGroup>(reader);
        }

        public static Dal.Models.ExpertGroup GetExpertGroup(int iLeaderID, int iSpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from V_Group where GroupLeader = ? and SpecialtyID = ? ";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@GroupLeader", OleDbType.Integer) { Value = iLeaderID }
                , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID });
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.ExpertGroup>(reader);
        }

        public static Dal.Models.ExpertGroup CreateExpertGroup(Dal.Models.ExpertGroup group, Dal.Models.UserInfo user, OleDbConnection conn, OleDbTransaction tran = null)
        {
            if (group == null || group.ActivityID == null || group.GroupLeader == null || string.IsNullOrEmpty(group.GroupName))
            {
                throw new Exception("参数错误!");
            }

            Dal.Models.ExpertGroup groupOrriginal = GetExpertGroup(group.GroupName, group.SpecialtyID.Value, conn, tran);
            if (groupOrriginal != null && groupOrriginal.GroupID != group.GroupID)
            {
                throw new Exception("同一专业下，专家组名称不能重复!");
            }

            List<Dal.Models.Expert> lstExpert = null;
            lstExpert = Expert.GetExpertList(conn, user, null, "0701", group.GroupLeader.ToString(), tran);
            if (lstExpert == null || lstExpert.Count == 0)
            {
                throw new Exception("专家组组长不在专家库中或者已被禁用！");
            }

            List<string> lstDeputy = null;
            if (!string.IsNullOrEmpty(group.DeputyIDs))
            {
                lstDeputy = group.DeputyIDs.Split(',').ToList();
                lstExpert = Expert.GetExpertList(conn, user, null, "0701", group.DeputyIDs, tran);
                if (lstExpert == null || lstExpert.Count != lstDeputy.Count)
                {
                    throw new Exception("专家组副组长名单中有不在专家库中或者已被禁用的专家！");
                }
            }

            List<string> lstMember = null;
            if (!string.IsNullOrEmpty(group.MemberIDs))
            {
                lstMember = group.MemberIDs.Split(',').ToList();
                lstExpert = Expert.GetExpertList(conn, user, null, "0701", group.MemberIDs, tran);
                if (lstExpert == null || lstExpert.Count != lstMember.Count)
                {
                    throw new Exception("专家组成员名单中有不在专家库中或者已被禁用的专家！");
                }
            }

            StringBuilder sbSql = new StringBuilder();
            if (group.GroupID != null)
            {
                // 更新专家组信息
                sbSql.Append(" UPDATE ExpertGroup");
                sbSql.Append("  SET ActivityID=? ");
                sbSql.Append(" ,GroupName=? ");
                sbSql.Append(" ,GroupLeader=? ");
                sbSql.Append(" ,SpecialtyID=?");
                sbSql.Append(" ,ParentID=?");
                sbSql.Append(" WHERE  GroupID=?;");
                Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                    , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = group.ActivityID }
                    , new OleDbParameter("@GroupName", OleDbType.VarWChar) { Value = group.GroupName }
                    , new OleDbParameter("@GroupLeader", OleDbType.Integer) { Value = group.GroupLeader }
                    , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = group.SpecialtyID }
                    , new OleDbParameter("@ParentID", OleDbType.Integer) { Value = group.ParentID }
                    , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = group.GroupID });

                // 清空专家组成员 如果参数没有传入专家组成员，则不删除专家组成员
                sbSql.Clear();
                if (string.IsNullOrEmpty(group.MemberIDs))
                {
                    sbSql.Append(" delete from GroupMember where GroupID = ? and Grade <> '1203' ");
                }
                else
                {
                    sbSql.Append(" delete from GroupMember where GroupID = ? ");
                }

                Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                    , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = group.GroupID });
            }
            else
            {
                sbSql.Append(" INSERT INTO ExpertGroup ( ");
                sbSql.Append(" ActivityID ");
                sbSql.Append(" ,GroupName ");
                sbSql.Append(" ,GroupLeader ");
                sbSql.Append(" ,ParentID ");
                sbSql.Append(" ,SpecialtyID");
                sbSql.Append(" ) VALUES (?, ?, ?, ?, ? ) ");

                Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                     , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = group.ActivityID }
                     , new OleDbParameter("@GroupName", OleDbType.VarWChar) { Value = group.GroupName }
                     , new OleDbParameter("@GroupLeader", OleDbType.Integer) { Value = group.GroupLeader }
                     , new OleDbParameter("@ParentID", OleDbType.Integer) { Value = group.ParentID }
                     , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = group.SpecialtyID });

                group = GetExpertGroup(group.GroupName, group.SpecialtyID.Value, conn, tran);
            }

            // 构建添加专家组成员的Sql文
            sbSql.Clear();
            sbSql.Append(" INSERT INTO GroupMember( ");
            sbSql.Append("   GroupID ");
            sbSql.Append(" , ExpertID ");
            sbSql.Append(" , Grade ");
            sbSql.Append(" , Ordinal ");
            sbSql.Append(" ) VALUES (?, ?, ?, ?) ");

            // 将专家组组长添加到专家组成员表中
            Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                  , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = group.GroupID }
                  , new OleDbParameter("@ExpertID", OleDbType.Integer) { Value = group.GroupLeader }
                  , new OleDbParameter("@Grade", OleDbType.VarWChar) { Value = "1201" }
                  , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = 1 });

            // 将专家组副组长添加到专家组成员表中
            int i = 0;
            if (lstDeputy != null)
            {
                for (i = 0; i < lstDeputy.Count; i++)
                {
                    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                        , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = group.GroupID }
                        , new OleDbParameter("@ExpertID", OleDbType.Integer) { Value = lstDeputy[i] }
                        , new OleDbParameter("@Grade", OleDbType.VarWChar) { Value = "1202" }
                        , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = i + 2 });
                }
            }

            // 将专家组成员添加到专家组成员表中
            if (lstMember != null)
            {
                for (i = 0; i < lstMember.Count; i++)
                {
                    Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, tran
                        , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = group.GroupID }
                        , new OleDbParameter("@ExpertID", OleDbType.Integer) { Value = lstMember[i] }
                        , new OleDbParameter("@Grade", OleDbType.VarWChar) { Value = "1203" }
                        , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = i + (lstDeputy == null ? 0 : lstDeputy.Count) + 2 });
                }
            }
            return group;
        }

        public static void AddMember(Dal.Models.GroupMember member, OleDbConnection conn, OleDbTransaction trans = null)
        {
            if (member == null
                || member.GroupID == null
                || member.ExpertID == null)
            {
                throw new Exception("参数错误!");
            }

            if (string.IsNullOrEmpty(member.Grade))
            {
                member.Grade = "1203";
            }

            if (string.IsNullOrEmpty(member.Duty))
            {
                member.Duty = "1302";
            }

            if (IsExpertInGroup(member.GroupID.Value, member.ExpertID.Value, conn, trans))
            {
                throw new Exception("专家已在本专家组!");
            }

            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" INSERT INTO GroupMember( ");
            sbSql.Append("   GroupID ");
            sbSql.Append(" , ExpertID ");
            sbSql.Append(" , Grade ");
            sbSql.Append(" , Duty ");
            sbSql.Append(" , Ordinal ");
            sbSql.Append(" ) VALUES (?, ?, ?, ?, ?) ");
            Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                  , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = member.GroupID }
                  , new OleDbParameter("@ExpertID", OleDbType.Integer) { Value = member.ExpertID }
                  , new OleDbParameter("@Grade", OleDbType.VarWChar) { Value = member.Grade }
                  , new OleDbParameter("@Duty", OleDbType.VarWChar) { Value = member.Duty }
                  , new OleDbParameter("@Ordinal", OleDbType.Integer) { Value = member.Ordinal });
        }

        public static int RemoveMember(int iGroupID, int iExpertID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " delete from GroupMember where GroupID = ? and ExpertID = ? ";
            int iResult = Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                  , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = iGroupID }
                  , new OleDbParameter("@ExpertID", OleDbType.Integer) { Value = iExpertID });

            return iResult;
        }

        public static int RemoveGroup(int iGroupID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            // 如果专家组已经分配了项目，不允许删除
            string strSql = " select count(*) from Declaration where ExpertReviewGroupID = ? ";
            int iCount = Convert.ToInt32(Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = iGroupID }));
            if (iCount > 0)
            {
                throw new Exception("专家组已经分配了项目，不允许删除！");
            }

            // 清除下级专家组
            strSql = " UPDATE ExpertGroup set ParentID = Null where ParentID = ? ";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                  , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = iGroupID });

            // 删除专家组成员
            strSql = " delete from GroupMember where GroupID = ?  ";
            Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                  , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = iGroupID });

            // 删除专家组
            strSql = " delete from ExpertGroup where GroupID = ? ";
            int iResult = Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                  , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = iGroupID });

            return iResult;
        }

        public static bool IsExpertInGroup(int iGroupID, int iExpertID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select Count(*) from GroupMember where GroupID = ? and ExpertID = ? ";
            int iResult = (int)Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = iGroupID }
                , new OleDbParameter("@ExpertID", OleDbType.Integer) { Value = iExpertID });

            return iResult > 0;
        }

        public static List<Dal.Models.GroupMember> GetGroupMemberList(int iGroupID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from V_GroupMember where GroupID = ? ";

            return Dal.OleDbHlper.GetList<Dal.Models.GroupMember>(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = iGroupID });
        }

        public static List<Dal.Models.ExpertGroup> GetChildGroupList(int iGroupID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from dbo.Fn_GetChildGroupByGroupID(?)";

            return Dal.OleDbHlper.GetList<Dal.Models.ExpertGroup>(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = iGroupID });
        }

        public static List<Dal.Models.ExpertGroup> GetGroupList(int iActivityID, string SpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" select * from V_Group where ActivityID = ? ");
            if (!string.IsNullOrEmpty(SpecialtyID))
            {
                sbSql.AppendFormat(" AND SpecialtyID in ({0})", SpecialtyID);
            }

            return Dal.OleDbHlper.GetList<Dal.Models.ExpertGroup>(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });
        }

        public static List<Dal.Models.ExpertGroup> GetExpertGroupList(int iActivityID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " SELECT  * FROM ExpertGroup where ActivityID = ? ";

            return Dal.OleDbHlper.GetList<Dal.Models.ExpertGroup>(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID });
        }

        public static Dal.Models.ExpertGroup GetExpertGroupParent(int iGroupID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            Dal.Models.ExpertGroup ExpertGroup = null;

            ExpertGroup =BLL.ExpertGroup.GetExpertGroup(iGroupID, conn, tran);
            if (ExpertGroup.ParentID.HasValue)
            {
                return GetExpertGroupParent(ExpertGroup.ParentID.Value, conn, tran);
            }
            string strSql = " SELECT  * FROM ExpertGroup where GroupID = ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                  , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = iGroupID });
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.ExpertGroup>(reader);
        }

        public static int UpdateExpertReviewGroupID(int iGroupID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " UPDATE ExpertGroup set ParentID = Null where ParentID = ? ";
            return Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                 , new OleDbParameter("@ExpertReviewGroupID", OleDbType.Integer) { Value = iGroupID });
        }

        public static List<Dal.Models.ExpertGroup> GetExpertGroupList(int iExpertID, int iActivityID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " SELECT g.* FROM ExpertGroup g inner join GroupMember m on m.GroupID = g.GroupID where g.ActivityID = ? and m.ExpertID = ? ";

            return Dal.OleDbHlper.GetList<Dal.Models.ExpertGroup>(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActivityID }
                , new OleDbParameter("@ExpertID", OleDbType.Integer) { Value = iExpertID });
        }

        public static int Count(int iActicityID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "select COUNT(*) from ExpertGroup where ActivityID = ? ";

            int? iResult = Common.ToInt32(Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, tran
               , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = iActicityID }));

            return iResult ?? 0;
        }

        /// <summary>
        /// 获取指定专家组的上级专家组
        /// </summary>
        /// <param name="iGroupID"></param>
        /// <param name="conn"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public static List<Dal.Models.ExpertGroup> GetParentList(int iGroupID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            List<Dal.Models.ExpertGroup> lstParent = new List<Dal.Models.ExpertGroup>();
            Dal.Models.ExpertGroup group = GetExpertGroup(iGroupID, conn, tran);
            lstParent.Add(group);
            if (group.ParentID != null)
            {
                lstParent.AddRange(GetParentList(group.ParentID.Value, conn, tran));
            }
            return lstParent;
        }

        public static List<Dal.Models.ExpertGroup> GetChildList(int iGroupID, OleDbConnection conn, OleDbTransaction tran = null)
        {

            Dal.Models.ExpertGroup group = GetExpertGroup(iGroupID, conn, tran);

            string strSql = " select * from ExpertGroup where ParentID = ? ";


            List<Dal.Models.ExpertGroup> lstChild = Dal.OleDbHlper.GetList<Dal.Models.ExpertGroup>(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@ParentID", OleDbType.Integer) { Value = iGroupID });

            lstChild.Insert(0, group);

            return lstChild.Distinct().ToList();
        }

        public static List<Dal.Models.ExpertGroup> GetExpertGroupByPrizeID(int iActiveID, int PrizeID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "select * from ExpertGroup";
            strSql += " where ActivityID = " + iActiveID;
            if (PrizeID >0 )
            {
                strSql += " and SpecialtyID = (select SpecialtyID from Prize where PrizeID=" + PrizeID +")";
            }
            return Dal.OleDbHlper.GetList<Dal.Models.ExpertGroup>(strSql, conn, CommandType.Text, tran);
        }

        public static int DeteleGroupLeader(int iGroupID,int iGroupLeader, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " UPDATE ExpertGroup set GroupLeader = Null where GroupID = ? and GroupLeader = ? ";
            return Dal.OleDbHlper.ExecuteNonQuery(strSql, conn, CommandType.Text, trans
                 , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = iGroupID }
                 , new OleDbParameter("@GroupLeader", OleDbType.Integer) { Value = iGroupLeader });
        }

        public static Dal.Models.ExpertGroup GetExpertGroupByLeader(int iGroupLeaderID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from ExpertGroup where GroupLeader = ? ";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@GroupLeader", OleDbType.Integer) { Value = iGroupLeaderID });
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.ExpertGroup>(reader);
        }

    }
}
