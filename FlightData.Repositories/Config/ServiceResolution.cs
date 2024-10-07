using FlightData.Repositories.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FlightData.Repositories.Config
{
    public static class ServiceResolution
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services
                .AddScoped<IRoleRepository, RoleRepository>();
        }
    }
}