using ConsoleApiAdapter.Interfaces;
using Domain.Models.ConsoleModels;

namespace ConsoleApiAdapter.Services.Parser;

public class ConsoleParser
{
    private IParserHandler _handler;
    public ConsoleParser()
    {
        Command = new Command();
        _handler = new CommandHandler();
        _handler.SetNextHandler(new FlagHandler());
    }

    public Command Command { get; init; }

    public void Parse(string? commandString) => _handler.Handle(commandString, Command);
}