using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// 复投结果
    /// </summary>
    public class RevoteResult : BaseEntity
    {
        /// <summary>
        /// 复投评优活动的编号
        /// </summary>
        public int RevotePrizeId { get; set; }
        /// <summary>
        /// 评审项目的编号
        /// </summary>
        public int DeclarationId { get; set; }
        /// <summary>
        /// 复投结果序号
        /// </summary>
        public int Index { get; set; }
        /// <summary>
        /// 获奖编号
        /// </summary>
        public int PrizeLevelId { get; set; }
        /// <summary>
        /// 复投推荐票数
        /// </summary>
        public int RevoteRecommended { get; set; }
        /// <summary>
        /// 复投不推荐票数
        /// </summary>
        public int RevoteNotRecommended { get; set; }
    }
}
