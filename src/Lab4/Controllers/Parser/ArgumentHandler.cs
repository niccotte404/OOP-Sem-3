using System;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Controllers.Parser;
public class ArgumentHandler : ParserHandler
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

        string[] args = cmd.Split(' ');

        foreach (string arg in args)
        {
            if (arg.StartsWith('-') || string.IsNullOrEmpty(cmd.Trim()))
                break;
            command.CommandAtributes.Add(arg);
            cmd = cmd.Replace(arg, string.Empty, StringComparison.OrdinalIgnoreCase).Trim();
        }

        if (cmd.StartsWith('-'))
            _nextHandler?.Handle(cmd, command);
    }
}
