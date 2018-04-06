using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// 模版常量
    /// </summary>
    [Serializable]
    public class TemplateConstant : BaseEntity
    {
        /// <summary>
        /// 模版编号
        /// </summary>
        public string TemplateCode { get; set; }

        /// <summary>
        /// 关键字
        /// </summary>
        public string KeyWord { get; set; }

        /// <summary>
        /// 关联值
        /// </summary>
        public string KeyValue { get; set; }

        /// <summary>
        /// 说明
        /// </summary>
        public string Discription { get; set; }
    }
}