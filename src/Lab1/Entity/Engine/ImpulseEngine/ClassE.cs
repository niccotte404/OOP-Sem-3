using System;
using Itmo.ObjectOrientedProgramming.Lab1.Enum;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
public class ClassE : ImpulseEngineBase
{
    public ClassE(int pathLength, bool antinitrinRadiation, double fuelAmount, double fuelLimit, int startVelocity)
        : base(pathLength, antinitrinRadiation, fuelAmount, fuelLimit, (int)FuelConsumptionType.Medium, startVelocity)
    {
        Time = CountPathTime(pathLength);
    }

    protected new int CountPathTime(int pathLength)
    {
        // через дискриминант находится время пути. по равноускоренному движению
        return (int)((Math.Sqrt((8 * StartVelocity) + (2 * pathLength * Math.Exp(1))) - (2 * StartVelocity)) / (2 * Math.Exp(1)));
    }
}
