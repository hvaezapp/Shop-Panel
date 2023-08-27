using ShopPanel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Domain
{
    public class Size : BaseEntity<int>
    {



        [Display(Name = " نام سایز")]
        public string name { get; set; } // 32   // large

        //[Display(Name = "دسته بندی")]
        //public int cat_id { get; set; } // shoe   //closet

        public bool isEnable { get; set; }


        // nav


        [ForeignKey("cat_id")]
        public virtual Category Tbl_Category { get; set; }





    }
}
