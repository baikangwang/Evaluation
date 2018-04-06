using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    [Serializable]
    public class Review : BaseEntity
    {
        /// <summary>
        /// 评审编号
        /// </summary>
        public int? ReviewID { get; set; }

        /// <summary>
        /// 申报编号
        /// </summary>
        public int? DeclarationID { get; set; }

        /// <summary>
        /// 专家组编号
        /// </summary>
        public string GroupID { get; set; }
        /// <summary>
        /// 评审内容
        /// </summary>
        public string Comment { get; set; }

        /// <summary>
        /// 评审时间
        /// </summary>
        public DateTime? ReviewTime { get; set; }
    }
}
