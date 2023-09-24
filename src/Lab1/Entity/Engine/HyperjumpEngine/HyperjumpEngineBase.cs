using Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;

internal abstract class HyperjumpEngineBase : EngineBase
{
    public HyperjumpEngineBase(int pathLength, double fuelAmount, double fuelLimit)
    {
        FuelLimit = fuelLimit;
        Time = CountPathTime(pathLength);
        if (EngineValidation.IsFuelAmountValid(fuelAmount, FuelLimit)) FuelAmount = fuelAmount;
    }

    protected int SubspaceRange { get; init; } = 10; // +-const, т.к. динамически не хочется запариваться и перегружать конструкторы классов движков

    protected int CountPathTime(int pathLength)
    {
        // количество прыжков
        return pathLength / SubspaceRange;
    }
}