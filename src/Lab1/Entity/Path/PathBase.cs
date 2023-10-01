using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Data.Enum;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.Path.PathPart;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Space.SpaceType;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Path;
public class PathBase
{
    private readonly IEnumerable<PathPartBase> _pathParts;
    private readonly SpaceShipBase _spaceShip;

    public PathBase(IEnumerable<PathPartBase> pathParts, SpaceShipBase spaceShip)
    {
        _pathParts = pathParts;
        _spaceShip = spaceShip;
    }

    public PathOutcome Outcome()
    {
        foreach (PathPartBase part in _pathParts)
        {
            if (_spaceShip.IsAlive(part.Space.Obstacles) == false)
            {
                return PathOutcome.ShipDestroy;
            }

            if (part.Space is HighDestinySpace && (_spaceShip.HyperjumpEngine is null || _spaceShip.HyperjumpEngine.IsShipLost() == true))
            {
                return PathOutcome.ShipLost;
            }
        }

        return PathOutcome.Success;
    }

    public (int SpentTime, int SpentFuel)? GetSuccessData()
    {
        if (Outcome() is PathOutcome.Success && _spaceShip is not null && _spaceShip.ImpulseEngine is not null)
        {
            int hyperjumpEngineFuel;
            if (_spaceShip.HyperjumpEngine is null)
            {
                hyperjumpEngineFuel = 0;
            }
            else
            {
                hyperjumpEngineFuel = _spaceShip.HyperjumpEngine.Fuel;
            }

            int impulseEngineFuel = _spaceShip.ImpulseEngine.Fuel;
            int time = _spaceShip.ImpulseEngine.Time;
            int fuel = impulseEngineFuel + hyperjumpEngineFuel;
            return (time, fuel);
        }

        return null;
    }
}
