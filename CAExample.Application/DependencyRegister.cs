using CAExample.Application.Cities;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace CAExample.Application
{
    public static class DependencyRegister
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<ICityService, CityService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
