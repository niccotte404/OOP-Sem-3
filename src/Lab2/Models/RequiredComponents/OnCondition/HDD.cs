namespace Itmo.ObjectOrientedProgramming.Lab2.Models.RequiredComponents.OnCondition;
public sealed class HDD
{
    public HDD(int memoryAmount, int spinSpeed, float powerConsumprion)
    {
        MemoryAmount = memoryAmount;
        SpinSpeed = spinSpeed;
        PowerConsumprion = powerConsumprion;
    }

    public int MemoryAmount { get; init; }
    public int SpinSpeed { get; init; }
    public float PowerConsumprion { get; init; }
}
