using ShopPanel.Models.ApiModels;
using ShopPanel.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiObject
{
    public class PropertiesValueApiObject : AllApi
    {
        public IEnumerable<PropertiesValue> propertiesValues { get; set; }
    }
}
