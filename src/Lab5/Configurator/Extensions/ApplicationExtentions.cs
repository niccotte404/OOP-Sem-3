using ConsoleApiAdapter.Services;
using Itmo.Dev.Platform.Postgres.Plugins;
using Microsoft.Extensions.DependencyInjection;
using Ports.Ports;
using PostgresAdapter.Mapper;
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
        services.AddSingleton<IDataSourcePlugin, EnumMapper>();

        return services;
    }
}