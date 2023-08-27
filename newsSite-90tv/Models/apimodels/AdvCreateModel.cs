using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiModels
{
    public class AdvCreateModel
    {
        public long shopId { get; set; }

        public string title { get; set; }


        public string desc { get; set; }


        public string image { get; set; }
    }
}
