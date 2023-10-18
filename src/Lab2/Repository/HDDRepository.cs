using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repository;
public class HDDRepository : RepositoryService<HDD>
{
    private readonly RepositoryContext _context;
    public HDDRepository(RepositoryContext context)
    {
        _context = context;
    }

    public override IReadOnlyCollection<HDD> SelectComponent(HDD componentHelper)
    {
        if (_context.HDDs is null || componentHelper is null) return Enumerable.Empty<HDD>().ToImmutableList();
        IEnumerable<HDD> hdds = _context.HDDs;

        if (componentHelper.MemoryAmount is not null)
        {
            hdds = hdds.Where(hdd => hdd.MemoryAmount >= componentHelper.MemoryAmount);
        }

        if (componentHelper.SpinSpeed is not null)
        {
            hdds = hdds.Where(hdd => hdd.SpinSpeed == componentHelper.SpinSpeed);
        }

        if (componentHelper.PowerConsumprion is not null)
        {
            hdds = hdds.Where(hdd => hdd.PowerConsumprion <= componentHelper.PowerConsumprion);
        }

        return hdds.ToImmutableList();
    }
}
