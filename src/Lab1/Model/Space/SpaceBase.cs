using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Model.Space;
public abstract class SpaceBase
{
    protected SpaceBase(IEnumerable<ObstacleBase> obstacles)
    {
        Obstacles = obstacles;
    }

    public IEnumerable<ObstacleBase> Obstacles { get; init; }
    public int Length { get; init; }

    public abstract bool IsShipSuitable(SpaceShipBase spaceShip);
}
