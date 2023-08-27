using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopPanel.Models.Domain;

namespace ShopPanel.Models.Services
{
    public interface IUserapp 
    {
        Task<string> getfullname(long id);
        Task<UserApp> IsUserappExist(string phone);

    }
}
