
using Infrastructure_Layer.Services;
using Microsoft.Extensions.DependencyInjection;
using MediatR;
using Infrastructure_Layer.Common.Models.Swagger.Response;
using Microsoft.Extensions.Configuration;

namespace Infrastructure_Layer
{
   public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services) {

            services.AddScoped<IGrammatikService, GrammatikService>();
            services.AddTransient<RestClient>();
            return services;

        }

 
    }
}
