namespace Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.OtherObstacles;
internal class SpaceWhile : ObstacleBase
{
    public SpaceWhile(int amount)
    {
        Damage = int.MaxValue;
        Amount = amount;
        Size = 1;
    }
}
