using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Helpers;
public sealed class HelperCPU
{
    public float? CoreFrequency { get; set; }
    public int? CoreAmount { get; set; }
    public string? Socket { get; set; }
    public bool? IGPU { get; set; }
    public IEnumerable<int>? SupportedMemoryFrequency { get; set; }
    public float? TDP { get; set; }
    public float? PowerConsumption { get; set; }
}
