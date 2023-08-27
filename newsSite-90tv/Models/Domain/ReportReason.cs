using ShopPanel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Domain
{
    public class ReportReason : BaseEntity<int>
    {
 

        [Display(Name = "عنوان دلیل")]
        public string title { get; set; }


        public bool isenable { get; set; }
    }
}
