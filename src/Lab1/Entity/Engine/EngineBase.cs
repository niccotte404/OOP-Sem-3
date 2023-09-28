namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine;
public abstract class EngineBase
{
    public int RemainingFuel => (int)(FuelAmount - (Time * FuelConsumption));
    public int PathLength { get; set; }
    public double FuelAmount { get; init; }
    public bool AntinitrinRadiation { get; init; }
    protected double FuelLimit { get; set; }
    protected int Time { get; set; }
    protected int FuelConsumption { get; init; }
    public bool IsFuelEnough() => RemainingFuel >= 0;
    public void GetPath(int pathLength) => PathLength = pathLength;
}
