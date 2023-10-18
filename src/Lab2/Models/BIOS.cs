using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models;
public sealed class BIOS
{
    public string? Type { get; set; }
    public string? Version { get; set; }
    public IEnumerable<CPU>? SupportedCPU { get; set; }
}
