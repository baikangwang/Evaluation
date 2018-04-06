using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    [Serializable]
    public class PageInfo<T> where T : BaseEntity
    {
        /// <summary>
        /// 当前页，从1开始
        /// </summary>
        public int? CuttentPage { get; set; }

        /// <summary>
        /// 每页显示记录条数
        /// </summary>
        public int? PerPage { get; set; }

        /// <summary>
        /// 总记录条数
        /// </summary>
        public int? RecordNumber { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        public int? PagesCount { get; set; }

        /// <summary>
        /// 操作是否成功
        /// </summary>
        public bool IsSeuuess { get; set; }

        /// <summary>
        /// 读取到的数据列表
        /// </summary>
        public List<T> List { get; set; }

        /// <summary>
        /// 读取到的数据
        /// </summary>
        public DataTable Table { get; set; }
    }
}
