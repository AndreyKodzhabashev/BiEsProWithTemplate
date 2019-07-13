namespace BiEsPro.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using BiEsPro.Common;
    using BiEsPro.Data.Models;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.Extensions.DependencyInjection;

    public class UserAdminSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<ApplicationRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<ApplicationUser>>();

            await SeedUserAdminAsync(roleManager, userManager);
        }

        private static async Task SeedUserAdminAsync(RoleManager<ApplicationRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            var role = await roleManager.FindByNameAsync(GlobalConstants.AdministratorRoleName);
            if (role != null)
            {
                var adminUser = new ApplicationUser
                {
                    UserName = "admin",
                    FirstName = "admin",
                    LastName = "adminov",
                    Ucn = "9999999999",
                    Email = "drju@abv.bg",
                    PhoneNumber = "9999999999",
                };

                var resultAddUser = await userManager.CreateAsync(adminUser, "admin1");

                if (!resultAddUser.Succeeded)
                {
                    throw new Exception(string.Join(Environment.NewLine, resultAddUser.Errors.Select(e => e.Description)));
                }

                var resultAddUserToRole = await userManager.AddToRoleAsync(adminUser, role.Name);
            }
        }
    }
}
