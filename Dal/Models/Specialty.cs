using System;
using System.Data;

namespace Dal.Models
{
    [Serializable]
    public class Specialty : BaseEntity, IComparable<Specialty>, IEquatable<Specialty>
    {
        /// <summary>
        /// 专业编号
        /// </summary>
        public int? SpecialtyID { get; set; }

        /// <summary>
        /// 活动编号
        /// </summary>
        public int? ActivityID { get; set; }

        /// <summary>
        /// 专业编码
        /// </summary>
        public string SpecialtyCode { get; set; }

        /// <summary>
        /// 专业名
        /// </summary>
        public string SpecialtyName { get; set; }

        /// <summary>
        /// 专业图标
        /// </summary>
        public string SpecialtyIcon { get; set; }

        /// <summary>
        /// 模板编码
        /// </summary>
        public string TemplateCode { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int? Ordinal { get; set; }

        /// <summary>
        /// 是否共享获奖名额
        /// </summary>
        public bool? IsShareQuota { get; set; }

        /// <summary>
        /// 是否继承时间表
        /// </summary>
        public bool? IsInheritSchedule { get; set; }

        /// <summary>
        /// 是否继承模板
        /// </summary>
        public bool? IsInheritTemplet { get; set; }

        /// <summary>
        /// 父专业编号
        /// </summary>
        public int? ParentID { get; set; }

        /// <summary>
        /// 父专业名称
        /// </summary>
        public string ParentName { get; set; }
             

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get; set; }

        public int? TotalOrdinal { get; set; }

        /// <summary>
        /// 最后一次修改时间
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// 是否允许修改
        /// </summary>
        public bool? IsAllowUpdate { get; set; }
        /// <summary>
        /// 必填项未填是否允许提交
        /// </summary>
        public bool? IsAllowSubmit { get; set; }
        //收件封存时发送邮件
        public bool? IsSendReceivePost { get; set; }

        //驳回修改时发送邮件
        public bool? IsSendUpdatePost { get; set; }

        //管理员删除时发送邮件
        public bool? IsSendDeletePost { get; set; }


        public string SpecialtyLevel { get; set; }

        /// <summary>
        /// 下设子专业数
        /// </summary>
        public int? ChildCount { get; set; }

        /// <summary>
        /// 下设奖项数
        /// </summary>
        public int? PrizeCount { get; set; }

        /// <summary>
        /// 下设图集数
        /// </summary>
        public int? AtlasCount { get; set; }

        /// <summary>
        /// 下设附件数
        /// </summary>
        public int? AppendixCount { get; set; }

        /// <summary>
        /// 专业
        /// </summary>
        public int? DeclarationCount { get; set; }

        #region IComparable<Specialty> 成员

        public int CompareTo(Specialty other)
        {
            if (this.TotalOrdinal == null || other.TotalOrdinal == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                return this.TotalOrdinal.Value - other.TotalOrdinal.Value;
            }
        }

        #endregion

        #region IEquatable<Specialty> 成员

        public bool Equals(Specialty other)
        {
            if (this.ActivityID == null|| string.IsNullOrEmpty(this.SpecialtyCode)
                || other.ActivityID == null || string.IsNullOrEmpty(other.SpecialtyCode))
            {
                throw new NotImplementedException();
            }
            else
            {
                return this.ActivityID == other.ActivityID && this.SpecialtyCode == other.SpecialtyCode;
            }
        }

        #endregion
    }
}
