using System;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Controllers.Parser;
public class FlagHandler : ParserHandler
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

        for (int i = 0; i < args.Length; i += 2)
        {
            if (command.FlagAtributes.ContainsKey(args[i]))
                continue;
            else if (args[i].StartsWith('-'))
                command.FlagAtributes.Add(args[i], args[i + 1]);
            else
                i--;
            cmd = cmd.Replace(args[i], string.Empty, StringComparison.OrdinalIgnoreCase).Replace(args[i + 1], string.Empty, StringComparison.OrdinalIgnoreCase).Trim();
        }

        _nextHandler?.Handle(cmd, command);
    }
}
