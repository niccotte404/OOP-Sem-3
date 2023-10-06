using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Data.EnumData.Path;
using Itmo.ObjectOrientedProgramming.Lab1.Entity.SpaceShip;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Fuel;
using Itmo.ObjectOrientedProgramming.Lab1.Model.Space.SpaceType;

namespace Itmo.ObjectOrientedProgramming.Lab1.Entity.Path;
public class Path
{
    private readonly IEnumerable<PathPart> _pathParts;
    private readonly IEnumerable<SpaceShipBase> _spaceShips;
    private ICollection<SpaceShipBase> _successfulShips = new List<SpaceShipBase>();
    private ICollection<PathOutcome> _pathOutcomes = new List<PathOutcome>();
    private ICollection<(double, SpaceShipBase)> _scores = new List<(double, SpaceShipBase)>();

    public Path(IEnumerable<PathPart> pathParts, IEnumerable<SpaceShipBase> spaceShips)
    {
        _pathParts = pathParts;
        _spaceShips = spaceShips;
        GetSuccessfulShips();
        PathOutcomes = _pathOutcomes.ToImmutableList();
    }

    public IReadOnlyCollection<PathOutcome> PathOutcomes { get; init; }

    public PathOutcome Outcome(SpaceShipBase ship)
    {
        if (ship is null) return PathOutcome.None;

        foreach (PathPart part in _pathParts)
        {
            if (ship.IsAlive(part.Space.Obstacles) == false)
            {
                return PathOutcome.ShipDestroy;
            }

            if (part.Space is HighDestinySpace && (ship.HyperjumpEngine is null || ship.HyperjumpEngine.IsShipLost() == true))
            {
                return PathOutcome.ShipLost;
            }

            if (ship.Deflector is not null && ship.Deflector.IsCrewAlive())
            {
                return PathOutcome.PersonelDead;
            }
        }

        return PathOutcome.Success;
    }

    public (int SpentTime, int SpentFuel)? GetSuccessData()
    {
        foreach (SpaceShipBase ship in _spaceShips)
        {
            if (Outcome(ship) is PathOutcome.Success && ship is not null && ship.ImpulseEngine is not null)
            {
                int hyperjumpEngineFuel;
                if (ship.HyperjumpEngine is null)
                {
                    hyperjumpEngineFuel = 0;
                }
                else
                {
                    hyperjumpEngineFuel = ship.HyperjumpEngine.Fuel;
                }

                int impulseEngineFuel = ship.ImpulseEngine.Fuel;
                int time = ship.ImpulseEngine.Time;
                int fuel = impulseEngineFuel + hyperjumpEngineFuel;
                return (time, fuel);
            }
        }

        return null;
    }

    public SpaceShipBase? GetBestShip()
    {
        GetShipScore();
        double minScore = _scores.Min(elem => elem.Item1);
        foreach ((double, SpaceShipBase) elem in _scores)
        {
            if (elem.Item1 == minScore) return elem.Item2;
        }

        return null;

        // IEnumerable<SpaceShipBase> elem = _scores.Where(elem => elem.Item1 == minScore).Select(elem => elem.Item2);
    }

    private void GetShipScore()
    {
        double score;
        foreach (SpaceShipBase spaceShip in _successfulShips)
        {
            if (spaceShip.ImpulseEngine is null) continue;
            if (spaceShip.HyperjumpEngine is null)
            {
                score = spaceShip.ImpulseEngine.Fuel * FuelCost.ActivePlasmaCost / spaceShip.ImpulseEngine.Time;
            }
            else
            {
                score = ((spaceShip.ImpulseEngine.Fuel * FuelCost.ActivePlasmaCost) + (spaceShip.HyperjumpEngine.Fuel * FuelCost.GravityMaterCost)) / spaceShip.ImpulseEngine.Time;
            }

            _scores.Add((score, spaceShip));
        }
    }

    private void GetSuccessfulShips()
    {
        foreach (SpaceShipBase spaceShip in _spaceShips)
        {
            PathOutcome outcome = Outcome(spaceShip);
            _pathOutcomes.Add(outcome);
            if (outcome is PathOutcome.Success)
            {
                _successfulShips.Add(spaceShip);
            }
        }
    }
}
