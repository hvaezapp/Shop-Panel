using Microsoft.AspNetCore.Identity;

namespace ShopPanel.Models.Domain
{
    public class ApplicationRoles : IdentityRole
    {
        public string RoleLevel { get; set; }

        public string Description { get; set; }
    }
}
