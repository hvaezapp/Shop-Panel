using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace ShopPanel.Models.Domain
{
    public class Color : BaseEntity<int>
    {

        [Display(Name = "نام رنگ")]
        public string name { get; set; }

        [Display(Name = "  نام رنگ انگلیسی")]

        public string nameen { get; set; }


        [Display(Name = "کد رنگ")]

        public string code { get; set; }


        public bool isenable { get; set; }
    }
}
