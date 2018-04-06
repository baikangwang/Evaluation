using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Reflection;

namespace Dal
{
    public static class DataTableExtensions
    {

        /// <summary>    
        /// DataTable 转换为List 集合    
        /// </summary>    
        /// <typeparam name="TResult">类型</typeparam>    
        /// <param name="dt">DataTable</param>    
        /// <returns></returns>    
        public static List<T> ToList<T>(this DataTable dt) where T : Dal.Models.BaseEntity, new()
        {
            //创建一个属性的列表    
            List<PropertyInfo> prlist = new List<PropertyInfo>();
            //获取TResult的类型实例  反射的入口

            Type t = typeof(T);

            //获得TResult 的所有的Public 属性 并找出TResult属性和DataTable的列名称相同的属性(PropertyInfo) 并加入到属性列表     
            Array.ForEach<PropertyInfo>(t.GetProperties(), p => { if (dt.Columns.IndexOf(p.Name) != -1) prlist.Add(p); });

            //创建返回的集合    

            List<T> oblist = new List<T>();

            foreach (DataRow row in dt.Rows)
            {
                //创建TResult的实例    
                T ob = new T();

                //找到对应的数据  并赋值    
                prlist.ForEach(p => { if (row[p.Name] != DBNull.Value) p.SetValue(ob, row[p.Name]); });

                //放入到返回的集合中.    
                oblist.Add(ob);
            }
            return oblist;
        }

        /// <summary>    
        /// 将集合类转换成DataTable    
        /// </summary>    
        /// <param name="list">集合</param>    
        /// <returns></returns>    
        public static DataTable ToDataTable(IList list)
        {
            DataTable result = new DataTable();

            if (list.Count > 0)
            {
                PropertyInfo[] propertys = list[0].GetType().GetProperties();

                foreach (PropertyInfo pi in propertys)
                {
                    result.Columns.Add(pi.Name);
                }

                for (int i = 0; i < list.Count; i++)
                {
                    ArrayList tempList = new ArrayList();
                    foreach (PropertyInfo pi in propertys)
                    {
                        object obj = pi.GetValue(list[i]);
                        tempList.Add(obj);
                    }
                    object[] array = tempList.ToArray();
                    result.LoadDataRow(array, true);
                }
            }
            return result;
        }
    }

    public static class OleDbHlper
    {
        public static string ConnectionString { get; set; }

        ///执行返回首行首列带参数的
        public static object ExecuteScalar(string sql, OleDbConnection conn, CommandType cmdType = CommandType.Text, OleDbTransaction tran = null, params OleDbParameter[] values)
        {
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.CommandType = cmdType;

            if (tran != null)
            {
                cmd.Transaction = tran;
            }

            if (values != null)
            {
                cmd.Parameters.AddRange(values);
            }

            object objResult = cmd.ExecuteScalar();

            cmd.Dispose();

            return objResult;
        }

        public static IDataReader ExecuteReader(string sql, OleDbConnection conn, CommandType cmdType = CommandType.Text, OleDbTransaction tran = null, params OleDbParameter[] values)
        {
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.CommandType = cmdType;

            if (tran != null)
            {
                cmd.Transaction = tran;
            }

            if (values != null && values.Length > 0)
            {
                cmd.Parameters.AddRange(values);
            }

           return cmd.ExecuteReader();
        }

        public static List<T> GetList<T>(string strSql, Dal.Models.PageInfo<T> pageInfo, OleDbConnection conn, OleDbTransaction tran = null)
            where T : Dal.Models.BaseEntity, new()
        {
            OleDbCommand cmd = new OleDbCommand("[dbo].[Proc_Pagination]", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            if (tran != null)
            {
                cmd.Transaction = tran;
            }

            cmd.Parameters.Add(new OleDbParameter("@Sql", OleDbType.VarChar) { Value = strSql, Direction = ParameterDirection.Input });
            cmd.Parameters.Add(new OleDbParameter("@PerPage", OleDbType.Integer) { Value = pageInfo.PerPage, Direction = ParameterDirection.Input });
            cmd.Parameters.Add(new OleDbParameter("@CuttentPage", OleDbType.Integer) { Value = pageInfo.CuttentPage, Direction = ParameterDirection.InputOutput });
            cmd.Parameters.Add(new OleDbParameter("@RecordNumber", OleDbType.Integer) { Direction = ParameterDirection.Output });
            cmd.Parameters.Add(new OleDbParameter("@PagesCount", OleDbType.Integer) { Direction = ParameterDirection.Output });

            IDataReader reader = cmd.ExecuteReader();

            List<T> lst = new List<T>();
            if (reader != null)
            {
                reader.Read();
                if (reader.NextResult())
                {

                    while (reader.Read())
                    {
                        T t = new T();
                        t.Load<T>(reader);
                        lst.Add(t);
                    }
                }
                reader.Close();

                pageInfo.CuttentPage = (int)cmd.Parameters["@CuttentPage"].Value;
                pageInfo.RecordNumber = (int)cmd.Parameters["@RecordNumber"].Value;
                pageInfo.PagesCount = (int)cmd.Parameters["@PagesCount"].Value;
            }

            return lst;
        }

        public static List<T> GetList<T>(string safeSql, OleDbConnection conn, CommandType cmdType = CommandType.Text, OleDbTransaction trans = null, params OleDbParameter[] values)
            where T : Dal.Models.BaseEntity, new()
        {
            List<T> lst = new List<T>();
            IDataReader reader = ExecuteReader(safeSql, conn, cmdType, trans, values);
            if (reader != null)
            {
                while (reader.Read())
                {
                    T t = new T();
                    t.Load<T>(reader);
                    lst.Add(t);
                }
                reader.Close();
            }

            return lst;
        }

        /// <summary>
        /// 这个主要就是为了集合对象多服务的
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string safeSql, OleDbConnection conn, CommandType cmdType = CommandType.Text, OleDbTransaction trans = null, params OleDbParameter[] values)
        {
            IDataReader reader = ExecuteReader(safeSql, conn, cmdType, trans, values);
            DataTable dt = new DataTable();

            if (reader != null)
            {
                dt.Load(reader);
                reader.Close();
            }

            return dt;
        }

