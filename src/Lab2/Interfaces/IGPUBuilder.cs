using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
public interface IGPUBuilder
{
    public GPU Build();
    public IGPUBuilder GetGpuVideoMemoryAmount(int memoryAmount);
    public IGPUBuilder GetGpuVersionPCI(string versionPCI);
    public IGPUBuilder GetGpuChipFrequency(int chipFrequency);
    public IGPUBuilder GetGpuPowerConsumption(float powerConsumprion);
    public IGPUBuilder GetGpuFormFactor(FormFactor formFactor);
}
