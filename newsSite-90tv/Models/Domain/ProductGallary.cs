using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPanel.Models.Domain
{
    public class ProductGallary : BaseEntity<int>
    {

        public long product_id { get; set; }


        public string imagepath { get; set; }


        // nav

        [ForeignKey("product_id")]
        public virtual Product product { get; set; }



    }


}
