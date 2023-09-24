using Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
internal class Gamma : HyperjumpEngineBase
{
    public Gamma(int pathLength, double fuelConsumption, double fuelAmount, double fuelLimit)
        : base(pathLength, fuelAmount, fuelLimit)
    {
        FuelConsumption = EngineValidation.GammaConsumption(fuelConsumption);
    }
}
