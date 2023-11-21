using System;
using System.IO;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Controllers.Commands;
public class CopyCommand : ICommand
{
    public void Execute(Command command)
    {
        if (command is null) return;

        FilterArguments(command);
        File.Copy(command.CommandAtributes[0], command.CommandAtributes[1]);
    }

    private static void FilterArguments(Command command)
    {
        if (command.FlagAtributes.Any() || command.CommandAtributes.Count != 2)
            throw new ArgumentException("Wrong command arguments");
    }
}
