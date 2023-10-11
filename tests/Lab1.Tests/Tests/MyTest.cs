using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Size;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip.SpaceShipType;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle.ObstacleWithInheritedDamage;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.OtherObstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Space.SpaceType;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests.Tests;
public class MyTest
{
    [Fact]
    private void Test()
    {
        IEnumerable<SpaceShipBase> spaceShips = new List<SpaceShipBase>() { new Vaclas(true), new Avgur(true) };
        var highDestinyPathPart = new PathPart(new HighDestinySpace(new AntimaterFlare(2)), spaceShips, (int)PathLength.Medium);
        var commonSpacePathPart = new PathPart(new CommonSpace(new Asteroid(SizeType.Small, 1), new Metheorit(SizeType.Small, 1)), spaceShips, (int)PathLength.Medium);
        IEnumerable<PathPart> pathParts = new List<PathPart>() { highDestinyPathPart, commonSpacePathPart };
        var path = new Path(pathParts, spaceShips);

        IEnumerable<PathOutcome> expectedOutcomes = new List<PathOutcome>() { PathOutcome.Success, PathOutcome.ShipLost };
        IReadOnlyCollection<PathOutcome> outcomes = path.PathOutcomes;

        Assert.Equal(expectedOutcomes, outcomes);
    }
}
