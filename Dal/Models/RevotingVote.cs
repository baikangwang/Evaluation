using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// 一轮复投的投票
    /// </summary>
    public class RevotingVote : BaseEntity
    {
        /// <summary>
        ///  复投投票编号
        /// </summary>
        public int RevotingVoteId { get; set; }
        /// <summary>
        /// 关联的复投分组编号
        /// </summary>
        public int RevoteGroupId { get; set; }
        /// <summary>
        /// 项目申请的编号
        /// </summary>
        public int DeclarationId { get; set; }
        /// <summary>
        /// 推荐的票数
        /// </summary>
        public int RevoteRecommended { get; set; }
        /// <summary>
        /// 不推荐的票数
        /// </summary>
        public int RevoteNotRecommended { get; set; }
        /// <summary>
        /// 投票人编号
        /// </summary>
        public int UserId { get; set; }
        /// <summary>
        /// 是否提交
        /// </summary>
        public bool IsSubmit { get; set; }

    }
}
