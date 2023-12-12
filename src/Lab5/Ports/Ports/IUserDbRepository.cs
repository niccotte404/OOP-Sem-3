using Domain.Models;

namespace Ports.Ports;
public interface IUserDbRepository
{
    void CreateUser(AccountData account);
    AccountData? GetUserDataByName(string? userName);
    AccountData? GetUserDataById(string? userId);
    void SetBalance(string userId, decimal balance);
}
