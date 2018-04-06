using System;
using System.Data;
using System.Reflection;

namespace Dal.Models
{
    [Serializable]
    public class BaseEntity
    {
        public virtual void Load<T>(IDataReader reader) where T : Dal.Models.BaseEntity
        {
            if (reader == null)
            {
                return;
            }

            DataTable dt = reader.GetSchemaTable();
            PropertyInfo[] pis = typeof(T).GetProperties();
            foreach (PropertyInfo item in pis)
            {
                if (item.CanWrite)
                {
                    if (dt.Select("ColumnName='" + item.Name + "'").Length > 0)
                    {
                        if (reader[item.Name] == null || reader[item.Name] == DBNull.Value)
                        {
                            item.SetValue(this, null);
                        }
                        else
                        {
                            try
                            {
                                item.SetValue(this, reader[item.Name]);
                            }
                            catch
                            {
                                int iValue = 0;
                                if (int.TryParse(reader[item.Name].ToString(), out iValue))
                                {
                                    try
                                    {
                                        item.SetValue(this, iValue);
                                    }
                                    catch
                                    {
                                        item.SetValue(this, null);
                                    }
                                }
                            }
                        }
                    }
                }
            }            
        }

        public virtual void Load<T>(DataRow row) where T : Dal.Models.BaseEntity
        {
            DataTable dt = row.Table;
            PropertyInfo[] pis = typeof(T).GetProperties();

            foreach (PropertyInfo item in pis)
            {
                if (item.CanWrite)
                {
                    if (dt.Columns.Contains(item.Name))
                    {
                        if (row[item.Name] != null && row[item.Name] != DBNull.Value)
                        {
                            item.SetValue(this, row[item.Name]);
                        }
                    }
                }
            }
        }

        public static T GetEntity<T>(IDataReader reader) where T : Dal.Models.BaseEntity, new()
        {
            T t = null;
            if (reader != null)
            {
                if (reader.Read())
                {
                    t = new T();
                    t.Load<T>(reader);
                }
                reader.Close();
            }

            return t;
        }
    }
}
