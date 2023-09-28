using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip.SpaceShipType;
public class Shuttle : SpaceShipBase
{
    public Shuttle()
    {
        HyperjumpEngine = null;
        ImpulseEngine = new ClassC(false, );
    }
}
