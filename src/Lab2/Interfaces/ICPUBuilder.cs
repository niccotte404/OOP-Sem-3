using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
public interface ICPUBuilder
{
    public CPU Build();
    public ICPUBuilder GetCpuCoreFrequency(float coreFrequency);
    public ICPUBuilder GetCpuCoreAmount(int coreAmount);
    public ICPUBuilder GetCpuSocket(string socket);
    public ICPUBuilder GetCpuGPU(bool igpu);
    public ICPUBuilder GetCpuSupportedMemoryFrequency(IEnumerable<int> memoryFrequency);
    public ICPUBuilder GetCpuTDP(float tdp);
    public ICPUBuilder GetCpuPowerConsumprion(float powerComsumption);
}
