using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// 复投分组
    /// </summary>
    public class RevoteGroup : BaseEntity
    {
        /// <summary>
        /// 复投分组编号
        /// </summary>
        public int RevoteGroupId { get; set; }

        /// <summary>
        /// 关联的复投评优活动编号
        /// </summary>
        public int RevotePrizeId { get; set; }

        /// <summary>
        /// 复投分组的序号
        /// </summary>
        public int Index { get; set; }
    }
}
