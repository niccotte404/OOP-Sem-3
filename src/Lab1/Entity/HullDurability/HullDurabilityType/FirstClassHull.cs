using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum.Size;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Damage;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle.ObstacleWithInheritedDamage;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability.HullDurabilityType;
public class FirstClassHull : HullDurabilityBase
{
    public FirstClassHull(SizeType size)
        : base(size, HullDamage.LittleAsteroidDamage, HullDamage.LittleMetheoritDamage) { }

    protected override void SetDamage(ObstacleBase obstacle)
    {
        if (obstacle is null) return;

        if (obstacle is Asteroid)
        {
            obstacle.Damage = HitPoints - 1;
        }
        else
        {
            obstacle.Damage = HitPoints;
        }
    }
}
