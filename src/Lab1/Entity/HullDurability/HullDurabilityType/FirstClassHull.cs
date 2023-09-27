using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability.HullDurabilityType;
public class FirstClassHull : HullDurabilityBase
{
    public FirstClassHull(int size)
        : base(size, 1, 0) { }

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
