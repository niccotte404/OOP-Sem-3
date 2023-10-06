using System;
using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Engine.Fuel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
public class Gamma : HyperjumpEngineBase
{
    public Gamma()
        : base(GammaConsumption((int)FuelConsumptionType.Huge), EngineHyperjumpRange.Huge) { }

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
