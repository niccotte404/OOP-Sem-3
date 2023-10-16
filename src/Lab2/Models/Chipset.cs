using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models;
public sealed class Chipset
{
    public IEnumerable<int>? SupportedMemoryFrequency { get; set; }
    public bool? SupportXMP { get; set; }
}
