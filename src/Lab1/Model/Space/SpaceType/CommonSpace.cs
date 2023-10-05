﻿using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle.ObstacleWithInheritedDamage;

namespace Itmo.ObjectOrientedProgramming.Lab1.Model.Space.SpaceType;
public class CommonSpace : SpaceBase
{
    public CommonSpace(Asteroid asteroid, Metheorit metheorit, int length)
        : base(length, new List<ObstacleBase>() { asteroid, metheorit }) { }
}
