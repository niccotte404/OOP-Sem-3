using System;
using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Engine.Fuel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
public class Omega : HyperjumpEngineBase
{
    public Omega()
        : base(OmegaConsumption((int)FuelConsumptionType.Medium), EngineHyperjumpRange.Medium) { }

    private static int OmegaConsumption(int fuelConsumption)
    {
        int result = 0;
        for (int i = 1; i < fuelConsumption + 1; i++)
        {
            result += (int)Math.Log(i);
        }

        return result;
    }
}
