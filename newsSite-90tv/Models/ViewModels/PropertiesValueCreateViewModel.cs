using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Domain;

namespace ShopPanel.Models.ViewModels
{
    public class PropertiesValueCreateViewModel
    {
        public PropertiesValue propertiesValue { get; set; }


        public Properties properties { get; set; }

        public IEnumerable<PropertiesValue> propertiesValues { get; set; }
    }
}
