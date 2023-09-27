namespace Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle;
public abstract class LittleObstacleBase : ObstacleBase
{
    protected LittleObstacleBase(int size, int damage, int amount)
    {
        Size = size;
        Damage = damage;
        Amount = amount;
    }
}
