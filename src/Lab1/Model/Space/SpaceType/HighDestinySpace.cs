using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.OtherObstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Model.Space.SpaceType;
public class HighDestinySpace : SpaceBase
{
    public HighDestinySpace(AntimaterFlare antimaterFlare, int length)
        : base(length, new List<ObstacleBase> { antimaterFlare }) { }
}
