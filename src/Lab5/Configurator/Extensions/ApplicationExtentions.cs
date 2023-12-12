using ConsoleApiAdapter.Services;
using Microsoft.Extensions.DependencyInjection;
using Ports.Ports;
using PostgresAdapter.Repositories;

namespace Configurator.Extensions;

public static class ApplicationExtentions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IAdminDbRepository, AdminRepository>();
        services.AddScoped<IUserDbRepository, UserRepository>();
        services.AddScoped<IHistoryDbRepository, HistoryRepository>();
        services.AddScoped<IConsoleService, ConsoleService>();

        return services;
    }
}