using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    public enum AppendixType
    {
        Prize,
        Specialty
    }
    [Serializable]
    public class Appendix : BaseEntity, IComparable<Appendix>, IEquatable<Appendix>
    {
        /// <summary>
        /// 附件集ID
        /// </summary>
        public int? AppendixID { get; set; }

        /// <summary>
        /// 专业ID
        /// </summary>
        public int? SpecialtyID { get; set; }

        /// <summary>
        /// 奖项ID
        /// </summary>
        public int? PrizeID { get; set; }

        /// <summary>
        /// 序号（排序用）
        /// </summary>
        public int? Ordinal { get; set; }

        /// <summary>
        /// 附件集名称
        /// </summary>
        public string AppendixName { get; set; }

        /// <summary>
        /// 上传数量最大限制
        /// </summary>
        public int? UploadLimitMax { get; set; }

        /// <summary>
        /// 上传数量最小限制
        /// </summary>
        public int? UploadLimitMin { get; set; }

        /// <summary>
        /// 数据大小限制
        /// </summary>
        public int? SizeLimit { get; set; }

        /// <summary>
        /// 是否必填
        /// </summary>
        public bool? IsRequired { get; set; }


        #region IComparable<Appendix> 成员

        int IComparable<Appendix>.CompareTo(Appendix other)
        {
            if (this.Ordinal == null || other.Ordinal == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                return this.Ordinal.Value - other.Ordinal.Value;
            }

            throw new NotImplementedException();
        }

        #endregion

        #region IEquatable<Appendix> 成员

        bool IEquatable<Appendix>.Equals(Appendix other)
        {
            if (this.AppendixID == null || other.AppendixID == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                return this.AppendixID == other.AppendixID && this.SpecialtyID == other.SpecialtyID;
            }
        }

        #endregion
    }
}
