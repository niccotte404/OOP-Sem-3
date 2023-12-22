using Domain.Models;

namespace Ports.Ports;

public interface IAdminDbRepository
{
    void CreateAdmin(AdminData admin);
    AdminData? GetAdminDataByName(string? adminName);
}