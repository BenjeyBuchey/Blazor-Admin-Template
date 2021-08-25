using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorAdminTemplate.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = BlazorAdminTemplate.Data.Enums.UserRoles.User.ToString(), 
            //    NormalizedName = BlazorAdminTemplate.Data.Enums.UserRoles.User.ToString().ToUpper(), Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
            //builder.Entity<IdentityRole>().HasData(new IdentityRole { Name = BlazorAdminTemplate.Data.Enums.UserRoles.Admin.ToString(), 
            //    NormalizedName = BlazorAdminTemplate.Data.Enums.UserRoles.Admin.ToString().ToUpper(), Id = Guid.NewGuid().ToString(), ConcurrencyStamp = Guid.NewGuid().ToString() });
        }
    }
}
