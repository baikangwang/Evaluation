using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    public enum EnumSituation
    {
        Declara,
        Declaration,
        ExpertReview,
        Delete,
        Auditing,
        ExpertElect,
        LeaguerElect
    }

    [Serializable]
    public class TemplateBase
    {
        public TemplateBase() { }

        public virtual void Load<T>(IDataReader reader) where T : Dal.Models.TemplateBase
        {
            if (reader == null)
            {
                return;
            }

            PropertyInfo[] pis = typeof(T).GetProperties();
            Dictionary<string,TemplateBase> dic = new Dictionary<string,TemplateBase>();
            foreach (PropertyInfo item in pis)
            {
                object obj = Activator.CreateInstance(item.PropertyType);
                item.SetValue(this, obj);
                dic.Add(item.PropertyType.Name, (TemplateBase)obj);
            }

            List<PropertyInfo> lstItem;
            List<PropertyInfo> lstSubItem;
            while (reader.Read())
            {
                if (reader["TemplateClass"].ToString() != typeof(T).Name)
                {
                    throw new Exception("参数错误");
                }

                lstItem = pis.Where(p => p.PropertyType.Name == reader["PartClass"].ToString()).ToList();
                if (lstItem.Count > 0)
                {
                    lstSubItem = lstItem[0].PropertyType.GetProperties()
                        .Where(p => p.Name == reader["RecordNameEn"].ToString()).ToList();
                    if (lstSubItem.Count > 0)
                    {
                        if (reader["Data"] == null || reader["Data"] == DBNull.Value)
                        {
                            lstSubItem[0].SetValue(dic[lstItem[0].PropertyType.Name], null);
                        }
                        else
                        {
                            lstSubItem[0].SetValue(dic[lstItem[0].PropertyType.Name], reader["Data"]);
                        }
                    }

                    lstSubItem = lstItem[0].PropertyType.GetProperties()
                        .Where(p => p.Name == "IsPublic" + reader["RecordNameEn"].ToString()).ToList();
                    if (lstSubItem.Count > 0)
                    {
                        if (reader["IsPublic"] == null || reader["IsPublic"] == DBNull.Value)
                        {
                            lstSubItem[0].SetValue(dic[lstItem[0].PropertyType.Name], null);
                        }
                        else
                        {
                            lstSubItem[0].SetValue(dic[lstItem[0].PropertyType.Name], reader["IsPublic"]);
                        }
                    }

                    lstSubItem = lstItem[0].PropertyType.GetProperties()
                        .Where(p => p.Name == "IsRequired" + reader["RecordNameEn"].ToString()).ToList();
                    if (lstSubItem.Count > 0)
                    {
                        if (reader["IsRequired"] == null || reader["IsRequired"] == DBNull.Value)
                        {
                            lstSubItem[0].SetValue(dic[lstItem[0].PropertyType.Name], null);
                        }
                        else
                        {
                            lstSubItem[0].SetValue(dic[lstItem[0].PropertyType.Name], reader["IsRequired"]);
                        }
                    }

                    lstSubItem = lstItem[0].PropertyType.GetProperties()
                        .Where(p => p.Name == "RecordType" + reader["RecordNameEn"].ToString()).ToList();
                    if (lstSubItem.Count > 0)
                    {
                        if (reader["RecordType"] == null || reader["RecordType"] == DBNull.Value)
                        {
                            lstSubItem[0].SetValue(dic[lstItem[0].PropertyType.Name], null);
                        }
                        else
                        {
                            lstSubItem[0].SetValue(dic[lstItem[0].PropertyType.Name], reader["RecordType"]);
                        }
                    }
                }
            }
            reader.Close();     
        }
        public static TemplateBase GetInstance(string strClassName)
        {
            switch (strClassName)
            {
                case "Dal.Models.Template_01_PublicBuilding":
                    return new Template_01_PublicBuilding();
                case "Dal.Models.Template_0101":
                    return new Template_0101();
                case "Dal.Models.Template_0102":
                    return new Template_0102();
                case "Dal.Models.Template_0103":
                    return new Template_0103();
                case "Dal.Models.Template_0104":
                    return new Template_0104();
                case "Dal.Models.Template_0105":
                    return new Template_0105();
                case "Dal.Models.Template_0106":
                    return new Template_0106();
                case "Dal.Models.Template_02_ResidentialBuilding":
                    return new Template_02_ResidentialBuilding();
                case "Dal.Models.Template_0201":
                    return new Template_0201();
                case "Dal.Models.Template_0202":
                    return new Template_0202();
                case "Dal.Models.Template_0203":
                    return new Template_0203();
                case "Dal.Models.Template_0204":
                    return new Template_0204();
                case "Dal.Models.Template_0205":
                    return new Template_0205();
                case "Dal.Models.Template_0206":
                    return new Template_0206();
                case "Dal.Models.Template_03_TraditionalBuilding":
                    return new Template_03_TraditionalBuilding();
                case "Dal.Models.Template_0301":
                    return new Template_0301();
                case "Dal.Models.Template_0302":
                    return new Template_0302();
                case "Dal.Models.Template_04_GreenBuilding":
                    return new Template_04_GreenBuilding();
                case "Dal.Models.Template_0401":
                    return new Template_0401();
                case "Dal.Models.Template_0402":
                    return new Template_0402();
                case "Dal.Models.Template_0403":
                    return new Template_0403();
                case "Dal.Models.Template_0404":
                    return new Template_0404();
                case "Dal.Models.Template_0405":
                    return new Template_0405();
                case "Dal.Models.Template_0406":
                    return new Template_0406();
                case "Dal.Models.Template_0407":
                    return new Template_0407();
                case "Dal.Models.Template_0408":
                    return new Template_0408();
                case "Dal.Models.Template_05_BIM":
                    return new Template_05_BIM();
                case "Dal.Models.Template_0501":
                    return new Template_0501();
                case "Dal.Models.Template_0502":
                    return new Template_0502();
                case "Dal.Models.Template_06_Architecture":
                    return new Template_06_Architecture();
                case "Dal.Models.Template_0601":
                    return new Template_0601();
                case "Dal.Models.Template_0602":
                    return new Template_0602();
                case "Dal.Models.Template_07_Electrical":
                    return new Template_07_Electrical();
                case "Dal.Models.Template_0701":
                    return new Template_0701();
                case "Dal.Models.Template_0702":
                    return new Template_0702();
                case "Dal.Models.Template_08_Equipment":
                    return new Template_08_Equipment();
                case "Dal.Models.Template_0801":
                    return new Template_0801();
                case "Dal.Models.Template_0802":
                    return new Template_0802();
                case "Dal.Models.Template_09_IntelligentBuilding":
                    return new Template_09_IntelligentBuilding();
                case "Dal.Models.Template_0901":
                    return new Template_0901();
                case "Dal.Models.Template_0902":
                    return new Template_0902();
                case "Dal.Models.Template_10_CivilAirDefence":
                    return new Template_10_CivilAirDefence();
                case "Dal.Models.Template_1001":
                    return new Template_1001();
                case "Dal.Models.Template_1002":
                    return new Template_1002();
                case "Dal.Models.Template_11_AntiSeismic":
                    return new Template_11_AntiSeismic();
                case "Dal.Models.Template_1101":
                    return new Template_1101();
                case "Dal.Models.Template_1102":
                    return new Template_1102();
                case "Dal.Models.Template_1103":
                    return new Template_1103();
                case "Dal.Models.Template_1104":
                    return new Template_1104();
                case "Dal.Models.Template_12_Municipal":
                    return new Template_12_Municipal();
                case "Dal.Models.Template_1201":
                    return new Template_1201();
                case "Dal.Models.Template_1202":
                    return new Template_1202();
                case "Dal.Models.Template_13_Landscape":
                    return new Template_13_Landscape();
                case "Dal.Models.Template_1301":
                    return new Template_1301();
                case "Dal.Models.Template_1302":
                    return new Template_1302();
                case "Dal.Models.Template_14_Survey":
                    return new Template_14_Survey();
                case "Dal.Models.Template_1401":
                    return new Template_1401();
                case "Dal.Models.Template_1402":
                    return new Template_1402();
                case "Dal.Models.Template_1403":
                    return new Template_1403();
                case "Dal.Models.Template_15_Industry":
                    return new Template_15_Industry();
                case "Dal.Models.Template_1501":
                    return new Template_1501();
                case "Dal.Models.Template_1502":
                    return new Template_1502();
                case "Dal.Models.Template_16_Software":
                    return new Template_16_Software();
                case "Dal.Models.Template_1601":
                    return new Template_1601();
                case "Dal.Models.Template_1602":
                    return new Template_1602();
                case "Dal.Models.Template_17_Standard":
                    return new Template_17_Standard();
                case "Dal.Models.Template_1701":
                    return new Template_1701();
                case "Dal.Models.Template_1702":
                    return new Template_1702();
                case "Dal.Models.Template_18_WaterSystem":
                    return new Template_18_WaterSystem();
                case "Dal.Models.Template_1801":
                    return new Template_1801();
                case "Dal.Models.Template_1802":
                    return new Template_1802();
                case "Dal.Models.Template_1803":
                    return new Template_1803();
                case "Dal.Models.Template_1804":
                    return new Template_1804();
                case "Dal.Models.Template_1805":
                    return new Template_1805();
                case "Dal.Models.Template_1806":
                    return new Template_1806();
                default:
                    return null;
            }
        }       
        public virtual void Load<T>(DataTable dtData) where T : Dal.Models.TemplateBase
        {
            if (dtData == null)
            {
                return;
            }

            PropertyInfo[] pis = typeof(T).GetProperties();
            Dictionary<string, TemplateBase> dic = new Dictionary<string, TemplateBase>();
            foreach (PropertyInfo item in pis)
            {
                object obj = Activator.CreateInstance(item.PropertyType);
                item.SetValue(this, obj);
                dic.Add(item.PropertyType.Name, (TemplateBase)obj);
            }

            List<PropertyInfo> lstItem;
            List<PropertyInfo> lstSubItem;
            int i = 0;
            foreach (DataRow row in dtData.Rows)
            {
                i = i + 1;
                if (row["TemplateClass"].ToString() != typeof(T).Name)
                {
                    return;
                    //throw new Exception("参数错误");
                }

                lstItem = pis.Where(p => p.PropertyType.Name == row["PartClass"].ToString()).ToList();
                if (lstItem.Count > 0)
                {
                    lstSubItem = lstItem[0].PropertyType.GetProperties()
                        .Where(p => p.Name == row["RecordNameEn"].ToString()).ToList();
                    if (lstSubItem.Count > 0)
                    {
                        if (row["Data"] == null || row["Data"] == DBNull.Value)
                        {
                            lstSubItem[0].SetValue(dic[lstItem[0].PropertyType.Name], null);
                        }
                        else
                        {
                            lstSubItem[0].SetValue(dic[lstItem[0].PropertyType.Name], row["Data"]);
                        }
                    }

                    lstSubItem = lstItem[0].PropertyType.GetProperties()
                        .Where(p => p.Name == "IsPublic" + row["RecordNameEn"].ToString()).ToList();
                    if (lstSubItem.Count > 0)
                    {
                        if (row["IsPublic"] == null || row["IsPublic"] == DBNull.Value)
                        {
                            lstSubItem[0].SetValue(dic[lstItem[0].PropertyType.Name], null);
                        }
                        else
                        {
                            lstSubItem[0].SetValue(dic[lstItem[0].PropertyType.Name], row["IsPublic"]);
                        }
                    }

                    lstSubItem = lstItem[0].PropertyType.GetProperties()
                        .Where(p => p.Name == "IsRequired" + row["RecordNameEn"].ToString()).ToList();
                    if (lstSubItem.Count > 0)
                    {
                        if (row["IsRequired"] == null || row["IsRequired"] == DBNull.Value)
                        {
                            lstSubItem[0].SetValue(dic[lstItem[0].PropertyType.Name], null);
                        }
                        else
                        {
                            lstSubItem[0].SetValue(dic[lstItem[0].PropertyType.Name], row["IsRequired"]);
                        }
                    }

                    lstSubItem = lstItem[0].PropertyType.GetProperties()
                        .Where(p => p.Name == "RecordType" + row["RecordNameEn"].ToString()).ToList();
                    if (lstSubItem.Count > 0)
                    {
                        if (row["RecordType"] == null || row["RecordType"] == DBNull.Value)
                        {
                            lstSubItem[0].SetValue(dic[lstItem[0].PropertyType.Name], null);
                        }
                        else
                        {
                            lstSubItem[0].SetValue(dic[lstItem[0].PropertyType.Name], row["RecordType"]);
                        }
                    }
                }
            }
        }
    }

    [Serializable]
    public class TemplateInfo : BaseEntity
    {
        /// <summary>
        /// 场合
        /// </summary>
        public EnumSituation Situation { get; set; }

        /// <summary>
        /// 模板编码
        /// </summary>
        public string TemplateCode { get; set; }

        /// <summary>
        /// 模板部件编码
        /// </summary>
        public string PartCode { get; set; }

        /// <summary>
        /// 模板类
        /// </summary>
        public string TemplateClass { get; set; }

        /// <summary>
        /// 模版部件类
        /// </summary>
        public string PartClass { get; set; }

        /// <summary>
        /// 模板
        /// </summary>
        public string TemplateUrl { get; set; }

        /// <summary>
        /// 新模板
        /// </summary>
        public string NewTemplateUrl { get; set; }

        /// <summary>
        /// 模版部件在模板中的位置
        /// </summary>
        public string Anchor { get; set; }

        /// <summary>
        /// 当前的申报编号
        /// </summary>
        public int? DeclarationID { get; set; }

        /// <summary>
        /// 当前的申报编码
        /// </summary>
        public string DeclarationCode{ get; set; }
    }
}
