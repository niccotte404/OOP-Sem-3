using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repository;
public class ComputerCaseRepository : RepositoryService<ComputerCase>
{
    private readonly RepositoryContext _context;
    public ComputerCaseRepository(RepositoryContext context)
    {
        _context = context;
    }

    public override IReadOnlyCollection<ComputerCase> SelectComponent(ComputerCase componentHelper)
    {
        if (_context.ComputerCases is null || componentHelper is null) return Enumerable.Empty<ComputerCase>().ToImmutableList();
        IEnumerable<ComputerCase> computerCases = _context.ComputerCases;

        if (componentHelper.MotherboardFormFactor is not null)
        {
            computerCases = computerCases.Where(
                component => component.MotherboardFormFactor is not null &&
                component.MotherboardFormFactor.Width <= componentHelper.MotherboardFormFactor.Width &&
                component.MotherboardFormFactor.Height <= componentHelper.MotherboardFormFactor.Height &&
                component.MotherboardFormFactor.Depth <= componentHelper.MotherboardFormFactor.Depth);
        }

        if (componentHelper.MaxGraphicAdapterFormFactor is not null)
        {
            computerCases = computerCases.Where(
                component => component.MaxGraphicAdapterFormFactor is not null &&
                component.MaxGraphicAdapterFormFactor.Width <= componentHelper.MaxGraphicAdapterFormFactor.Width &&
                component.MaxGraphicAdapterFormFactor.Height <= componentHelper.MaxGraphicAdapterFormFactor.Height &&
                component.MaxGraphicAdapterFormFactor.Depth <= componentHelper.MaxGraphicAdapterFormFactor.Depth);
        }

        if (componentHelper.FormFactor is not null)
        {
            computerCases = computerCases.Where(
                component => component.FormFactor is not null &&
                component.FormFactor.Width <= componentHelper.FormFactor.Width &&
                component.FormFactor.Height <= componentHelper.FormFactor.Height &&
                component.FormFactor.Depth <= componentHelper.FormFactor.Depth);
        }

        return computerCases.ToImmutableList();
    }
}
