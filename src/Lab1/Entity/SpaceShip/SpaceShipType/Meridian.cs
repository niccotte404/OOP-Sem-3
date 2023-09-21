using Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability.HullDurabilityType;
using Itmo.ObjectOrientedProgramming.Lab1.Enum;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip.SpaceShipType;
internal class Meridian : SpaceShipBase
{
    public Meridian(int pathLength, int huperjumpLength, int fuelAmount, int deflectorHitPoints, int hullHitPoints)
    {
        ImpulseEngine = new ClassE(pathLength, true, fuelAmount);
        HyperjumpEngine = new Gamma(huperjumpLength, fuelAmount);
        Deflector = new SecondClassDeflector(true, false, deflectorHitPoints);
        HullDurability = new SecondClassHull(hullHitPoints, (int)SizeType.Medium);
    }
}
