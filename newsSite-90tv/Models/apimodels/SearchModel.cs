using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiModels
{
    public class SearchModel
    {
        public int page { get; set; } = 1;
        public string value { get; set; }
    }
}
