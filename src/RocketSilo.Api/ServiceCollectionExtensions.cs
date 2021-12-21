using Microsoft.Extensions.DependencyInjection;

namespace RocketSilo.Api;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add required services for the RocketSilo API
    /// </summary>
    /// <param name="services">IServiceCollection</param>
    /// <param name="configureOpts">A configuration callback</param>
    /// <returns>The IServiceCollection, for chaining</returns>
    public static IServiceCollection AddRocketSilo(this IServiceCollection services, Action<RocketSiloConfig>? configureOpts = null)
    {
        services.AddOptions<RocketSiloConfig>()
            .Configure(configureOpts ?? (config => config.BaseUrl = RocketSiloConfig.DefaultBaseUrl))
            .Validate(config => config.Validate());
        services.AddHttpClient();
        services.AddSingleton<IClientFactory, ClientFactory>();
        return services;
    }

    /// <summary>
    /// Add required services for the RocketSilo API
    /// </summary>
    /// <param name="services">IServiceCollection</param>
    /// <param name="baseUrl">API base URL</param>
    /// <returns>The IServiceCollection, for chaining</returns>
    public static IServiceCollection AddRocketSilo(this IServiceCollection services, string baseUrl)
    {
        return services.AddRocketSilo(opts => opts.BaseUrl = baseUrl);
    }
}
