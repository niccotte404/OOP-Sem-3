namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine;
public abstract class EngineBase
{
    public int PathLength { get; set; }
    public double FuelAmount { get; init; }
    public bool AntinitrinRadiation { get; init; }
    protected double FuelLimit { get; set; }
    protected int Time { get; set; }
    protected int FuelConsumption { get; init; }
    public bool IsFuelEnough()
    {
        return FuelAmount - (Time * FuelConsumption) >= 0;
    }
}
