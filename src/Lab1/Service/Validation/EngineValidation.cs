using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;
internal static class EngineValidation
{
    public static bool IsFuelAmountValid(double fuelAmount, double topFuelAmount)
    {
        return fuelAmount <= topFuelAmount && fuelAmount >= 0 ? true :
        throw new ArgumentException("the amount of fuel is not valid for this type of engine");
    }
}
