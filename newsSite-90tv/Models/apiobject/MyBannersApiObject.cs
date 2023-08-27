using ShopPanel.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiObject
{
    public class MyBannersApiObject : AllApi
    {
        public IEnumerable<MyBannersApiModel> mybanners { get; set; }
    }
}
