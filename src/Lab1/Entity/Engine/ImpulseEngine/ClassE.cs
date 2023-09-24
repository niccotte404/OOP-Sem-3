using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
internal class ClassE : ImpulseEngineBase
{
    public ClassE(int pathLength, bool antinitrinRadiation, double fuelAmount, double fuelConsumption, int startVelocity, double fuelLimit)
        : base(pathLength, antinitrinRadiation, fuelAmount, fuelLimit, fuelConsumption, startVelocity)
    {
        Time = CountPathTime(pathLength);
    }

    protected new int CountPathTime(int pathLength)
    {
        // через дискриминант находится время пути. по равноускоренному движению
        return (int)((Math.Sqrt((8 * StartVelocity) + (2 * pathLength * Math.Exp(1))) - (2 * StartVelocity)) / (2 * Math.Exp(1)));
    }
}
