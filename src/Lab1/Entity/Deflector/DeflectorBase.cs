using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.OtherObstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector;
internal abstract class DeflectorBase : IDeflector
{
    public DeflectorBase(bool setDeflector, bool setPhotonDeflector, int asteroidAmount, int metheoritAmount)
    {
        SetDeflector = setDeflector;
        SetPhotonDeflector = setPhotonDeflector; // 'cause photon deflector is modification of common deflector i used boolean variable for it
        AsteroidAmount = asteroidAmount;
        MetheoritAmount = metheoritAmount;
        HitPoints = AsteroidAmount * MetheoritAmount;
        IsAliveAfterSpaceWhile = false;
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
    protected bool IsAliveAfterSpaceWhile { get; init; }
    private int AsteroidAmount { get; init; }
    private int MetheoritAmount { get; init; }

    // get all damage instance 'cause we don't have update method that can get damage by amount each collision
    public void GetDamage(ObstacleBase obstacle)
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

    // used for validation common deflector and photon deflector hit points
    public bool IsDeflectorSet(int hitPoints)
    {
        bool isHitPointsExists = hitPoints > 0;

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

    // that's strange dependence between obstacle.Damage and deflector/ship
    // anyway damage usually set as a const
    // but there is no choise to set damage in another way but in the deflector and hull
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
            if (IsAliveAfterSpaceWhile)
            {
                obstacle.Damage = HitPoints - 1;
            }
            else
            {
                obstacle.Damage = HitPoints;
            }
        }
    }
}
