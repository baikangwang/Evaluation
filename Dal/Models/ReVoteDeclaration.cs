using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    [Serializable]
    public class ReVoteDeclaration : BaseEntity
    {
        /// <summary>
        /// 等票复投_申报表编号
        /// </summary>
        public int? ReVoteDeclarationID { get; set; }

        /// <summary>
        /// 等票复投_批次编号
        /// </summary>
        public int? ReVoteBatchID { get; set; }

        /// <summary>
        /// 申报表编号
        /// </summary>
        public int? DeclarationID { get; set; }
    }
}
