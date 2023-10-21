using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Helpers;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repository;
public class CPUCoolingSystemRepository : RepositoryService<CPUCoolingSystem, HelperCoolingSystem>
{
    private readonly RepositoryContext _context;
    public CPUCoolingSystemRepository(RepositoryContext context)
    {
        _context = context;
    }

    // that's not paradoxal 'cause we use componentHelper as model that has
    // each params to select main model with (EXAMPLE: socket is not null but other params are)
    public override IReadOnlyCollection<CPUCoolingSystem> SelectComponent(HelperCoolingSystem componentHelper)
    {
        if (componentHelper is null) return Enumerable.Empty<CPUCoolingSystem>().ToImmutableList();
        IEnumerable<CPUCoolingSystem> cpuCoolingSystems = _context.CPUCoolingSystems;

        if (componentHelper.SupportedSockets is not null)
        {
            cpuCoolingSystems = cpuCoolingSystems.Where(cpuCoolingSystem => cpuCoolingSystem.SupportedSockets is not null && cpuCoolingSystem.SupportedSockets.Intersect(componentHelper.SupportedSockets).Any());
        }

        if (componentHelper.MaxTDP is not null)
        {
            cpuCoolingSystems = cpuCoolingSystems.Where(cpuCoolingSystem => cpuCoolingSystem.MaxTDP >= componentHelper.MaxTDP);
        }

        if (componentHelper.FormFactor is not null)
        {
            cpuCoolingSystems = cpuCoolingSystems.Where(
                component => component.FormFactor is not null &&
                component.FormFactor.Width <= componentHelper.FormFactor.Width &&
                component.FormFactor.Height <= componentHelper.FormFactor.Height &&
                component.FormFactor.Depth <= componentHelper.FormFactor.Depth);
        }

        return cpuCoolingSystems.ToImmutableList();
    }
}
