using Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
internal class ClassC : ImpulseEngineBase
{
    public ClassC(int pathLength, double fuelAmount)
    {
        FuelConsumption = 1;
        StartVelocity = 10;
        FuelLimit = 50;
        Time = CountPathTime(pathLength);
        if (EngineValidation.IsFuelAmountValid(fuelAmount, FuelLimit)) FuelAmount = fuelAmount;
    }
}
