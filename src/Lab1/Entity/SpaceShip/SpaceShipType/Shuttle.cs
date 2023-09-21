using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability.HullDurabilityType;
using Itmo.ObjectOrientedProgramming.Lab1.Enum;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip.SpaceShipType;
internal class Shuttle : SpaceShipBase
{
    public Shuttle(int pathLength, int fuelAmount, int hitPoints)
    {
        ImpulseEngine = new ClassC(pathLength, false, fuelAmount);
        HyperjumpEngine = null;
        Deflector = null;
        HullDurability = new FirstClassHull(hitPoints, (int)SizeType.Small);
    }
}
