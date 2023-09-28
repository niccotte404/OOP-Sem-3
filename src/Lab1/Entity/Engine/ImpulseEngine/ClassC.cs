using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;

public class ClassC : ImpulseEngineBase
{
    public ClassC(bool antinitrinRadiation, double fuelAmount, int startVelocity, double fuelLimit)
        : base(antinitrinRadiation, fuelAmount, fuelLimit, (int)FuelConsumptionType.Little, startVelocity) { }
}
