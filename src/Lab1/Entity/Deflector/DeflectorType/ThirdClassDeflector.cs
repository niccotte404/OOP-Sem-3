namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
internal class ThirdClassDeflector : DeflectorBase
{
    public ThirdClassDeflector(bool setDeflector, bool setPhotonDeflector)
        : base(setDeflector, setPhotonDeflector, 40, 10)
    {
        // 'cause only this type of deflector can stay alive after getting space while damage
        IsAliveAfterSpaceWhile = true;
    }
}