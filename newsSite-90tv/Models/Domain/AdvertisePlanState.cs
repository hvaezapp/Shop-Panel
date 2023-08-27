using ShopPanel.Models.Common;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPanel.Models.Domain
{
    public class AdvertisePlanState : BaseEntity<int>
    {

        public long adv_id { get; set; }

        public int plan_id { get; set; }

        public DateTime startdateml { get; set; }
        public string startdatesh { get; set; }

        public DateTime expiredateml { get; set; }
        public string expiredatesh { get; set; }


        //nav


        [ForeignKey(nameof(plan_id))]
        public virtual Plan Tbl_Plan { get; set; }


        [ForeignKey(nameof(adv_id))]
        public virtual shopadvertise Tbl_Shopadv { get; set; }

    }
}
