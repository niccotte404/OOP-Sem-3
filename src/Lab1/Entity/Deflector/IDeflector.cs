namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector;
internal interface IDeflector
{
    public void GetDamage<TObstacle>(TObstacle obstacle);
    public bool IsDeflectorSet();
}
