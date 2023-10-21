using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Helpers;
public sealed class HelperCoolingSystem
{
    public IEnumerable<string>? SupportedSockets { get; set; }
    public float? MaxTDP { get; set; }
    public FormFactor? FormFactor { get; set; }
}
