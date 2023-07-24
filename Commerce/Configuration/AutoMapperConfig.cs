using Commerce.Profiles;

namespace Commerce.Configuration
{
    public static class AutoMapperConfig
    {
        public static IServiceCollection ConfigureAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(UsuarioProfile));
            return services;
        }
    }
}
