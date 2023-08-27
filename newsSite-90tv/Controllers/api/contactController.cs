using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopPanel.Models.ApiModels;
using ShopPanel.Models.Services;
using ShopPanel.Models.UnitOfWork;

namespace ShopPanel.Controllers.api
{
    [Produces("application/json")]
    [Route("api/contact/[action]")]
    public class contactController : Controller
    {
   
        private readonly Icontact _contact;


        public contactController( Icontact contact)
        {
           
            _contact = contact;
        }


        [HttpPost]
        public async Task<AllApi> Addcontact([FromBody] ContactApiModel model)

        {
            var token = Request.Headers["token"];

            return await _contact.addcontact(token, model);

        }


    }
}