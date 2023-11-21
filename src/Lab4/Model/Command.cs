using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab4.Model;
public record Command
{
    public Command()
    {
        CommandAtributes = new List<string>();
        FlagAtributes = new Dictionary<string, string>();
    }

    public string? CommandName { get; set; }
    public IList<string> CommandAtributes { get; init; }
    public IDictionary<string, string> FlagAtributes { get; init; }
}