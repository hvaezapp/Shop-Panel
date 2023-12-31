﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopPanel.Models.ApiObject;
using ShopPanel.Models.Repository;
using ShopPanel.Models.Services;
using ShopPanel.Models.UnitOfWork;

namespace ShopPanel.Controllers.api
{
    [Produces("application/json")]
    [Route("api/seller/[action]")]
    public class sellerController : Controller
    {


        private readonly Iseller _seller;


        public sellerController(Iseller iseller)
        {
            _seller = iseller;
        }



        /*

        [HttpGet]
        public async Task<SellerinfoApiObject>  GetSellerInfo(long sellerid)
        {
            return await _seller.getsellerinfo(sellerid);
        }


        [HttpGet]

        public async  Task<SellerListApiObject> GetAllSeller(int page=1)
        {
            return await _seller.allseller(page);
        }

        [HttpGet]

        public async Task<ShopListApiObject> GetSellerShops(long sellerid , int page = 1)
        {
            return await _seller.getsellershops(sellerid , page);
        }


        [HttpGet]

        public async Task<ProductListAllApiObject> GetSellerProducts(long sellerid , int page = 1)
        {
            return await _seller.getsellerproducts(sellerid , page);
        }



       */




    }
}