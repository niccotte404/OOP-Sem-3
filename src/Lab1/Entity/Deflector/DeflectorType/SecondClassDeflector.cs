namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
internal class SecondClassDeflector : DeflectorBase
{
    public SecondClassDeflector(bool setDeflector, bool setPhotonDeflector, int hitPoints)
    {
        SetDeflector = setDeflector;
        IsPhotonDeflectorSet = setPhotonDeflector;
        HitPoints = hitPoints;
    }
}
