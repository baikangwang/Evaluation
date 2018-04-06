using System;
using System.Data;

namespace Dal.Models
{
    /// <summary>
    /// 通知公告
    /// </summary>
    [Serializable]
    public class Notice : BaseEntity
    {
        /// <summary>
        /// 公告编号
        /// </summary>
        public int? NoticeID { get; set; }

        /// <summary>
        /// 活动编号
        /// </summary>
        public int? ActivityID { get; set; }

        /// <summary>
        /// 公告标题
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 公告内容
        /// </summary>
        public string NoticeContent { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        public DateTime? EffectTime { get; set; }

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
        public DateTime? LastEditTime { get; set; }

        /// <summary>
        /// 最后一次修改时间
        /// </summary>
        public string LastEditTimeText
        {
            get
            {
                return LastEditTime == null ? "" : LastEditTime.Value.ToString("yyyy-MM-dd");
            }
        }

        //点击次数
        public int? Clicks { get; set; }
        /// <summary>
        /// 公告附件名称
        /// </summary>
        public string NoticeFileName { get; set; }
    }
}
