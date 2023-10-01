using System;
using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum.Engine.Fuel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
public class Omega : HyperjumpEngineBase
{
    public Omega()
        : base(OmegaConsumption((int)FuelConsumptionType.Medium), (int)FuelConsumptionPerJump.Medium) { }

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
