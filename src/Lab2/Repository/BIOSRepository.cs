using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repository;
public class BIOSRepository : RepositoryService<BIOS>
{
    private readonly RepositoryContext _context;
    public BIOSRepository(RepositoryContext context)
    {
        _context = context;
    }

    // that's not paradoxal 'cause we use componentHelper as model that has
    // each params to select main model with (EXAMPLE: socket is not null but other params are)
    public override IReadOnlyCollection<BIOS> SelectComponent(BIOS componentHelper)
    {
        if (_context.BIOSs is null || componentHelper is null) return Enumerable.Empty<BIOS>().ToImmutableList();
        IEnumerable<BIOS> bioss = _context.BIOSs;

        if (componentHelper.Type is not null)
        {
            bioss = bioss.Where(bios => bios.Type == componentHelper.Type);
        }

        if (componentHelper.Version is not null)
        {
            bioss = bioss.Where(bios => bios.Version == componentHelper.Version);
        }

        if (componentHelper.SupportedCPU is not null)
        {
            bioss = bioss.Where(bios => bios.SupportedCPU is not null && bios.SupportedCPU.Intersect(componentHelper.SupportedCPU).Any());
        }

        return bioss.ToImmutableList();
    }
}
