using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Domain;

namespace ShopPanel.Models.ApiModels
{
    public class CategoryObject : AllApi
    {
        public IEnumerable<Category> categories { get; set; }


        public CategoryObject()
        {
            categories = new List<Category>();
        }
        
    }

  
}


