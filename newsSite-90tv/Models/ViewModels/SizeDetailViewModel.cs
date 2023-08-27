using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Domain;

namespace ShopPanel.Models.ViewModels
{
    public class SizeDetailViewModel
    {
        public Size size { get; set; }

        public IEnumerable<string> category { get; set; }
    }
}
