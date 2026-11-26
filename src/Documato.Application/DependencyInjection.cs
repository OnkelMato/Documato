using Microsoft.Extensions.DependencyInjection;

namespace Documato.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        // Register application services, handlers, and pipeline behaviors here.
        return services;
    }
}
