using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders;
public class CPUCoolingSystemBuilder : ICPUCoolingSystemBuilder
{
    private CPUCoolingSystem _cpuCoolingSystem;
    private IEnumerable<string>? _sockets;
    private float _tdp;
    private FormFactor? _formFactor;
    public CPUCoolingSystemBuilder()
    {
        _cpuCoolingSystem = new CPUCoolingSystem(
            supportedSockets: _sockets,
            maxTDP: _tdp,
            formFactor: _formFactor);
    }

    public CPUCoolingSystem Build()
    {
        CPUCoolingSystem coolingSystem = _cpuCoolingSystem;
        return coolingSystem;
    }

    public ICPUCoolingSystemBuilder GetCoolingSystemFormFactor(FormFactor formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public ICPUCoolingSystemBuilder GetCoolingSystemSockets(IEnumerable<string> sockets)
    {
        _sockets = sockets;
        return this;
    }

    public ICPUCoolingSystemBuilder GetCoolingSystemTDP(float tdp)
    {
        _tdp = tdp;
        return this;
    }
}