        //这是通用的增删改的方法带参数的
        public static int ExecuteNonQuery(string sql, OleDbConnection conn, CommandType cmdType = CommandType.Text, OleDbTransaction tran = null, params OleDbParameter[] values)
        {
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            cmd.CommandType = cmdType;

            if (tran != null)
            {
                cmd.Transaction = tran;
            }

            if (values != null)
            {
                cmd.Parameters.AddRange(values);
            }

            return cmd.ExecuteNonQuery();
        }
    }

    static class SqlHlper
    {
        private static SqlConnection connection;

        public static string ConnectionString { get; set; }

        public static SqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection(ConnectionString);
                    connection.Open();
                }
                else if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                else if (connection.State == ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }

                return connection;
            }
        }

        ///执行返回首行首列带参数的
        public static object ExecuteScalar(string sql, CommandType cmdType = CommandType.Text, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.CommandType = cmdType;

            if (values != null)
            {
                cmd.Parameters.AddRange(values);
            }

            return cmd.ExecuteScalar();
        }

        public static IDataReader ExecuteReader(string sql, CommandType cmdType = CommandType.Text, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.CommandType = cmdType;

            if (values != null)
            {
                cmd.Parameters.AddRange(values);
            }

            return cmd.ExecuteReader();
        }

        /// <summary>
        /// 这个主要就是为了集合对象多服务的
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string safeSql, CommandType cmdType = CommandType.Text, params SqlParameter[] values)
        {
            IDataReader r = ExecuteReader(safeSql, cmdType, values);
            DataTable dt = new DataTable();

            if (r != null)
            {
                dt.Load(r);
                r.Close();
            }

            return dt;
        }

        //这是通用的增删改的方法带参数的
        public static int ExecuteNonQuery(string sql, CommandType cmdType = CommandType.Text, SqlTransaction tran = null, params SqlParameter[] values)
        {
            SqlCommand cmd = new SqlCommand(sql, Connection);
            cmd.CommandType = cmdType;

            if (tran != null)
            {
                cmd.Transaction = tran;
            }

            if (values != null)
            {
                cmd.Parameters.AddRange(values);
            }

            return cmd.ExecuteNonQuery();
        }
    }

    static class CommonDblHlper
    {
        private static DbConnection connection;

        public static string ConnectionString { get; set; }

        public static string ProviderName { get; set; }

        public static DbConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = DbProviderFactories.GetFactory(ProviderName).CreateConnection();
                    connection.ConnectionString = ConnectionString;
                    connection.Open();
                }
                else if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                else if (connection.State == ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }

                return connection;
            }
        }

        ///执行返回首行首列带参数的
        public static object ExecuteScalar(string sql, CommandType cmdType = CommandType.Text, params DbParameter[] values)
        {
            DbCommand cmd = Connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = cmdType;

            if (values != null)
            {
                cmd.Parameters.AddRange(values);
            }

            cmd.CommandType = cmdType;

            return cmd.ExecuteScalar();
        }

        public static IDataReader ExecuteReader(string sql, CommandType cmdType = CommandType.Text, params DbParameter[] values)
        {
            DbCommand cmd = Connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = cmdType;

            if (values != null)
            {
                cmd.Parameters.AddRange(values);
            }

            cmd.CommandType = cmdType;

            return cmd.ExecuteReader();
        }

        /// <summary>
        /// 这个主要就是为了集合对象多服务的
        /// </summary>
        /// <param name="safeSql"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string safeSql, CommandType cmdType = CommandType.Text, params DbParameter[] values)
        {
            IDataReader r = ExecuteReader(safeSql, cmdType, values);
            DataTable dt = new DataTable();

            if (r != null)
            {
                dt.Load(r);
                r.Close();
            }

            return dt;
        }

        //这是通用的增删改的方法带参数的
        public static int ExecuteNonQuery(string sql, CommandType cmdType = CommandType.Text, DbTransaction tran = null, params DbParameter[] values)
        {
            DbCommand cmd = Connection.CreateCommand();
            cmd.CommandText = sql;
            cmd.CommandType = cmdType;

            if (tran != null)
            {
                cmd.Transaction = tran;
            }

            if (values != null)
            {
                cmd.Parameters.AddRange(values);
            }

            return cmd.ExecuteNonQuery();
        }
    }
}
