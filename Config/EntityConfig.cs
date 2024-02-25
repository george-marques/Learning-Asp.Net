using Asp_mvc.Data;
using Microsoft.EntityFrameworkCore;

namespace Asp_mvc.Config
{
    public static class EntityConfig
    {

        public static IServiceCollection EntityDbContextConfig(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AspContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("AspContext") ?? throw new InvalidOperationException("Connection string 'AspContext' not found.")));

            return services;
        }
    }
}
