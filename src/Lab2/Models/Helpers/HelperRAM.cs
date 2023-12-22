using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Helpers;
public sealed class HelperRAM
{
    public int? MemoryAmount { get; set; }
    public IEnumerable<FrequensyAndJEDEC>? FrequencyAndJEDEC { get; set; }
    public IEnumerable<HelperXMPProfile>? SupportedXMP { get; set; }
    public FormFactor? FormFactor { get; set; }
    public string? DDR { get; set; }
    public float? PowerConsumption { get; set; }
}
