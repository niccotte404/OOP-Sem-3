﻿using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Size;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Engine.ImpulseEngine;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability.HullDurabilityType;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip.SpaceShipType;
public class Meridian : SpaceShipBase
{
    public Meridian(bool setPhotonDeflector)
    {
        ImpulseEngine = new ClassE(true);
        HyperjumpEngine = null;
        Deflector = new SecondClassDeflector(setPhotonDeflector);
        HullDurability = new SecondClassHull(SizeType.Medium);
    }
}
