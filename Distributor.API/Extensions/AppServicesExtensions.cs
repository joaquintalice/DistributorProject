using Distributor.Infraestructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Distributor.API.Extensions
{
    public static class AppServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(
            this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<ApplicationDbContext>(
                opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection"))
                );

            return services;
        }
    }
}
