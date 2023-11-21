using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab4.Model;
public static class Glossary
{
    public static IList<string> Commands { get; } = new List<string>()
    {
        "connect",
        "disconnect",
        "tree goto",
        "tree list",
        "file show",
        "file move",
        "file copy",
        "file delete",
        "file rename",
    };
}
