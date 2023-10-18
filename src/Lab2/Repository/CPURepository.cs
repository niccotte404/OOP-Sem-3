using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repository;
public class CPURepository : RepositoryService<CPU>
{
    private readonly RepositoryContext _context;
    public CPURepository(RepositoryContext context)
    {
        _context = context;
    }

    // that's not paradoxal 'cause we use componentHelper as model that has
    // each params to select main model with (EXAMPLE: socket is not null but other params are)
    public override IReadOnlyCollection<CPU> SelectComponent(CPU componentHelper)
    {
        if (_context.CPUs is null || componentHelper is null) return Enumerable.Empty<CPU>().ToImmutableList();
        IEnumerable<CPU> cpus = _context.CPUs;

        if (componentHelper.CoreFrequency is not null)
        {
            cpus = cpus.Where(cpu => cpu.CoreFrequency == componentHelper.CoreFrequency);
        }

        if (componentHelper.CoreAmount is not null)
        {
            cpus = cpus.Where(cpu => cpu.CoreAmount == componentHelper.CoreAmount);
        }

        if (componentHelper.Socket is not null)
        {
            cpus = cpus.Where(cpu => cpu.Socket == componentHelper.Socket);
        }

        if (componentHelper.IGPU is not null)
        {
            cpus = cpus.Where(cpu => cpu.IGPU == componentHelper.IGPU);
        }

        if (componentHelper.SupportedMemoryFrequency is not null)
        {
            cpus = cpus.Where(cpu => cpu.SupportedMemoryFrequency == componentHelper.SupportedMemoryFrequency);
        }

        if (componentHelper.TDP is not null)
        {
            cpus = cpus.Where(cpu => cpu.TDP <= componentHelper.TDP);
        }

        if (componentHelper.PowerConsumption is not null)
        {
            cpus = cpus.Where(cpu => cpu.PowerConsumption <= componentHelper.PowerConsumption);
        }

        return cpus.ToImmutableList();
    }
}
