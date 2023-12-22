namespace Domain.Models;

public class HistoryData
{
    public HistoryData(string userId, string? message)
    {
        UserId = userId;
        Message = message;
    }

    public string UserId { get; init; }
    public string? Message { get; init; }
}
