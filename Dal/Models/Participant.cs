using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    [Serializable]
    public class Participant : BaseEntity
    {
        /// <summary>
        /// 参与者编号
        /// </summary>
        public int? ParticipantID { get; set; }

        /// <summary>
        /// 申报表编号
        /// </summary>
        public int? DeclarationID { get; set; }

        /// <summary>
        /// 参与者序号
        /// </summary>
        public int? Ordinal { get; set; }

        /// <summary>
        /// 参与者姓名
        /// </summary>
        public string ParticipantName { get; set; }

        /// <summary>
        /// 参与者职称
        /// </summary>
        public string AcademicTitle { get; set; }

        /// <summary>
        /// 参与者专业
        /// </summary>
        public string Speciality { get; set; }

        /// <summary>
        /// 参与者职责
        /// </summary>
        public string Duties { get; set; }

        /// <summary>
        /// 证件类别
        /// </summary>
        public string IDType { get; set; }

        /// <summary>
        /// 证件类别
        /// </summary>
        public string IDTypeName { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        public string IDNumber { get; set; }

        /// <summary>
        /// 工作单位
        /// </summary>
        public string Workplace { get; set; }

        /// <summary>
        /// 最后一次修改时间
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// 最后一次编辑者
        /// </summary>
        public int? LastUpdateUser { get; set; }
    }
}
