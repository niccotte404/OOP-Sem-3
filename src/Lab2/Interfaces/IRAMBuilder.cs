using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
public interface IRAMBuilder
{
    public RAM Build();
    public IRAMBuilder GetRamMemoryAmount(int memoryAmount);
    public IRAMBuilder GetRamFrequencyAndJEDEC(IEnumerable<FrequensyAndJEDEC> frequencyAndJEDEC);
    public IRAMBuilder GetRamSupportedXMP(IEnumerable<XMPProfile> xmps);
    public IRAMBuilder GetRamDDR(string ddr);
    public IRAMBuilder GetRamFormFactor(FormFactor formFactor);
    public IRAMBuilder GetRamPowerConsumption(float powerConsumption);
}
