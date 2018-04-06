using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    [Serializable]
    public class Vote : BaseEntity
    {
        /// <summary>
        /// 投票ID
        /// </summary>
        public int? VoteID { get; set; }

        public int? UserID { get; set; }
        
        public int? DeclarationID { get; set; }

        /// <summary>
        /// 投票类型
        /// </summary>
        public string VoteType { get; set; }

        /// <summary>
        /// 投票轮次
        /// </summary>
        public int? VoteRound { get; set; }

        /// <summary>
        /// 投票项编码
        /// </summary>
        public string VoteCode { get; set; }

        /// <summary>
        /// 奖项编号
        /// </summary>
        public int? PrizeID { get; set; }

        /// <summary>
        /// 奖项等级编码
        /// </summary>
        public string PrizeLevelCode { get; set; }

        /// <summary>
        /// 专家ID
        /// </summary>
        public int? Votor { get; set; }

        /// <summary>
        /// 是否提交
        /// </summary>
        public bool? IsSubmit { get; set; }

        /// <summary>
        /// 多轮投票的轮次(综合奖)
        /// </summary>
        public int? MultipleVoteRound { get; set; }

        /// <summary>
        /// 等票复投轮次编码
        /// </summary>
        public string RevoteCode { get; set; }

        /// <summary>
        /// 等票复投轮次
        /// </summary>
        public int? RevoteRound { get; set; }

        public DateTime? VoteTime { get; set; }

        /// <summary>
        /// 投票数量
        /// </summary>
        public int? VoteNum { get; set; }

        /// <summary>
        /// 项目报优名称
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 奖项名称
        /// </summary>
        public string PrizeName { get; set; }

        /// <summary>
        /// 申报单位名称
        /// </summary>
        public string OrganizationName { get; set; }

        /// <summary>
        /// 奖项类别
        /// </summary>
        public string PrizeType { get; set; }

        /// <summary>
        /// 一等奖
        /// </summary>
        public bool? FirstPrize { get; set; }

        /// <summary>
        /// 二等奖
        /// </summary>
        public bool? SecondPrize { get; set; }

        /// <summary>
        /// 三等奖
        /// </summary>
        public bool? ThirdPrize { get; set; }

        /// <summary>
        /// 推荐
        /// </summary>
        public bool? Recommended { get; set; }

        /// <summary>
        /// 不推荐
        /// </summary>
        public bool? NotRecommended { get; set; }

        /// <summary>
        /// 缓评
        /// </summary>
        public bool? SlowRating { get; set; }

        /// <summary>
        /// 转出
        /// </summary>
        public bool? TurnOut { get; set; }

        /// <summary>
        /// 专家姓名
        /// </summary>
        public string ExpertName { get; set; }

        ///<summary>
        ///活动ID
        ///<summary>
        public int? ActivityID { get;set;}

        /// <summary>
        /// 序号
        /// </summary>
        public int? Ordinal { get; set; }

        /// <summary>
        /// 建筑大排序
        /// </summary>
        public int? BigOrdinal { get; set; }

        public string TypeEx { get; set; }

        /// <summary>
        /// 专家ID
        /// </summary>
        public int? ExpertID{ get; set; }

        /// <summary>
        /// 投票情况（是否已投票）
        /// </summary>
        public String VoteStatus{ get; set; }


        /// <summary>
        /// 是否提交（文字显示）
        /// </summary>
        public string IsSubmitText { get; set; }

    }
}
