using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.OtherObstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip;
public abstract class SpaceShipBase
{
    public ImpulseEngineBase? ImpulseEngine { get; set; }
    public HyperjumpEngineBase? HyperjumpEngine { get; set; }
    public DeflectorBase? Deflector { get; set; }
    public HullDurabilityBase? HullDurability { get; set; }

    public bool IsCrewAlive(IEnumerable<ObstacleBase> obstacles)
    {
        if (obstacles is null) return true;

        foreach (ObstacleBase obstacle in obstacles)
        {
            if (((Deflector is not null && Deflector.IsCrewAlive() == false) || Deflector is null) && obstacle is AntimaterFlare && obstacle.Amount > 0)
            {
                return false;
            }
        }

        return true;
    }

    public bool IsAlive(IEnumerable<ObstacleBase> obstacles)
    {
        if (obstacles is null) return true;
        if (HullDurability is null) return false;

        if (IsDeflectorSet(obstacles))
        {
            return true;
        }
        else
        {
            foreach (ObstacleBase obstacle in obstacles)
            {
                obstacle.Amount = HullDurability.GetDamage(obstacle);
                if (HullDurability.IsExists() == false)
                {
                    return false;
                }
            }

            return HullDurability.IsExists();
        }
    }

    private bool IsDeflectorSet(IEnumerable<ObstacleBase> obstacles)
    {
        if (Deflector is null) return false;

        foreach (ObstacleBase obstacle in obstacles)
        {
            obstacle.Amount = Deflector.GetDamage(obstacle);
            if (Deflector.IsExists() == false)
            {
                return false;
            }
        }

        return Deflector.IsExists();
    }
}
