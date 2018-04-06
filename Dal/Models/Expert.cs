using System;
using System.ComponentModel;
using System.Data;

namespace Dal.Models
{
    [Serializable]
    public class Expert : BaseEntity, IEquatable<Expert>
    {
        /// <summary>
        /// 专家编号
        /// </summary>
        public int? ExpertID { get; set; }

        /// <summary>
        /// 专家用户编号
        /// </summary>
        public int? UserID { get; set; }

        /// <summary>
        /// 专家姓名
        /// </summary>
        [Description("专家姓名")]
        public string ExpertName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [Description("性别")]
        public string Gender { get; set; }

        /// <summary>
        /// 证件类别
        /// </summary>
        [Description("证件类别")]
        public string IDType { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [Description("证件号")]
        public string IDNumber { get; set; }

        /// <summary>
        /// 职称
        /// </summary>
        [Description("职称")]
        public string AcademicTitle { get; set; }

        /// <summary>
        /// 专业
        /// </summary>
        [Description("专业")]
        public string Profession { get; set; }

        /// <summary>
        /// 工作单位
        /// </summary>
        [Description("工作单位")]
        public string Workplace { get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        [Description("电子邮箱")]
        public string Email { get; set; }

        /// <summary>
        /// 用户状态 文字
        /// </summary>
        [Description("用户状态文字")]
        public string UserStatusText { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 最后一次修改时间
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// 证件类别对应值
        /// </summary>
        public string IDTypeText { get; set; }

        /// <summary>
        /// 权限范围内的专业编号，半角逗号分隔
        /// </summary>
        public string SpecialtyIDs { get; set; }

        /// <summary>
        /// 权限范围内的专业名称，半角逗号分隔
        /// </summary>
        public string SpecialtyNames { get; set; }

        #region IEquatable<Expert> 成员

        public bool Equals(Expert other)
        {
            return this.IDType == other.IDType && this.IDNumber == other.IDNumber;
        }

        #endregion
    }
}
