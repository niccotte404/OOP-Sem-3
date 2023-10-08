using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip.SpaceShipType;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.OtherObstacles;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Space.SpaceType;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab1.Tests;
public class ThirdTest
{
    [Fact]
    private void Test()
    {
        IEnumerable<SpaceShipBase> spaceShips = new List<SpaceShipBase>() { new Vaclas(false), new Avgur(false), new Meridian(false) };
        IEnumerable<PathPart> pathParts = new List<PathPart>() { new PathPart(new NitrineParticlesSpace(new SpaceWhile(3)), spaceShips, (int)PathLength.Medium) };
        var path = new Path(pathParts, spaceShips);

        IEnumerable<PathOutcome> expectedOutcomes = new List<PathOutcome>() { PathOutcome.ShipDestroy, PathOutcome.Success, PathOutcome.Success };
        IReadOnlyCollection<PathOutcome> outcomes = path.PathOutcomes;

        Assert.Equal(expectedOutcomes, outcomes);
    }
}
