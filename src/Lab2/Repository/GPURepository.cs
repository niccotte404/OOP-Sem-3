using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Helpers;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repository;
public class GPURepository : RepositoryService<GPU, HelperGPU>
{
    private readonly RepositoryContext _context;
    public GPURepository(RepositoryContext context)
    {
        _context = context;
    }

    public override IReadOnlyCollection<GPU> SelectComponent(HelperGPU componentHelper)
    {
        if (componentHelper is null) return Enumerable.Empty<GPU>().ToImmutableList();
        IEnumerable<GPU> gpus = _context.GPUs;

        if (componentHelper.FormFactor is not null)
        {
            gpus = gpus.Where(
                component => component.FormFactor is not null &&
                component.FormFactor.Width <= componentHelper.FormFactor.Width &&
                component.FormFactor.Height <= componentHelper.FormFactor.Height &&
                component.FormFactor.Depth <= componentHelper.FormFactor.Depth);
        }

        if (componentHelper.VideoMemoryAmount is not null)
        {
            gpus = gpus.Where(gpu => gpu.VideoMemoryAmount == componentHelper.VideoMemoryAmount);
        }

        if (componentHelper.VersionPCI is not null)
        {
            gpus = gpus.Where(gpu => gpu.VersionPCI == componentHelper.VersionPCI);
        }

        if (componentHelper.ChipFrequency is not null)
        {
            gpus = gpus.Where(gpu => gpu.ChipFrequency == componentHelper.ChipFrequency);
        }

        if (componentHelper.PowerConsumption is not null)
        {
            gpus = gpus.Where(gpu => gpu.PowerConsumption <= componentHelper.PowerConsumption);
        }

        return gpus.ToImmutableList();
    }
}
