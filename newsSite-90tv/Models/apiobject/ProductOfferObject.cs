using ShopPanel.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiObject
{
    public class ProductOfferObject  : AllApi
    {
        public IEnumerable<ProductOfferModel> offerproducts { get; set; }

        public IEnumerable<ProductModel> newestproducts { get; set; }

        public IEnumerable<ProductModel> topviewproducts { get; set; }

        public IEnumerable<ProductModel> toplikeproducts { get; set; }


        public IEnumerable<ProductModel> topsellproducts { get; set; }
    }
}
