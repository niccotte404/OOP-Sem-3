using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;

namespace Itmo.ObjectOrientedProgramming.Lab1.Interface;
public interface IDefence
{
    public void GetDamage(IEnumerable<ObstacleBase> obstacles);
    public bool IsExists();
}
