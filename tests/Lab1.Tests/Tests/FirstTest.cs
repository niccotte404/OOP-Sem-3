using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip.SpaceShipType;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.OtherObstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Space;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Space.SpaceType;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests.Tests;
public class FirstTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[] { new HighDestinySpace(new AntimaterFlare(0)), (int)PathLength.Medium, new List<SpaceShipBase>() { new Shuttle(), new Avgur(false) }, new List<PathOutcome>() { PathOutcome.Success, PathOutcome.ShipLost } };
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
