using ShopPanel.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiObject
{
    public class bannerInfoApiObject : AllApi
    {

        public bannerInfoApiModel bannerdetail { get; set; }

        public IEnumerable<string> images { get; set; }

        public IEnumerable<bannerListApiModel> samebanner { get; set; }

      

    }
}
