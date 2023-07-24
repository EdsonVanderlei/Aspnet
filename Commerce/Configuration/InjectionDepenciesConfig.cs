using Commerce.Data.Interfaces;
using Commerce.Data.Repositories;
using Commerce.Services;
using Commerce.Services.Repository;

namespace Commerce.Configuration
{
    public static class InjectionDepenciesConfigs
    {
        public static IServiceCollection ResolveInjectionDepencies(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioServico, UsuarioServico>();
            services.AddScoped<IRepositoryUsuario, RepositoryUsuario>();
            return services;

        }

    }
}
