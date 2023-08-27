using ShopPanel.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.ApiObject
{
    public class SellerSellInfoApiObject : AllApi
    {

        public UserAddressListApiModel useraddress { get; set; }

        public SellerSellInfoApiModel sellersellinfo { get; set; }
    }
}
