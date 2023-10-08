using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Size;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability.HullDurabilityType;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip.SpaceShipType;
public class Vaclas : SpaceShipBase
{
    public Vaclas(bool setPhotonDeflector)
    {
        ImpulseEngine = new ClassE(false);
        HyperjumpEngine = new Gamma();
        Deflector = new FirstClassDeflector(setPhotonDeflector);
        HullDurability = new SecondClassHull(SizeType.Medium);
    }
}
