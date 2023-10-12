namespace Itmo.ObjectOrientedProgramming.Lab2.Models.RequiredComponents;
public sealed class PowerUnit
{
    public PowerUnit(float maxPower)
    {
        MaxPower = maxPower;
    }

    public float MaxPower { get; init; }
}
