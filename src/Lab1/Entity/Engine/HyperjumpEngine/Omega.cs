using System;
using Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
internal class Omega : HyperjumpEngineBase
{
    public Omega(int pathLength, double fuelAmount = 150)
    {
        FuelLimit = 150;
        Time = CountPathTime(pathLength);
        FuelConsumption = CountFuelConsumption(5);
        if (EngineValidation.IsFuelAmountValid(fuelAmount, FuelLimit)) FuelAmount = fuelAmount;
    }

    protected override double CountFuelConsumption(double fuelConsumption)
    {
        double result = 0;
        for (int i = 1; i < fuelConsumption + 1; i++)
        {
            result += Math.Log(i);
        }

        return result;
    }
}
