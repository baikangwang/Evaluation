using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Models
{
    public class RevotingVoteView:BaseEntity
    {
        public int RevoteGroupId { get; set; }

        public int DeclarationId { get; set; }

        public string DeclarationName { get; set; }

        public string OrganizationName { get; set; }

        public int? RevotingVoteId { get; set; }

        public int? RevoteRecommended { get; set; }

        public int? RevoteNotRecommended { get; set; }

        public bool? IsSubmit { get; set; }
    }
}
