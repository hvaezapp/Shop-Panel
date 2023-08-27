using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiModels
{
    public class FactorProductApiModel
    {
        public long tariff { get; set; }

        public long sellerShare { get; set; }

        public long tax { get; set; }
    }
}
