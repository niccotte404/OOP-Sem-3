using Itmo.Dev.Platform.Postgres.Extensions;
using Itmo.Dev.Platform.Postgres.Models;
using Microsoft.Extensions.DependencyInjection;
using PostgresAdapter.Migrations;

namespace Configurator.Extensions;

public static class Configuration
{
    public static IServiceCollection Configure(this IServiceCollection services, Action<PostgresConnectionConfiguration> configuration)
    {
        services.AddPlatformPostgres(builder => builder.Configure(configuration));
        services.AddPlatformMigrations(typeof(Init).Assembly);

        return services;
    }
}