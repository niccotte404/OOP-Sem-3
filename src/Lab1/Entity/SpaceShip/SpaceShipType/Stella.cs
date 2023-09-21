using Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability.HullDurabilityType;
using Itmo.ObjectOrientedProgramming.Lab1.Enum;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip.SpaceShipType;
internal class Stella : SpaceShipBase
{
    public Stella(int pathLength, int huperjumpLength, int fuelAmount, int deflectorHitPoints, int hullHitPoints)
    {
        ImpulseEngine = new ClassC(pathLength, true, fuelAmount);
        HyperjumpEngine = new Omega(huperjumpLength, fuelAmount);
        Deflector = new FirstClassDeflector(true, false, deflectorHitPoints);
        HullDurability = new FirstClassHull(hullHitPoints, (int)SizeType.Small);
    }
}
