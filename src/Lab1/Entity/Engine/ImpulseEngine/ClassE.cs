using System;
using Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
internal class ClassE : ImpulseEngineBase
{
    public ClassE(int pathLength, bool antinitrinRadiation, double fuelAmount = 70)
    {
        FuelLimit = 70;
        FuelConsumption = 2;
        StartVelocity = 10;
        AntinitrinRadiation = antinitrinRadiation;
        Time = CountPathTime(pathLength);
        if (EngineValidation.IsFuelAmountValid(fuelAmount, FuelLimit)) FuelAmount = fuelAmount;
    }

    protected override int CountPathTime(int pathLength)
    {
        // через дискриминант находится время пути. по равноускоренному движению
        return (int)((Math.Sqrt((8 * StartVelocity) + (2 * pathLength * Math.Exp(1))) - (2 * StartVelocity)) / (2 * Math.Exp(1)));
    }
}
