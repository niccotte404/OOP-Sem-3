using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.RequiredComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repository;
public class CPUCoolingSystemRepository : IRepositoryService<CPUCoolingSystem>
{
    private readonly RepositoryContext _context;
    public CPUCoolingSystemRepository(RepositoryContext context)
    {
        _context = context;
    }

    public void Add(CPUCoolingSystem component)
    {
        if (_context.CPUCoolingSystems is null) return;
        _context.CPUCoolingSystems.Add(component);
    }

    public void Remove(CPUCoolingSystem component)
    {
        if (_context.CPUCoolingSystems is null) return;
        _context.CPUCoolingSystems.Remove(component);
    }

    public bool IsExists(CPUCoolingSystem component)
    {
        if (_context.CPUCoolingSystems is null) return false;
        return _context.CPUCoolingSystems.Contains(component);
    }

    public void Update(CPUCoolingSystem oldComponent, CPUCoolingSystem newComponent)
    {
        if (_context.CPUCoolingSystems is null) return;
        if (IsExists(oldComponent) == false) return;
        _context.CPUCoolingSystems.Remove(oldComponent);
        _context.CPUCoolingSystems.Add(newComponent);
    }

    public IReadOnlyCollection<CPUCoolingSystem> SelectComponent(CPUCoolingSystem componentHelper)
    {
        IEnumerable<CPUCoolingSystem> cpuCoolingSystems = new List<CPUCoolingSystem>();
        if (_context.CPUCoolingSystems is null || componentHelper is null) return cpuCoolingSystems.ToImmutableList();

        if (componentHelper.SupportedSockets is not null)
        {
            cpuCoolingSystems = _context.CPUCoolingSystems.Where(cpuCoolingSystem => cpuCoolingSystem.SupportedSockets is not null && cpuCoolingSystem.SupportedSockets.Intersect(componentHelper.SupportedSockets).Any());
        }

        if (componentHelper.MaxTDP is not null)
        {
            cpuCoolingSystems = _context.CPUCoolingSystems.Where(cpuCoolingSystem => cpuCoolingSystem.MaxTDP == componentHelper.MaxTDP);
        }

        if (componentHelper.FormFactor is not null)
        {
            cpuCoolingSystems = _context.CPUCoolingSystems.Where(
                component => component.FormFactor is not null &&
                component.FormFactor.Width <= componentHelper.FormFactor.Width &&
                component.FormFactor.Height <= componentHelper.FormFactor.Height &&
                component.FormFactor.Depth <= componentHelper.FormFactor.Depth);
        }

        return cpuCoolingSystems.ToImmutableList();
    }
}
