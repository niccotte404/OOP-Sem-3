using Domain.Data.Enums;

namespace Domain.Models;

public class AdminData
{
    public AdminData(string? userId, string? userName, string? password, Roles? role)
    {
        UserId = userId;
        UserName = userName;
        Password = password;
        Role = role;
    }

    public string? UserId { get; init; }
    public string? UserName { get; init; }
    public string? Password { get; init; }
    public Roles? Role { get; init; }
}