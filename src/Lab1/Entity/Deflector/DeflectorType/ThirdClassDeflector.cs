using Itmo.ObjectOrientedProgramming.Lab1.Model.Damage;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
public class ThirdClassDeflector : DeflectorBase
{
    public ThirdClassDeflector(bool setPhotonDeflector)
        : base(setPhotonDeflector, DeflectorDamage.HugeAsteroidDamage, DeflectorDamage.HugeMetheoritDamage) { }

    protected override void GetSpaceWhileDamage(ObstacleBase obstacle)
    {
        if (obstacle is null) return;
        obstacle.Damage = HitPoints - 1;
    }
}