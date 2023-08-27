using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Domain;

namespace ShopPanel.Models.ApiModels
{
    public class OstanApiModel : AllApi
    {
        public  IEnumerable<Ostan>  ostans{ get; set; }
    }


    public class CityApiModel : AllApi
    {
        public IEnumerable<City> city { get; set; }
    }


    
}
