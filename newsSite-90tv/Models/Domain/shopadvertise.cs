using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Common;

namespace ShopPanel.Models.Domain
{
    public class shopadvertise : BaseEntity<long>
    {
      

        [Display(Name = "تصویر تبلیغاتی")]
        public string image { get; set; }

        public long appuser_id { get; set; }

        [Display(Name = "فروشگاه مربوط")]
        public long shop_id { get; set; }

        public DateTime fromdateMiladi { get; set; }
        public DateTime todateMiladi { get; set; }


        [Display(Name = "شروع نمایش تبلیغ")]
        public string fromdateShamsi { get; set; }

        [Display(Name = "پایان نمایش تبلیغ")]
        public string todateShamsi { get; set; }
        public bool isenable { get; set; }
        public string users_id { get; set; }


        // nav

        [ForeignKey("shop_id")]
        public virtual Shop Shop { get; set; }

        [ForeignKey("users_id")]
        public virtual ApplicationUsers User { get; set; }

    }
}
