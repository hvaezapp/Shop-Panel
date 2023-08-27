using ShopPanel.Models.ApiModels;
using ShopPanel.Models.ApiObject;
using ShopPanel.Models.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ShopPanel.Models.Repository.CategoryRepository;

namespace ShopPanel.Models.Services
{
    public interface ICategory
    {


        Task<CategoryObject> getproductcategory(int page);

        Task<CategoryObject> getsubcategory(int categoryid , int page);

        Task<CategoryObject> getshopcategory(int page);


        /*
        Task<JobCategoryApiObject> getjobcategory(int page);
        Task<ShopcategoryApiObject> getshopcategory(int page);

        Task<CategoryObject> getcategory(int type , int page);
       
        Task<CategoryApiObj> getsubcategory(int id);
        Task<CategoryApiObject> GetJobCategory();

       */






    }

}
