﻿using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip.SpaceShipType;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.OtherObstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Space.SpaceType;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;
public class FirstTest
{
    [Fact]
    private void Test()
    {
        IEnumerable<SpaceShipBase> spaceShips = new List<SpaceShipBase>() { new Shuttle(), new Avgur(false) };
        var highDestinyPart = new PathPart(new HighDestinySpace(new AntimaterFlare(0)), spaceShips, (int)PathLength.Medium);
        IEnumerable<PathPart> pathParts = new List<PathPart>() { highDestinyPart };
        IEnumerable<PathOutcome> expectedOutcomes = new List<PathOutcome>() { PathOutcome.ShipLost, PathOutcome.ShipLost };

        var path = new Path(pathParts, spaceShips);
        IReadOnlyCollection<PathOutcome> outcomes = path.PathOutcomes;

        Assert.Equal<PathOutcome>(expectedOutcomes, outcomes);
    }
}
