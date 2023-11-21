using System;
using System.IO;
using System.Linq;
using System.Text;
using Itmo.ObjectOrientedProgramming.Lab4.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Controllers.Commands;
public class TreeListCommand : ICommand
{
    private readonly StringBuilder _sb;
    private int _depth;
    public TreeListCommand()
    {
        _sb = new StringBuilder();
    }

    public void Execute(Command command)
    {
        if (command is null || Context.Path is null) return;
        FilterArguments(command);
        TreeListOutput(Context.Path);

        string output = _sb.ToString();
        Console.WriteLine(output);
    }

    private void FilterArguments(Command command)
    {
        if (command.CommandAtributes.Count > 1)
            throw new ArgumentException("Wrong command atribute");

        string? depth;
        command.FlagAtributes.TryGetValue("-d", out depth);
        _ = int.TryParse(depth, out _depth);
    }

    private void TreeListOutput(string executingDirectory, int depth = 0, string prefix = "")
    {
        if (depth >= _depth) return;

        var directory = new DirectoryInfo(executingDirectory);
        var items = directory.GetFileSystemInfos()
            .OrderBy(f => f.Name)
            .ToList();

        foreach (FileSystemInfo? item in items.Take(items.Count - 1))
        {
            string row = $"{prefix}{Context.DirectoryPrefix}{item.Name}";
            _sb.Append(row);
            _sb.AppendLine();
            if ((item.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
                TreeListOutput(item.FullName, depth + 1, $"{prefix}{Context.CommonPrefix}");
        }

        FileSystemInfo? lastItem = items.LastOrDefault();

        if (lastItem is null) return;

        string lastRow = $"{prefix}{Context.LastDirectoryPrefix}{lastItem.Name}";
        _sb.Append(lastRow);
        _sb.AppendLine();
        if ((lastItem.Attributes & FileAttributes.Directory) == FileAttributes.Directory)
            TreeListOutput(lastItem.FullName, depth + 1, $"{prefix}{Context.LastPrefix}");
    }
}