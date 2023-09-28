using Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
public abstract class ImpulseEngineBase : EngineBase
{
    protected ImpulseEngineBase(bool antinitrinRatioation, double fuelAmount, double fuelLimit, int fuelConsumprion, int startVelocity)
    {
        FuelConsumption = fuelConsumprion;
        StartVelocity = startVelocity;
        FuelLimit = fuelLimit;
        AntinitrinRadiation = antinitrinRatioation;
        Time = CountPathTime();
        if (EngineValidation.IsFuelAmountValid(fuelAmount, FuelLimit)) FuelAmount = fuelAmount;
    }

    protected double StartVelocity { get; init; }
    protected int CountPathTime()
    {
        // вычисление времени по равномерному движению
        return (int)(PathLength / StartVelocity);
    }
}
