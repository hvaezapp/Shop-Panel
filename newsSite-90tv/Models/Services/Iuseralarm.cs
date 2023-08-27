using ShopPanel.Models.ApiModels;
using ShopPanel.Models.ApiObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Services
{
    public interface Iuseralarm 
    {

        Task<UserAlarmApiObject> Getuseralarm(string token, int page);
        Task<AllApi> SetReadUseralarm(string token, int id);

    }
}
