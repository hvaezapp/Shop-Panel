using ShopPanel.Models.ApiModels;
using ShopPanel.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiObject
{
    public class CreateProductGetApiObject : AllApi
    {

        public IEnumerable<Category> categories { get; set; }

        public IEnumerable<Color> colors { get; set; }

        public IEnumerable<ProductBrand> brands { get; set; }
    }
}
