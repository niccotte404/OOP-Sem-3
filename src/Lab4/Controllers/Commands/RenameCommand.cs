using System;
using System.IO;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Controllers.Commands;
public class RenameCommand : ICommand
{
    public void Execute(Command command)
    {
        if (command is null) return;

        FilterArguments(command);
        string pathWithName = command.CommandAtributes[0];

        int indexOfName = pathWithName.LastIndexOf(Path.DirectorySeparatorChar);
        string directoryPath = pathWithName[..indexOfName];
        string newPath = Path.Combine(directoryPath, command.CommandAtributes[1]);

        File.Delete(newPath);
        File.Move(pathWithName, newPath);
        File.Delete(pathWithName);
    }

    private static void FilterArguments(Command command)
    {
        if (command.FlagAtributes.Any() || command.CommandAtributes.Count != 2)
            throw new ArgumentException("Wrong command arguments");
    }
}
