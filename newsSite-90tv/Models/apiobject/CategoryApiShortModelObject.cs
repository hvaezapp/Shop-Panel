using ShopPanel.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiObject
{
    public class CategoryApiShortModelObject : AllApi
    {
        public List<CategoryApiShortModel> category { get; set; }
    }
}
