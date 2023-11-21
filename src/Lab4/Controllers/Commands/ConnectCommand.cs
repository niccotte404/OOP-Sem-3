using System;
using System.IO;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Controllers.Commands;
public class ConnectCommand : ICommand
{
    public void Execute(Command command)
    {
        FilterArguments(command);
        string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        if (command is not null)
            Context.ConnectServer = command.CommandAtributes.First();

        Directory.SetCurrentDirectory(path);
    }

    private static void FilterArguments(Command command)
    {
        if (command is null) return;

        string? mode;
        command.FlagAtributes.TryGetValue("-m", out mode);

        if (mode != "local")
            throw new ArgumentException("Wrong command arguments");
    }
}