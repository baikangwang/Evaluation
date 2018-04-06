using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    [Serializable]
    public class Schedule : BaseEntity
    {
        /// <summary>
        /// 时间表编号
        /// </summary>
        public int? ScheduleID { get; set; }

        /// <summary>
        /// 活动编号
        /// </summary>
        public int? ActivityID { get; set; }

        /// <summary>
        /// 专业编号
        /// </summary>
        public int? SpecialtyID { get; set; }
        /// <summary>
        /// 申报开始日期
        /// </summary>
        public DateTime? DeclarationBeginDate { get; set; }

        /// <summary>
        /// 申报结束日期
        /// </summary>
        public DateTime? DeclarationEndDate { get; set; }

        /// <summary>
        /// 申报是否自动开始
        /// </summary>
        public bool? IsDeclarationAutoStart { get; set; }

        /// <summary>
        /// 申报是否自动结束
        /// </summary>
        public bool? IsDeclarationAutoEnd { get; set; }

        /// <summary>
        /// 申报是否开始
        /// </summary>
        public bool? IsDeclarationStart { get; set; }

        /// <summary>
        /// 海选开始日期
        /// </summary>
        public DateTime? PrimaryElectionBeginDate { get; set; }

        /// <summary>
        /// 海选结束日期
        /// </summary>
        public DateTime? PrimaryElectionEndDate { get; set; }

        /// <summary>
        /// 海选是否自动开始
        /// </summary>
        public bool? IsPrimaryElectionAutoStart { get; set; }

        /// <summary>
        /// 海选是否自动开始
        /// </summary>
        public bool? IsPrimaryElectionAutoEnd { get; set; }

        /// <summary>
        /// 是否开始海选
        /// </summary>
        public bool? IsPrimaryElectionStart { get; set; }

        /// <summary>
        /// 专家评审开始日期
        /// </summary>
        public DateTime? ExpertReviewBeginDate { get; set; }

        /// <summary>
        /// 专家评审结束日期
        /// </summary>
        public DateTime? ExpertReviewEndDate { get; set; }

        /// <summary>
        /// 是否自动开始专家评审
        /// </summary>
        public bool? IsExpertReviewAutoStart { get; set; }

        /// <summary>
        /// 是否自动开始专家评审
        /// </summary>
        public bool? IsExpertReviewAutoEnd { get; set; }

        /// <summary>
        /// 是否开始专家评审
        /// </summary>
        public bool? IsExpertReviewStart { get; set; }

        /// <summary>
        /// 是否开始复投
        /// </summary>



        /// 下载开始日期
        /// </summary>
        public DateTime? DownloadBeginDate { get; set; }

        /// <summary>
        /// 下载结束日期
        /// </summary>
        public DateTime? DownloadEndDate { get; set; }

        /// <summary>
        /// 是否自动开始下载
        /// </summary>
        public bool? IsDownloadAutoStart { get; set; }

        /// <summary>
        /// 是否自动开始下载
        /// </summary>
        public bool? IsDownloadAutoEnd { get; set; }

        /// <summary>
        /// 是否开始下载
        /// </summary>
        public bool? IsDownloadStart { get; set; }

        /// 下载开始日期
        /// </summary>
        public DateTime? VoteBeginDate { get; set; }

        /// <summary>
        /// 下载结束日期
        /// </summary>
        public DateTime? VoteEndDate { get; set; }

        /// <summary>
        /// 是否自动开始下载
        /// </summary>
        public bool? IsVoteAutoStart { get; set; }

        /// <summary>
        /// 是否自动开始下载
        /// </summary>
        public bool? IsVoteAutoEnd { get; set; }

        /// <summary>
        /// 是否开始下载
        /// </summary>
        public bool? IsVoteStart { get; set; }

        /// <summary>
        /// 是否开始复投
        /// </summary>

        public bool? IsReVoteStart { get; set; }
        /// <summary>
        /// 多伦投票轮次
        /// </summary>
        public int? MultipleVoteRound { get; set; }
    }
}
