using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPanel.Models.Domain
{
    public class Buycheck : BaseEntity<int>
    {



        [Display(Name = "خرید")]
        public long buy_id { get; set; }


        [Display(Name = "توضیحات")]
        public string desc { get; set; }

        public bool isenable { get; set; }


        // nav

        [ForeignKey(nameof(buy_id))]
        public virtual Buy Tbl_Buy { get; set; }
    }
}
