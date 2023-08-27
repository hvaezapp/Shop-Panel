using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Domain;

namespace ShopPanel.Models.ViewModels
{
    public class selbankinfocreateViewModel
    {
        public IEnumerable<AppUserDropDownViewModel> sellers { get; set; }
        public sellerBank bankinfo { get; set; }
    }
}
