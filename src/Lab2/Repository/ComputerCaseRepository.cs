using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Helpers;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repository;
public class ComputerCaseRepository : RepositoryService<ComputerCase, HelperComputerCase>
{
    private readonly RepositoryContext _context;
    public ComputerCaseRepository(RepositoryContext context)
    {
        _context = context;
    }

    public override IReadOnlyCollection<ComputerCase> SelectComponent(HelperComputerCase componentHelper)
    {
        if (componentHelper is null) return Enumerable.Empty<ComputerCase>().ToImmutableList();
        IEnumerable<ComputerCase> computerCases = _context.ComputerCases;

        if (componentHelper.MotherboardFormFactor is not null)
        {
            computerCases = computerCases.Where(
                component => component.MotherboardFormFactor is not null &&
                component.MotherboardFormFactor.Width <= componentHelper.MotherboardFormFactor.Width &&
                component.MotherboardFormFactor.Height <= componentHelper.MotherboardFormFactor.Height &&
                component.MotherboardFormFactor.Depth <= componentHelper.MotherboardFormFactor.Depth);
        }

        if (componentHelper.MaxGPUFormFactor is not null)
        {
            computerCases = computerCases.Where(
                component => component.MaxGPUFormFactor is not null &&
                component.MaxGPUFormFactor.Width <= componentHelper.MaxGPUFormFactor.Width &&
                component.MaxGPUFormFactor.Height <= componentHelper.MaxGPUFormFactor.Height &&
                component.MaxGPUFormFactor.Depth <= componentHelper.MaxGPUFormFactor.Depth);
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
