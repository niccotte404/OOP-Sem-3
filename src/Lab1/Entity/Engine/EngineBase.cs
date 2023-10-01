namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine;
public abstract class EngineBase
{
    public int RemainingFuel => Time * FuelConsumption;
    public int PathLength { get; set; }
    public bool AntinitrinRadiation { get; init; }
    public int FuelCategory { get; init; }
    protected int Time { get; set; }
    protected int FuelConsumption { get; init; }
    public bool IsFuelEnough() => RemainingFuel >= 0;
    public void GetPath(int pathLength) => PathLength = pathLength;
}
