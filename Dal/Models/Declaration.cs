using System;
using System.Data;

namespace Dal.Models
{
    /// <summary>
    /// 资格审查结果
    /// </summary>
    public enum QualificationReviewResult
    {
        Pass,
        Reject
    }

    [Serializable]
    public class Declaration : BaseEntity, IEquatable<Declaration>, IComparable<Declaration>
    {
        /// <summary>
        /// 申报表编号
        /// </summary>
        public int? DeclarationID { get; set; }

        /// <summary>
        /// 申报表编码
        /// </summary>
        public string DeclarationCode { get; set; }

        /// <summary>
        /// 项目报优名称
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 申报单位编号
        /// </summary>
        public int? OrganizationID { get; set; }

        /// <summary>
        /// 申报单位名称
        /// </summary>
        public string OrganizationName { get; set; }

        /// <summary>
        /// 申报单位法人代表人
        /// </summary>
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 申报单位法人代表人证件号
        /// </summary>
        public string LegalPersonIDNo { get; set; }

        /// <summary>
        /// 邮件地址
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 申报奖项
        /// </summary>
        public int? PrizeID { get; set; }

        /// <summary>
        /// 奖项名称
        /// </summary>
        public string PrizeName { get; set; }

        /// <summary>
        /// 奖项对应模版编号
        /// </summary>
        public string TemplateCode { get; set; }

        /// <summary>
        /// 参与者人数限制
        /// </summary>
        public int? ParticipantLimit { get; set; }

        /// <summary>
        /// 单位推荐序号
        /// </summary>
        public int? OrganizationOrdinal { get; set; }

        /// <summary>
        /// 协会推荐序号
        /// </summary>
        public int? AssociationOrdinal { get; set; }

        /// <summary>
        /// 申报表归属用户
        /// </summary>
        public int? UserID { get; set; }

        /// <summary>
        /// 申报表归属用户姓名
        /// </summary>
        public string Creator { get; set; }

        /// <summary>
        /// 项目申报时间
        /// </summary>
        public DateTime? DeclareDate { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 最后一次修改时间
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// 删除时间
        /// </summary>
        public DateTime? DeleteTime { get; set; }

        /// <summary>
        /// 申报表状态
        /// </summary>
        public string DeclarationStatus { get; set; }

        /// <summary>
        /// 申报表状态 对应文字
        /// </summary>
        public string DeclarationStatusText { get; set; }

        /// <summary>
        /// 申报表状态备份
        /// </summary>
        public string DeclarationStatusBackup { get; set; }

        /// <summary>
        /// 资格审查负责人
        /// </summary>
        public int? QualificationReviewer { get; set; }

        /// <summary>
        /// 资格审查负责人用户名
        /// </summary>
        public string QualificationReviewerName { get; set; }

        /// <summary>
        /// 资格复核情况
        /// </summary>
        public string QualificationReviewComment { get; set; }

        /// <summary>
        /// 资格审查时间
        /// </summary>
        public DateTime? QualificationReviewTime { get; set; }

        /// <summary>
        /// 专业评审组编号
        /// </summary>
        public int? ExpertReviewGroupID { get; set; }

        /// <summary>
        /// 专业评审组专家组名
        /// </summary>
        public string ExpertReviewGroupName { get; set; }

        /// <summary>
        /// 申报项目的意见填写人的专家ID
        /// </summary>
        public int ExpertReviewer { get; set; }

        /// <summary>
        /// 专业评审组专家组名
        /// </summary>
        public string ExpertReviewerName { get; set; }

        /// <summary>
        /// 申报项目的意见填写内容
        /// </summary>
        public string ExpertReviewComment { get; set; }

        /// <summary>
        /// 申报项目的意见填写时间
        /// </summary>
        public DateTime? ExpertReviewTime { get; set; }

        /// <summary>
        /// 推荐协会
        /// </summary>
        public string RecommendFrom { get; set; }

        /// <summary>
        /// 项目评价
        /// </summary>
        public string RejectComment { get; set; }

        /// <summary>
        /// 调整后奖项
        /// </summary>
        public int? AdjustedPrize { get; set; }

        /// <summary>
        /// Vote相关:投票代码
        /// </summary>
        public string VoteCode { get; set; }

        /// <summary>
        /// Vote相关:是否投票
        /// </summary>
        public string IsSubmit { get; set; }

        /// <summary>
        /// 奖项类别编码
        /// </summary>
        public string PrizeTypeCode { get; set; }

        /// <summary>
        /// 是否需要多次投票
        /// </summary>
        public bool? IsMultipleVoting { get; set; }

        /// <summary>
        /// 奖项类别
        /// </summary>
        public string PrizeType { get; set; }

        /// <summary>
        /// 综合奖投票类别编码
        /// </summary>
        public string VoteType { get; set; }

        /// <summary>
        /// 综合奖投票类别文字
        /// </summary>
        public string VoteTypeText { get; set; }

        /// <summary>
        /// 活动编号
        /// </summary>
        public int? ActivityID { get; set; }

        /// <summary>
        /// 专业编号
        /// </summary>
        public int? SpecialtyID { get; set; }

        /// <summary>
        /// 专业名称
        /// </summary>
        public string SpecialtyName { get; set; }

        /// <summary>
        /// 所属顶级专业编号
        /// </summary>
        public int? TopSpecialtyID { get; set; }

        /// <summary>
        /// 所属顶级专业名称
        /// </summary>
        public string TopSpecialtyName { get; set; }

        /// <summary>
        /// 申报是否开始
        /// </summary>
        public bool? IsDeclarationStart { get; set; }

        /// <summary>
        /// 是否允许下载
        /// </summary>
        public bool? IsDownloadStart { get; set; }

        /// <summary>
        /// 专业是否允许提交后修改
        /// </summary>
        public bool? IsAllowUpdate { get; set; }

        /// <summary>
        /// 专业是否允必填项未填
        /// </summary>
        public bool? IsAllowSubmit { get; set; }

        /// <summary>
        /// 申报项目的专业的总排序
        /// </summary>
        public int SpecialtyTotalOrdinal { get; set; }

        /// <summary>
        /// 申报项目的奖项的排序
        /// </summary>
        public int PrizeOrdinal { get; set; }

        /// <summary>
        /// 是否发送删除邮件
        /// </summary>
        public bool? IsSendDeletePost { get; set; }

        /// <summary>
        /// 是否发送驳回邮件
        /// </summary>
        public bool? IsSendUpdatePost { get; set; }

        /// <summary>
        /// 是否发送封存邮件
        /// </summary>
        public bool? IsSendReceivePost { get; set; }

        /// <summary>
        /// 建筑行业 大排序
        /// </summary>
        public int? BigOrdinal { get; set; }

        /// <summary>
        /// 建筑行业 分类编号
        /// </summary>
        public string TypeEx { get; set; }

        /// <summary>
        /// 获奖等级
        /// </summary>
        public string AwardCode { get; set; }

        /// <summary>
        /// 获奖等级 文字
        /// </summary>
        public string AwardCodeText { get; set; }

        #region IEquatable<Declaration> 成员

        public bool Equals(Declaration other)
        {
            return this.DeclarationCode == other.DeclarationCode;
        }

        #endregion

        #region IComparable<Declaration> 成员

        int IComparable<Declaration>.CompareTo(Declaration other)
        {
            if (this.AssociationOrdinal == null || this.OrganizationOrdinal == null || other.AssociationOrdinal == null || other.OrganizationOrdinal == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                return this.AssociationOrdinal.Value - other.AssociationOrdinal.Value;
            }
        }

        #endregion
    }

