using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders.Compositors;
public class CPUCoolingSystemBuilder : ICPUCoolingSystemBuilder
{
    private IEnumerable<string>? _sockets;
    private float _tdp;
    private FormFactor? _formFactor;

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
