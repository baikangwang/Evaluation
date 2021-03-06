﻿using System;
using System.Collections.Generic;
using System.Data;

namespace Dal.Models
{
    [Serializable]
    public class Prize : BaseEntity
    {
        /// <summary>
        /// 奖项编号
        /// </summary>
        public int? PrizeID { get; set; }

        /// <summary>
        /// 奖项名称
        /// </summary>
        public string PrizeName { get; set; }

        /// <summary>
        /// 活动编号
        /// </summary>
        public int? ActivityID { get; set; }

        /// <summary>
        /// 专业编号
        /// </summary>
        public int? SpecialtyID { get; set; }

        /// <summary>
        /// 专业名
        /// </summary>
        public string SpecialtyName { get; set; }

        /// <summary>
        /// 奖项编码
        /// </summary>
        public string PrizeCode { get; set; }

        /// <summary>
        /// 奖项类别编码
        /// </summary>
        public string PrizeTypeCode { get; set; }

        /// <summary>
        /// 奖项类别
        /// </summary>
        public string PrizeType { get; set; }

        /// <summary>
        /// 一等奖数量
        /// </summary>
        public int? FirstPrize { get; set; }

        /// <summary>
        /// 二等奖数量
        /// </summary>
        public int? SecondPrize { get; set; }

        /// <summary>
        /// 三等奖数量
        /// </summary>
        public int? ThirdPrize { get; set; }

        /// <summary>
        /// 获奖项目数量
        /// </summary>
        public int? AwardCount { get; set; }


        /// <summary>
        /// 文档编码
        /// </summary>
        public string TemplateCode { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        public string TemplateName { get; set; }

        /// <summary>
        /// 是否需要多次投票
        /// </summary>
        public bool? IsMultipleVoting { get; set; }

        /// <summary>
        /// 参与者人数限制
        /// </summary>
        public int? ParticipantLimit { get; set; }

        /// <summary>
        /// 奖项说明
        /// </summary>
        public string PrizeDiscription { get; set; }

        /// <summary>
        /// 附件说明
        /// </summary>
        public string AppendixDiscription { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int? Ordinal { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 最后一次修改时间
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// 多轮投票轮次
        /// </summary>
        public int? MultipleVoteRound { get; set; }

        /// <summary>
        /// 等票复投轮次
        /// </summary>
        public int? RevoteRound { get; set; }

        /// <summary>
        /// 该奖项下被收件封存的申报数量
        /// </summary>
        public int? DeclarationCheckCount { get; set; }

        /// <summary>
        /// 该奖项下当前轮次待投票的申报数量
        /// </summary>
        public int? VoteDeclarationCount { get; set; }

        /// <summary>
        /// 当前已投票的专家数量
        /// </summary>
        public int? VotedExpertCount { get; set; }

        /// <summary>
        /// 综合奖投票类别编码
        /// </summary>
        public string VoteType { get; set; }

        /// <summary>
        /// 综合奖投票类别文字
        /// </summary>
        public string VoteTypeText { get; set; }

        /// <summary>
        /// 等票复投编码
        /// </summary>
        public string RevoteCode { get; set; }

        /// <summary>
        /// 是否暂停投票
        /// </summary>
        public bool IsStopVote { get; set; }
    }
}
