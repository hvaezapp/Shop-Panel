using ShopPanel.Models.ApiModels;
using ShopPanel.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ShopPanel.Models.Repository.ProductRepository;

namespace ShopPanel.Models.ApiObject
{
    public class ProductDetailObject : AllApi
    {
        public ProductDetailModel productDetail { get; set; }
        public IEnumerable<SameProductListApiModel> sameproduct { get; set; }
        public IEnumerable<CommentApiModel> productcomment { get; set; }


        public IEnumerable<string> productgallary { get; set; }

        public IEnumerable<Color> productcolors { get; set; }
        public IEnumerable<ProductSizeApiModel> productsize { get; set; }

        public IEnumerable<ProductPropertyListApiModel> productproperty { get; set; }








    }


 


   
}
