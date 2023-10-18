﻿using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repository;
public class RAMRepository : RepositoryService<RAM>
{
    private readonly RepositoryContext _context;
    public RAMRepository(RepositoryContext context)
    {
        _context = context;
    }

    // that's not paradoxal 'cause we use componentHelper as model that has
    // each params to select main model with (EXAMPLE: socket is not null but other params are)
    public override IReadOnlyCollection<RAM> SelectComponent(RAM componentHelper)
    {
        if (_context.RAMs is null || componentHelper is null) return Enumerable.Empty<RAM>().ToImmutableList();
        IEnumerable<RAM> rams = _context.RAMs;

        if (componentHelper.MemoryAmount is not null)
        {
            rams = rams.Where(ram => ram.MemoryAmount >= componentHelper.MemoryAmount);
        }

        if (componentHelper.MemoryFrequencyAndJEDEC is not null)
        {
            rams = rams.Where(ram => ram.MemoryFrequencyAndJEDEC is not null && ram.MemoryFrequencyAndJEDEC.Intersect(componentHelper.MemoryFrequencyAndJEDEC).Any());
        }

        if (componentHelper.SupportedXMP is not null)
        {
            rams = rams.Where(ram => ram.SupportedXMP == componentHelper.SupportedXMP);
        }

        if (componentHelper.FormFactor is not null)
        {
            rams = rams.Where(
                component => component.FormFactor is not null &&
                component.FormFactor.Width <= componentHelper.FormFactor.Width &&
                component.FormFactor.Height <= componentHelper.FormFactor.Height &&
                component.FormFactor.Depth <= componentHelper.FormFactor.Depth);
        }

        if (componentHelper.DDR is not null)
        {
            rams = rams.Where(ram => ram.DDR == componentHelper.DDR);
        }

        if (componentHelper.PowerConsumption is not null)
        {
            rams = rams.Where(ram => ram.PowerConsumption <= componentHelper.PowerConsumption);
        }

        return rams.ToImmutableList();
    }
}