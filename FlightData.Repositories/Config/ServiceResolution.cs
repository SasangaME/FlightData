using Microsoft.Extensions.DependencyInjection;

namespace FlightData.Repositories.Config
{
    public static class ServiceResolution
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            return services;
        }
    }
}
