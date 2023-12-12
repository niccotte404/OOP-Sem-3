using Domain.Data.Enums;
using Domain.Models;
using Domain.Models.ConsoleModels;
using Ports.Ports;

namespace Application.Commands;

public class LogInCommand : IAppCommand
{
    private readonly IUserDbRepository _userDbRepository;
    private readonly IAdminDbRepository _adminDbRepository;
    private readonly IConsoleService _consoleService;
    private readonly Command _command;
    private string? _mode;
    private string? _userName;
    private string? _userPassword;
    private Roles _role;
    private string? _dbPassword;
    private string? _userId;

    public LogInCommand(IUserDbRepository userDbRepository, IAdminDbRepository adminDbRepository, IConsoleService consoleService, Command command)
    {
        _userDbRepository = userDbRepository;
        _adminDbRepository = adminDbRepository;
        _consoleService = consoleService;
        _command = command;
    }

    public void Execute()
    {
        Validate();
        if (_mode == "admin")
        {
            AdminData? adminData = _adminDbRepository.GetAdminDataByName(_userName);
            _dbPassword = adminData?.Password;
            _role = Roles.Admin;
            _userId = adminData?.UserId;
        }
        else
        {
            AccountData? userData = _userDbRepository.GetUserDataByName(_userName);
            _dbPassword = userData?.Pincode;
            _role = Roles.User;
            _userId = userData?.UserId;
        }

        if (_userPassword != _dbPassword)
        {
            _consoleService.WriteMassage("Wrong password");
            return;
        }

        AppContext.IsLoggedIn = true;
        AppContext.Id = _userId;
        AppContext.Role = _role;
    }

    public void Validate()
    {
        if (AppContext.Id is not null || AppContext.IsLoggedIn)
        {
            _consoleService.WriteMassage("Log out from current account");
            return;
        }

        _command.FlagAttributes.TryGetValue("-m", out _mode);
        _command.FlagAttributes.TryGetValue("-n", out _userName);
        _command.FlagAttributes.TryGetValue("-p", out _userPassword);
    }
}