using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability;
internal interface IHullDurability
{
    public void GetDamage(ObstacleBase obstacle);
    public bool IsHullExists();
}
