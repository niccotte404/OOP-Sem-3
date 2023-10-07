using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.OtherObstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Model.Space.SpaceType;
public class NitrineParticlesSpace : SpaceBase
{
    public NitrineParticlesSpace(SpaceWhile spaceWhile)
        : base(new List<ObstacleBase> { spaceWhile }) { }

    public override bool IsShipSuitable(SpaceShipBase spaceShip)
    {
        if (spaceShip is not null && spaceShip.ImpulseEngine is not null && spaceShip.ImpulseEngine is ClassE)
        {
            return true;
        }

        return false;
    }
}
