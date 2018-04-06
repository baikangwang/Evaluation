using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
   public  class Control:BaseEntity
    {
       public int ControlID { get; set; }
       public int PageID { get; set; }
       public string ControlName { get; set; }
       public string ControlType { get; set; }
       public string PageName { get; set; }
       public string PageUrl { get; set; }
       public bool Details { get; set; }
    }
}
