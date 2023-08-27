using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Common;

namespace ShopPanel.Models.Domain
{
    public class UserFake :  BaseEntity<long>
    {


        [Display(Name = "نام")]
        public string firstName { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        public string lastName { get; set; }

        [Display(Name = "شماره تماس")]
        public string phone { get; set; }

        [Display(Name = "تصویر کاربر")]
        public string image { get; set; }

        [Display(Name = "وضیعت فعال بودن")]
        public bool isEnable { get; set; }


        [Display(Name = "وضیعت فعال بودن")]
        public byte gender { get; set; }


        [Display(Name = "ایمیل")]
        public string email { get; set; }

    }
}
