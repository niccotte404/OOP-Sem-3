using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum.Size;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Damage;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability.HullDurabilityType;
public class ThirdClassHull : HullDurabilityBase
{
    public ThirdClassHull(SizeType size)
        : base(size, HullDamage.HugeAsteroidDamage, HullDamage.HugeMetheoritDamage) { }
}
