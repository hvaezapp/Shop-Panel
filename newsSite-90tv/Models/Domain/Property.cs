using ShopPanel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Domain
{
    public class Property : BaseEntity<int>
    {

        [Display(Name = "نام خصوصیت")]
        public string name { get; set; }


        [Display(Name = " بخش")]
        public int part_id { get; set; }


        [Display(Name = " دسته بندی")]
        public int cat_id { get; set; }

        public bool isenable { get; set; }


        // nav

        [ForeignKey("part_id")]
        public virtual Part Tbl_Part { get; set; }


        [ForeignKey("cat_id")]
        public virtual Category Tbl_Category { get; set; }
    }
}
