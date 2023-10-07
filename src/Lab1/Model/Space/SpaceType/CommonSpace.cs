using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle.ObstacleWithInheritedDamage;

namespace Itmo.ObjectOrientedProgramming.Lab1.Model.Space.SpaceType;
public class CommonSpace : SpaceBase
{
    public CommonSpace(Asteroid asteroid, Metheorit metheorit)
        : base(new List<ObstacleBase>() { asteroid, metheorit }) { }

    public override bool IsShipSuitable(SpaceShipBase spaceShip)
    {
        if (spaceShip is not null && spaceShip.ImpulseEngine is not null)
        {
            return true;
        }

        return false;
    }
}
