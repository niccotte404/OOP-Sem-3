namespace Domain.Models.ConsoleModels;

public static class AvailableFlags
{
    public static IList<string> CreateCommandFlags { get; } = new List<string>() { "-n", "-p" };
    public static IList<string> LogInCommandFlags { get; } = new List<string>() { "-m", "-n", "-p" };
    public static IList<string> ShowBalanceCommandFlags { get; } = new List<string>();
    public static IList<string> DecreaseBalanceCommandFlags { get; } = new List<string>() { "-b" };
    public static IList<string> IncreaseBalanceCommandFlags { get; } = new List<string>() { "-b" };
    public static IList<string> HistoryCommandFlags { get; } = new List<string>();
}