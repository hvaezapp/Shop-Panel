using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ShopPanel.Models.Domain
{
    public class ApplicationUsers : IdentityUser
    {
        [Display(Name = "نام")]
        public string FirstName { get; set; }


        [Display(Name = "نام خانوادگی")]
        public string LastName { get; set; }

        [Display(Name = "جنسیت")]
        public byte gender { get; set; }

        [Display(Name = "شماره همراه")]
        public override string PhoneNumber { get; set; }

        [Display(Name = "تصویر")]
        public string UserImagePath { get; set; }

        [Display(Name = "تاریخ تولد")]
        public string BirthDayDate { get; set; }

        public bool isEnable { get; set; }
    }
}
