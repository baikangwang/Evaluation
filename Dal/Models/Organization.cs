using System;
using System.Data;

namespace Dal.Models
{
    [Serializable]
    public class Organization : BaseEntity, IEquatable<Organization>
    {
        /// <summary>
        /// 单位编号
        /// </summary>
        public int? OrganizationID { get; set; }

        /// <summary>
        /// 一级用户编号
        /// </summary>
        public int? UserID { get; set; }

        /// <summary>
        /// 单位名称
        /// </summary>
        public string OrganizationName { get; set; }

        /// <summary>
        /// 单位简称
        /// </summary>
        public string Abbreviation { get; set; }

        /// <summary>
        /// 统一社会信用代码
        /// </summary>
        public string UnifiedCode { get; set; }

        /// <summary>
        /// 组织机构代码
        /// </summary>
        public string OrganizationCode { get; set; }

        /// <summary>
        /// 单位地址
        /// </summary>
        public string OrganizationAddress { get; set; }

        /// <summary>
        /// 法人姓名
        /// </summary>
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 法人身份证号
        /// </summary>
        public string LegalPersonIDNo { get; set; }

        /// <summary>
        /// 联系人
        /// </summary>
        public string Linkman { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 电话号码
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 邮政编码
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// 传真号
        /// </summary>
        public string FaxNumber { get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string EmailAddress { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 最后一次修改时间
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        #region IEquatable<Organization> 成员

        public bool Equals(Organization other)
        {
            return this.OrganizationName == other.OrganizationName || this.OrganizationCode == other.OrganizationCode || this.UnifiedCode == other.UnifiedCode;
        }

        #endregion
    }
}
