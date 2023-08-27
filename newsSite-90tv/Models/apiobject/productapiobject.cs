using ShopPanel.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiObject
{
    public class productapiobject : AllApi
    {
        public List<ProductModel> products { get; set; }
        public int  page { get; set; }
    }
}
