using Itmo.ObjectOrientedProgramming.Lab1.Enum;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;

public class ClassC : ImpulseEngineBase
{
    public ClassC(int pathLength, bool antinitrinRadiation, double fuelAmount, int startVelocity, double fuelLimit)
        : base(pathLength, antinitrinRadiation, fuelAmount, fuelLimit, (int)FuelConsumptionType.Little, startVelocity) { }
}
