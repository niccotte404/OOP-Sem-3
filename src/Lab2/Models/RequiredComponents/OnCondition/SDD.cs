using Itmo.ObjectOrientedProgramming.Lab2.Enums;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.RequiredComponents.OnCondition;
public sealed class SDD
{
    public SDD(ConnectionSSD connectionOption, int memoryAmount, int maxDatatransferSpeed, float powerConsumption)
    {
        ConnectionOption = connectionOption;
        MemoryAmount = memoryAmount;
        MaxDatatransferSpeed = maxDatatransferSpeed;
        PowerConsumprion = powerConsumption;
    }

    public ConnectionSSD ConnectionOption { get; init; }
    public int MemoryAmount { get; init; }
    public int MaxDatatransferSpeed { get; init; }
    public float PowerConsumprion { get; init; }
}
