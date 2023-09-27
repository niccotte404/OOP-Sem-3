using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability;
public interface IHullDurability
{
    public void GetDamage(ObstacleBase obstacle);
    public bool IsHullExists();
}
