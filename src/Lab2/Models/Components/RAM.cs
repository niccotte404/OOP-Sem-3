using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
public sealed class RAM
{
    public RAM(int memoryAmount, IEnumerable<FrequensyAndJEDEC>? frequencyAndJEDEC, IEnumerable<XMPProfile>? supportedXMP, FormFactor? formFactor, string? ddr, float powerConsumption)
    {
        MemoryAmount = memoryAmount;
        FrequencyAndJEDEC = frequencyAndJEDEC;
        SupportedXMP = supportedXMP;
        FormFactor = formFactor;
        DDR = ddr;
        PowerConsumption = powerConsumption;
    }

    public int MemoryAmount { get; init; }
    public IEnumerable<FrequensyAndJEDEC>? FrequencyAndJEDEC { get; init; }
    public IEnumerable<XMPProfile>? SupportedXMP { get; init; }
    public FormFactor? FormFactor { get; init; }
    public string? DDR { get; init; }
    public float PowerConsumption { get; init; }
}
