
using Infrastructure_Layer.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure_Layer
{
   public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services) {

            services.AddScoped<IKrammatikService, KrammatikService>();
            services.AddTransient<RestClient>();
            return services;

        }

 
    }
}
