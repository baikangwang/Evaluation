using System;
using System.Data;

namespace Dal.Models
{
    [Serializable]
    public class Authority : BaseEntity
    {
        /// <summary>
        /// 角色权限编号
        /// </summary>
        public int? AuthorityID { get; set; }

        /// <summary>
        /// 角色编号
        /// </summary>
        public string UserType { get; set; }

        /// <summary>
        /// 菜单编号
        /// </summary>
        public string MenuCode { get; set; }
    }
}
