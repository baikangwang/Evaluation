using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    [Serializable]
    public class PrizeLevel : BaseEntity
    {
        public int? PrizeLevelID { get; set; }

        public int? PrizeID { get; set; }

        public string LevelCode { get; set; }

        public int? LevelLimitPercent { get; set; }

        public int? LevelLimitNumber { get; set; }
    }
}
