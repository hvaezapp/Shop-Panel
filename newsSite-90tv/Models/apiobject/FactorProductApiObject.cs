using ShopPanel.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiObject
{
    public class FactorProductApiObject : AllApi
    {
        public FactorProductApiModel factorProduct { get; set; }


        public FactorProductApiObject()
        {
            factorProduct = new FactorProductApiModel();
        }

    }
}
