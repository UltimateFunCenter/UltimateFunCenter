using Microsoft.AspNetCore.Identity;

namespace UltimateFunCenter.Data
{
    public class IdentitySeedData
    {
        public static async Task Initialize(ApplicationDbContext context, UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            string asdminRole = "Admin";
            string memberRole = "Member";
            string passwordForAll = "Catalin@1";

            if (await roleManager.FindByNameAsync(asdminRole) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(asdminRole));
            }

            if (await roleManager.FindByNameAsync(memberRole) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(memberRole));
            }

            if (await userManager.FindByNameAsync("admin1@admin.aa") == null) {
                var user = new IdentityUser
                {
                    UserName = "admin1@admin.aa",
                    Email = "admin1@admin.aa",
                    PhoneNumber ="123466789"
                };

                var result =  await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, passwordForAll);
                    await userManager.AddToRoleAsync(user, asdminRole);
                }
                
            }

            if (await userManager.FindByNameAsync("member@member.mm") == null)
            {
                var user = new IdentityUser
                {
                    UserName = "member@member.mm",
                    Email = "member@member.mm",
                    PhoneNumber = "123456788"
                };

                var result = await userManager.CreateAsync(user);
                if (result.Succeeded)
                {
                    await userManager.AddPasswordAsync(user, passwordForAll);
                    await userManager.AddToRoleAsync(user, memberRole);
                }

            }
        }
    }

}
    