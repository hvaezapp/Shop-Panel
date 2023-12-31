﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopPanel.Models;

using ShopPanel.PublicClass;

using ShopPanel.Models.UnitOfWork;
using ShopPanel.Models.ApiModels;
using ShopPanel.Models.Services;
using static ShopPanel.Models.Repository.CategoryRepository;
using ShopPanel.Models.ApiObject;

namespace ShopPanel.Controllers.api
{
    [Produces("application/json")]

    [Route("api/category/[action]")]


    public class categoryController : Controller
    {


        private readonly ICategory _ic;



        public categoryController( ICategory ic)
        {
       
            _ic = ic;

        }



        //get product category
        [HttpGet]
        public async Task<CategoryObject> GetProductCategory(int page = 1)
        {
            return await _ic.getproductcategory(page);
        }




        //get sub category

        [HttpGet]
        public async Task<CategoryObject> GetsubCategory(int id , int page = 1)
        {
            return await _ic.getsubcategory(id, page);
        }


        //get shop category

        [HttpGet]
        public async Task<CategoryObject> GetShopCategory(int page = 1)
        {
            return await _ic.getshopcategory(page);
        }





        /*

        // get all category with paging and type
        [HttpGet]
        public async Task<CategoryObject> getcategory(int t , int page =1)
        {
            return await _ic.getcategory(t, page);
        }


        

        // get sub category of a category

        [HttpGet]
        public async Task<CategoryApiObj> getsubcategory(int id)
        {
            return await _ic.getsubcategory(id);
        }



        // get job categry 

        [HttpGet]

        public async Task<JobCategoryApiObject>  GetBannerCategory(int page=1)
        {
            return await _ic.getjobcategory(page);
        }

        //get shop category
        [HttpGet]
        public async Task<ShopcategoryApiObject> GetShopCategory(int page = 1)
        {
            return await _ic.getshopcategory(page);
        }


      



        [HttpGet]
        public async Task<CategoryApiObject>  getjobcategory()
        {
            return  await _ic.GetJobCategory();
        }


    */

    }
}