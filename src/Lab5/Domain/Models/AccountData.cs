using Domain.Data.Enums;

namespace Domain.Models;

public class AccountData
{
    public AccountData(string? userId, string? userName, string? pincode, decimal balance, Roles? role)
    {
        UserId = userId;
        Pincode = pincode;
        Balance = balance;
        Role = role;
        UserName = userName;
    }

    public string? UserId { get; init; }
    public string? Pincode { get; init; }
    public decimal Balance { get; init; }
    public Roles? Role { get; init; }
    public string? UserName { get; init; }
}