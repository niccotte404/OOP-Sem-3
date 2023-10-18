using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repository;
public class MotherboardRepository : RepositoryService<Motherboard>
{
    private readonly RepositoryContext _context;
    public MotherboardRepository(RepositoryContext context)
    {
        _context = context;
    }

    // that's not paradoxal 'cause we use componentHelper as model that has
    // each params to select main model with (EXAMPLE: socket is not null but other params are)
    public override IReadOnlyCollection<Motherboard> SelectComponent(Motherboard componentHelper)
    {
        if (_context.Motherboards is null || componentHelper is null) return Enumerable.Empty<Motherboard>().ToImmutableList();
        IEnumerable<Motherboard> motherboard = _context.Motherboards;

        if (componentHelper.Socket is not null)
        {
            motherboard = motherboard.Where(component => component.Socket == componentHelper.Socket);
        }

        if (componentHelper.AmountPCI is not null)
        {
            motherboard = motherboard.Where(component => component.AmountPCI >= componentHelper.AmountPCI);
        }

        if (componentHelper.AmountSATA is not null)
        {
            motherboard = motherboard.Where(component => component.AmountSATA >= componentHelper.AmountSATA);
        }

        if (componentHelper.Chipset is not null)
        {
            motherboard = motherboard.Where(component => component.Chipset == componentHelper.Chipset);
        }

        if (componentHelper.StandartDDR is not null)
        {
            motherboard = motherboard.Where(component => component.StandartDDR == componentHelper.StandartDDR);
        }

        if (componentHelper.AmountRAM is not null)
        {
            motherboard = motherboard.Where(component => component.AmountRAM >= componentHelper.AmountRAM);
        }

        if (componentHelper.FormFactor is not null)
        {
            motherboard = motherboard.Where(
                component => component.FormFactor is not null &&
                component.FormFactor.Width <= componentHelper.FormFactor.Width &&
                component.FormFactor.Height <= componentHelper.FormFactor.Height &&
                component.FormFactor.Depth <= componentHelper.FormFactor.Depth);
        }

        if (componentHelper.BIOS is not null)
        {
            motherboard = motherboard.Where(component => component.BIOS == componentHelper.BIOS);
        }

        return motherboard.ToImmutableList();
    }
}
