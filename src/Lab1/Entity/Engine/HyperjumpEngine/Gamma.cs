using System;
using Itmo.ObjectOrientedProgramming.Lab1.Enum;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
public class Gamma : HyperjumpEngineBase
{
    public Gamma(int pathLength, double fuelAmount, double fuelLimit)
        : base(pathLength, fuelAmount, fuelLimit, GammaConsumption((int)FuelConsumptionType.Huge)) { }

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
