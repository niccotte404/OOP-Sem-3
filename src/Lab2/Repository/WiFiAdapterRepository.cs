using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Repository;
public class WiFiAdapterRepository : RepositoryService<WiFiAdapter>
{
    private readonly RepositoryContext _context;
    public WiFiAdapterRepository(RepositoryContext context)
    {
        _context = context;
    }

    public override IReadOnlyCollection<WiFiAdapter> SelectComponent(WiFiAdapter componentHelper)
    {
        if (_context.WiFiAdapters is null || componentHelper is null) return Enumerable.Empty<WiFiAdapter>().ToImmutableList();
        IEnumerable<WiFiAdapter> wifiAdapters = _context.WiFiAdapters;

        if (componentHelper.Version is not null)
        {
            wifiAdapters = wifiAdapters.Where(adapter => adapter.Version == componentHelper.Version);
        }

        if (componentHelper.BuiltInBluetoothModule is not null)
        {
            wifiAdapters = wifiAdapters.Where(adapter => adapter.BuiltInBluetoothModule == componentHelper.BuiltInBluetoothModule);
        }

        if (componentHelper.VersionPCI is not null)
        {
            wifiAdapters = wifiAdapters.Where(adapter => adapter.VersionPCI == componentHelper.VersionPCI);
        }

        if (componentHelper.PowerConsumption is not null)
        {
            wifiAdapters = wifiAdapters.Where(adapter => adapter.PowerConsumption <= componentHelper.PowerConsumption);
        }

        return wifiAdapters.ToImmutableList();
    }
}
