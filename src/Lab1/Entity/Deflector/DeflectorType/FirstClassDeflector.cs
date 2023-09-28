﻿namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
public class FirstClassDeflector : DeflectorBase
{
    public FirstClassDeflector(bool setDeflector, bool setPhotonDeflector)
        : base(setDeflector, setPhotonDeflector, 2, 1) { }
}