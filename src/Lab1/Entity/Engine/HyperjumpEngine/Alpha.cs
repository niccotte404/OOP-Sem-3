using Itmo.ObjectOrientedProgramming.Lab1.Enum;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
public class Alpha : HyperjumpEngineBase
{
    public Alpha(int pathLength, double fuelAmount, double fuelLimit)
        : base(pathLength, fuelAmount, fuelLimit, (int)FuelConsumptionType.Little) { }
}
