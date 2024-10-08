using FlightData.BusinessLogic.Config;
using FlightData.Repositories.Config;

namespace FlightData.API.Config;

public static class ServiceCollectionExtension
{
    public static IServiceCollection AddDependencyServices(this IServiceCollection services)
    {
        return services
            .AddRepositories()
            .AddBusinessLogicServices();
    }
}