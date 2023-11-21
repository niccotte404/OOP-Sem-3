using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Controllers;
using Itmo.ObjectOrientedProgramming.Lab4.Model;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab4.Tests.TestCommands;

public class Tests
{
    [Fact]
    public void TestConnectCommand()
    {
        string? command = "connect .. -m local";
        var invoker = new Invoker();
        invoker.ExecuteCommand(command);

        Assert.Equal("..", Context.ConnectServer);
    }

    [Fact]
    public void TestTreeGotoCommand()
    {
        string? command = "tree goto ..";
        var invoker = new Invoker();
        invoker.ExecuteCommand(command);

        Assert.Equal("..", Context.Path);
    }

    [Fact]
    public void TestTreeListCommand()
    {
        string? command = "tree goto ..";
        var invoker = new Invoker();
        invoker.ExecuteCommand(command);

        command = "tree list ..";
        invoker = new Invoker();
        invoker.ExecuteCommand(command);

        Assert.Equal("..", Context.Path);
    }

    [Fact]
    public void TestFileShowCommand()
    {
        string path = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "hello.txt"));
        string? command = $"file show {path} -m console";

        var fs = new FileStream(path, FileMode.OpenOrCreate);
        using (var stream = new StreamWriter(fs))
        {
            stream.WriteLine("hello");
        }

        var invoker = new Invoker();
        invoker.ExecuteCommand(command);

        Assert.Equal("console", Context.Mode);
    }

    [Fact]
    public void TestFileRenameCommand()
    {
        string oldPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "hello.txt"));
        string newPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "goodbye.txt"));
        string? command = $"file rename {oldPath} {newPath}";

        var fs = new FileStream(oldPath, FileMode.OpenOrCreate);
        using (var stream = new StreamWriter(fs))
        {
            stream.WriteLine("bye");
        }

        var invoker = new Invoker();
        invoker.ExecuteCommand(command);

        string? output;
        fs = new FileStream(newPath, FileMode.Open);
        using (var stream = new StreamReader(fs))
        {
            output = stream.ReadLine();
        }

        Assert.Equal("bye", output);
    }
}
