using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models;
public record HelperBIOS
{
    public string? Type { get; set; }
    public string? Version { get; set; }
    public IEnumerable<CPU>? SupportedCPU { get; set; }
}
