using Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;

public abstract class HyperjumpEngineBase : EngineBase
{
    protected HyperjumpEngineBase(int pathLength, double fuelAmount, double fuelLimit, int fuelConsumption)
    {
        FuelLimit = fuelLimit;
        Time = CountPathTime(pathLength);
        FuelConsumption = fuelConsumption;
        if (EngineValidation.IsFuelAmountValid(fuelAmount, FuelLimit)) FuelAmount = fuelAmount;
    }

    protected int SubspaceRange { get; init; } = 10; // +-const, т.к. динамически не хочется запариваться и перегружать конструкторы классов движков

    protected int CountPathTime(int pathLength)
    {
        // количество прыжков
        return pathLength / SubspaceRange;
    }
}