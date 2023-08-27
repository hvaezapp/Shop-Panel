using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPanel.Models.Domain
{
    public class ErrorReportShop : BaseEntity<int>
    {
        [Display(Name = "فروشگاه")]
        public long shop_id { get; set; }


        [Display(Name = "کاربر درخواست دهنده")]
        public long appuser_id { get; set; }


        [Display(Name = "دلیل تخلف")]
        public int reason_id { get; set; }



        [Display(Name = "توضیحات")]
        public string message { get; set; }


        public bool isenable { get; set; }



        // nav

        [ForeignKey("shop_id")]
        public virtual Shop Tbl_Shop { get; set; }

        [ForeignKey("appuser_id")]
        public virtual UserApp Tbl_UserApp { get; set; }


        [ForeignKey("reason_id")]
        public virtual ReportReason Tbl_Reason { get; set; }
    }
}
