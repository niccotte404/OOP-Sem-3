using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Space;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Path;
public class PathPart
{
    public PathPart(SpaceBase space, SpaceShipBase spaceShip)
    {
        Space = space;
        SpaceShip = spaceShip;
    }

    public SpaceBase Space { get; init; }
    public SpaceShipBase SpaceShip { get; init; }
}
