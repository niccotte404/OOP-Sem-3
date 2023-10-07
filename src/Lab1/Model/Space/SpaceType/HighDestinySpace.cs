using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.OtherObstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Model.Space.SpaceType;
public class HighDestinySpace : SpaceBase
{
    public HighDestinySpace(AntimaterFlare antimaterFlare)
        : base(new List<ObstacleBase> { antimaterFlare }) { }

    public override bool IsShipSuitable(SpaceShipBase spaceShip)
    {
        if (spaceShip is not null && spaceShip.HyperjumpEngine is not null)
        {
            return true;
        }

        return false;
    }
}
