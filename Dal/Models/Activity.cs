using System;
using System.Data;

namespace Dal.Models
{
    [Serializable]
    public class Activity : BaseEntity, IEquatable<Activity>
    {
        /// <summary>
        /// 评优活动编号
        /// </summary>
        public int? ActivityID { get; set; }

        /// <summary>
        /// 评优活动名称
        /// </summary>
        public string ActivityName { get; set; }

        /// <summary>
        /// 评优活动类别 常量类别：01
        /// </summary>
        public string ActivityTypeCode { get; set; }

        /// <summary>
        /// 评优活动类别名称
        /// </summary>
        public string ActivityTypeName { get; set; }

        /// <summary>
        /// 评优活动状态 常量类别：11
        /// </summary>
        public string ActivityStatus { get; set; }

        /// <summary>
        /// 评优活动状态名称
        /// </summary>
        public string ActivityStatusName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 最后一次修改时间
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        #region IEquatable<Activity> 成员

        public bool Equals(Activity other)
        {
            if (this.ActivityID == null || other.ActivityID == null)
            {
                return false;
            }
            else
            {
                return this.ActivityID == other.ActivityID;
            }
        }

        #endregion
    }
}
