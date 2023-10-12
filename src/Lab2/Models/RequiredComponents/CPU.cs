using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.RequiredComponents;
public sealed class CPU
{
    public CPU(int coreFrequency, int coreAmount, string socket, bool iGPU, IEnumerable<int> supportedMemoryFrequency, float tdp, float powerConsumption)
    {
        CoreFrequency = coreFrequency;
        CoreAmount = coreAmount;
        Socket = socket;
        IGPU = iGPU;
        SupportedMemoryFrequency = supportedMemoryFrequency;
        TDP = tdp;
        PowerConsumption = powerConsumption;
    }

    public int CoreFrequency { get; init; }
    public int CoreAmount { get; init; }
    public string Socket { get; init; }
    public bool IGPU { get; init; }
    public IEnumerable<int> SupportedMemoryFrequency { get; init; }
    public float TDP { get; init; }
    public float PowerConsumption { get; init; }
}
