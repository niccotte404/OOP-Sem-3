using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models;
public sealed class RAM
{
    public int? MemoryAmount { get; set; }
    public IEnumerable<(int, int)>? MemoryFrequencyAndJEDEC { get; set; }
    public IEnumerable<XMPProfile>? SupportedXMP { get; set; }
    public FormFactor? FormFactor { get; set; }
    public string? DDR { get; set; }
    public float? PowerConsumption { get; set; }
}
