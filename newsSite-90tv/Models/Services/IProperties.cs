using ShopPanel.Models.ApiObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Services
{
    public interface IProperties
    {
        Task<PropertiesApiObject> getpropertiesbycategory(int categoryid);
        Task<PropertiesValueApiObject> getpropertyvaluebyproperty(int propertyid);
    }
}
