using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPanel.Models.Domain
{
    public class bannerImage : BaseEntity<int>
    {

        public long banner_id { get; set; }

        public string image { get; set; }

         // nav

        [ForeignKey("banner_id")]
        public virtual workerBanner Tbl_WorkerBanner { get; set; }
    }
}
