﻿using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip.SpaceShipType;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.OtherObstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Space.SpaceType;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;
public class SixthTest
{
    [Fact]
    private void Test()
    {
        IEnumerable<SpaceShipBase> spaceShips = new List<SpaceShipBase>() { new Shuttle(), new Vaclas(false) };
        IEnumerable<PathPart> pathParts = new List<PathPart>() { new PathPart(new NitrineParticlesSpace(new SpaceWhile(0)), spaceShips, (int)PathLength.Little) };
        var path = new Path(pathParts, spaceShips);
        SpaceShipBase? bestShip = path.GetBestShip();

        Assert.True(bestShip is Vaclas);
    }
}
