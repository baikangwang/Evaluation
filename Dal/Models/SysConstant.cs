using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    [Serializable]
    public class SysConstant : BaseEntity
    {
        /// <summary>
        /// 常量值
        /// </summary>
        public string ConstantValue { get; set; }

        /// <summary>
        /// 常量关联值
        /// </summary>
        public string CorrelationValue { get; set; }

        /// <summary>
        /// 常量类别
        /// </summary>
        public string ConstantType { get; set; }

        /// <summary>
        /// 常量编码
        /// </summary>
        public string ConstantCode { get; set; }

        /// <summary>
        /// 常量说明
        /// </summary>
        public string ConstantDiscription { get; set; }
    }
}
