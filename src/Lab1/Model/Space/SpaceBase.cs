using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Model.Space;
public abstract class SpaceBase
{
    protected SpaceBase(int length, IEnumerable<ObstacleBase> obstacles)
    {
        Obstacles = obstacles;
        Length = length;
    }

    public IEnumerable<ObstacleBase> Obstacles { get; init; }
    public int Length { get; init; }
}
