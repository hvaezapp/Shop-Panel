using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopPanel.Models.ApiModels;
using ShopPanel.Models.ApiObject;
using ShopPanel.Models.Services;
using ShopPanel.Models.UnitOfWork;

namespace ShopPanel.Controllers.api
{
    [Produces("application/json")]
    [Route("api/useralarm/[action]")]
    public class useralarmController : Controller
    {

        private readonly Iuseralarm _iuseralarm;

        public useralarmController(Iuseralarm useralarm)
        {
            _iuseralarm = useralarm;
        }


       
        [HttpGet]
        public async Task<UserAlarmApiObject> GetUserAlarm(int page =1)
        {
            var token = Request.Headers["token"].ToString();
            return await _iuseralarm.Getuseralarm(token, page);
        }


        [HttpGet]
        public async Task<AllApi> SetReadUserAlarm(int id)
        {
            var token = Request.Headers["token"].ToString();
            return await _iuseralarm.SetReadUseralarm(token, id);
        }
    }
}