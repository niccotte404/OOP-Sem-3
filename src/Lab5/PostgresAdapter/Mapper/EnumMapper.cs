using Domain.Data.Enums;
using Itmo.Dev.Platform.Postgres.Plugins;
using Npgsql;

namespace PostgresAdapter.Mapper;

public class EnumMapper : IDataSourcePlugin
{
    public void Configure(NpgsqlDataSourceBuilder builder)
    {
        builder?.MapEnum<Roles>();
    }
}