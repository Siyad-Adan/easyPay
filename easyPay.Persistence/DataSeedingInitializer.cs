using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace easyPay.Persistence
{
    public static class DataSeedingInitializer
    {
        public async static Task UserAndRoleSeedAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            string[] roles = { "Admin", "Manager", "Staff" };
            foreach(var role in roles)
            {
                var roleExist = await roleManager.RoleExistsAsync(role);
                if (!roleExist)
                {
                    IdentityResult result = await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            //Create Admin User
            if (userManager.FindByEmailAsync("siyad.adan94@gmail.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "siyad.adan94@gmail.com",
                    Email = "siyad.adan94@gmail.com"
                };

                IdentityResult identityResult = await userManager.CreateAsync(user, "Password1");

                if (identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }

            //Create Manager User
            if (userManager.FindByEmailAsync("siyad.a094@gmail.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "siyad.a094@gmail.com",
                    Email = "siyad.a094@gmail.com"
                };

                IdentityResult identityResult = await userManager.CreateAsync(user, "Password1");

                if (identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Manager").Wait();
                }
            }


            //Create Staff User
            if (userManager.FindByEmailAsync("siyadadan@cmail.carleton.ca").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "siyadadan@cmail.carleton.ca",
                    Email = "siyadadan@cmail.carleton.ca"
                };

                IdentityResult identityResult = await userManager.CreateAsync(user, "Password1");

                if (identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Staff").Wait();
                }
            }


            //Create No Role User
            if (userManager.FindByEmailAsync("siyad_adan@hotmail.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "siyad_adan@hotmail.com",
                    Email = "siyad_adan@hotmail.com"
                };

                IdentityResult identityResult = await userManager.CreateAsync(user, "Password1");
                //no role assigned here
            }
        }
    }
}
