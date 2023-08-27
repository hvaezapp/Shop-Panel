using ShopPanel.Models.Services;
using ShopPanel.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopPanel.Models.Repository
{
    public class AspNetUserRoleRepository : IAspNetUserRoleRepository
    {
        private readonly ApplicationDbContext _context;

        public AspNetUserRoleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public string GetRoleId(string userId)
        {
            var getRoleId = _context.UserRoles.Where(ur => ur.UserId == userId).ToList();
            string getRolIdArray = "";

            for (int i = 0; i < getRoleId.Count; i++)
            {
                getRolIdArray += getRoleId[i].RoleId.ToString() + ",";
            }

            return getRolIdArray;
        }
    }
}
