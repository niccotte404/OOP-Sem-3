using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Model.Space.SpaceType;
public class CommonSpace : SpaceBase
{
    public CommonSpace(Asteroid asteroid, Metheorit metheorit, int length)
        : base(length)
    {
        Obstacle = new List<ObstacleBase>() { asteroid, metheorit };
    }

    public IEnumerable<ObstacleBase> Obstacle { get; init; }
}
