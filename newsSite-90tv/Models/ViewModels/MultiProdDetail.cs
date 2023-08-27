using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Domain;

namespace ShopPanel.Models.ViewModels
{
    public class MultiProdDetail
    {
   
        public Shop shop { get; set; }

        public Salsman seller { get; set; }

        public Product product { get; set; }
    }
}
