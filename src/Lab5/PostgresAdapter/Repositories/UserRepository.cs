using System.Globalization;
using Domain.Data.Enums;
using Domain.Models;
using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
using Npgsql;
using Ports.Ports;

namespace PostgresAdapter.Repositories;

public class UserRepository : IUserDbRepository
{
    private readonly IPostgresConnectionProvider _connectionProvider;
    public UserRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public void CreateUser(AccountData account)
    {
        string query =
            """
            insert into users (username, pincode, balance, role)
            values (:userName, :pin, :userBalance, :userRole)
            """;

        NpgsqlConnection connection = _connectionProvider
            .GetConnectionAsync(default).AsTask()
            .GetAwaiter()
            .GetResult();

        using var command = new NpgsqlCommand(query, connection);
        command.AddParameter("pin", account?.Pincode)
            .AddParameter("userBalance", account?.Balance)
            .AddParameter("userRole", Convert.ToInt32(account?.Role, new NumberFormatInfo()))
            .AddParameter("userName", account?.UserName);

        command.ExecuteNonQuery();
    }

    public AccountData? GetUserDataByName(string? userName)
    {
        string query =
            """
            select userid, pincode, balance, role
            from users
            where username = :name
            """;

        NpgsqlConnection connection = _connectionProvider
            .GetConnectionAsync(default).AsTask()
            .GetAwaiter()
            .GetResult();

        using var command = new NpgsqlCommand(query, connection);
        command.AddParameter("name", userName);

        using NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read() is false)
            return null;

        return new AccountData(
            userId: $"{reader.GetInt32(0)}",
            userName: userName,
            pincode: reader.GetString(1),
            balance: reader.GetInt32(2),
            role: (Roles)reader.GetInt32(3));
    }

    public AccountData? GetUserDataById(string? userId)
    {
        string query =
            """
            select username, pincode, balance, role
            from users
            where userid = :id
            """;

        NpgsqlConnection connection = _connectionProvider
            .GetConnectionAsync(default).AsTask()
            .GetAwaiter()
            .GetResult();

        using var command = new NpgsqlCommand(query, connection);
        command.AddParameter("id", Convert.ToInt32(userId, new NumberFormatInfo()));

        using NpgsqlDataReader reader = command.ExecuteReader();

        if (reader.Read() is false)
            return null;

        return new AccountData(
            userId: userId,
            userName: reader.GetString(0),
            pincode: reader.GetString(1),
            balance: reader.GetInt32(2),
            role: (Roles)reader.GetInt32(3));
    }

    public void SetBalance(string userId, decimal balance)
    {
        string query =
            """
            update users
            set balance = :newBalance
            where userid = :id
            """;

        NpgsqlConnection connection = _connectionProvider
            .GetConnectionAsync(default).AsTask()
            .GetAwaiter()
            .GetResult();

        using var command = new NpgsqlCommand(query, connection);
        command.AddParameter("newBalance", balance);
        command.AddParameter("id", userId);

        command.ExecuteNonQuery();
    }
}