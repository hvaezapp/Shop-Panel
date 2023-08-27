using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPanel.Models.Domain
{
    public class ProductColor : BaseEntity<int>
    {


        public long product_id { get; set; }

        public int color_id { get; set; }


        // nav

        [ForeignKey("color_id")]
        public virtual Color Tbl_color { get; set; }

        [ForeignKey("product_id")]
        public virtual Product Tbl_Product { get; set; }



    }
}
