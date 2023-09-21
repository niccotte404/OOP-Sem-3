using Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability.HullDurabilityType;
using Itmo.ObjectOrientedProgramming.Lab1.Enum;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip.SpaceShipType;
internal class Vaclas : SpaceShipBase
{
    public Vaclas(int pathLength, int huperjumpLength, int fuelAmount, int deflectorHitPoints, int hullHitPoints)
    {
        ImpulseEngine = new ClassE(pathLength, false, fuelAmount);
        HyperjumpEngine = new Gamma(huperjumpLength, fuelAmount);
        Deflector = new FirstClassDeflector(true, false, deflectorHitPoints);
        HullDurability = new SecondClassHull(hullHitPoints, (int)SizeType.Medium);
    }
}
