using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Helpers;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repository;
public class PowerUnitRepository : RepositoryService<PowerUnit, HelperPowerUnit>
{
    private readonly RepositoryContext _context;
    public PowerUnitRepository(RepositoryContext context)
    {
        _context = context;
    }

    public override IReadOnlyCollection<PowerUnit> SelectComponent(HelperPowerUnit componentHelper)
    {
        if (componentHelper is null) return Enumerable.Empty<PowerUnit>().ToImmutableList();
        IEnumerable<PowerUnit> powerUnits = _context.PowerUnits;

        if (componentHelper.MaxPower is not null)
        {
            powerUnits = powerUnits.Where(component => component.MaxPower >= componentHelper.MaxPower && component.MaxPower <= componentHelper.MaxPower * 1.3f);
        }

        return powerUnits.ToImmutableList();
    }
}
