using Domain.Data.Enums;

namespace Domain.Models;

public class AccountData
{
    public AccountData(string? userId, string? userName, string? pincode, int balance, Roles? role)
    {
        UserId = userId;
        Pincode = pincode;
        Balance = balance;
        Role = role;
        UserName = userName;
    }

    public string? UserId { get; init; }
    public string? Pincode { get; init; }
    public int Balance { get; init; }
    public Roles? Role { get; init; }
    public string? UserName { get; init; }
}