using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector;
internal interface IDeflector
{
    public void GetDamage(ObstacleBase obstacle);
    public bool IsDeflectorSet();
}
