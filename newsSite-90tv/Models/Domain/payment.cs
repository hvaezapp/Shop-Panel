using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPanel.Models.Domain
{
    public class payment : BaseEntity<int>
    {


        [Display(Name = "پرداخت کننده")]
        public long appuser_id { get; set; }


        [Display(Name = "مبلغ پرداختی")]
        public long amount { get; set; }


        public long order_id { get; set; }



        [Display(Name = "وضیعت پرداخت")]
        public bool isSuccess { get; set; }



        [Display(Name = "توضیحات")]
        public string comment { get; set; }


        [Display(Name = "شماره رهگیری پرداخت")]
        public string refid { get; set; }


        public bool isenable { get; set; }


        // nav

        [ForeignKey("appuser_id")]
        public virtual UserApp Tbl_UserApp { get; set; }


    }
}
