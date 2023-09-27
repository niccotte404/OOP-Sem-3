using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;
public static class EngineValidation
{
    public static bool IsFuelAmountValid(double fuelAmount, double topFuelAmount)
    {
        if (fuelAmount < 0)
        {
            throw new ArgumentException("the amount of fuel is not valid for this type of engine");
        }

        return fuelAmount <= topFuelAmount && fuelAmount >= 0 ? true : false;
    }
}
