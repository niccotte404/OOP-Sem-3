using System;
using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
public class ClassE : ImpulseEngineBase
{
    public ClassE(bool antinitrinRadiation, double fuelAmount, double fuelLimit, int startVelocity)
        : base(antinitrinRadiation, fuelAmount, fuelLimit, (int)FuelConsumptionType.Medium, startVelocity)
    {
        Time = CountPathTime();
    }

    protected new int CountPathTime()
    {
        // через дискриминант находится время пути. по равноускоренному движению
        return (int)((Math.Sqrt((8 * StartVelocity) + (2 * PathLength * Math.Exp(1))) - (2 * StartVelocity)) / (2 * Math.Exp(1)));
    }
}
