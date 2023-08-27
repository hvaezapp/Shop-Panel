using ShopPanel.Models.ApiModels;
using ShopPanel.Models.ApiObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Services
{
    public interface Ifav
    {
        Task<AllApi> SetFav(long productid , string token);
        Task<AllApi> DelFav(int favid, string token);

        Task<FavListApiObject> GetFavList(int page , string token);

    }
}
