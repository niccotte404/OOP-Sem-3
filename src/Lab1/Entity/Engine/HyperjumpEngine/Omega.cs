using Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
internal class Omega : HyperjumpEngineBase
{
    public Omega(int pathLength, double fuelConsumption, double fuelAmount, double fuelLimit)
        : base(pathLength, fuelAmount, fuelLimit)
    {
        FuelConsumption = EngineValidation.OmegaConsumption(fuelConsumption);
    }
}
