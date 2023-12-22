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
public class ThirdTest
{
    public static IEnumerable<object[]> GetData()
    {
        yield return new object[] { new NitrineParticlesSpace(new SpaceWhile(3)), (int)PathLength.Medium, new List<SpaceShipBase>() { new Vaclas(false), new Avgur(false), new Meridian(false) }, new List<PathOutcome>() { PathOutcome.ShipDestroy, PathOutcome.Success, PathOutcome.Success } };
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
