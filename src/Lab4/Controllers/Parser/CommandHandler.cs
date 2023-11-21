using System;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Controllers.Parser;
public class CommandHandler : ParserHandler
{
    private ParserHandler? _nextHandler;
    public override ParserHandler SetNext(ParserHandler handler)
    {
        _nextHandler = handler;
        return _nextHandler;
    }

    public override void Handle(string cmd, Command command)
    {
        if (cmd is null || string.IsNullOrEmpty(cmd) || command is null) return;

        string? cmdName = Glossary.Commands.FirstOrDefault(cmd.StartsWith);
        if (cmdName is null)
            throw new ArgumentException("Wrong command name");

        command.CommandName = cmdName;
        cmd = cmd.Replace(cmdName, string.Empty, StringComparison.OrdinalIgnoreCase).Trim();

        _nextHandler?.Handle(cmd, command);
    }
}