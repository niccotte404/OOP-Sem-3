using System;
using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
public class Omega : HyperjumpEngineBase
{
    public Omega(double fuelAmount, double fuelLimit, int avalibleJumpAmount)
        : base(fuelAmount, fuelLimit, OmegaConsumption((int)FuelConsumptionType.Medium), avalibleJumpAmount) { }

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
