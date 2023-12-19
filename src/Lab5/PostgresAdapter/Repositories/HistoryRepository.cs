using System.Collections.Immutable;
using System.Globalization;
using Domain.Models;
using Itmo.Dev.Platform.Postgres.Connection;
using Itmo.Dev.Platform.Postgres.Extensions;
using Npgsql;
using Ports.Ports;

namespace PostgresAdapter.Repositories;

public class HistoryRepository : IHistoryDbRepository
{
    private readonly IPostgresConnectionProvider _connectionProvider;
    public HistoryRepository(IPostgresConnectionProvider connectionProvider)
    {
        _connectionProvider = connectionProvider;
    }

    public void AddHistoryData(HistoryData historyData)
    {
        string query =
            """
            insert into history (userid, logmessage)
            values (:id, :message)
            """;

        NpgsqlConnection connection = _connectionProvider
            .GetConnectionAsync(default).AsTask()
            .GetAwaiter()
            .GetResult();

        using var command = new NpgsqlCommand(query, connection);
        command.AddParameter("id", Convert.ToInt32(historyData?.UserId, new NumberFormatInfo()))
            .AddParameter("message", historyData?.Message);

        command.ExecuteNonQuery();
    }

    public ImmutableList<HistoryData>? GetHistoryData(string userId)
    {
        string query =
            """
            select logmessage
            from history
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

        IList<HistoryData> userHistory = new List<HistoryData>();
        while (reader.HasRows)
        {
            userHistory.Add(new HistoryData(
                userId: userId,
                message: reader.GetString(0)));
            if (reader.Read() is false) break;
        }

        return userHistory.ToImmutableList();
    }
}