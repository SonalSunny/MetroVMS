using MetroVMS.DataAccess;
using MetroVMS.Entity.Identity.ViewModel;
using MetroVMS.Services.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MetroVMS.Startup
{
    public static class DBInitializer
    {
        public static async Task Initialize(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                try
                {
                    var context = serviceScope.ServiceProvider.GetService<MetroVMSDBContext>();
                    if (context != null)
                    {
                        context.Database.Migrate();
                        var _userManager = serviceScope.ServiceProvider.GetRequiredService<IUserRepository>();
                        var _roleManager = serviceScope.ServiceProvider.GetRequiredService<IRoleRepository>();

                        var role = new RoleViewModel()
                        {
                            RoleName = "Admin",
                            Active = true,

                        };
                        var RoleData = await _roleManager.SaveRole(role);
                        if (RoleData.returnData != null)
                        {
                            var user = new UserViewModel()
                            {
                                Username = "Admin",
                                Password = "123",
                                RoleId = (long)RoleData.returnData.RoleId,
                                Active = true
                            };
                            await _userManager.RegisterUser(user);
                        }
                    }
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
