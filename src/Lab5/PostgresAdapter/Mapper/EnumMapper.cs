using Domain.Data.Enums;
using Npgsql;

namespace PostgresAdapter.Mapper;

public static class EnumMapper
{
    public static void Configure(NpgsqlDataSourceBuilder builder)
    {
        builder?.MapEnum<Roles>();
    }
}