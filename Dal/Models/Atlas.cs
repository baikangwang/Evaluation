using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    /// <summary>
    /// 
    /// </summary>
    public enum AtlasType
    {
        Prize,
        Specialty
    }

    [Serializable]
    public class Atlas : BaseEntity
    {
        /// <summary>
        /// 图集编号
        /// </summary>
        public int? AtlasID { get; set; }

        /// <summary>
        /// 奖项编号
        /// </summary>
        public int? PrizeID { get; set; }

        /// <summary>
        /// 专业编号
        /// </summary>
        public int? SpecialtyID { get; set; }

        /// <summary>
        /// 图集序号
        /// </summary>
        public int? Ordinal { get; set; }

        /// <summary>
        /// 图集名称
        /// </summary>
        public string AtlasName { get; set; }

        /// <summary>
        /// 图集上传数量限制上限
        /// </summary>
        public int? UploadLimitMax { get; set; }
        /// <summary>
        /// 图集上传数量限制下限
        /// </summary>
        public int? UploadLimitMin { get; set; }

        /// <summary>
        /// 图片大小限制
        /// </summary>
        public int? SizeLimit { get; set; }

        /// <summary>
        /// 是否必需
        /// </summary>
        public bool? IsRequired { get; set; }
    }
}
