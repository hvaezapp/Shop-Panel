using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Services
{
    public interface IAspNetUserRoleRepository
    {
        string GetRoleId(string userId);
    }
}
