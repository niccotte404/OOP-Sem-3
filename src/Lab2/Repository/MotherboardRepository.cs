using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.RequiredComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repository;
public class MotherboardRepository : IRepositoryService<Motherboard>
{
    private readonly RepositoryContext _context;
    public MotherboardRepository(RepositoryContext context)
    {
        _context = context;
    }

    public void Add(Motherboard component)
    {
        if (_context.Motherboards is null) return;
        _context.Motherboards.Add(component);
    }

    public void Remove(Motherboard component)
    {
        if (_context.Motherboards is null) return;
        _context.Motherboards.Remove(component);
    }

    public bool IsExists(Motherboard component)
    {
        if (_context.Motherboards is null) return false;
        return _context.Motherboards.Contains(component);
    }

    public void Update(Motherboard oldComponent, Motherboard newComponent)
    {
        if (_context.Motherboards is null) return;
        if (IsExists(oldComponent) == false) return;
        _context.Motherboards.Remove(oldComponent);
        _context.Motherboards.Add(newComponent);
    }

    // that's not paradoxal 'cause we use componentHelper as model that has
    // each params to select main model with (EXAMPLE: socket is not null but other params are)
    public IReadOnlyCollection<Motherboard> SelectComponent(Motherboard componentHelper)
    {
        IEnumerable<Motherboard> motherboard = new List<Motherboard>();
        if (_context.Motherboards is null || componentHelper is null) return motherboard.ToImmutableList();

        if (componentHelper.Socket is not null)
        {
            motherboard = _context.Motherboards.Where(component => component.Socket == componentHelper.Socket);
        }

        if (componentHelper.AmountPCI is not null)
        {
            motherboard = _context.Motherboards.Where(component => component.AmountPCI == componentHelper.AmountPCI);
        }

        if (componentHelper.AmountSATA is not null)
        {
            motherboard = _context.Motherboards.Where(component => component.AmountSATA == componentHelper.AmountSATA);
        }

        if (componentHelper.Chipset is not null)
        {
            motherboard = _context.Motherboards.Where(component => component.Chipset == componentHelper.Chipset);
        }

        if (componentHelper.StandartDDR is not null)
        {
            motherboard = _context.Motherboards.Where(component => component.StandartDDR == componentHelper.StandartDDR);
        }

        if (componentHelper.AmountRAM is not null)
        {
            motherboard = _context.Motherboards.Where(component => component.AmountRAM == componentHelper.AmountRAM);
        }

        if (componentHelper.FormFactor is not null)
        {
            motherboard = _context.Motherboards.Where(
                component => component.FormFactor is not null &&
                component.FormFactor.Width <= componentHelper.FormFactor.Width &&
                component.FormFactor.Height <= componentHelper.FormFactor.Height &&
                component.FormFactor.Depth <= componentHelper.FormFactor.Depth);
        }

        if (componentHelper.BIOS is not null)
        {
            motherboard = _context.Motherboards.Where(component => component.BIOS == componentHelper.BIOS);
        }

        return motherboard.ToImmutableList();
    }
}
