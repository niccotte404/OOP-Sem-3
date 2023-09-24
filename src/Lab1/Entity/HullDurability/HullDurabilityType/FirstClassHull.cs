namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability.HullDurabilityType;
internal class FirstClassHull : HullDurabilityBase
{
    public FirstClassHull(int size)
        : base(size, 1, 0)
    {
        IsHullSmallSize = true;
    }
}
