using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiModels
{
    public class ProductFilterSearch : SearchModel
    {

        public string title { get; set; }

        public string colors { get; set; }

        public string brands { get; set; }

        public string cats { get; set; }

        public string region { get; set; }

     
    }
}
