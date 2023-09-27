using Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
public abstract class ImpulseEngineBase : EngineBase
{
    protected ImpulseEngineBase(int pathLength, bool antinitrinRatioation, double fuelAmount, double fuelLimit, int fuelConsumprion, int startVelocity)
    {
        PathLength = pathLength;
        FuelConsumption = fuelConsumprion;
        StartVelocity = startVelocity;
        FuelLimit = fuelLimit;
        AntinitrinRadiation = antinitrinRatioation;
        Time = CountPathTime(PathLength);
        if (EngineValidation.IsFuelAmountValid(fuelAmount, FuelLimit)) FuelAmount = fuelAmount;
    }

    protected double StartVelocity { get; init; }
    protected int CountPathTime(int pathLength)
    {
        // вычисление времени по равномерному движению
        return (int)(pathLength / StartVelocity);
    }
}
