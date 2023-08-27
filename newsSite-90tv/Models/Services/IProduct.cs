using ShopPanel.Controllers.api;
using ShopPanel.Models.ApiModels;
using ShopPanel.Models.ApiObject;
using ShopPanel.Models.UnitOfWork;
using ShopPanel.PublicClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ShopPanel.Models.Repository.ProductRepository;

namespace ShopPanel.Models.Services
{
    public interface IProduct 
    {
      
        Task<ProductDetailObject> productdetail(long id);
        Task<ProductListAutoCompleteObject> autocomplete(string data , int page);
  
      

        Task<CreateProductGetApiObject> createproductget();
        Task<AllApi> createproductpost(ProductCreateModel product, string token);


        Task<OstanApiModel> getostan();
        Task<CityApiModel> getcity(int id);
        Task<CityApiModel> getallcity(int page);
        Task<CityApiModel> getcitybyname(string title);



        Task<ProductListAllApiObject> allproduct(int page);
        Task<ProductListAllApiObject> allproductbysort(int sort, int page);
        Task<ProductListAllApiObject> getproductsbyfilter(int page  ,string title,  string brands , string price , string regions);



        Task<UpdateProductGetApiObject> updateproductget(long productId);
        Task<AllApi> updateproductpost(ProductUpdateModel model , string token); 


         Task<ProductOfferObject> homeapi();

        Task<AllApi> deleteproduct(long id , string token);


        Task<ProductListAllApiObject> getproductsbycat(int catId , int page);
        Task<ProductListAllApiObject> getproductsbytitle(string title,  int page);


        Task<SizeApiObject> getsizebycategory(int categoryid);


        Task<FactorProductApiObject> getfactorproduct(long price);


    }

   
}
