using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Domain;

namespace ShopPanel.Models.ViewModels
{
    public class shopCreateViewModel
    {
        public IEnumerable<City> cities { get; set; }
        public IEnumerable<Ostan> ostan { get; set; }
        public IEnumerable<AppUserDropDownViewModel> seller { get; set; }

        public IEnumerable<Category> shopCategory { get; set; }

        public Shop shop { get; set; }


    }
}
