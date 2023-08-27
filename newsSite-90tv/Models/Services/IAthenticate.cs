using ShopPanel.Models.ApiModels;
using ShopPanel.Models.ApiObject;
using ShopPanel.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Services
{
    public interface IAthenticate
    {

        Task<UserApp> checkToken(string token);


      

        Task<AllApi> register(RegisterApiModel register);
        Task<AllApi> preregister(string phone);
        Task<AllApi> login(string phone);
        Task<AllApi> coderesend(string phone);

        Task<UserAppApiObject> verify(string code, string phone);

        Task<AllApi> updateprofile(UserAppApiModel profile, string token);


    }
}
