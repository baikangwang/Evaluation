using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// 一组复投组内的奖项配置
    /// </summary>
    public class RevotePrizeLevel : BaseEntity
    {
        /// <summary>
        /// 奖项编号
        /// </summary>
        public int PrizeLevelId { get; set; }
        /// <summary>
        /// 复投分组的编号
        /// </summary>
        public int RevoteGroupId { get; set; }
        /// <summary>
        /// 奖项配置的序号
        /// </summary>
        public int Index { get; set; }

        /// <summary>
        /// 奖项名额
        /// </summary>
        public int LevelLimitNumber { get; set; }

        public AwardView ToAwardView()
        {
            return new AwardView()
            {
                Number=this.LevelLimitNumber,
                AwardLabel = this.ToAwardLabel(),
                AwardCode = this.ToAwardCode()
            };
        }

        public string ToAwardCode()
        {
            switch (this.PrizeLevelId)
            {
                case 1:
                    return "0401";
                case 2:
                    return "0402";
                case 3:
                    return "0403";
                case 4:
                    return "0404";
            }
            return string.Empty;
        }

        public string ToAwardLabel()
        {
            switch (this.PrizeLevelId)
            {
                case 1:
                    return "一等奖";
                case 2:
                    return "二等奖";
                case 3:
                    return "三等奖";
                case 4:
                    return "推荐";
            }
            return string.Empty;
        }
    }

    public class AwardView
    {
        public string AwardLabel { get; set; }

        public int Number { get; set; }

        public string AwardCode { get; set; }
    }
}
