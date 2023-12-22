namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
public sealed class SSD
{
    public SSD(string? connectionOption, int memoryAmount, int maxDatatransferSpeed, float powerConsumprion)
    {
        ConnectionOption = connectionOption;
        MemoryAmount = memoryAmount;
        MaxDatatransferSpeed = maxDatatransferSpeed;
        PowerConsumprion = powerConsumprion;
    }

    public string? ConnectionOption { get; init; }
    public int MemoryAmount { get; init; }
    public int MaxDatatransferSpeed { get; init; }
    public float PowerConsumprion { get; init; }
}
