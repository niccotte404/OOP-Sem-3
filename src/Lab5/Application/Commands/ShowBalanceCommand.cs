using Domain.Data.Enums;
using Domain.Models;
using Ports.Ports;

namespace Application.Commands;

public class ShowBalanceCommand : IAppCommand
{
    private readonly IUserDbRepository _userRepository;
    private readonly IConsoleService _consoleService;
    private readonly IHistoryDbRepository _historyDbRepository;

    public ShowBalanceCommand(IUserDbRepository userRepository, IConsoleService consoleService, IHistoryDbRepository historyDbRepository)
    {
        _userRepository = userRepository;
        _consoleService = consoleService;
        _historyDbRepository = historyDbRepository;
    }

    public void Execute()
    {
        if (AppContext.Role is not Roles.User || AppContext.Id is null) return;
        AccountData? currAccount = _userRepository.GetUserDataById(AppContext.Id);
        if (currAccount is null) return;
        _historyDbRepository.AddHistoryData(new HistoryData(AppContext.Id, "Show Balance"));
        _consoleService.WriteMassage($"Balance: {currAccount.Balance}");
    }

    public void Validate()
    {
        return;
    }
}