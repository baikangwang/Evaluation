using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace Dal.Models
{
    [Serializable]
    public class ExpertGroup : BaseEntity
    {
        /// <summary>
        /// 专家组编号
        /// </summary>
        public int? GroupID { get; set; }

        /// <summary>
        /// 活动编号
        /// </summary>
        public int? ActivityID { get; set; }

        /// <summary>
        /// 上级专家组
        /// </summary>
        public int? ParentID { get; set; }

        /// <summary>
        /// 上级专家组名
        /// </summary>
        public string ParentName { get; set; }

        /// <summary>
        /// 专家组组名
        /// </summary>
        public string GroupName { get; set; }

        /// <summary>
        /// 组长
        /// </summary>
        public int? GroupLeader { get; set; }

        /// <summary>
        /// 组长姓名
        /// </summary>
        public string LeaderName { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// 最后修改时间
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// 专业id
        /// </summary>
        public int? SpecialtyID { get; set; }

        /// <summary>
        /// 专业名称
        /// </summary>
        public string SpecialtyName { get; set; }

        /// <summary>
        /// 副组长编号，半角逗号分隔
        /// </summary>
        public string DeputyIDs { get; set; }

        /// <summary>
        /// 副组长姓名，半角逗号分隔
        /// </summary>
        public string DeputyNames { get; set; }

        /// <summary>
        /// 专家组成员编号，半角逗号分隔
        /// </summary>
        public string MemberIDs { get; set; }

        /// <summary>
        /// 专家组成员姓名，半角逗号分隔
        /// </summary>
        public string MemberNames { get; set; }
    }
}
