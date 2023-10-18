using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repository;
public class SSDRepository : RepositoryService<SSD>
{
    private readonly RepositoryContext _context;
    public SSDRepository(RepositoryContext context)
    {
        _context = context;
    }

    public override IReadOnlyCollection<SSD> SelectComponent(SSD componentHelper)
    {
        if (_context.SSDs is null || componentHelper is null) return Enumerable.Empty<SSD>().ToImmutableList();
        IEnumerable<SSD> ssds = _context.SSDs;

        if (componentHelper.ConnectionOption is not null)
        {
            ssds = ssds.Where(ssd => ssd.ConnectionOption == componentHelper.ConnectionOption);
        }

        if (componentHelper.MemoryAmount is not null)
        {
            ssds = ssds.Where(ssd => ssd.MemoryAmount >= componentHelper.MemoryAmount);
        }

        if (componentHelper.MaxDatatransferSpeed is null)
        {
            ssds = ssds.Where(ssd => ssd.MaxDatatransferSpeed >= componentHelper.MaxDatatransferSpeed);
        }

        if (componentHelper.PowerConsumprion is not null)
        {
            ssds = ssds.Where(ssd => ssd.PowerConsumprion <= componentHelper.PowerConsumprion);
        }

        return ssds.ToImmutableList();
    }
}
