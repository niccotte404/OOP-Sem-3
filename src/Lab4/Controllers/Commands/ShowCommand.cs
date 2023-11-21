using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Controllers.Commands;
public class ShowCommand : ICommand
{
    public void Execute(Command command)
    {
        if (command is null) return;

        FilterArguments(command);
        Console.WriteLine(File.ReadAllText(command.CommandAtributes[0]));
    }

    private static void FilterArguments(Command command)
    {
        string? mode;
        command.FlagAtributes.TryGetValue("-m", out mode);

        if (mode != "console" || command.CommandAtributes.Count != 1)
            throw new ArgumentException("Wrong command arguments");
        Context.Mode = mode;
    }
}
