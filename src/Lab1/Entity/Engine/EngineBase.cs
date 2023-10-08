using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine;
public abstract class EngineBase
{
    public int Fuel => Math.Abs(Time * FuelConsumption);
    public int PathLength { get; set; }
    public bool AntinitrinRadiation { get; init; }
    public int FuelCategory { get; init; }
    public int Time { get; set; }
    protected int FuelConsumption { get; init; }
}
