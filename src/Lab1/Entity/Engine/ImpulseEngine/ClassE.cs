using System;
using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Engine.Fuel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
public class ClassE : ImpulseEngineBase
{
    public ClassE(bool antinitrinRadiation)
        : base(antinitrinRadiation, (int)FuelConsumptionType.Medium)
    {
        CountClassETime();
    }

    protected void CountClassETime()
    {
        // find time by accelerate
        Time = (int)((Math.Sqrt((8 * StartVelocity) + (2 * PathLength * Math.Exp(1))) - (2 * StartVelocity)) / (2 * Math.Exp(1)));
        StartVelocity = (Time * Math.Exp(1)) - StartVelocity;
    }
}
