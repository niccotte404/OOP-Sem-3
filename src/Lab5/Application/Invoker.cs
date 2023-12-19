using Application.Commands;
using Domain.Models.ConsoleModels;
using Ports.Ports;

namespace Application;

public class Invoker
{
    private static IConsoleService? _consoleService;
    private static IUserDbRepository? _userDbRepository;
    private static IAdminDbRepository? _adminDbRepository;
    private static IHistoryDbRepository? _historyDbRepository;
    private static Command? _command;

    private IDictionary<string, Func<IAppCommand>> _commandMap = new Dictionary<string, Func<IAppCommand>>()
    {
        ["create"] = () => new CreateUserCommand(_userDbRepository, _command),
        ["login"] = () => new LogInCommand(_userDbRepository, _adminDbRepository, _consoleService, _command),
        ["logout"] = () => new LogOutCommand(_command),
        ["show balance"] = () => new ShowBalanceCommand(_userDbRepository, _consoleService, _historyDbRepository),
        ["decrease"] = () => new DecreaseBalanceCommand(_userDbRepository, _command, _historyDbRepository),
        ["increase"] = () => new IncreaseBalanceCommand(_userDbRepository, _command, _historyDbRepository),
        ["history"] = () => new HistoryCommand(_historyDbRepository, _consoleService),
    };

    public Invoker(IConsoleService? consoleService, IUserDbRepository? userDbRepository, IAdminDbRepository? adminDbRepository, IHistoryDbRepository? historyDbRepository)
    {
        _consoleService = consoleService;
        _userDbRepository = userDbRepository;
        _adminDbRepository = adminDbRepository;
        _historyDbRepository = historyDbRepository;
        _command = _consoleService?.GetMessage();
    }

    public void Invoke()
    {
        if (_command is null || _command.CommandName is null) return;
        Func<IAppCommand>? invokeCommand;
        _commandMap.TryGetValue(_command.CommandName, out invokeCommand);
        if (invokeCommand is null) return;
        invokeCommand().Execute();
    }
}