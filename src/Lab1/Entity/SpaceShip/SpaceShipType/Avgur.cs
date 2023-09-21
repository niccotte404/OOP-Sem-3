using Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability.HullDurabilityType;
using Itmo.ObjectOrientedProgramming.Lab1.Enum;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip.SpaceShipType;
internal class Avgur : SpaceShipBase
{
    public Avgur(int pathLength, int huperjumpLength, int fuelAmount, int deflectorHitPoints, int hullHitPoints)
    {
        ImpulseEngine = new ClassE(pathLength, true, fuelAmount);
        HyperjumpEngine = new Alpha(huperjumpLength, fuelAmount);
        Deflector = new ThirdClassDeflector(true, false, deflectorHitPoints);
        HullDurability = new ThirdClassHull(hullHitPoints, (int)SizeType.Large);
    }
}
