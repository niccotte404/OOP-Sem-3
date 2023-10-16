using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.RequiredComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repository;
internal class RAMRepository : IRepositoryService<RAM>
{
    private readonly RepositoryContext _context;

    public RAMRepository(RepositoryContext context)
    {
        _context = context;
    }

    public void Add(RAM component)
    {
        if (_context.RAMs is null) return;
        _context.RAMs.Add(component);
    }

    public void Remove(RAM component)
    {
        if (_context.RAMs is null) return;
        _context.RAMs.Remove(component);
    }

    public bool IsExists(RAM component)
    {
        if (_context.RAMs is null) return false;
        return _context.RAMs.Contains(component);
    }

    public void Update(RAM oldComponent, RAM newComponent)
    {
        if (_context.RAMs is null) return;
        if (IsExists(oldComponent) == false) return;
        _context.RAMs.Remove(oldComponent);
        _context.RAMs.Add(newComponent);
    }

    public IReadOnlyCollection<RAM> SelectComponent(RAM componentHelper)
    {
        IEnumerable<RAM> rams = new List<RAM>();
        if (_context.RAMs is null || componentHelper is null) return rams.ToImmutableList();

        if (componentHelper.MemoryAmount is not null)
        {
            rams = _context.RAMs.Where(ram => ram.MemoryAmount == componentHelper.MemoryAmount);
        }

        if (componentHelper.MemoryFrequencyAndJEDEC is not null)
        {
            rams = _context.RAMs.Where(ram => ram.MemoryFrequencyAndJEDEC is not null && ram.MemoryFrequencyAndJEDEC.Intersect(componentHelper.MemoryFrequencyAndJEDEC).Any());
        }

        if (componentHelper.SupportedXMP is not null)
        {
            rams = _context.RAMs.Where(ram => ram.SupportedXMP == componentHelper.SupportedXMP);
        }

        if (componentHelper.FormFactor is not null)
        {
            rams = _context.RAMs.Where(
                component => component.FormFactor is not null &&
                component.FormFactor.Width <= componentHelper.FormFactor.Width &&
                component.FormFactor.Height <= componentHelper.FormFactor.Height &&
                component.FormFactor.Depth <= componentHelper.FormFactor.Depth);
        }

        if (componentHelper.DDR is not null)
        {
            rams = _context.RAMs.Where(ram => ram.DDR == componentHelper.DDR);
        }

        if (componentHelper.PowerConsumption is not null)
        {
            rams = _context.RAMs.Where(ram => ram.PowerConsumption == componentHelper.PowerConsumption);
        }

        return rams.ToImmutableList();
    }
}
