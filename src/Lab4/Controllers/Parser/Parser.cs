using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Controllers.Parser;
public class Parser
{
    private readonly ParserHandler _cmdHandler;
    public Parser()
    {
        Command = new Command();
        _cmdHandler = new CommandHandler();
        _cmdHandler.SetNext(new ArgumentHandler()).SetNext(new FlagHandler());
    }

    public Command Command { get; init; }

    public void Parse(string command)
    {
        if (command is null) return;
        _cmdHandler.Handle(command, Command);
    }
}
