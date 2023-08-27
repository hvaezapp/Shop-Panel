using ShopPanel.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiObject
{
    public class ProductListAllApiObject : AllApi
    {
        public IEnumerable<ProductListApiModel> products { get; set; }


        public ProductListAllApiObject()
        {
            products = new List<ProductListApiModel>();
        }
    }
}
