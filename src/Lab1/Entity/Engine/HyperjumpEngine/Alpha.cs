using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum.Engine.Fuel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
public class Alpha : HyperjumpEngineBase
{
    public Alpha()
        : base((int)FuelConsumptionType.Little, EngineHyperjumpRange.Little) { }
}
