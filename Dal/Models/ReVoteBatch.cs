using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    [Serializable]
    public class ReVoteBatch : BaseEntity
    {
        /// <summary>
        /// 等票复投_批次编号
        /// </summary>
        public int? ReVoteBatchID { get; set; }

        /// <summary>
        /// 需要等票复投的奖项
        /// </summary>
        public int? PrizeID { get; set; }

        /// <summary>
        /// 需要等票复投的奖项级别
        /// </summary>
        public string PrizeLevelCode { get; set; }

        /// <summary>
        /// 等票复投轮次
        /// </summary>
        public int? Round { get; set; }
    }
}
