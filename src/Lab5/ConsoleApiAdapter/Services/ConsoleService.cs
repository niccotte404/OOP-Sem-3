using ConsoleApiAdapter.Services.Parser;
using Domain.Models.ConsoleModels;
using Ports.Ports;

namespace ConsoleApiAdapter.Services;

public class ConsoleService : IConsoleService
{
    public void WriteMassage(string? message) => Console.WriteLine(message);

    public Command GetMessage(string? commandString)
    {
        var parser = new ConsoleParser();
        parser.Parse(commandString);
        return parser.Command;
    }
}