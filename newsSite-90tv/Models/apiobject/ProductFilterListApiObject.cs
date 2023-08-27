using ShopPanel.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiObject
{
    public class ProductFilterListApiObject : AllApi
    {

        public IEnumerable<filter> filters { get; set; }

        public long toprice { get; set; }



    }


    public class filter
    {
        public string name { get; set; } // brand
        public IEnumerable<object> values { get; set; }
    }
}
