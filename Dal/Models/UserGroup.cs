using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    public class UserGroup : BaseEntity
    {
        public int GroupID { get; set; }
        public string  GroupName { get; set; }
    }
}
