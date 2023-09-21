namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
internal class FirstClassDeflector : DeflectorBase
{
    public FirstClassDeflector(bool setDeflector, bool setPhotonDeflector, int hitPoints)
    {
        SetDeflector = setDeflector;
        IsPhotonDeflectorSet = setPhotonDeflector;
        HitPoints = hitPoints;
    }
}
