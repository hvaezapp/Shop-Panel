using ShopPanel.Models.ApiModels;
using ShopPanel.Models.ApiObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Services
{
    public interface Iuserbuy 
    {
        Task<UserBuyListApiObject> GetUserBuylist(int state , int page , string token);
        Task<UserBuyInfoApiObject> GetUserBuyInfo(long buyid);

        Task<AllApi> SetBuyDeliverStatus(long buyid, string token);
    }
}
