using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiModels
{
    public class CategoryApiShortModel
    {
        public int id { get; set; }
        public string title { get; set; }

        public int type { get; set; }
    }
}
