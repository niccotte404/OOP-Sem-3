namespace Domain.Models.ConsoleModels;

public class Command
{
    public string? CommandName { get; set; }
    public IDictionary<string, string> FlagAttributes { get; init; } = new Dictionary<string, string>();
}