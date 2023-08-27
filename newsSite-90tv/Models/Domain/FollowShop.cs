using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPanel.Models.Domain
{
    public class FollowShop : BaseEntity<int>
    {


        [Display(Name = "کاربر دنبال کننده")]
        public string usertoken { get; set; }


        [Display(Name = "کاربر دنبال کننده")]
        public long userapp_id { get; set; }


        [Display(Name = "فروشگاه دنبال شده")]
        public long shop_id { get; set; }


        public bool isenable { get; set; }



        //nav 
        [ForeignKey("shop_id")]
        public virtual Shop shop { get; set; }

        [ForeignKey("userapp_id")]
        public virtual UserApp TblUserApp { get; set; }

    }
}
