using ShopPanel.Models.ApiModels;
using ShopPanel.Models.ApiObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Services
{
    public interface Iuseraddress 
    {

        Task<AllApi> AddAddress(AdduserAddressApiModel model , string token);
        Task<UserAddressApiObject> GetUserAddressList(string token);
        Task<AllApi> DeleteUserAdd(int id , string token);
    }
}
