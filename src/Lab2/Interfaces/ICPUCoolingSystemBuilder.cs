using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
public interface ICPUCoolingSystemBuilder
{
    public CPUCoolingSystem Build();
    public ICPUCoolingSystemBuilder GetCoolingSystemSockets(IEnumerable<string> sockets);
    public ICPUCoolingSystemBuilder GetCoolingSystemTDP(float tdp);
    public ICPUCoolingSystemBuilder GetCoolingSystemFormFactor(FormFactor formFactor);
}
