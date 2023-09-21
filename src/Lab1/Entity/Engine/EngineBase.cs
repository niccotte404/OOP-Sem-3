namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine;
internal abstract class EngineBase
{
    public double FuelConsumption { get; init; }
    public double FuelAmount { get; init; }
    public bool AntinitrinRadiation { get; init; }
    protected double FuelLimit { get; set; }
    protected int Time { get; set; }
    public bool IsFuelEnough()
    {
        return FuelAmount - (Time * FuelConsumption) >= 0;
    }
}
