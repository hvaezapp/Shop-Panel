using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiModels
{
    public class EditBannerApiModel : AddJobBannerApiModel
    {

        public long idbanner { get; set; }
        public IEnumerable<long> trashimage { get; set; }
        //public IEnumerable<long> trashimage { get; set; }
    }
}
