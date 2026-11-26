using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Documato.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        // Register persistence and external service adapters here.
        return services;
    }
}
