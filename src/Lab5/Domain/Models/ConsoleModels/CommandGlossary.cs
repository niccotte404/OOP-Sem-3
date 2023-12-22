namespace Domain.Models.ConsoleModels;

public static class CommandGlossary
{
    public static IList<string> Commands { get; } = new List<string>()
    {
        "create",
        "login",
        "logout",
        "show balance",
        "decrease",
        "increase",
        "history",
    };
}