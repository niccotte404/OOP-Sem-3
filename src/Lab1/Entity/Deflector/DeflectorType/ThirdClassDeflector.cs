namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
internal class ThirdClassDeflector : DeflectorBase
{
    public ThirdClassDeflector(bool setDeflector, bool setPhotonDeflector, int hitPoints)
    {
        SetDeflector = setDeflector;
        IsPhotonDeflectorSet = setPhotonDeflector;
        HitPoints = hitPoints;
    }
}