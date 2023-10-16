using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.RequiredComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.NoneRequiredComponents;
public sealed class BIOS
{
    public string? Type { get; set; }
    public string? Version { get; set; }
    public IEnumerable<CPU>? SupportedCPU { get; set; }
}
