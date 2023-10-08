using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Size;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability.HullDurabilityType;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip.SpaceShipType;
public class Stella : SpaceShipBase
{
    public Stella(bool setPhotonDeflector)
    {
        ImpulseEngine = new ClassC(false);
        HyperjumpEngine = new Omega();
        Deflector = new FirstClassDeflector(setPhotonDeflector);
        HullDurability = new FirstClassHull(SizeType.Small);
    }
}
