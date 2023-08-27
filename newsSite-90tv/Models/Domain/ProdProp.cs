using ShopPanel.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Domain
{
    public class ProdProp : BaseEntity<int>
    {
       
        public long product_id { get; set; }

        public int property_id { get; set; }

        // property value
        public string value { get; set; }


         // nav

        [ForeignKey("property_id")]
        public virtual Property Tbl_Property { get; set; }

        [ForeignKey("product_id")]
        public virtual Product Tbl_Product { get; set; }
    }
}
