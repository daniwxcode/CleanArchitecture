using Ocelot.DependencyInjection;

namespace API.Configurations;

public static class OcelotConfiguration
{
    public static IConfigurationBuilder ConfigureOcelot(this IConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.AddJsonFile("OcelotConfig.Json");
        return configurationBuilder;

    }
    public static IServiceCollection InstallOcelot(this IServiceCollection services)
    {
        services.AddOcelot();
        return services;
    }

}
