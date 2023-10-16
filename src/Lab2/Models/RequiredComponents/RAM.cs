using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.NoneRequiredComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.RequiredComponents;
public sealed class RAM
{
    public int? MemoryAmount { get; set; }
    public IEnumerable<(int, int)>? MemoryFrequencyAndJEDEC { get; set; }
    public IEnumerable<XMPProfile>? SupportedXMP { get; set; }
    public FormFactor? FormFactor { get; set; }
    public string? DDR { get; set; }
    public float? PowerConsumption { get; set; }
}
