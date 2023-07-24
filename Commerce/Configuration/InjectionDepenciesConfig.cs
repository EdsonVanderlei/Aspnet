using Commerce.Data.Interfaces;
using Commerce.Data.Repositories;

namespace Commerce.Configuration
{
    public static class InjectionDepenciesConfigs
    {
        public static IServiceCollection ResolveInjectionDepencies(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryUsuario, RepositoryUsuario>();
            return services;

        }

    }
}
