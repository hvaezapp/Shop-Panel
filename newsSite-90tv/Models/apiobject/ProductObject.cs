using ShopPanel.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiObject
{
    public class ProductObject : AllApi
    {

        public IEnumerable<ProductModel> products { get; set; }
        public IEnumerable<ProductModel> newest { get; set; }
        public IEnumerable<ProductModel> topview { get; set; }
        public IEnumerable<ProductModel> likely { get; set; }



    }
}
