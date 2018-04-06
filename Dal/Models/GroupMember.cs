using System;
using System.Data;

namespace Dal.Models
{
    [Serializable]
    public class GroupMember : BaseEntity
    {
        /// <summary>
        /// 专家组成员表编号
        /// </summary>
        public int? MemberID { get; set; }

        /// <summary>
        /// 专家组编号
        /// </summary>
        public int? GroupID { get; set; }

        /// <summary>
        /// 专家编号
        /// </summary>
        public int? ExpertID { get; set; }

        /// <summary>
        /// 组内身份
        /// </summary>
        public string Grade { get; set; }

        /// <summary>
        /// 组内职责
        /// </summary>
        public string Duty { get; set; }

        /// <summary>
        /// 组内序号
        /// </summary>
        public int? Ordinal { get; set; }

        /// <summary>
        /// 专家姓名
        /// </summary>
        public string ExpertName { get; set; }

        //专家组
        public string GroupName { get; set; }

        //身份对应值
        public string GradeValue { get; set; }
    }
}
