using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum.Size;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability.HullDurabilityType;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip.SpaceShipType;
public class Stella : SpaceShipBase
{
    public Stella()
    {
        ImpulseEngine = new ClassC(false);
        HyperjumpEngine = new Omega();
        Deflector = new FirstClassDeflector(false);
        HullDurability = new FirstClassHull(SizeType.Small);
    }
}
