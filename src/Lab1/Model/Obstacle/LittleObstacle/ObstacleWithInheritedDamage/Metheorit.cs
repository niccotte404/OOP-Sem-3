using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum.Size;

namespace Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle.ObstacleWithInheritedDamage;
public class Metheorit : LittleObstacleBase
{
    public Metheorit(SizeType size, int amount = 0)
        : base(size, amount) { }
}
