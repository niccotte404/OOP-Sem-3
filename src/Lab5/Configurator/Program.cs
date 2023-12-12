using Configurator.Extensions;
using Itmo.Dev.Platform.Postgres.Extensions;
using Microsoft.Extensions.DependencyInjection;

var collection = new ServiceCollection();

collection
    .AddApplication()
    .Configure(configuration =>
    {
        configuration.Host = "localhost";
        configuration.Port = 5432;
        configuration.Username = "app";
        configuration.Password = "app";
        configuration.Database = "mydb";
        configuration.SslMode = "Prefer";
    });

ServiceProvider provider = collection.BuildServiceProvider();
using IServiceScope scope = provider.CreateScope();

scope.UsePlatformMigrationsAsync(default).GetAwaiter().GetResult();