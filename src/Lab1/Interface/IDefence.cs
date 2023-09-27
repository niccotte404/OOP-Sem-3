using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Interface;
public interface IDefence
{
    public void GetDamage(ObstacleBase obstacle);
    public bool IsExists();
}