    /// <summary>
    /// 申报查询条件
    /// </summary>
    public class DeclarationSearchCondition
    {
        /// <summary>
        /// 活动编号
        /// </summary>
        public int? ActivityID { get; set; }

        /// <summary>
        /// 用户编号
        /// </summary>
        public int? UserID { get; set; }

        /// <summary>
        /// 用户类别编码
        /// </summary>
        public string UserType { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 单位编号，逗号分割
        /// </summary>
        public string OrganizationID { get; set; }

        /// <summary>
        /// 单位名称
        /// </summary>
        public string OrganizationName { get; set; }

        /// <summary>
        /// 专业编号，逗号分割
        /// </summary>
        public string SpecialtyID { get; set; }

        /// <summary>
        /// 专业名称，逗号分割
        /// </summary>
        public string SpecialtyName { get; set; }

        /// <summary>
        /// 奖项编号，逗号分割
        /// </summary>
        public string PrizeID { get; set; }

        /// <summary>
        /// 申报奖项，逗号分割
        /// </summary>
        public string PrizeName { get; set; }

        /// <summary>
        /// 奖项类别，逗号分割
        /// </summary>
        public string PrizeType { get; set; }

        /// <summary>
        /// 申报状态，逗号分割
        /// </summary>
        public string DeclarationStatus { get; set; }

        /// <summary>
        /// 申报项目名称
        /// </summary>
        public string DeclarationName { get; set; }

        /// <summary>
        /// 申报时间－开始
        /// </summary>
        public DateTime? DeclarationBeginDate { get; set; }

        /// <summary>
        /// 申报时间－结束
        /// </summary>
        public DateTime? DeclarationEndDate { get; set; }

        /// <summary>
        /// 修改时间－开始
        /// </summary>
        public DateTime? EditBeginDate { get; set; }

        /// <summary>
        /// 修改时间－结束
        /// </summary>
        public DateTime? EditEndDate { get; set; }
    }
}
