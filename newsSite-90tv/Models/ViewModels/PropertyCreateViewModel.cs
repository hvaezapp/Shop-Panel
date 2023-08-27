using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Domain;

namespace ShopPanel.Models.ViewModels
{
    public class PropertyCreateViewModel
    {
        public Property property { get; set; }

        public IEnumerable<Part> part { get; set; }

        public IEnumerable<Category> category { get; set; }
    }
}
