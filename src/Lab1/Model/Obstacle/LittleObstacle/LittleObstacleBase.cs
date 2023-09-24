namespace Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle;
internal abstract class LittleObstacleBase : ObstacleBase
{
    public LittleObstacleBase(int size, int damage, int amount)
    {
        Size = size;
        Damage = damage;
        Amount = amount;
    }
}
