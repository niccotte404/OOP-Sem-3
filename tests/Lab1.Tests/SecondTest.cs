﻿using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip.SpaceShipType;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.OtherObstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Space;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Space.SpaceType;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;
public class SecondTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[] { new HighDestinySpace(new AntimaterFlare(2)), (int)PathLength.Little, new List<SpaceShipBase>() { new Vaclas(false), new Vaclas(true) }, new List<PathOutcome>() { PathOutcome.PersonelDead, PathOutcome.Success } };
    }

    [Theory]
    [MemberData(nameof(GetData))]
    private void Test(SpaceBase space, int pathLength, IEnumerable<SpaceShipBase> spaceShips, IEnumerable<PathOutcome> expectedOutcomes)
    {
        IEnumerable<PathPart> pathParts = new List<PathPart>() { new PathPart(space, spaceShips, pathLength) };

        var path = new Path(pathParts, spaceShips);
        IReadOnlyCollection<PathOutcome> outcomes = path.PathOutcomes;

        Assert.Equal(expectedOutcomes, outcomes);
    }
}
