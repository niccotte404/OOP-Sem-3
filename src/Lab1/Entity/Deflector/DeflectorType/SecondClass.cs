namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
internal class SecondClass : DeflectorBase
{
    public SecondClass(bool setDeflector, bool setPhotonDeflector, int hitPoints)
    {
        SetDeflector = setDeflector;
        IsPhotonDeflectorSet = setPhotonDeflector;
        HitPoints = hitPoints;
    }
}
