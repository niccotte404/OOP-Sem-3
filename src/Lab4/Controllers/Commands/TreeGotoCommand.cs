using System;
using System.IO;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Controllers.Commands;
public class TreeGotoCommand : ICommand
{
    public void Execute(Command command)
    {
        if (command is null) return;

        FilterArguments(command);
        Context.Path = command.CommandAtributes.First();
        Directory.SetCurrentDirectory(command.CommandAtributes[0]);
    }

    private static void FilterArguments(Command command)
    {
        if (command.FlagAtributes.Any() || command.CommandAtributes.Count != 1)
            throw new ArgumentException("Wrong command arguments");
    }
}