using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.InterfaceProj;
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
        if (SetPhotonDeflector)
        {
            PhotonHitPoints = 3;
        }
        else
        {
            PhotonHitPoints = 0;
        }
    }

    protected bool SetPhotonDeflector { get; set; }
    protected int HitPoints { get; set; }
    protected int PhotonHitPoints { get; set; }
    protected bool SetDeflector { get; set; }
    private int AsteroidAmount { get; init; }
    private int MetheoritAmount { get; init; }

    // get all damage instance 'cause we don't have update method that can get damage by amount each collision
    public void GetDamage(IEnumerable<ObstacleBase> obstacles)
    {
        if (obstacles is null) return;

        foreach (ObstacleBase obstacle in obstacles)
        {
            SetDamage(obstacle);

            if (obstacle is AntimaterFlare)
            {
                PhotonHitPoints -= obstacle.Amount;
            }
            else if (obstacle.Amount > 0)
            {
                HitPoints -= obstacle.Damage * obstacle.Amount;
            }
        }
    }

    // used for validation common deflector and photon deflector hit points
    public bool IsExists()
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

    public bool IsCrewAlive()
    {
        if (PhotonHitPoints < 0) return false;
        return true;
    }

    protected virtual void GetSpaceWhileDamage(ObstacleBase obstacle)
    {
        if (obstacle is null) return;
        obstacle.Damage = HitPoints;
    }

    // that's strange dependence between obstacle.Damage and deflector/ship
    // anyway damage usually set as a const
    // but there is no choise to set damage in another way in the deflector and hull
    private void SetDamage(ObstacleBase obstacle)
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
            GetSpaceWhileDamage(obstacle);
        }
    }
}
