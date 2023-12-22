namespace Itmo.ObjectOrientedProgramming.Lab4.Model;
public static class Context
{
    public static string? ConnectServer { get; set; }
    public static string? Mode { get; set; }
    public static string? Path { get; set; }
    public static string DirectoryPrefix { get; } = "├── ";
    public static string LastDirectoryPrefix { get; } = "└── ";
    public static string CommonPrefix { get; } = "│   ";
    public static string LastPrefix { get; } = "    ";
}
