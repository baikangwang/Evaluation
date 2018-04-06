using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    public class AwardResult : BaseEntity
    {
        /// <summary>
        /// 奖项ID
        /// </summary>
        public int? PrizeID { get; set; }

        /// <summary>
        /// 奖项名称
        /// </summary>
        public string PrizeName { get; set; }

        /// <summary>
        /// 奖项等级
        /// </summary>
        public string PrizeLevelCode { get; set; }

        /// <summary>
        /// 投票方式
        /// </summary>
        public string VoteCode { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        public int? DeclarationID { get; set; }

        /// <summary>
        /// 申报单位
        /// </summary>
        public string OrganizationName { get; set; }

        /// <summary>
        /// 获奖结果
        /// </summary>
        public string AwardCode { get; set; }


        /// <summary>
        /// 投票结果 文字
        /// </summary>
        public string AwardCodeText
        {
            get
            {
                switch (AwardCode)
                {
                    case "2301": return "一等奖";
                    case "2302": return "二等奖";
                    case "2303": return "三等奖";
                    case "2304": return "推荐";
                    case "2305": return "不推荐";
                    case "2306": return "缓评";
                    case "2307": return "转出";
                    default: return "";
                }
            }
            set
            {
                switch (value)
                {
                    case "一等奖": AwardCode = "2301"; break;
                    case "二等奖": AwardCode = "2302"; break;
                    case "三等奖": AwardCode = "2303"; break;
                    case "推荐": AwardCode = "2304"; break;
                    case "不推荐": AwardCode = "2305"; break;
                    case "缓评": AwardCode = "2306"; break;
                    case "转出": AwardCode = "2307"; break;
                    default: AwardCode = ""; break;
                }
            }
        }


        /// <summary>
        /// 排序
        /// </summary>
        public int? Ordinal { get; set; }

        /// <summary>
        /// 索引
        /// </summary>
        public int? Idx { get; set; }

        /// <summary>
        /// 一等奖
        /// </summary>
        public int? FirstPrize { get; set; }

        /// <summary>
        /// 二等奖
        /// </summary>
        public int? SecondPrize { get; set; }

        /// <summary>
        /// 三等奖
        /// </summary>
        public int? ThirdPrize { get; set; }

        /// <summary>
        /// 推荐
        /// </summary>
        public int? Recommended { get; set; }

        /// <summary>
        /// 不推荐
        /// </summary>
        public int? NotRecommended { get; set; }

        /// <summary>
        /// 缓评
        /// </summary>
        public int? SlowRating { get; set; }

        /// <summary>
        /// 转出
        /// </summary>
        public int? TurnOut { get; set; }

        /// <summary>
        /// 投票轮次
        /// </summary>
        public int? MultipleVoteRound { get; set; }

        /// <summary>
        /// 投所选奖项的专家百分比（一等奖：投一等奖的专家百分比 二等奖：投一二等奖的专家百分比 三等奖：投一二三等奖的专家百分比）
        /// </summary>
        public decimal? ExpertPercent { get; set; }

        /// <summary>
        /// 同奖项内排序
        /// </summary>
        public int? InnerOrdinal { get; set; }

        /// <summary>
        /// 是否需要等票复投
        /// </summary>
        public bool? IsNeedRevote { get; set; }

        /// <summary>
        /// 等票复投级别 2301：一等奖等票复投 2302：二等奖等票复投 2303：三等奖等票复投 2304：推荐等票复投
        /// </summary>
        public string RevoteLevelCode { get; set; }
    }
}
