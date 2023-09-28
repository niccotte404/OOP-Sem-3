using Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.HyperjumpEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip;
public abstract class SpaceShipBase
{
    public ImpulseEngineBase? ImpulseEngine { get; set; }
    public HyperjumpEngineBase? HyperjumpEngine { get; set; }
    public DeflectorBase? Deflector { get; set; }
    public HullDurabilityBase? HullDurability { get; set; }
}
