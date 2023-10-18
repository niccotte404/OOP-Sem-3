using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models;
public sealed class CPUCoolingSystem
{
    public IEnumerable<string>? SupportedSockets { get; set; }
    public float? MaxTDP { get; set; }
    public FormFactor? FormFactor { get; set; }
}
