using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    [Serializable]
    public class Declaration_Data : BaseEntity
    {
        /// <summary>
        /// 数据编号
        /// </summary>
        public int? DataID { get; set; }

        /// <summary>
        /// 申报表编号
        /// </summary>
        public int? DeclarationID { get; set; }

        /// <summary>
        /// 字段编码
        /// </summary>
        public string RecordCode { get; set; }
        /// <summary>
        /// 申报表数据
        /// </summary>
        public string Data { get; set; }
        /// <summary>
        /// 是否公开
        /// </summary>
        public bool IsPublic { get; set; }
        
    }
}
