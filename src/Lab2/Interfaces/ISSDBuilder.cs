using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
public interface ISSDBuilder
{
    public SSD Build();
    public ISSDBuilder GetSsdConnectionOption(string connectionOption);
    public ISSDBuilder GetSsdMemoryAmount(int memoryAmount);
    public ISSDBuilder GetSsdDatatransferSpeed(int datatransferSpeed);
    public ISSDBuilder GetSsdPowerConsumprion(float powerConsumption);
}
