using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum.Engine.Fuel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;

public abstract class HyperjumpEngineBase : EngineBase
{
    private int _jumpRange;
    protected HyperjumpEngineBase(int fuelConsumption, EngineHyperjumpRange jumpRange)
    {
        FuelCategory = (int)FuelType.GravityMater;
        Time = CountPathTime();
        FuelConsumption = fuelConsumption * (int)jumpRange;
        _jumpRange = (int)jumpRange;
    }

    public bool IsShipLost() => _jumpRange - PathLength < 0;

    protected int CountPathTime()
    {
        // количество прыжков
        return PathLength / FuelConsumption;
    }
}