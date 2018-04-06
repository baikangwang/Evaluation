using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    /// <summary>
    /// 专家组成员
    /// </summary>
   public class GroupMember
    {
        public static Dal.Models.GroupMember GetGroupMember(int iGroupID, int iExpertID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from GroupMember  where GroupID = ? And ExpertID = ?";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@GroupID", OleDbType.Integer) { Value = iGroupID }
                 , new OleDbParameter("@ExpertID", OleDbType.Integer) { Value = iExpertID });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.GroupMember>(reader);
        }

        public static List<Dal.Models.GroupMember> GetExpertsByPrizeID(int ExpertGroupID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            List<Dal.Models.GroupMember> list = new List<Dal.Models.GroupMember>();
            if (ExpertGroupID > 0)
            {
                string strSql = "SELECT gm.ExpertID,eg.ExpertName FROM GroupMember gm";
                strSql += " left join Expert eg on eg.ExpertID = gm.ExpertID";
                strSql += " where GroupID = " + ExpertGroupID;
                list = Dal.OleDbHlper.GetList<Dal.Models.GroupMember>(strSql, conn, CommandType.Text, tran);
            }
            return list;
        }

        public static List<Dal.Models.Expert> GetExpertBySpecialty(int ActivityID, int SpecialtyID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = "SELECT e.*,sc.ConstantValue as IDTypeText,us.Email FROM  GroupMember gm";
            strSql += " left join Expert e on e.ExpertID = gm.ExpertID";
            strSql += " left join SysConstant sc on sc.ConstantCode = e.IDType";
            strSql += " left join Users us on us.UserID = e.UserID";
            strSql += " where gm.GroupID in (SELECT GroupID FROM  ExpertGroup eg where eg.ActivityID = ? and eg.SpecialtyID = ?)";

            return Dal.OleDbHlper.GetList<Dal.Models.Expert>(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@ActivityID", OleDbType.Integer) { Value = ActivityID }
                 , new OleDbParameter("@SpecialtyID", OleDbType.Integer) { Value = SpecialtyID });

        }
    }
}
