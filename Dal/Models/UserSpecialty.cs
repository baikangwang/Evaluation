using System;
using System.ComponentModel;
using System.Data;

namespace Dal.Models
{
    /// <summary>
    /// 用户信息
    /// </summary>
    [Serializable]
    public sealed class UserSpecialty : BaseEntity
    {
        /// <summary>
        /// 用户专业编号
        /// </summary>
        public int? UserSpecialtyID { get; set; }

        /// <summary>
        /// 用户编号
        /// </summary>
        public int? UserID { get; set; }

        /// <summary>
        /// 专业编号
        /// </summary>
        public int? SpecialtyID { get; set; }

      
    }
}
