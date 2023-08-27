using ShopPanel.Models.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopPanel.Models.Domain
{
    public class SizeCategory : BaseEntity<int>
    {

       

        public int cat_id { get; set; }

        public int size_id { get; set; }


        // nav

        [ForeignKey("cat_id")]
        public virtual Category Tbl_Category { get; set; }

        [ForeignKey("size_id")]
        public virtual Size Tbl_Size { get; set; }
    }
}
