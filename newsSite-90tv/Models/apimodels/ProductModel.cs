using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiModels
{
    public class ProductModel
    {
        public long Id { get; set; }

        public string title { get; set; }

        public long price { get; set; }

        public int  offpercent { get; set; }

        public string image { get; set; }
        
    }


}
