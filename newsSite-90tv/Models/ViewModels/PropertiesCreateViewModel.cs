using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Domain;

namespace ShopPanel.Models.ViewModels
{
    public class PropertiesCreateViewModel
    {
        public Properties properties { get; set; }

        public IEnumerable<Category> categories { get; set; }
    }
}
