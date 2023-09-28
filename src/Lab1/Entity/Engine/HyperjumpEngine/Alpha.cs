using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
public class Alpha : HyperjumpEngineBase
{
    public Alpha(double fuelAmount, double fuelLimit, int avalibleJumpAmount)
        : base(fuelAmount, fuelLimit, (int)FuelConsumptionType.Little, avalibleJumpAmount) { }
}
