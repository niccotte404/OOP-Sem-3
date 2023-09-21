using System;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.OtherObstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Service.Validation;
internal static class DeflectorValidation
{
    public static bool IsDeflectorActive(int hitPoints)
    {
        return hitPoints >= 0;
    }

    public static int GetObstacle<TObstacle>(TObstacle obstacle)
    {
        // как это можно сделать по-человечески?
        if (obstacle is Asteroid asteroid)
        {
            return asteroid.Damage;
        }
        else if (obstacle is Metheorit metheorit)
        {
            return metheorit.Damage;
        }
        else if (obstacle is SpaceWhile spaceWhile)
        {
            return spaceWhile.Damage;
        }
        else if (obstacle is AntimaterFlare antimaterFlare)
        {
            return antimaterFlare.Damage;
        }

        throw new ArgumentException("not valid type of argument in DeflectorValidation.GetObstacle");
    }
}
