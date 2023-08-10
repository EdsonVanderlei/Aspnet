using Commerce.Data.Interfaces;
using Commerce.Data.Repositories;
using Commerce.Notifications;
using Commerce.Notifications.Interfaces;
using Commerce.Services;
using Commerce.Services.Interface;
using Commerce.Services.Repository;

namespace Commerce.Configuration
{
    public static class InjectionDepenciesConfigs
    {
        public static IServiceCollection ResolveDependencyInjection(this IServiceCollection services)
        {
            services.AddScoped<IUsuarioServico, UsuarioService>();
            services.AddScoped<IRepositoryUsuario, RepositoryUsuario>();
            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IAutenticacaoServico,AutenticacaoServico>();
            return services;
        }
    }
}
