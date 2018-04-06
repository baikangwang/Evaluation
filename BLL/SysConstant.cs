using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;

namespace BLL
{
    public class SysConstant
    {
        public static Dal.Models.SysConstant GetConstant(string strConstantCode, OleDbConnection conn = null, OleDbTransaction trans = null)
        {
            bool bNewConn = false;
            if (conn == null)
            {
                bNewConn = true;
                conn = new OleDbConnection(Dal.OleDbHlper.ConnectionString);
                conn.Open();
            }
            string strSql = " select * from SysConstant where ConstantCode = ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@ConstantCode", OleDbType.VarWChar) { Value = strConstantCode });
            Dal.Models.SysConstant cnst = Dal.Models.BaseEntity.GetEntity<Dal.Models.SysConstant>(reader);

            if (bNewConn)
            {
                conn.Close();
                conn.Dispose();
            }

            return cnst;
        }

        public static string GetAppSettings(string strAppSettingsName, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " select ConstantValue from SysConstant where ConstantType = '00' and CorrelationValue = ? ";

            object objResult = Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@CorrelationValue", OleDbType.VarWChar) { Value = strAppSettingsName });

            return objResult == System.DBNull.Value ? "" : objResult.ToString();
        }

        public static Dictionary<string, string> GetAppSettingDict(string strActivityType, OleDbConnection conn, OleDbTransaction trans = null)
        {
            List<Dal.Models.SysConstant> lstConstant = GetConstantList("00", conn, trans);
            lstConstant = lstConstant.Where(c => !c.CorrelationValue.Contains('_') || c.CorrelationValue.EndsWith("_" + strActivityType)).ToList();

            Dictionary<string, string> dicAppSettings = new Dictionary<string,string>();
            foreach (Dal.Models.SysConstant cnst in lstConstant)
            {
                dicAppSettings.Add(cnst.CorrelationValue, cnst.ConstantValue);
            }

            return dicAppSettings;
        }

        public static Dal.Models.SysConstant GetConstantCode(string strCorrelationValue, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " select * from SysConstant where CorrelationValue = ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@CorrelationValue", OleDbType.VarWChar) { Value = strCorrelationValue });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.SysConstant>(reader);
        }

        public static Dal.Models.SysConstant GetConstantCorrelationValue(string strConstantCode, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " select * from SysConstant where ConstantCode = ? ";
            IDataReader reader = Dal.OleDbHlper.ExecuteReader(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@ConstantCode", OleDbType.VarWChar) { Value = strConstantCode });

            return Dal.Models.BaseEntity.GetEntity<Dal.Models.SysConstant>(reader);
        }

        public static string GetTemplateConstant(string strTemplateCode, string strKeyWord, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " select KeyValue from TemplateConstant where TemplateCode = ? and KeyWord = ? ";
            object objResult = Dal.OleDbHlper.ExecuteScalar(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@TemplateCode", OleDbType.VarWChar) { Value = strTemplateCode }
                , new OleDbParameter("@KeyWord", OleDbType.VarWChar) { Value = strKeyWord });

            if (objResult == System.DBNull.Value || objResult == null)
            {
                return "";
            }
            else
            {
                return objResult.ToString();
            }
        }

        public static Dictionary<string, string> GetTemplateConstantDict(string strTemplateCode, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " select KeyWord, KeyValue from TemplateConstant where TemplateCode = ? ";
            List<Dal.Models.TemplateConstant> lstConstant =  Dal.OleDbHlper.GetList<Dal.Models.TemplateConstant>(strSql, conn, CommandType.Text, trans
                , new OleDbParameter("@TemplateCode", OleDbType.VarWChar) { Value = strTemplateCode });

            Dictionary<string, string> dictConstant = new Dictionary<string, string>();
            foreach (Dal.Models.TemplateConstant cnst in lstConstant)
            {
                dictConstant.Add(cnst.KeyWord, cnst.KeyValue);
            }

            return dictConstant;
        }

        public static List<Dal.Models.TemplateConstant> GetSysConstantListOfConstantDiscription(string strTemplateCode, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from TemplateConstant  where TemplateCode = ? and KeyWord in('CollaborativeStart','CollaborativeEnd')";

            return Dal.OleDbHlper.GetList<Dal.Models.TemplateConstant>(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@TemplateCode", OleDbType.VarWChar) { Value = strTemplateCode });
        }
        public static List<Dal.Models.SysConstant> GetSysConstantList(string strConstantType, OleDbConnection conn, OleDbTransaction tran = null)
        {
            string strSql = " select * from SysConstant  where ConstantType = ?";

            return Dal.OleDbHlper.GetList<Dal.Models.SysConstant>(strSql, conn, CommandType.Text, tran
                 , new OleDbParameter("@ConstantType", OleDbType.VarWChar) { Value = strConstantType });
        }
        public static List<Dal.Models.SysConstant> GetConstantList(string strConstantType, OleDbConnection conn, OleDbTransaction trans = null)
        {
            string strSql = " select ConstantCode, ConstantType, ConstantValue, ConstantDiscription, CorrelationValue from SysConstant ";
            if (string.IsNullOrEmpty(strConstantType))
            {
                strSql += " order by ConstantCode ";
                return Dal.OleDbHlper.GetList<Dal.Models.SysConstant>(strSql, conn, CommandType.Text, trans);
            }
            else
            {
                strSql += " where ConstantType = ? order by ConstantCode ";
                return Dal.OleDbHlper.GetList<Dal.Models.SysConstant>(strSql, conn, CommandType.Text, trans
                    , new OleDbParameter("@ConstantType", OleDbType.VarWChar) { Value = strConstantType });
            }
        }
    }
}
