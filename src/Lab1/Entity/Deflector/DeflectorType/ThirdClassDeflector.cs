using Itmo.ObjectOrientedProgramming.Lab1.Model.Damage;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle.ObstacleWithInheritedDamage;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.OtherObstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
public class ThirdClassDeflector : DeflectorBase
{
    public ThirdClassDeflector(bool setPhotonDeflector)
        : base(setPhotonDeflector, DeflectorDamage.HugeAsteroidDamage, DeflectorDamage.HugeMetheoritDamage) { }

    protected override void SetDamage(ObstacleBase obstacle)
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
            obstacle.Damage = HitPoints - 1;
        }
    }
}