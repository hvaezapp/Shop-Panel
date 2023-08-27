using ShopPanel.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiObject
{
    public class SellerShopProductApiObject : AllApi
    {

        public IEnumerable<SellerShopProductApiModel> products { get; set; }
    }
}
