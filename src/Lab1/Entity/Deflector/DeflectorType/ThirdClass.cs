namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
internal class ThirdClass : DeflectorBase
{
    public ThirdClass(bool setDeflector, bool setPhotonDeflector, int hitPoints)
    {
        SetDeflector = setDeflector;
        IsPhotonDeflectorSet = setPhotonDeflector;
        HitPoints = hitPoints;
    }
}