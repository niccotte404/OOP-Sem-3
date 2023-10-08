using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Engine.Fuel;

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

    public double StartVelocity { get; protected set; }

    protected int CountPathTime()
    {
        // вычисление времени по равномерному движению
        return (int)(PathLength / StartVelocity);
    }
}
