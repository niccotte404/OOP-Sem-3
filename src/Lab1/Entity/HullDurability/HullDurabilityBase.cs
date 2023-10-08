using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Size;
using Itmo.ObjectOrientedProgramming.Lab1.InterfaceProj;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle.ObstacleWithInheritedDamage;
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

    public int GetDamage(ObstacleBase obstacle)
    {
        if (obstacle is null) return 0;

        SetDamage(obstacle);

        for (int i = 1; i < obstacle.Amount + 1; i++)
        {
            if (obstacle is SpaceWhile)
            {
                HitPoints -= obstacle.Damage;
            }
            else if (obstacle is not AntimaterFlare)
            {
                HitPoints -= obstacle.Damage * (obstacle.Size / Size);
            }

            if (HitPoints <= 0)
            {
                return obstacle.Amount - i;
            }
        }

        return 0;
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
