using System;
using System.Data;

namespace Dal.Models
{
    [Serializable]
    public class SysMenu : BaseEntity, IComparable<SysMenu>, IEquatable<SysMenu>
    {
        /// <summary>
        /// 菜单编号
        /// </summary>
        public string MenuCode { get; set; }

        /// <summary>
        /// 菜单项英文
        /// </summary>
        public string MenuNameEn { get; set; }

        /// <summary>
        /// 菜单项中文
        /// </summary>
        public string MenuNameCn { get; set; }

        /// <summary>
        /// 父节点菜单
        /// </summary>
        public string ParentMenuCode { get; set; }

        /// <summary>
        /// 菜单级别
        /// </summary>
        public int? MenuLevel { get; set; }

        /// <summary>
        /// 菜单显示顺序
        /// </summary>
        public int? MenuOrdinal { get; set; }

        /// <summary>
        /// 菜单项对应的页面URL
        /// </summary>
        public string PageUrl { get; set; }

        /// <summary>
        /// 菜单项图标
        /// </summary>
        public string MenuIcon { get; set; }

        /// <summary>
        /// 菜单项说明
        /// </summary>
        public string MenuDiscription { get; set; }


        #region IComparable<SysMenu> 成员

        public int CompareTo(SysMenu other)
        {
            return this.MenuOrdinal.Value - other.MenuOrdinal.Value;
        }

        #endregion

        #region IEquatable<SysMenu> 成员

        public bool Equals(SysMenu other)
        {
            return this.MenuCode == other.MenuCode;
        }

        #endregion
    }
}
