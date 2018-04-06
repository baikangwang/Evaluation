using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    public enum MediaType
    {
        Prize,
        Specialty
    }

    [Serializable]
    public class Media : BaseEntity, IComparable<Media>, IEquatable<Media>
    {
        /// <summary>
        /// 视频ID
        /// </summary>
        public int? MediaID { get; set; }

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
        /// 视频名称
        /// </summary>
        public string MediaName { get; set; }

        /// <summary>
        /// 数据大小限制
        /// </summary>
        public int? SizeLimit { get; set; }

        /// <summary>
        /// 是否必需
        /// </summary>
        public bool? IsRequired { get; set; }

        #region IComparable<Media> 成员

        int IComparable<Media>.CompareTo(Media other)
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

        #region IEquatable<Media> 成员

        bool IEquatable<Media>.Equals(Media other)
        {
            if (this.MediaID == null || other.MediaID == null)
            {
                throw new NotImplementedException();
            }
            else
            {
                return this.MediaID == other.MediaID && this.SpecialtyID == other.SpecialtyID;
            }
        }

        #endregion
    }
}
