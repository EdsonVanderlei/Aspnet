using Commerce.Data;
using Commerce.Profiles;
using Microsoft.EntityFrameworkCore;

namespace Commerce.Configuration
{
    public static class GeneralConfig
    {
        public static IServiceCollection AddGeneralConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(UsuarioProfile));
            services.AddDbContext<CommerceContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }
    }
}
