using Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;

public abstract class HyperjumpEngineBase : EngineBase
{
    protected HyperjumpEngineBase(double fuelAmount, double fuelLimit, int fuelConsumption, int avalibleJumpAmount)
    {
        FuelLimit = fuelLimit;
        Time = CountPathTime();
        FuelConsumption = fuelConsumption * avalibleJumpAmount;
        if (EngineValidation.IsFuelAmountValid(fuelAmount, FuelLimit)) FuelAmount = fuelAmount;
    }

    protected int CountPathTime()
    {
        // количество прыжков
        return PathLength / FuelConsumption;
    }
}