using ShopPanel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Domain
{
    public class ProductBrand : BaseEntity<int>
    {



        [Display(Name = "نام برند")]
        public string name { get; set; }

        [Display(Name = "نام برند (انگلیسی)")]
        public string nameen { get; set; }

        public bool isenable { get; set; }


    }
}
