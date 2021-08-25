using BlazorAdminTemplate.Data;
using BlazorAdminTemplate.Data.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorAdminTemplate.IdentityUtils
{
    public static class RoleSeeds
    {
        public static async Task SeedAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            var roles = Enum.GetValues(typeof(UserRoles));
            foreach (var role in roles)
            {
                if(! await roleManager.RoleExistsAsync(role.ToString()))
                    await roleManager.CreateAsync(new IdentityRole(role.ToString()));
            }
        }
    }
}
