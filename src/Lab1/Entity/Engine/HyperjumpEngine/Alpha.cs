namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
internal class Alpha : HyperjumpEngineBase
{
    public Alpha(int pathLength, int fuelConsumption, double fuelAmount, double fuelLimit)
        : base(pathLength, fuelAmount, fuelLimit)
    {
        FuelConsumption = fuelConsumption;
    }
}
