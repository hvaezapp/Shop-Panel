using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiModels
{
    public class ProductUpdateModel : ProductCreateModel
    {


        public long productId { get; set; }

        public List<string> trashImages { get; set; }

    }



}
