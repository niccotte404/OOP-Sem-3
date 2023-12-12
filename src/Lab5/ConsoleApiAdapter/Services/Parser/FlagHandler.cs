using ConsoleApiAdapter.Interfaces;
using Domain.Models.ConsoleModels;

namespace ConsoleApiAdapter.Services.Parser;

public class FlagHandler : IParserHandler
{
    private IParserHandler? _nextHandler;
    public void Handle(string? commandString, Command? command)
    {
        if (commandString is null || string.IsNullOrEmpty(commandString) || command is null) return;

        string[] args = commandString.Split(' ');

        for (int i = 0; i < args.Length; i += 2)
        {
            if (command.FlagAttributes.ContainsKey(args[i]))
                continue;
            if (args[i].StartsWith('-'))
                command.FlagAttributes.Add(args[i], args[i + 1]);
            commandString = commandString.Replace(args[i], string.Empty, StringComparison.OrdinalIgnoreCase).Replace(args[i + 1], string.Empty, StringComparison.OrdinalIgnoreCase).Trim();
        }

        _nextHandler?.Handle(commandString, command);
    }

    public IParserHandler SetNextHandler(IParserHandler handler)
    {
        _nextHandler = handler;
        return _nextHandler;
    }
}