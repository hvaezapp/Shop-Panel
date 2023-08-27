using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPanel.Models.Domain
{
    public class CheckoutRequest : BaseEntity<long>
    {

        [Display(Name = "فروشگاه درخواست دهنده")]
        public long shop_id { get; set; }

        [Display(Name = "فروشنده درخواست دهنده")]
        public long seller_id { get; set; }


        public long bank_id { get; set; }


        [Display(Name = "درخواست برداشت")]
        public int requestprice { get; set; }




        //nav

        [ForeignKey(nameof(shop_id))]
        public virtual Shop Tbl_Shop { get; set; }


        [ForeignKey(nameof(seller_id))]
        public virtual Salsman Tbl_Salsman { get; set; }


        [ForeignKey(nameof(bank_id))]
        public virtual sellerBank Tbl_sellerbank { get; set; }

    }
}
