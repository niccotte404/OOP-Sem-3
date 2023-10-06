using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Size;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Damage;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability.HullDurabilityType;
public class SecondClassHull : HullDurabilityBase
{
    public SecondClassHull(SizeType size)
        : base(size, HullDamage.MediumAsteroidDamage, HullDamage.MediumMetheoritDamage) { }
}