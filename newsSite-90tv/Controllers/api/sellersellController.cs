﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopPanel.Models.ApiModels;
using ShopPanel.Models.ApiObject;
using ShopPanel.Models.Services;

namespace ShopPanel.Controllers.api
{
    [Produces("application/json")]
    [Route("api/sellersell/[action]")]
    public class sellersellController : Controller
    {

        private readonly Isellersell isellersell;


        public sellersellController(Isellersell sellersell)
        {
            isellersell = sellersell;
        }


        [HttpGet]
        public async Task<SellerSellListApiObject> GetSellerSellList(int state , int page=1)
        {
            var token = Request.Headers["token"];
            return await isellersell.GetSellerSellList(state, page, token);
        }


        [HttpGet]
        public async Task<SellerSellInfoApiObject> GetSellerSellInfo(long sellid)
        {
            
            return await isellersell.GetSellerSellInfo(sellid);
        }


        [HttpGet]
        public async Task<AllApi> SetSellingStatus(long sellid)
        {
            var token = Request.Headers["token"];
            return await isellersell.SetSellingStatus(sellid , token);
        }
    }
}