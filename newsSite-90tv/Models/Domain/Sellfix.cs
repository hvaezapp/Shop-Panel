using ShopPanel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Domain
{
    public class Sellfix : BaseEntity<int>
    {

        [Display(Name = "فروش مربوط")]
        public int sell_id { get; set; }


         // nav

        [ForeignKey(nameof(sell_id))]
        public virtual Sell Tbl_Sell { get; set; }


    }
}
