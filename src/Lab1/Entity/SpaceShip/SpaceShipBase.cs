using Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip;
internal abstract class SpaceShipBase
{
    public EngineBase? ImpulseEngine { get; set; }
    public EngineBase? HyperjumpEngine { get; set; }
    public DeflectorBase? Deflector { get; set; }
    public HullDurabilityBase? HullDurability { get; set; }
}
