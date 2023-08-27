using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace ShopPanel.Models.Domain
{
    public class Appversion : BaseEntity<int>
    {



        [Display(Name = "شماره نسخه جاری")]
        public int versionCode { get; set; }     //1


        [Display(Name = "نام نسخه اپلیکیشن")]
        public string versionName { get; set; }   //1.0.0


        [Display(Name = " توضیحات نسخه اپلیکیشن")]
        public string desc { get; set; }


        [Display(Name = "لینک دانلود اپلیکیشن(ورژن جدید)")]
        [DataType(DataType.Url, ErrorMessage = "آدرس لینک دانلود نامعتبر است")]
        public string link { get; set; }

        public bool isEnable { get; set; }


    }
}
