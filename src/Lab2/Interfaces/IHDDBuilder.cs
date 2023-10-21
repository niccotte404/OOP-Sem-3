using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
public interface IHDDBuilder
{
    public HDD Build();
    public IHDDBuilder GetHddMemoryAmount(int memoryAmount);
    public IHDDBuilder GetHddSpinSpeed(int spinSpeed);
    public IHDDBuilder GetHddPowerConsumprion(float powerConsumption);
}
