

using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPanel.Models.Domain
{
    public class Checkout : BaseEntity<long>
    {


        [Display(Name = "فروشگاه مورد نظر")]
        public long shop_id { get; set; }

        [Display(Name = "فروشنده مورد نظر")]
        public long seller_id { get; set; }

        public long bank_id { get; set; }


        [Display(Name = "پرداخت شده")]
        public int checkoutprice { get; set; }



        //nav

        [ForeignKey(nameof(shop_id))]
        public virtual Shop Tbl_Shop { get; set; }


        [ForeignKey(nameof(seller_id))]
        public virtual Salsman Tbl_Salsman { get; set; }


        [ForeignKey(nameof(bank_id))]
        public virtual sellerBank Tbl_sellerBank { get; set; }

    }
}
