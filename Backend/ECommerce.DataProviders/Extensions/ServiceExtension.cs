using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.Data;

public static class ServiceExtension
{
    public static IServiceCollection ConfigureDataProviders(this IServiceCollection services, IConfiguration configuration) {
        return services;
    }
}
