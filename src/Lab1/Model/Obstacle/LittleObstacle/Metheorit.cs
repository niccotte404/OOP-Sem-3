using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum;

namespace Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle;
public class Metheorit : LittleObstacleBase
{
    public Metheorit(SizeType size, int damage, int amount = 0)
        : base(size, damage, amount) { }
}
