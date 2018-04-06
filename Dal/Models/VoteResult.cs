using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    [Serializable]
    public class VoteResult : BaseEntity
    {
        /// <summary>
        /// 项目ID
        /// </summary>
        public int? DeclarationID { get; set; }

        /// <summary>
        /// 项目名称
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 申报编码
        /// </summary>
        public string DeclarationCode { get; set; }

        /// <summary>
        /// 奖项编号
        /// </summary>
        public int? PrizeID { get; set; }

        /// <summary>
        /// 奖项名称
        /// </summary>
        public string PrizeName { get; set; }

        /// <summary>
        /// 申报单位
        /// </summary>
        public string OrganizationName { get; set; }

        /// <summary>
        /// 奖项类别
        /// </summary>
        public string PrizeType { get; set; }

        /// <summary>
        /// 投票方式
        /// </summary>
        public string VoteTypeText { get; set; }

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
        /// 投票后的排名
        /// </summary>
        public int? Ordinal { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int? Index { get; set; }

        /// <summary>
        /// 是否需要等票复投
        /// </summary>
        public bool? IsNeedRevote { get; set; }

        /// <summary>
        /// 专家投票比例
        /// </summary>
        public decimal? ExpertPercent{get;set;}
    }
}
