using Asp_mvc.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace Asp_mvc.Config
{
    public static class IdentityConfig
    {

        public static IServiceCollection IdentityConfigs(this IServiceCollection services)
        {
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true).AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ContextIdentity>();

            return services;
        }

        public static IServiceCollection IdentityDbContextConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ContextIdentity>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ContextIdentityConnection") ?? throw new InvalidOperationException("Connection string 'ContextIdentity' not found.")));

            return services;
        }
    }
}
