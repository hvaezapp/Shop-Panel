using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPanel.Models.Domain
{
    public class UserApp : BaseEntity<long>
    {


        [Display(Name = "نام")]
        public string firstName { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        public string lastName { get; set; }

        [Display(Name = " شماره تماس ثابت")]
        public string phone { get; set; }

        [Display(Name = "شماره همراه")]
        public string mobile { get; set; }


        [Display(Name = "تصویر کاربر")]
        public string image { get; set; }





        [Display(Name = "جنسیت")]
        public byte gender { get; set; }


        [Display(Name = "ایمیل")]
        public string email { get; set; }


        public string mobileActiveCode { get; set; }


        [Display(Name = "وضیعت فعال سازی شماره همراه")]
        public bool mobileActiveStatus { get; set; }


        [Display(Name = "کد ملی")]
        public string nationalcode { get; set; }



        [Display(Name = "تاریخ تولد")]
        public string birthdate { get; set; }


        public bool isEnable { get; set; }

        [Display(Name = "ماهیت کاربر")]
        public byte type { get; set; }


        public string token { get; set; }





        //nav
        public string User_id { get; set; }

        [ForeignKey("User_id")]
        public virtual ApplicationUsers user { get; set; }



    }
}
