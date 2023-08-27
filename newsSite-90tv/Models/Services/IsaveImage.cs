using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Services
{
    public  interface IsaveImage 
    {
        Task<string> SaveProductGallaryImages(string image);

        Task<bool> DelProductGallaryImages(List<string> names);

        Task<string> SaveProductIndexImage(string image);

        Task<string> SaveShopIndexImage(byte[] image);

        Task<string> SaveAdvShopImage(byte[] image);
        Task<string> SaveJobBannerImage(byte[] image);

        Task<bool> DelShopIndexImage(string name);

        Task<string> SaveUserAppImage(string oldimage , byte[] newimage);
       
    }
}
