using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector;
internal abstract class DeflectorBase : IDeflector
{
    public bool IsPhotonDeflectorSet { get; set; }
    protected int HitPoints { get; set; }
    protected bool SetDeflector { get; set; }

    public void GetDamage(ObstacleBase obstacle)
    {
        HitPoints -= obstacle.Damage;
    }

    public bool IsDeflectorSet()
    {
        bool isHitPointsExists = HitPoints > 0;

        if (SetDeflector)
        {
            if (isHitPointsExists == false)
            {
                return false;
            }

            return true;
        }

        return false;
    }
}
