using ShopPanel.Models.ApiModels;
using ShopPanel.Models.ApiObject;
using ShopPanel.Models.Services;
using ShopPanel.Models.UnitOfWork;
using ShopPanel.PublicClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Repository
{
    public class AdvertiseRepository : IAdvertise
    {
        private readonly IUnitOfWork _context;

        private readonly IsaveImage _isv;

        public AdvertiseRepository(IUnitOfWork context , IsaveImage isv)
        {
            _context = context;
            _isv = isv;
        }
     

        //public  async Task<AdvGetModelObject> getalladv(int page)
        //{
        //    var model = new AdvGetModelObject();
        //    try
        //    {
        //        int paresh = (page - 1) * 10;

        //        model.advertise =  _context.AdvertisRepositoryUW.Get(a => a.status ==1 && a.isenable && a.todateMiladi.Date.CompareTo(DateTime.Now.Date) > 0 ,null , "Shop").Skip(paresh).Take(10).Select(a => new AdvGetModel
        //        {
        //            id  = 1 , 
        //            image = a.image,
        //            shopname = a.Shop.title,
        //            viewcount = a.viewCount,
        //            title = a.title
                    

        //        }).ToList();

        //        model.message = EndPointMessage.API_OK_MSG;
        //        model.status = EndPointMessage.API_OK_Std;
        //    }
        //    catch (Exception)
        //    {

        //        model.message = EndPointMessage.API_ERROR_MSG;
        //        model.status = EndPointMessage.API_ERROR_Std;
        //    }

        //    return model;
        //}


       

        //public async Task<bool> setadv(AdvCreateModel model, string token)
        //{
        //    try
        //    {
        //        var adv = new shopadvertise()
        //        {
        //            title = model.title,
        //            desc = model.desc,
        //            image =await _isv.SaveAdvShopImage(Convert.FromBase64String(model.image)),
        //            shop_id = model.shopId,
        //            sel_id = _context.salsmanRepositoryUW.Get(a=>a.Tbl_Userapp.token == token).FirstOrDefault().Id,
        //            status =(byte) Status.suspend,
        //            isenable = true,
        //            time = DateAndTimeShamsi.MyTime(),
        //            fromdateShamsi = string.Empty,
        //            todateShamsi = string.Empty,
        //            userapptoken = token
                    

                    

        //        };


        //        _context.AdvertisRepositoryUW.Create(adv);
        //        await _context.saveAsync();


        //        return true;
        //    }
        //    catch (Exception)
        //    {

        //        return false;
        //    }
        //}
    }
}
