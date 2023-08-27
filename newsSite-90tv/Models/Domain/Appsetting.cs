using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPanel.Models.Domain
{
    public class Appsetting : BaseEntity<int>
    {


        // admin bank account


        [Display(Name = "مالک حساب")]
        public string ownername { get; set; }


        [Display(Name = " شماره شبا بانکی")]
        public string shabacode { get; set; }

        //.......  

        [Display(Name = "درباره ما")]
        public string about { get; set; }


        [Display(Name = "ایمیل (تماس با ما)")]
        public string email { get; set; }


        [Display(Name = " شماره تماس (تماس با ما)")]
        public string phone { get; set; }


        [Display(Name = "کارمزد فروش")]
        public int wage { get; set; }


        // public bool isEnable { get; set; }

        public string user_id { get; set; }


        // nav

        [ForeignKey("user_id")]
        public virtual ApplicationUsers user { get; set; }

    }
}
