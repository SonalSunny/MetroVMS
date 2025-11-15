using MetroVMS.DataAccess;
using MetroVMS.Services.Interface;
using MetroVMS.Services.Repository;
using Microsoft.EntityFrameworkCore;

namespace MetroVMS.Program
{
    public static class DBContextInjector
    {
        public static void RegisterDBContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<MetroVMSDBContext>(options =>
            options.UseSqlServer(connectionString));

            services.AddScoped<IUserLoginRepository, UserLoginRepository>();
            services.AddScoped<IMenuRepository, MenuRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IDropDownRepository, DropDownRepository>();
            services.AddScoped<IRoleRepository, RoleRepository>();

        }
    }
}
