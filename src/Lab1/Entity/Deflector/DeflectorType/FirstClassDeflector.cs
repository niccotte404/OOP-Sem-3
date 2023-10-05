using Itmo.ObjectOrientedProgramming.Lab1.Model.Damage;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
public class FirstClassDeflector : DeflectorBase
{
    public FirstClassDeflector(bool setPhotonDeflector)
        : base(setPhotonDeflector, DeflectorDamage.LittleAsteroidDamage, DeflectorDamage.LittleMetheoritDamage) { }
}
