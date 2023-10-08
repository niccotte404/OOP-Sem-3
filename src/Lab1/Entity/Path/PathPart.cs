using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Space;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Path;
public class PathPart
{
    public PathPart(SpaceBase space, IEnumerable<SpaceShipBase> spaceShip, int pathLength)
    {
        Space = space;
        SpaceShip = spaceShip;
        PathLength = pathLength;
        SetPathLength();
    }

    public SpaceBase Space { get; init; }
    public IEnumerable<SpaceShipBase> SpaceShip { get; init; }
    public int PathLength { get; init; }

    private void SetPathLength()
    {
        foreach (SpaceShipBase spaceShip in SpaceShip)
        {
            if (spaceShip.ImpulseEngine is not null) spaceShip.ImpulseEngine.PathLength = PathLength;
            if (spaceShip.HyperjumpEngine is not null) spaceShip.HyperjumpEngine.PathLength = PathLength;
        }
    }
}
