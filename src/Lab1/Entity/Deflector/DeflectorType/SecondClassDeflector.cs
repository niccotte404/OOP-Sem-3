using Itmo.ObjectOrientedProgramming.Lab1.Model.Damage;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector.DeflectorType;
public class SecondClassDeflector : DeflectorBase
{
    public SecondClassDeflector(bool setPhotonDeflector)
        : base(setPhotonDeflector, DeflectorDamage.MediumAsteroidDamage, DeflectorDamage.MediumMetheoritDamage) { }
}
