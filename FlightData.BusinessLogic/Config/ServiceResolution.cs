using FlightData.BusinessLogic.Services;
using Microsoft.Extensions.DependencyInjection;

namespace FlightData.BusinessLogic.Config
{
    public static class ServiceResolution
    {
        public static IServiceCollection AddBusinessLogicServices(this IServiceCollection services)
        {
            return services
                .AddScoped<IRoleService, RoleService>();
        }
    }
}