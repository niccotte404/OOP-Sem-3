using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders.Compositors;
public class CPUBuilder : ICPUBuilder
{
    private float _coreFrequency;
    private int _coreAmount;
    private string? _socket;
    private bool _igpu;
    private IEnumerable<int>? _supportedMemoryFrequency;
    private float _tdp;
    private float _powerConsumption;

    public CPU Build()
    {
        var cpu = new CPU(
            coreAmount: _coreAmount,
            coreFrequency: _coreFrequency,
            socket: _socket,
            igpu: _igpu,
            supportedMemoryFrequency: _supportedMemoryFrequency,
            tdp: _tdp,
            powerConsumption: _powerConsumption);
        ValidateComponents.IsCPUValid(cpu);
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
