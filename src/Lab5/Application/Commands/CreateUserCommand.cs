using Domain.Data.Enums;
using Domain.Models;
using Domain.Models.ConsoleModels;
using Ports.Ports;

namespace Application.Commands;

public class CreateUserCommand : IAppCommand
{
    private readonly IUserDbRepository? _userRepository;
    private readonly Command? _command;
    private string? _pincode;
    private int _balance;
    private Roles _role;
    private string? _userName;

    public CreateUserCommand(IUserDbRepository? userRepository, Command? command)
    {
        _userRepository = userRepository;
        _command = command;
    }

    public void Execute()
    {
        Validate();
        var accountData = new AccountData(null, _userName, _pincode, _balance, _role);
        _userRepository?.CreateUser(accountData);
    }

    public void Validate()
    {
        _balance = 0;
        _role = Roles.User;
        _command?.FlagAttributes.TryGetValue("-p", out _pincode);
        _command?.FlagAttributes.TryGetValue("-n", out _userName);
    }
}