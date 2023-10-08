using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Size;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability.HullDurabilityType;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip.SpaceShipType;
public class Avgur : SpaceShipBase
{
    public Avgur(bool setPhotonDeflector)
    {
        ImpulseEngine = new ClassE(false);
        HyperjumpEngine = new Alpha();
        Deflector = new ThirdClassDeflector(setPhotonDeflector);
        HullDurability = new ThirdClassHull(SizeType.Large);
    }
}
