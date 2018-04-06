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
    /// 专家评审
    /// </summary>
    public class Review
    {
        public static Dal.Models.Review GetReview(int iDeclarationID, string strGroupID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from Review  where DeclarationID = ? And GroupID = ?";

            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarationID }
                 , new OleDbParameter("@GroupID", OleDbType.VarWChar) { Value = strGroupID });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.Review>(reader);
        }

        //public static List<Dal.Models.Review> GetReviewList(int iDeclarationID, OleDbConnection conn, OleDbTransaction tran = null)
        //{
        //    string strSql = " select * from Review  where DeclarationID = ?";

        //    return Dal.OleDbHlper.GetList < Dal.Models.Review >(strSql, conn, CommandType.Text, tran
        //         , new OleDbParameter("@DeclarationID", OleDbType.Integer) { Value = iDeclarationID });
        //}
    }
}
