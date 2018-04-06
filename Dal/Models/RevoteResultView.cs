using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    public class RevoteResultView:BaseEntity
    {
        private int _award;

        public string AwardLabel { get; set; }

        public string AwardCode { get; set; }

        public string DeclarationName { get; set; }

        public string OrganizationName { get; set; }

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
        public int PrizeLevelId {
            get { return _award; }
            set
            {
                _award = value;
                this.AwardCode = this.ToAwardCode();
                this.AwardLabel = this.ToAwardLabel();
            }
        }

        public int Award
        {
            get { return this.PrizeLevelId; }
            set { this.PrizeLevelId = value; }
        }

        public string AwardStatus
        {
            get { return this.AwardCode; }
            set { this.AwardCode = value; }
        }

        /// <summary>
        /// 复投推荐票数
        /// </summary>
        public int RevoteRecommended { get; set; }
        /// <summary>
        /// 复投不推荐票数
        /// </summary>
        public int RevoteNotRecommended { get; set; }

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
}
