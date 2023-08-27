using ShopPanel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Domain
{
    public class ProductSize : BaseEntity<int>
    {

     
        public long product_id { get; set; }
        public int size_id { get; set; }


        // nav

        [ForeignKey("product_id")]
        public virtual Product Tbl_Product { get; set; }


        [ForeignKey("size_id")]
        public virtual Size Tbl_Size { get; set; }
    }
}
