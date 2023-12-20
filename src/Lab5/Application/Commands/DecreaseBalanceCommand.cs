using System.Globalization;
using Domain.Data.Enums;
using Domain.Models;
using Domain.Models.ConsoleModels;
using Ports.Ports;

namespace Application.Commands;

public class DecreaseBalanceCommand : IAppCommand
{
    private readonly IUserDbRepository? _userDbRepository;
    private readonly IHistoryDbRepository? _historyDbRepository;
    private readonly Command? _command;
    private int _decreaseBalance;
    private string? _decreaseBalanceString;

    public DecreaseBalanceCommand(IUserDbRepository? userDbRepository, Command? command, IHistoryDbRepository? historyDbRepository)
    {
        _userDbRepository = userDbRepository;
        _command = command;
        _historyDbRepository = historyDbRepository;
    }

    public void Execute()
    {
        Validate();
        if (AppContext.IsLoggedIn is false || AppContext.Role is not Roles.User) return;
        AccountData? currAccount = _userDbRepository?.GetUserDataById(AppContext.Id);
        if (currAccount is null || AppContext.Id is null) return;
        if (currAccount.Balance - _decreaseBalance < 0)
            throw new ArgumentException("Failed to decrease balance");
        AppContext.Balance = currAccount.Balance - _decreaseBalance;
        _userDbRepository?.SetBalance(AppContext.Id, currAccount.Balance - _decreaseBalance);
        _historyDbRepository?.AddHistoryData(new HistoryData(AppContext.Id, "Decrease Balance"));
    }

    public void Validate()
    {
        _command?.FlagAttributes.TryGetValue("-b", out _decreaseBalanceString);
        _decreaseBalance = Convert.ToInt32(_decreaseBalanceString, new NumberFormatInfo());
    }
}