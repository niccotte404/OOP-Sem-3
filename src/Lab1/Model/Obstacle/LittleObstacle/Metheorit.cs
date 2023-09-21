namespace Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle;
internal class Metheorit : LittleObstacleBase
{
    public Metheorit(int size, int damage, int amount = 0)
    {
        Size = size;
        Damage = damage;
        Amount = amount;
    }
}
