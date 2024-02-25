using Asp_mvc.Data;

namespace Asp_mvc.Config
{
    public static class DependencyInjectionConfig
    {

        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddTransient<IFilmeRepository, FilmeRepository>();
            return services;

        }
    }
}
