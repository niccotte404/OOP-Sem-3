using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
public class ThirdClassDeflector : DeflectorBase
{
    public ThirdClassDeflector(bool setPhotonDeflector)
        : base(setPhotonDeflector, 40, 10) { }

    protected override void GetSpaceWhileDamage(ObstacleBase obstacle)
    {
        if (obstacle is null) return;
        obstacle.Damage = HitPoints - 1;
    }
}