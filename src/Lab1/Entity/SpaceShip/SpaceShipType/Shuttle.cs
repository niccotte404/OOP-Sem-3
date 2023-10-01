using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability.HullDurabilityType;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip.SpaceShipType;
public class Shuttle : SpaceShipBase
{
    public Shuttle()
    {
        ImpulseEngine = new ClassC(false);
        HyperjumpEngine = null;
        Deflector = null;
        HullDurability = new FirstClassHull(SizeType.Small);
    }
}
