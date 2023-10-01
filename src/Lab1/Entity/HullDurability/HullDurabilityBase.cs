using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum;
using Itmo.ObjectOrientedProgramming.Lab1.Interface;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.OtherObstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability;
public abstract class HullDurabilityBase : IDefence
{
    protected HullDurabilityBase(SizeType size, int asteroidAmount, int metheoritAmount)
    {
        Size = (int)size;
        AsteroidAmount = asteroidAmount;
        MetheoritAmount = metheoritAmount;
        HitPoints = AsteroidAmount * MetheoritAmount;
    }

    public int HitPoints { get; set; }
    public int Size { get; init; }
    private int AsteroidAmount { get; init; }
    private int MetheoritAmount { get; init; }

    public void GetDamage(ObstacleBase obstacle)
    {
        if (obstacle is null) return;

        SetDamage(obstacle);

        if (obstacle is not AntimaterFlare && obstacle.Amount > 0)
        {
            HitPoints -= obstacle.Damage * (obstacle.Size / Size);
        }
    }

    public bool IsExists()
    {
        return HitPoints > 0;
    }

    protected virtual void SetDamage(ObstacleBase obstacle)
    {
        if (obstacle is Asteroid)
        {
            obstacle.Damage = MetheoritAmount;
        }
        else if (obstacle is Metheorit)
        {
            obstacle.Damage = AsteroidAmount;
        }
        else if (obstacle is SpaceWhile)
        {
            obstacle.Damage = HitPoints;
        }
    }
}
