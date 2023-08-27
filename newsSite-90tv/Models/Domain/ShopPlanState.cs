using ShopPanel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Domain
{
    public class ShopPlanState : BaseEntity<int>
    {


        public long shop_id { get; set; }

        public int plan_id { get; set; }

        public DateTime startdateml { get; set; }
        public string startdatesh { get; set; }

        public DateTime expiredateml { get; set; }
        public string expiredatesh { get; set; }




        //nav


        [ForeignKey(nameof(plan_id))]
        public virtual Plan Tbl_Plan { get; set; }


        [ForeignKey(nameof(shop_id))]
        public virtual Shop Tbl_Shop { get; set; }


    }
}
