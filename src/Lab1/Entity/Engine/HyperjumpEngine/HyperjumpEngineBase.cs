using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum.Engine.Fuel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;

public abstract class HyperjumpEngineBase : EngineBase
{
    protected HyperjumpEngineBase(int fuelConsumption, int fuelForOneJump)
    {
        FuelCategory = (int)FuelType.GravityMater;
        Time = CountPathTime();
        FuelConsumption = fuelConsumption * fuelForOneJump;
    }

    protected int CountPathTime()
    {
        // количество прыжков
        return PathLength / FuelConsumption;
    }
}