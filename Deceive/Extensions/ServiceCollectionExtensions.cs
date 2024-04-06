using Deceive.Commands;
using Microsoft.Extensions.DependencyInjection;

namespace Deceive.Extensions;

internal static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCommands(this IServiceCollection services)
    {
        services.AddTransient<OfflineCommand>();
        services.AddTransient<DisableCommand>();
        services.AddTransient<EnableCommand>();
        services.AddTransient<HelpCommand>();
        services.AddTransient<MobileCommand>();
        services.AddTransient<OnlineCommand>();
        services.AddTransient<StatusCommand>();

        return services;
    }
}
