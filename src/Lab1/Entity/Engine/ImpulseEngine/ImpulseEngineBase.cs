namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
internal abstract class ImpulseEngineBase : EngineBase
{
    protected double StartVelocity { get; init; }
    protected virtual int CountPathTime(int pathLength)
    {
        // вычисление времени по равномерному движению
        return (int)(pathLength / StartVelocity);
    }
}
