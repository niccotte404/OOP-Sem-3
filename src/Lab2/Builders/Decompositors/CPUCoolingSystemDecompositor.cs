using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders.Decompositors;
public class CPUCoolingSystemDecompositor : ICPUCoolingSystemBuilder
{
    private IEnumerable<string>? _sockets;
    private float _tdp;
    private FormFactor? _formFactor;
    private CPUCoolingSystem _coolingSystem;

    public CPUCoolingSystemDecompositor(CPUCoolingSystem coolingSystem)
    {
        _coolingSystem = coolingSystem;
        _tdp = _coolingSystem.MaxTDP;
        _formFactor = _coolingSystem.FormFactor;
        _sockets = _coolingSystem.SupportedSockets;
    }

    public CPUCoolingSystem Build()
    {
        var coolingSystem = new CPUCoolingSystem(
            supportedSockets: _sockets,
            maxTDP: _tdp,
            formFactor: _formFactor);
        ValidateComponents.IsCoolingSystemValid(coolingSystem);
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
