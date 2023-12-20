﻿using System;
using System.IO;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Controllers.Commands;
public class MoveCommand : ICommand
{
    public void Execute(Command command)
    {
        if (command is null) return;

        FilterArguments(command);

        // FileInfo.MoveTo() cannot work 'cause of denied access
        File.Copy(command.CommandAtributes[0], command.CommandAtributes[1]);
        File.Delete(command.CommandAtributes[0]);
    }

    private static void FilterArguments(Command command)
    {
        if (command.FlagAtributes.Any() || command.CommandAtributes.Count != 2)
            throw new ArgumentException("Wrong command arguments");
    }
}