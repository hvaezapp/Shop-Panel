using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace ShopPanel.Models.Domain
{
    public class Part : BaseEntity<int>
    {


        [Display(Name = "نام بخش")]
        public string key { get; set; }

        public bool isenable { get; set; }
    }
}
