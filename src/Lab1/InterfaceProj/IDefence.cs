using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.InterfaceProj;
public interface IDefence
{
    public int GetDamage(ObstacleBase obstacle);
    public bool IsExists();
}
