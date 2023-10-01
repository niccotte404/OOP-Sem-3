using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum.Engine.Fuel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
public abstract class ImpulseEngineBase : EngineBase
{
    protected ImpulseEngineBase(bool antinitrinRatioation, int fuelConsumprion)
    {
        FuelCategory = (int)FuelType.ActivePlazma;
        FuelConsumption = fuelConsumprion;
        StartVelocity = (int)ImpulseEngineStartVelocity.StandartVelocity;
        AntinitrinRadiation = antinitrinRatioation;
        Time = CountPathTime();
    }

    protected double StartVelocity { get; init; }
    protected int CountPathTime()
    {
        // вычисление времени по равномерному движению
        return (int)(PathLength / StartVelocity);
    }
}
