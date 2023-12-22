using ConsoleApiAdapter.Interfaces;
using Domain.Models.ConsoleModels;

namespace ConsoleApiAdapter.Services.Parser;

public class CommandHandler : IParserHandler
{
    private IParserHandler? _nextHandler;

    public void Handle(string? commandString, Command? command)
    {
        if (commandString is null || string.IsNullOrEmpty(commandString) || command is null) return;
        string? commandName = CommandGlossary.Commands.FirstOrDefault(commandString.StartsWith);
        if (commandName is null)
        {
            Console.WriteLine("Wrong command name");
            return;
        }

        command.CommandName = commandName;
        commandString = commandString.Replace(commandName, string.Empty, StringComparison.OrdinalIgnoreCase).Trim();
        _nextHandler?.Handle(commandString, command);
    }

    public IParserHandler SetNextHandler(IParserHandler handler)
    {
        _nextHandler = handler;
        return _nextHandler;
    }
}