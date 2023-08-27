using ShopPanel.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Domain
{
    public class ProductFav : BaseEntity<int>
    {
    

        public long appuser_id { get; set; }

        public long product_id { get; set; }
    }
}
