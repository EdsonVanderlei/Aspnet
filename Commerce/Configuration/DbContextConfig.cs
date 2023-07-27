using Commerce.Data;
using Microsoft.EntityFrameworkCore;

namespace Commerce.Configuration
{
    public static class DbContextConfig
    {
        public static IServiceCollection ConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CommerceContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DataBase")));
            return services;
        }
    }
}
