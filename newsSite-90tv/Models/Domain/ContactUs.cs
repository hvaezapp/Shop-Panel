using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPanel.Models.Domain
{
    public class ContactUs : BaseEntity<int>
    {


        [Display(Name = "کاربر")]
        public long appuser_id { get; set; }


        [Display(Name = "عنوان")]
        public string title { get; set; }


        [Display(Name = "توضیحات")]
        public string body { get; set; }

        public bool isenable { get; set; }



        // nav

        [ForeignKey("appuser_id")]

        public virtual UserApp Tbl_UserApp { get; set; }

    }
}
