using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;
using System.Linq;

namespace BLL
{
    public class Expert
    {
        public static Dal.Models.Expert GetExpert(int iExpertID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from V_Expert where ExpertID = ? ";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@ExpertID", OleDbType.Integer) { Value = iExpertID });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Expert>(reader);
        }

        public static Dal.Models.Expert GetExpert(string strExpertName, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from V_Expert where  ExpertName= ? ";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@ExpertName", OleDbType.VarWChar) { Value = strExpertName });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Expert>(reader);
        }

        public static Dal.Models.Expert GetExpertByUserID(int iUserID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from Expert where UserID = ? ";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID });
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Expert>(reader);
        }

        public static Dal.Models.Expert GetExpert(string strIDType, string strIDNumber,OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " select * from Expert where IDType = ? and IDNumber = ?";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@IDType", OleDbType.VarWChar) { Value = strIDType }
                , new OleDbParameter("@IDNumber", OleDbType.VarWChar) { Value = strIDNumber });
            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Expert>(reader);
        }

        /// <summary>
        /// 创建专家，先创建用户，然后创建专家
        /// </summary>
        /// <param name="expert"></param>
        /// <returns></returns>
        public static int CreateExpert(Dal.Models.Expert expert, string strDefaultPassword, int iCurrentUserID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            if (expert == null
                || string.IsNullOrEmpty(expert.ExpertName)
                || string.IsNullOrEmpty(expert.IDType)
                || string.IsNullOrEmpty(expert.IDNumber))
            {
                throw new Exception("参数错误！");
            }

            if (GetExpert(expert.ExpertName, conn, trans) != null)
            {
                throw new Exception("该(" + expert.ExpertName + ")专家姓名已存在！");
            }

            if (GetExpert(expert.IDType, expert.IDNumber, conn, trans) != null)
            {
                throw new Exception("该(" + expert.ExpertName + ")专家证件下的证件码已存在！");
            }

            // 如果证件类别是身份证，判断正确性和性别
            if (expert.IDType == "0901")
            {
                try
                {
                    expert.Gender = IDOperation.GetGenderFromID(expert.IDNumber);
                }
                catch (Exception ex)
                {
                    throw (new Exception("专家（" + expert.ExpertName + "）：" + ex.Message));
                }
            }

            Dal.Models.UserInfo user = new Dal.Models.UserInfo()
            {
                CreateUser = iCurrentUserID,
                CreateTime = DateTime.Now,
                UserName = expert.ExpertName,
                UserType = "0805",
                UserStatus = "0701",
                Email = expert.Email,
                Password = strDefaultPassword,
                IsPasswordChanged=false
            };
            user.LastUpdateTime = user.CreateTime;

            // 创建用户
            int iResult = User.CreateUser(user, conn, trans);
            if (iResult <= 0)
            {
                throw new Exception("创建用户失败！");
            }

            user.UserID = iResult;
            expert.UserID = iResult;

            if (expert.CreateTime == null || expert.LastUpdateTime == null)
            {
                expert.CreateTime = user.CreateTime;
                expert.LastUpdateTime = user.CreateTime;
            }

            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" INSERT INTO Expert ( ");
            sbSql.Append("         UserID ");
            sbSql.Append("        ,ExpertName ");
            sbSql.Append("        ,IDType ");
            sbSql.Append("        ,IDNumber ");
            sbSql.Append("        ,Gender ");
            sbSql.Append("        ,AcademicTitle ");
            sbSql.Append("        ,Profession ");
            sbSql.Append("        ,Workplace ");
            sbSql.Append("        ,CreateTime ");
            sbSql.Append("        ,LastUpdateTime         ");
            sbSql.Append(" ) VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ? ) ");
            iResult = Dal.OleDbHlper.ExecuteNonQuery(sbSql.ToString(), conn, CommandType.Text, trans
                , new OleDbParameter("@UserID", OleDbType.Integer) { Value = expert.UserID }
                , new OleDbParameter("@ExpertName", OleDbType.VarWChar) { Value = expert.ExpertName }
                , new OleDbParameter("@IDType", OleDbType.VarWChar) { Value = expert.IDType }
                , new OleDbParameter("@IDNumber", OleDbType.VarWChar) { Value = expert.IDNumber }
                , new OleDbParameter("@Gender", OleDbType.VarWChar) { Value = expert.Gender }
                , new OleDbParameter("@AcademicTitle", OleDbType.VarWChar) { Value = expert.AcademicTitle }
                , new OleDbParameter("@Profession", OleDbType.VarWChar) { Value = expert.Profession }
                , new OleDbParameter("@Workplace", OleDbType.VarWChar) { Value = expert.Workplace }
                , new OleDbParameter("@CreateTime", OleDbType.Date) { Value = expert.CreateTime }
                , new OleDbParameter("@LastUpdateTime", OleDbType.Date) { Value = expert.LastUpdateTime });

            if (iResult > 0)
            {
                expert = GetExpert(expert.IDType, expert.IDNumber, conn, trans);
                iResult = expert.ExpertID.Value;
            }
            else
            {
                throw new Exception("创建专家失败！");
            }

            return iResult;
        }

        /// <summary>
        /// 删除专家：删除专家用户的同时会删除专家，不允许单独删除专家或者专家对应的用户
        /// </summary>
        /// <param name="iExpertID"></param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public static int DeleteExpert(int iExpertID, int iActivityID, OleDbConnection conn, OleDbTransaction trans = null)
        {
            Dal.Models.Expert expert = GetExpert(iExpertID, conn, trans);
            return User.DeleteUser(expert.UserID.Value, iActivityID, conn, trans);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="conn"></param>
        /// <param name="user">CurrentUser</param>
        /// <param name="strWhere">ExpertName、IDNumber、Workplace</param>
        /// <param name="strStatus">UserStatus</param>
        /// <param name="ExpertIDs">ExpertIDs</param>
        /// <param name="tran"></param>
        /// <returns></returns>
        public static List<Dal.Models.Expert> GetExpertList(OleDbConnection conn, Dal.Models.UserInfo user = null, string strWhere = null, string strStatus = null, string ExpertIDs = null, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            List<OleDbParameter> lstPara = new List<OleDbParameter>();
            sbSql.Append(" select ve.* from V_Expert ve where 1=1 ");

            if (!string.IsNullOrEmpty(ExpertIDs))
            {
                sbSql.AppendFormat(" and ExpertID in ({0})", ExpertIDs);
            }

            if (!string.IsNullOrEmpty(strWhere))
            {
                sbSql.Append(" and (ExpertName like ? or IDNumber like ? or Workplace like ? )");
                lstPara.Add(new OleDbParameter("@ExpertName", OleDbType.VarWChar) { Value = "%" + strWhere + "%" });
                lstPara.Add(new OleDbParameter("@IDNumber", OleDbType.VarWChar) { Value = "%" + strWhere + "%" });
                lstPara.Add(new OleDbParameter("@Workplace", OleDbType.VarWChar) { Value = "%" + strWhere + "%" });
            }

            if (!string.IsNullOrEmpty(strStatus) && strStatus != "0")
            {
                sbSql.Append(" and ve.UserStatus in ("+strStatus+")");
            }

            if (user.UserType == "0805")
            {
                sbSql.AppendFormat(" and ve.UserID = {0}", user.UserID);
            }

            List<Dal.Models.Expert> lstExpert = Dal.OleDbHlper.GetList<Dal.Models.Expert>(sbSql.ToString(), conn, CommandType.Text, tran, lstPara.ToArray());

            if (user.UserType == "0804")
            {
                string strSpecialtyIDs = User.GetUserSpecialtyIDs(user.UserID.Value, conn, tran);
                if (!string.IsNullOrEmpty(strSpecialtyIDs))
                {
                    lstExpert = lstExpert.Where(e => e.SpecialtyIDs.Split(',').Intersect(strSpecialtyIDs.Split(',')).Count() > 0).ToList();
                }
                else
                {
                    lstExpert = new List<Dal.Models.Expert>();
                }
            }

            return lstExpert;
        }

        public static List<Dal.Models.Expert> GetPrepMember(int iExpertGroupID, int iSpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();

            sbSql.Append(" select e.* from V_Expert e  ");
            sbSql.Append(" left join GroupMember m on m.ExpertID = e.ExpertID and m.GroupID = ? ");
            sbSql.Append(" where e.UserStatus = '0701' and m.ExpertID is null ");
            sbSql.Append(" and CHARINDEX(CAST(? AS NVARCHAR(50)), e.SpecialtyIDs, 1) > 0 ");
            return Dal.OleDbHlper.GetList<Dal.Models.Expert>(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = iExpertGroupID }
                , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = iSpecialtyID });
        }

        /// <summary>
        /// 专家组添加成员时，获取专家组里以外的专家列表
        /// </summary>
        /// <param name="iActiveID"></param>
        /// <param name="tran"></param>
        /// <remarks></remarks>
        /// <returns></returns>
        public static List<Dal.Models.Expert> GetExpertListOutExpertGroupMember(int iExpertGroupID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();

            sbSql.Append(" select e.* from Expert e  ");
            sbSql.Append(" inner join Users u on u.UserID = e.UserID ");
            sbSql.Append(" left join GroupMember m on m.ExpertID = e.ExpertID and m.GroupID = ? ");
            sbSql.Append(" where u.UserStatus = '0701' and UserType = '0805' and m.ExpertID is null ");
            return Dal.OleDbHlper.GetList<Dal.Models.Expert>(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = iExpertGroupID });
        }

        //修改专家表和邮箱
        public static int UpdateExpert(Dal.Models.Expert expert, OleDbConnection conn, OleDbTransaction tran = null)
        {
            if (expert.IDType == "0901")
            {
                expert.Gender = IDOperation.GetGenderFromID(expert.IDNumber);
            }

            Dal.Models.Expert expFinded = GetExpert(expert.IDType,expert.IDNumber, conn, tran);
            if (expFinded != null && expFinded.UserID != expert.UserID)
            {
                throw new Exception("该用证件类别下的证件号码已存在!");
            }

            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" update Expert set ");
            sbSql.Append(" ExpertName = ? , ");
            sbSql.Append(" IDType = ? , ");
            sbSql.Append(" Workplace = ?, ");
            sbSql.Append(" AcademicTitle = ?, ");
            sbSql.Append(" Profession = ?, ");
            sbSql.Append(" IDNumber = ?, ");
            sbSql.Append(" Gender = ? ");
            sbSql.Append(" where ExpertID = ? ;");
            sbSql.Append(" update Users set Email = ? where UserID =?");

            int iResult = Dal.OleDbHlper.ExecuteNonQuery(
                sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@ExpertName", OleDbType.VarWChar) { Value = expert.ExpertName }
                , new OleDbParameter("@IDType", OleDbType.VarWChar) { Value = expert.IDType }
                , new OleDbParameter("@Workplace", OleDbType.VarWChar) { Value = expert.Workplace }
                , new OleDbParameter("@AcademicTitle", OleDbType.VarWChar) { Value = expert.AcademicTitle }
                , new OleDbParameter("@Profession", OleDbType.VarWChar) { Value = expert.Profession }
                , new OleDbParameter("@IDNumber", OleDbType.VarWChar) { Value = expert.IDNumber }
                , new OleDbParameter("@Gender", OleDbType.VarWChar) { Value = expert.Gender }
                , new OleDbParameter("@ExpertID", OleDbType.Integer) { Value = expert.ExpertID }
                , new OleDbParameter("@Email", OleDbType.VarWChar) { Value = expert.Email }
                , new OleDbParameter("@UserID", OleDbType.Integer) { Value = expert.UserID });

            Dal.Models.UserInfo user = User.GetUserInfo(expert.UserID.Value, conn, tran);
            if (user.UserName != expert.ExpertName)
            {
                user.UserName = expert.ExpertName;
                User.Update(user, conn, tran);
            }

            return iResult;
        }
    }
}
