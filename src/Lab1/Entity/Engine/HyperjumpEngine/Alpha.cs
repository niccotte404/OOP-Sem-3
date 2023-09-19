using Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
internal class Alpha : HyperjumpEngineBase
{
    public Alpha(int pathLength, double fuelAmount = 100)
    {
        FuelLimit = 100;
        Time = CountPathTime(pathLength);
        FuelConsumption = CountFuelConsumption(5);
        if (EngineValidation.IsFuelAmountValid(fuelAmount, FuelLimit)) FuelAmount = fuelAmount;
    }
}
