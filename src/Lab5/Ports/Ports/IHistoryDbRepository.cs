using System.Collections.Immutable;
using Domain.Models;

namespace Ports.Ports;
public interface IHistoryDbRepository
{
    void AddHistoryData(HistoryData historyData);
    ImmutableList<HistoryData>? GetHistoryData(string userId);
}
