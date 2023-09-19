using System;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.LittleObstacle;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Obstacle.OtherObstacles;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Deflector;
internal abstract class DeflectorBase : IDeflector
{
    public bool IsPhotonDeflectorSet { get; set; }
    protected int GetAsterodAmount { get; set; }
    protected int GetMetheoritAmount { get; set; }
    protected int GetSpaceWhaleAmount { get; set; }
    protected int GetAnthimaterAmount { get; set; }
    protected bool SetDeflector { get; set; }
    public void GetDamage<TObstacle>(TObstacle obstacle)
    {
        // при учеличении количества возможных вариантов препятствий можно использовать коллекцию типов данных для валидации
        // в данном контексте это не имеет смысла, т.к. данных маловато
        // ps: пометочка о том, что я понимаю, как можно реализовать
        // pps: да, мне лень это реализовывать, и не лень все это писать (первая лаба. думаю тут можно такое себе позволить :D )

        // ps: вынести сие творение в класс валидации проблематично, т.к. она связяна напрямую (тип <-> значение)
        // итак стараюсь выносить все, что можно
        if (obstacle is Asteroid)
        {
            GetAsterodAmount--;
        }
        else if (obstacle is Metheorit)
        {
            GetMetheoritAmount--;
        }
        else if (obstacle is AntimaterFlare)
        {
            GetAnthimaterAmount--;
        }
        else if (obstacle is SpaceWhile)
        {
            GetSpaceWhaleAmount--;
        }
        else
        {
            throw new TypeAccessException("invalid obstacle type");
        }
    }

    public virtual bool IsDeflectorSet()
    {
        return SetDeflector;
    }
}
