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
                    //context.Database.EnsureCreated();
                    //if (context != null)
                    //{
                    //    context.Database.Migrate();
                    //    var _userManager = serviceScope.ServiceProvider.GetRequiredService<IUserRepository>();
                    //}
                    context.Database.Migrate();
                    var _userManager = serviceScope.ServiceProvider.GetRequiredService<IUserRepository>();
                    //var user = new UserViewModel()
                    //{
                    //    Username = "Administrator",
                    //    Password = "Admin@123",
                    //    Active = true
                    //};
                    //await _userManager.RegisterUser(user);

                }
                catch (Exception)
                {

                }
            }
        }
    }
}
