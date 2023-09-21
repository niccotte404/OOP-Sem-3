using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability;
internal abstract class HullDurabilityBase : IHullDurability
{
    public int HitPoints { get; set; }
    public int Size { get; init; }
    public void GetDamage(ObstacleBase obstacle)
    {
        HitPoints -= obstacle.Damage * (obstacle.Size / Size);
    }

    public bool IsHullExists()
    {
        return HitPoints >= 0;
    }
}
