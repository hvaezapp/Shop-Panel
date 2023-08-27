using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Domain;

namespace ShopPanel.Models.ViewModels
{
    public class sellerDetailViewModel
    {
        public Salsman seller { get; set; }
        public IEnumerable<sellerBank> bankinfo { get; set; }
    }
}
