using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Size;

namespace Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle;
public abstract class LittleObstacleBase : ObstacleBase
{
    protected LittleObstacleBase(SizeType size, int amount)
    {
        Size = (int)size;
        Amount = amount;
    }
}
