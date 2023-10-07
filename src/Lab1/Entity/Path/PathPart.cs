using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Space;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Path;
public class PathPart
{
    public PathPart(SpaceBase space, SpaceShipBase spaceShip, int pathLength)
    {
        Space = space;
        SpaceShip = spaceShip;
        PathLength = pathLength;
        SetPathLength();
    }

    public SpaceBase Space { get; init; }
    public SpaceShipBase SpaceShip { get; init; }
    public int PathLength { get; init; }

    private void SetPathLength()
    {
        if (SpaceShip.ImpulseEngine is not null) SpaceShip.ImpulseEngine.PathLength = PathLength;
        if (SpaceShip.HyperjumpEngine is not null) SpaceShip.HyperjumpEngine.PathLength = PathLength;
    }
}
