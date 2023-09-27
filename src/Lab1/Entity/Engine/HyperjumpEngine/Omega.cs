using System;
using Itmo.ObjectOrientedProgramming.Lab1.Enum;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
public class Omega : HyperjumpEngineBase
{
    public Omega(int pathLength, double fuelAmount, double fuelLimit)
        : base(pathLength, fuelAmount, fuelLimit, OmegaConsumption((int)FuelConsumptionType.Medium)) { }

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
