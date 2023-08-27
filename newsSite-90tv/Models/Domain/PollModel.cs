using ShopPanel.Models.Common;
using System.Collections.Generic;

namespace ShopPanel.Models.Domain
{
    public class Poll : BaseEntity<int>
    {

        public string Question { get; set; }
        public string PollStartDate { get; set; }
        public string PollEndDate { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<PollOption> pollOption { get; set; }
    }


    public class PollOption
    {
        public int PolloptionID { get; set; }
        public int PollID { get; set; }
        public string Answer { get; set; }
        public int VouteCount { get; set; }

        public virtual Poll poll { get; set; }
    }
}
