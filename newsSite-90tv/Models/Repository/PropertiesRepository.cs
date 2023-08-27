using ShopPanel.Models.ApiObject;
using ShopPanel.Models.Services;
using ShopPanel.Models.UnitOfWork;
using ShopPanel.PublicClass;
using ShopPanel.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Repository
{
    public class PropertiesRepository : IProperties
    {
        private readonly IUnitOfWork _context;

        public PropertiesRepository(IUnitOfWork context)
        {
            _context = context;
        }

        public async Task<PropertiesApiObject> getpropertiesbycategory(int categoryid)
        {
            var api = new PropertiesApiObject();

            try
            {

                api.properties = await _context.PropertiesRepositoryUW.GetManyAsync(a => a.isEnable && a.category_id == categoryid);


                api.message = EndPointMessage.API_OK_MSG;
                api.status = EndPointMessage.API_OK_Std;

            }
            catch (Exception)
            {

                api.properties = new List<Properties>();
                api.message = EndPointMessage.API_ERROR_MSG;
                api.status = EndPointMessage.API_ERROR_Std;
            }

            return api;
        }

        public async Task<PropertiesValueApiObject> getpropertyvaluebyproperty(int propertyid)
        {
            var api = new PropertiesValueApiObject();

            try
            {

                api.propertiesValues = await _context.PropertiesValueRepositoryUW.GetManyAsync(a => a.isEnable && a.properties_id == propertyid);


                api.message = EndPointMessage.API_OK_MSG;
                api.status = EndPointMessage.API_OK_Std;

            }
            catch (Exception)
            {

                api.propertiesValues = new List<PropertiesValue>();
                api.message = EndPointMessage.API_ERROR_MSG;
                api.status = EndPointMessage.API_ERROR_Std;
            }

            return api;
        }
    }
}
