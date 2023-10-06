using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Engine.Fuel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
public class Alpha : HyperjumpEngineBase
{
    public Alpha()
        : base((int)FuelConsumptionType.Little, EngineHyperjumpRange.Little) { }
}
