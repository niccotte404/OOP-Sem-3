using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
public sealed class CPUCoolingSystem
{
    public CPUCoolingSystem(IEnumerable<string>? supportedSockets, float maxTDP, FormFactor? formFactor)
    {
        SupportedSockets = supportedSockets;
        MaxTDP = maxTDP;
        FormFactor = formFactor;
    }

    public IEnumerable<string>? SupportedSockets { get; init; }
    public float MaxTDP { get; init; }
    public FormFactor? FormFactor { get; init; }
}
