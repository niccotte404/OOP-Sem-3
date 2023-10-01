using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum;

namespace Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle;
public abstract class LittleObstacleBase : ObstacleBase
{
    protected LittleObstacleBase(SizeType size, int damage, int amount)
    {
        Size = (int)size;
        Damage = damage;
        Amount = amount;
    }
}
