using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using qoltt.Infrastructure.Persistence;
using qoltt.Infrastructure.Seeders;

namespace qoltt.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<QolttDbContext>(options => options.UseSqlServer(
                configuration.GetConnectionString("QolttSqlServer")));

            services.AddScoped<QolttSeeder>();
        }
    }
}
