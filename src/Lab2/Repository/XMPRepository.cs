using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Helpers;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repository;
public class XMPRepository : RepositoryService<XMPProfile, HelperXMPProfile>
{
    private readonly RepositoryContext _context;
    public XMPRepository(RepositoryContext context)
    {
        _context = context;
    }

    // that's not paradoxal 'cause we use componentHelper as model that has
    // each params to select main model with (EXAMPLE: socket is not null but other params are)
    public override IReadOnlyCollection<XMPProfile> SelectComponent(HelperXMPProfile componentHelper)
    {
        if (componentHelper is null) return Enumerable.Empty<XMPProfile>().ToImmutableList();
        IEnumerable<XMPProfile> xmps = _context.XMPProfiles;

        if (componentHelper.Timing is not null)
        {
            xmps = xmps.Where(xmp => xmp.Timing == componentHelper.Timing);
        }

        if (componentHelper.Voltage is not null)
        {
            xmps = xmps.Where(xmp => xmp.Voltage == componentHelper.Voltage);
        }

        if (componentHelper.MemoryFrequency is not null)
        {
            xmps = xmps.Where(xmp => xmp.MemoryFrequency == componentHelper.MemoryFrequency);
        }

        return xmps.ToImmutableList();
    }
}