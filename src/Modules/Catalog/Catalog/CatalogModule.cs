using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Catalog
{
    /// <summary>
    /// This class will be registering all dependencies regarding the catalog module
    /// </summary>
    public static class CatalogModule
    {
        public static IServiceCollection AddCatalogModule(this IServiceCollection services,IConfiguration configuration)
        {
            // Add services to the container
            // services
            //      .AddApplicationServices()
            //      .AddInfrastructureServices(configuration)
            //      .AddApiServices(configuration);

            return services;
        }

        public static IApplicationBuilder UseCatalogModule(this IApplicationBuilder app)
        {
            // Configure the HTTP request pipeline
            //app
            //    .UseApplicationServices()
            //    .UseInfrastructureServices()
            //    .UseApiServices()
            return app;
        }
    }
}
