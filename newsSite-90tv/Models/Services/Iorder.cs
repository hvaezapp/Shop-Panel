using ShopPanel.Models.ApiModels;
using ShopPanel.Models.ApiObject;
using ShopPanel.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Services
{
    public interface Iorder
    {

        Task<AllApi> AddOrderDetail(OrderDetailAddApiModel model,string token);
        Task<AllApi> AddOrder(string token);

        Task<Order> GetLastOrder(long appuserid);

        Task<OrderApiObject> GetOrderInfo(int idaddress ,string token);

        Task<OrderHistoryApiObject> GetOrderHistory(string token);

        Task<OrderDetailListApiObject> GetOrderDetail(long idorder);

       
    }
}
