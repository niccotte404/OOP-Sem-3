using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Engine.Fuel;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;

public class ClassC : ImpulseEngineBase
{
    public ClassC(bool antinitrinRadiation)
        : base(antinitrinRadiation, (int)FuelConsumptionType.Little) { }
}
