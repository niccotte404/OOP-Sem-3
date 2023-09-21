using Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
internal class ClassC : ImpulseEngineBase
{
    private int pathLength;
    private bool v;

    public ClassC(int pathLength, bool antinitrinRatioation, double fuelAmount = 50)
    {
        FuelConsumption = 1;
        StartVelocity = 10;
        FuelLimit = 50;
        AntinitrinRadiation = antinitrinRatioation;
        Time = CountPathTime(pathLength);
        if (EngineValidation.IsFuelAmountValid(fuelAmount, FuelLimit)) FuelAmount = fuelAmount;
    }

    public ClassC(int pathLength, bool v, int fuelAmount)
    {
        this.pathLength = pathLength;
        this.v = v;
        FuelAmount = fuelAmount;
    }
}
