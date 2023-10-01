using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability.HullDurabilityType;
public class SecondClassHull : HullDurabilityBase
{
    public SecondClassHull(SizeType size)
        : base(size, 5, 2) { }
}