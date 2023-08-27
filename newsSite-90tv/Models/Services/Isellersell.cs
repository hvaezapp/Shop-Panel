using ShopPanel.Models.ApiModels;
using ShopPanel.Models.ApiObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Services
{
    public interface Isellersell 
    {
        Task<SellerSellListApiObject> GetSellerSellList(int state, int page, string token);
        Task<SellerSellInfoApiObject> GetSellerSellInfo(long sellid);
        Task<AllApi> SetSellingStatus(long sellid , string token);
    }
}
