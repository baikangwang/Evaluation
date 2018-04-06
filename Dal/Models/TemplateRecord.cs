using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// 申报表_模板字段
    /// </summary>
    /// <remarks>记述各模板的数据项</remarks>
    [Serializable]
    public class TemplateRecord : BaseEntity
    {
        /// <summary>
        /// 模版编号
        /// </summary>
        public string TemplateCode { get; set; }

        /// <summary>
        /// 模板内容编码
        /// </summary>
        public string PartCode { get; set; }

        /// <summary>
        /// 字段编码
        /// </summary>
        public string RecordCode { get; set; }

        /// <summary>
        /// 字段英文名
        /// </summary>
        public string RecordNameEn { get; set; }

        /// <summary>
        /// 字段中文名
        /// </summary>
        public string RecordNameCn { get; set; }

        /// <summary>
        /// 字段类型
        /// </summary>
        public string RecordType { get; set; }

        /// <summary>
        /// 字段长度
        /// </summary>
        public int? RecordLen { get; set; }

        /// <summary>
        /// 是否必填项
        /// </summary>
        public bool? IsRequired { get; set; }
    }
}
