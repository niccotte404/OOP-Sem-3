using System;
using Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
internal class Gamma : HyperjumpEngineBase
{
    public Gamma(int pathLength, double fuelAmount = 200)
    {
        FuelLimit = 200;
        Time = CountPathTime(pathLength);
        FuelConsumption = CountFuelConsumption(5);
        if (EngineValidation.IsFuelAmountValid(fuelAmount, FuelLimit)) FuelAmount = fuelAmount;
    }

    protected override double CountFuelConsumption(double fuelConsumption)
    {
        double result = 0;
        for (int i = 1; i < fuelConsumption + 1; i++)
        {
            result += Math.Pow(i, 2);
        }

        return result;
    }
}
