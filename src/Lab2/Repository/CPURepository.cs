using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.RequiredComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repository;
public class CPURepository : IRepositoryService<CPU>
{
    private readonly RepositoryContext _context;
    public CPURepository(RepositoryContext context)
    {
        _context = context;
    }

    public void Add(CPU component)
    {
        if (_context.CPUs is null) return;
        _context.CPUs.Add(component);
    }

    public void Remove(CPU component)
    {
        if (_context.CPUs is null) return;
        _context.CPUs.Remove(component);
    }

    public bool IsExists(CPU component)
    {
        if (_context.CPUs is null) return false;
        return _context.CPUs.Contains(component);
    }

    public void Update(CPU oldComponent, CPU newComponent)
    {
        if (_context.CPUs is null) return;
        if (IsExists(oldComponent) == false) return;
        _context.CPUs.Remove(oldComponent);
        _context.CPUs.Add(newComponent);
    }

    public IReadOnlyCollection<CPU> SelectComponent(CPU componentHelper)
    {
        IEnumerable<CPU> cpus = new List<CPU>();
        if (_context.CPUs is null || componentHelper is null) return cpus.ToImmutableList();

        if (componentHelper.CoreFrequency is not null)
        {
            cpus = _context.CPUs.Where(cpu => cpu.CoreFrequency == componentHelper.CoreFrequency);
        }

        if (componentHelper.CoreAmount is not null)
        {
            cpus = _context.CPUs.Where(cpu => cpu.CoreAmount == componentHelper.CoreAmount);
        }

        if (componentHelper.Socket is not null)
        {
            cpus = _context.CPUs.Where(cpu => cpu.Socket == componentHelper.Socket);
        }

        if (componentHelper.IGPU is not null)
        {
            cpus = _context.CPUs.Where(cpu => cpu.IGPU == componentHelper.IGPU);
        }

        if (componentHelper.SupportedMemoryFrequency is not null)
        {
            cpus = _context.CPUs.Where(cpu => cpu.SupportedMemoryFrequency == componentHelper.SupportedMemoryFrequency);
        }

        if (componentHelper.TDP is not null)
        {
            cpus = _context.CPUs.Where(cpu => cpu.TDP == componentHelper.TDP);
        }

        if (componentHelper.PowerConsumption is not null)
        {
            cpus = _context.CPUs.Where(cpu => cpu.PowerConsumption == componentHelper.PowerConsumption);
        }

        return cpus.ToImmutableList();
    }
}
