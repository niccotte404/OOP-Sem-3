using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.RequiredComponents;
public sealed class CPUCoolingSystem
{
    public CPUCoolingSystem(IEnumerable<string> supportedSockets, float maxTDP, FormFactor formFactor)
    {
        SupportedSockets = supportedSockets;
        FormFactor = formFactor;
        MaxTDP = maxTDP;
    }

    public IEnumerable<string> SupportedSockets { get; init; }
    public float MaxTDP { get; init; }

    [ForeignKey("FormFactor")]
    public FormFactor FormFactor { get; init; }
}
