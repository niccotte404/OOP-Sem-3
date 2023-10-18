using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repository;
public class PowerUnitRepository : RepositoryService<PowerUnit>
{
    private readonly RepositoryContext _context;
    public PowerUnitRepository(RepositoryContext context)
    {
        _context = context;
    }

    public override IReadOnlyCollection<PowerUnit> SelectComponent(PowerUnit componentHelper)
    {
        if (_context.PowerUnits is null || componentHelper is null) return Enumerable.Empty<PowerUnit>().ToImmutableList();
        IEnumerable<PowerUnit> powerUnits = _context.PowerUnits;

        if (componentHelper.MaxPower is not null)
        {
            powerUnits = powerUnits.Where(component => component.MaxPower >= componentHelper.MaxPower && component.MaxPower <= componentHelper.MaxPower * 1.3f);
        }

        return powerUnits.ToImmutableList();
    }
}
