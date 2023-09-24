namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
internal class ClassC : ImpulseEngineBase
{
    public ClassC(int pathLength, bool antinitrinRadiation, double fuelAmount, double fuelConsumption, int startVelocity, double fuelLimit)
        : base(pathLength, antinitrinRadiation, fuelAmount, fuelLimit, fuelConsumption, startVelocity) { }
}
