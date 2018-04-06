using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Text;

namespace BLL
{
    public class SysMenu
    {
        public static List<Dal.Models.SysMenu> GetMenu(int iUserID, OleDbConnection conn, OleDbTransaction tran = null)
        {
            StringBuilder sbSql = new StringBuilder();
            sbSql.Append(" select m.* from SysMenu m ");
            sbSql.Append(" inner join Authority a on a.MenuCode = m.MenuCode ");
            sbSql.Append(" inner join Users u on u.UserType = a.UserType ");
            sbSql.Append(" where u.UserID = ? order by MenuOrdinal ");

            return Dal.OleDbHlper.GetList<Dal.Models.SysMenu>(sbSql.ToString(), conn, CommandType.Text, tran
                , new OleDbParameter("@UserID", OleDbType.Integer) { Value = iUserID });
        }
    }
}
