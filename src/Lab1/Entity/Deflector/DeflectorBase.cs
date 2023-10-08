using Itmo.ObjectOrientedProgramming.Lab1.InterfaceProj;
using Itmo.ObjectOrientedProgramming.Lab1.Model.HitPoints;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle.ObstacleWithInheritedDamage;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.OtherObstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector;
public abstract class DeflectorBase : IDefence
{
    protected DeflectorBase(bool setPhotonDeflector, int asteroidAmount, int metheoritAmount)
    {
        SetDeflector = true;
        SetPhotonDeflector = setPhotonDeflector; // 'cause photon deflector is modification of common deflector i used boolean variable for it
        AsteroidAmount = asteroidAmount;
        MetheoritAmount = metheoritAmount;
        HitPoints = AsteroidAmount * MetheoritAmount;
        ToSetPhotonDeflector(SetPhotonDeflector);
    }

    protected bool SetPhotonDeflector { get; set; }
    protected int HitPoints { get; set; }
    protected int PhotonHitPoints { get; set; }
    protected bool SetDeflector { get; set; }
    protected int AsteroidAmount { get; init; }
    protected int MetheoritAmount { get; init; }

    // get all damage instance 'cause we don't have update method that can get damage by amount each collision
    public int GetDamage(ObstacleBase obstacle)
    {
        if (obstacle is null) return 0;

        SetDamage(obstacle);

        for (int i = 1; i < obstacle.Amount + 1; i++)
        {
            if (obstacle is AntimaterFlare)
            {
                PhotonHitPoints -= 1;
            }
            else if (obstacle.Amount > 0)
            {
                HitPoints -= obstacle.Damage;
            }

            if (HitPoints <= 0)
            {
                return obstacle.Amount - i;
            }
        }

        return 0;
    }

    // used for validation common deflector and photon deflector hit points
    public bool IsExists()
    {
        if (SetDeflector)
        {
            return HitPoints > 0;
        }

        return false;
    }

    public bool IsCrewAlive()
    {
        return PhotonHitPoints >= 0;
    }

    // that's strange dependence between obstacle.Damage and deflector/ship
    // anyway damage usually set as a const
    // but there is no choise to set damage in another way in the deflector and hull
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

    private void ToSetPhotonDeflector(bool set)
    {
        if (set)
        {
            PhotonHitPoints = DeflectorHitPoints.PhotonHitPoints;
        }
        else
        {
            PhotonHitPoints = DeflectorHitPoints.NonePhotonHitPoints;
        }
    }
}
