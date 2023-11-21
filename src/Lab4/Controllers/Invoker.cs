using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Controllers.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Controllers;
public class Invoker
{
    private static readonly ICommand _connect = new ConnectCommand();
    private static readonly ICommand _disconnect = new DisconnectCommand();
    private static readonly ICommand _treeGoto = new TreeGotoCommand();
    private static readonly ICommand _treeList = new TreeListCommand();
    private static readonly ICommand _fileShow = new ShowCommand();
    private static readonly ICommand _fileMove = new MoveCommand();
    private static readonly ICommand _fileCopy = new CopyCommand();
    private static readonly ICommand _fileDelete = new DeleteCommand();
    private static readonly ICommand _fileRename = new RenameCommand();
    private readonly Parser.Parser? _parser;
    private Command? _command;
    private Action<Command>? _executor;

    private IDictionary<string, Action<Command>> _commandMap = new Dictionary<string, Action<Command>>()
    {
        ["connect"] = _connect.Execute,
        ["disconnect"] = _disconnect.Execute,
        ["tree goto"] = _treeGoto.Execute,
        ["tree list"] = _treeList.Execute,
        ["file show"] = _fileShow.Execute,
        ["file move"] = _fileMove.Execute,
        ["file copy"] = _fileCopy.Execute,
        ["file delete"] = _fileDelete.Execute,
        ["file rename"] = _fileRename.Execute,
    };

    public Invoker()
    {
        _parser = new Parser.Parser();
    }

    public void ExecuteCommand(string? command)
    {
        if (_parser is null || command is null) return;

        _parser.Parse(command);
        _command = _parser.Command;

        if (_command is null || _command.CommandName is null) return;
        _commandMap.TryGetValue(_command.CommandName, out _executor);

        if (_executor is not null)
            _executor(_command);
    }
}
