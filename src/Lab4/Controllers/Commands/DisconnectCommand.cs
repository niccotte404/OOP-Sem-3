using System;
using System.IO;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Controllers.Commands;
public class DisconnectCommand : ICommand
{
    public void Execute(Command command)
    {
        FilterArguments(command);
        string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
        Directory.SetCurrentDirectory(path);
        Environment.Exit(0);
    }

    private static void FilterArguments(Command command)
    {
        if (command is null) return;

        if (command.CommandAtributes.Any() || command.FlagAtributes.Any())
            throw new ArgumentException("Wrong command arguments");
    }
}
