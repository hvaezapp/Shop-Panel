using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Domain;

namespace ShopPanel.Models.ViewModels
{
    public class ProductSellerCreateViewModel
    {
        public ProductSeller productseller { get; set; }
        public IEnumerable<Shop> sellers { get; set; }
        public IEnumerable<Color> colors { get; set; }
       
    }
}
