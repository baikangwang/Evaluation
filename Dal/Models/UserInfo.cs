using System;
using System.ComponentModel;
using System.Data;

namespace Dal.Models
{
    public enum EnumGender
    {
        [Description("女")]
        Female = 0,

        [Description("男")]
        Male = 1
    }

    /// <summary>
    /// 用户信息
    /// </summary>
    [Serializable]
    public sealed class UserInfo : BaseEntity
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
        /// 用户类别文字
        /// </summary>
        public string UserTypeText { get; set; }

        /// <summary>
        /// 用户状态 07 01：已激活 02：已禁用
        /// </summary>
        public string UserStatus { get; set; }

        /// <summary>
        /// 用户状态文字
        /// </summary>
        public string UserStatusText { get; set; }

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
        /// 权限范围内的专业编号，半角逗号分隔
        /// </summary>
        public string SpecialtyIDs { get; set; }

        /// <summary>
        /// 权限范围内的专业名称，半角逗号分隔
        /// </summary>
        public string SpecialtyNames { get; set; }

        /// <summary>
        /// 是否修改密码
        /// </summary>
        public bool IsPasswordChanged { get; set; }

        /// <summary>
        /// 单位名称
        /// </summary>
        public string OrganizationName { get; set; } 

    }
}
