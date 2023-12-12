using Domain.Data.Enums;

namespace Application;

public static class AppContext
{
    public static bool IsLoggedIn { get; set; }
    public static Roles? Role { get; set; }
    public static string? Id { get; set; }
}