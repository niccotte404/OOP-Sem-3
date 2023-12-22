using System.Globalization;
using Domain.Data.Enums;
using Domain.Models;
using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
using Npgsql;
using Ports.Ports;

namespace PostgresAdapter.Repositories;

public class AdminRepository : IAdminDbRepository
{
    private readonly IPostgresConnectionProvider _connectionProvider;
    public AdminRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public void CreateAdmin(AdminData admin)
    {
        string query =
            """
            insert into admins (adminname, password, role)
            values (:adminName, :adminPassword, :adminRole)
            """;

        NpgsqlConnection connection = _connectionProvider
            .GetConnectionAsync(default).AsTask()
            .GetAwaiter()
            .GetResult();

        using var command = new NpgsqlCommand(query, connection);
        command.AddParameter("adminPassword", admin?.Password)
            .AddParameter("adminRole", Convert.ToInt32(admin?.Role, new NumberFormatInfo()))
            .AddParameter("adminName", admin?.UserName);

        command.ExecuteNonQuery();
    }

    public AdminData? GetAdminDataByName(string? adminName)
    {
        string query =
            """
            select adminid, password, role
            from admins
            where adminname = :name
            """;

        NpgsqlConnection connection = _connectionProvider
            .GetConnectionAsync(default).AsTask()
            .GetAwaiter()
            .GetResult();

        using var command = new NpgsqlCommand(query, connection);
        command.AddParameter("name", adminName);

        using NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read() is false)
            return null;

        return new AdminData(
            userId: $"{reader.GetInt32(0)}",
            userName: adminName,
            password: reader.GetString(1),
            role: (Roles)reader.GetInt32(2));
    }
}