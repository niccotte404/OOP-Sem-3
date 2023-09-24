﻿using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.OtherObstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.HullDurability;
internal abstract class HullDurabilityBase : IHullDurability
{
    public HullDurabilityBase(int size, int asteroidAmount, int metheoritAmount)
    {
        Size = size;
        AsteroidAmount = asteroidAmount;
        MetheoritAmount = metheoritAmount;
        HitPoints = AsteroidAmount * MetheoritAmount;
        IsHullSmallSize = false;
    }

    public int HitPoints { get; set; }
    public int Size { get; init; }
    protected bool IsHullSmallSize { get; init; }
    private int AsteroidAmount { get; init; }
    private int MetheoritAmount { get; init; }

    public void GetDamage(ObstacleBase obstacle)
    {
        SetDamage(obstacle);

        if (obstacle is not AntimaterFlare && obstacle.Amount > 0)
        {
            HitPoints -= obstacle.Damage * (obstacle.Size / Size);
        }
    }

    public bool IsHullExists()
    {
        return HitPoints > 0;
    }

    // oh no cringe
    private void SetDamage(ObstacleBase obstacle)
    {
        if (obstacle is Asteroid)
        {
            obstacle.Damage = MetheoritAmount;
        }
        else if (obstacle is Metheorit)
        {
            obstacle.Damage = AsteroidAmount;
        }
        else if (obstacle is SpaceWhile)
        {
            obstacle.Damage = HitPoints;
        }

        // this if used for prevent unique situatuon generated by small hull
        if (IsHullSmallSize)
        {
            if (obstacle is Asteroid)
            {
                obstacle.Damage = HitPoints - 1;
            }
            else
            {
                obstacle.Damage = HitPoints;
            }
        }
    }
}
