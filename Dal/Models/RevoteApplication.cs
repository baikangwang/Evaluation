using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    public class RevoteApplication
    {
        /// <summary>
        /// 复投分组编号
        /// </summary>
        public int RevoteGroupId { get; set; }

        /// <summary>
        /// 复投分组关联的审评项目编号
        /// </summary>
        public int DeclarationId { get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        public int Index { get; set; }
    }
}
