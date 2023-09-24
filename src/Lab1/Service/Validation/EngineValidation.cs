using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;
internal static class EngineValidation
{
    public static bool IsFuelAmountValid(double fuelAmount, double topFuelAmount)
    {
        if (fuelAmount < 0)
        {
            throw new ArgumentException("the amount of fuel is not valid for this type of engine");
        }

        return fuelAmount <= topFuelAmount && fuelAmount >= 0 ? true : false;
    }

    public static double OmegaConsumption(double fuelConsumption)
    {
        double result = 0;
        for (int i = 1; i < fuelConsumption + 1; i++)
        {
            result += Math.Log(i);
        }

        return result;
    }

    public static double GammaConsumption(double fuelConsumption)
    {
        double result = 0;
        for (int i = 1; i < fuelConsumption + 1; i++)
        {
            result += Math.Pow(i, 2);
        }

        return result;
    }
}
