using System;
using System.ComponentModel;
using System.Data;

namespace Dal.Models
{
    /// <summary>
    /// 用户信息
    /// </summary>
    [Serializable]
    public sealed class UserOrg : BaseEntity
    {
        /// <summary>
        /// 用户编号 初创建时为空
        /// </summary>
        public int? UserID { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 用户密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 用户类别 08
        /// </summary>
        public string UserType { get; set; }

        /// <summary>
        /// 用户状态 07 01：已激活 02：已禁用
        /// </summary>
        public string UserStatus { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// 创建者编号
        /// </summary>
        public int? CreateUser { get; set; }

        /// <summary>
        /// 最后一次登录时间
        /// </summary>
        public DateTime? LastLoginTime { get; set; }

        /// <summary>
        /// 最后一次修改时间
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

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
        /// 电话号码
        /// </summary>
        public string TelephoneNumber { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        public string MobileNumber { get; set; }

        /// <summary>
        /// 电子邮箱
        /// </summary>
        public string EmailAddress { get; set; }

        //单位名称
        public string OrganizationName { get; set; }

        /// <summary>
        /// 单位地址
        /// </summary>
        public string OrganizationAddress { get; set; }

        //用户状态对应值
        public string UserStatusText { get; set; }
    }
}
