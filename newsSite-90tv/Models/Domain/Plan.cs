using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace ShopPanel.Models.Domain
{
    public class Plan : BaseEntity<int>
    {


        [Display(Name = "نام پلن (فارسی)")]
        public string namefa { get; set; }

        [Display(Name = "نام پلن (انگلیسی)")]
        public string nameen { get; set; }

        [Display(Name = "نوع پلن")]
        public byte plantype { get; set; } // year or mnth or ...

        [Display(Name = "مدت")]
        public byte count { get; set; }

        [Display(Name = "توضیحات پلن")]
        public string desc { get; set; }

        [Display(Name = "قیمت(ریال)")]
        public int price { get; set; }

        [Display(Name = "تخفیف% ")]
        public int offpercent { get; set; }


        [Display(Name = "استفاده پلن برای")]
        public byte type { get; set; } // shop plan or banner plan

        public bool isEnable { get; set; }




    }
}
