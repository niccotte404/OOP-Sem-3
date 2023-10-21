using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders;
public class CPUBuilder : ICPUBuilder
{
    private CPU _cpu;
    private float _coreFrequency;
    private int _coreAmount;
    private string? _socket;
    private bool _igpu;
    private IEnumerable<int>? _supportedMemoryFrequency;
    private float _tdp;
    private float _powerConsumption;
    public CPUBuilder()
    {
        _cpu = new CPU(
            coreAmount: _coreAmount,
            coreFrequency: _coreFrequency,
            socket: _socket,
            iGPU: _igpu,
            supportedMemoryFrequency: _supportedMemoryFrequency,
            tDP: _tdp,
            powerConsumption: _powerConsumption);
    }

    public CPU Build()
    {
        CPU cpu = _cpu;
        return cpu;
    }

    public ICPUBuilder GetCpuCoreAmount(int coreAmount)
    {
        _coreAmount = coreAmount;
        return this;
    }

    public ICPUBuilder GetCpuCoreFrequency(float coreFrequency)
    {
        _coreFrequency = coreFrequency;
        return this;
    }

    public ICPUBuilder GetCpuGPU(bool igpu)
    {
        _igpu = igpu;
        return this;
    }

    public ICPUBuilder GetCpuPowerConsumprion(float powerComsumption)
    {
        _powerConsumption = powerComsumption;
        return this;
    }

    public ICPUBuilder GetCpuSocket(string socket)
    {
        _socket = socket;
        return this;
    }

    public ICPUBuilder GetCpuSupportedMemoryFrequency(IEnumerable<int> memoryFrequency)
    {
        _supportedMemoryFrequency = memoryFrequency;
        return this;
    }

    public ICPUBuilder GetCpuTDP(float tdp)
    {
        _tdp = tdp;
        return this;
    }
}
