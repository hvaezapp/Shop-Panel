using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Common;

namespace ShopPanel.Models.Domain
{
    public class Sellcheck : BaseEntity<int>
    {
      

        public long sell_id { get; set; }

        public string desc { get; set; }

        public bool isenable { get; set; }



        // nav

        [ForeignKey(nameof(sell_id))]
        public virtual Sell Tbl_Sell { get; set; }
    }
}
