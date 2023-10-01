using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip;
public abstract class SpaceShipBase
{
    public ImpulseEngineBase? ImpulseEngine { get; set; }
    public HyperjumpEngineBase? HyperjumpEngine { get; set; }
    public DeflectorBase? Deflector { get; set; }
    public HullDurabilityBase? HullDurability { get; set; }

    public bool IsAlive(IEnumerable<ObstacleBase> obstacles)
    {
        if (obstacles is null) return true;
        if (HullDurability is null) return false;

        if (IsDeflectorSet(obstacles) == true)
        {
            return true;
        }
        else
        {
            foreach (ObstacleBase obstacle in obstacles)
            {
                HullDurability.GetDamage(obstacle);
            }

            return HullDurability.IsExists();
        }
    }

    private bool IsDeflectorSet(IEnumerable<ObstacleBase> obstacles)
    {
        if (Deflector is null) return false;
        foreach (ObstacleBase obstacle in obstacles)
        {
            Deflector.GetDamage(obstacle);
        }

        return Deflector.IsExists();
    }
}
