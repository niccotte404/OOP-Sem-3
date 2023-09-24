using Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
internal abstract class ImpulseEngineBase : EngineBase
{
    public ImpulseEngineBase(int pathLength, bool antinitrinRatioation, double fuelAmount, double fuelLimit, double fuelConsumprion, int startVelocity)
    {
        FuelConsumption = fuelConsumprion;
        StartVelocity = startVelocity;
        FuelLimit = fuelLimit;
        AntinitrinRadiation = antinitrinRatioation;
        Time = CountPathTime(pathLength);
        if (EngineValidation.IsFuelAmountValid(fuelAmount, FuelLimit)) FuelAmount = fuelAmount;
    }

    protected double StartVelocity { get; init; }
    protected int CountPathTime(int pathLength)
    {
        // вычисление времени по равномерному движению
        return (int)(pathLength / StartVelocity);
    }
}
