using System;
using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
public class Gamma : HyperjumpEngineBase
{
    public Gamma(double fuelAmount, double fuelLimit, int avalibleJumpAmount)
        : base(fuelAmount, fuelLimit, GammaConsumption((int)FuelConsumptionType.Huge), avalibleJumpAmount) { }

    private static int GammaConsumption(int fuelConsumption)
    {
        int result = 0;
        for (int i = 1; i < fuelConsumption + 1; i++)
        {
            result += (int)Math.Pow(i, 2);
        }

        return result;
    }
}
