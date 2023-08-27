using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiModels
{
    public class SearchModelBanner : SearchModel
    {
        public int cityid { get; set; }
        public int catid { get; set; }
    }
}
