using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.NoneRequiredComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repository;
public class BIOSRepository : IRepositoryService<BIOS>
{
    private readonly RepositoryContext _context;
    public BIOSRepository(RepositoryContext context)
    {
        _context = context;
    }

    public void Add(BIOS component)
    {
        if (_context.BIOSs is null) return;
        _context.BIOSs.Add(component);
    }

    public void Remove(BIOS component)
    {
        if (_context.BIOSs is null) return;
        _context.BIOSs.Remove(component);
    }

    public bool IsExists(BIOS component)
    {
        if (_context.BIOSs is null) return false;
        return _context.BIOSs.Contains(component);
    }

    public void Update(BIOS oldComponent, BIOS newComponent)
    {
        if (_context.BIOSs is null) return;
        if (IsExists(oldComponent) == false) return;
        _context.BIOSs.Remove(oldComponent);
        _context.BIOSs.Add(newComponent);
    }

    public IReadOnlyCollection<BIOS> SelectComponent(BIOS componentHelper)
    {
        IEnumerable<BIOS> bioss = new List<BIOS>();
        if (_context.BIOSs is null || componentHelper is null) return bioss.ToImmutableList();

        if (componentHelper.Type is not null)
        {
            bioss = _context.BIOSs.Where(bios => bios.Type == componentHelper.Type);
        }

        if (componentHelper.Version is not null)
        {
            bioss = _context.BIOSs.Where(bios => bios.Version == componentHelper.Version);
        }

        if (componentHelper.SupportedCPU is not null)
        {
            bioss = _context.BIOSs.Where(bios => bios.SupportedCPU is not null && bios.SupportedCPU.Intersect(componentHelper.SupportedCPU).Any());
        }

        return bioss.ToImmutableList();
    }
}
