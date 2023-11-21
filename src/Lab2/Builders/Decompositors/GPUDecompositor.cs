using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders.Decompositors;
public class GPUDecompositor : IGPUBuilder
{
    private int _videoMemoryAmount;
    private string? _versionPCI;
    private int _chipFrequency;
    private float _powerConsumption;
    private FormFactor? _formFactor;
    private GPU _gpu;

    public GPUDecompositor(GPU gpu)
    {
        _gpu = gpu;
        _videoMemoryAmount = _gpu.VideoMemoryAmount;
        _versionPCI = _gpu.VersionPCI;
        _chipFrequency = _gpu.ChipFrequency;
        _powerConsumption = _gpu.PowerConsumption;
        _formFactor = _gpu.FormFactor;
    }

    public GPU Build()
    {
        var gpu = new GPU(
            videoMemoryAmount: _videoMemoryAmount,
            versionPCI: _versionPCI,
            chipFrequency: _chipFrequency,
            powerConsumption: _powerConsumption,
            formFactor: _formFactor);
        ValidateComponents.IsGPUValid(gpu);
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
