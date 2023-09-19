namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;

internal abstract class HyperjumpEngineBase : EngineBase
{
    protected int SubspaceRange { get; init; } = 10; // +-const, т.к. динамически не хочется запариваться и перегружать конструкторы классов движков

    protected virtual int CountPathTime(int pathLength)
    {
        // количество прыжков
        return pathLength / SubspaceRange;
    }

    protected virtual double CountFuelConsumption(double fuelConsumption)
    {
        // метод для перезаписи (расширяемость)
        return fuelConsumption;
    }
}