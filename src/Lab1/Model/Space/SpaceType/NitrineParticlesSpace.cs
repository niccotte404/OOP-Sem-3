﻿using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.OtherObstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Model.Space.SpaceType;
public class NitrineParticlesSpace : SpaceBase
{
    public NitrineParticlesSpace(SpaceWhile spaceWhile, int length)
        : base(length)
    {
        Obstacle = spaceWhile;
    }

    public ObstacleBase Obstacle { get; init; }
}