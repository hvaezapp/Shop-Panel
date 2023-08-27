using ShopPanel.Models.ApiModels;
using ShopPanel.Models.ApiObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Services
{
    public interface Icomment 
    {
        Task<AllApi> setproductcomment(AddCommentModel model , string token);
        Task<AllApi> setshopcomment(AddCommentModel model , string token);
        

        Task<commentapiobject> getproductcomment(long id , int page);

        Task<commentapiobject> getshopcomments(long shopid, int page);
    }
}
