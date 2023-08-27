using ShopPanel.Models.ApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Services
{
   public  interface Icontact
    {
        Task<AllApi> addcontact(string token  , ContactApiModel contactmodel);
    }
}
