using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders;
public class GPUBuilder : IGPUBuilder
{
    private GPU _gpu;
    private int _videoMemoryAmount;
    private string? _versionPCI;
    private int _chipFrequency;
    private float _powerConsumption;
    private FormFactor? _formFactor;
    public GPUBuilder()
    {
        _gpu = new GPU(
            videoMemoryAmount: _videoMemoryAmount,
            versionPCI: _versionPCI,
            chipFrequency: _chipFrequency,
            powerConsumption: _powerConsumption,
            formFactor: _formFactor);
    }

    public GPU Build()
    {
        GPU gpu = _gpu;
        return gpu;
    }

    public IGPUBuilder GetGpuChipFrequency(int chipFrequency)
    {
        _chipFrequency = chipFrequency;
        return this;
    }

    public IGPUBuilder GetGpuFormFactor(FormFactor formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public IGPUBuilder GetGpuPowerConsumption(float powerConsumprion)
    {
        _powerConsumption = powerConsumprion;
        return this;
    }

    public IGPUBuilder GetGpuVersionPCI(string versionPCI)
    {
        _versionPCI = versionPCI;
        return this;
    }

    public IGPUBuilder GetGpuVideoMemoryAmount(int memoryAmount)
    {
        _videoMemoryAmount = memoryAmount;
        return this;
    }
}
