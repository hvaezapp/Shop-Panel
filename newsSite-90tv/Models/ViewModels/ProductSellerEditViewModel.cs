using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Domain;

namespace ShopPanel.Models.ViewModels
{
    public class ProductSellerEditViewModel
    {
        public ProductSeller productseller { get; set; }
        public IEnumerable<Color> color { get; set; }
        public IEnumerable<Shop> sellers { get; set; }
        public IEnumerable<int> coloridselect { get; set; }
    }
}
