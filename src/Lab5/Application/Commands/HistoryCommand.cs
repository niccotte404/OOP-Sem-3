using Domain.Data.Enums;
using Domain.Models;
using Ports.Ports;

namespace Application.Commands;

public class HistoryCommand : IAppCommand
{
    private readonly IHistoryDbRepository _historyDbRepository;
    private readonly IConsoleService _consoleService;

    public HistoryCommand(IHistoryDbRepository historyDbRepository, IConsoleService consoleService)
    {
        _historyDbRepository = historyDbRepository;
        _consoleService = consoleService;
    }

    public void Execute()
    {
        if (AppContext.IsLoggedIn is false || AppContext.Role is not Roles.User || AppContext.Id is null) return;
        IEnumerable<HistoryData>? historyData = _historyDbRepository.GetHistoryData(AppContext.Id);
        historyData?.AsParallel().ForAll(data => _consoleService.WriteMassage(data.Message));
    }

    public void Validate()
    {
        return;
    }
}