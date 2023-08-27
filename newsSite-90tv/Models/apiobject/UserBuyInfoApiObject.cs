using ShopPanel.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiObject
{
    public class UserBuyInfoApiObject : AllApi
    {

        public UserAddressListApiModel useraddress { get; set; }

        public UserBuyDetailApiModel userbuyinfo { get; set; }
    }
}
