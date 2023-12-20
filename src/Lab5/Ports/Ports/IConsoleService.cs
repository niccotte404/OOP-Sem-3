using Domain.Models.ConsoleModels;

namespace Ports.Ports;

public interface IConsoleService
{
    void WriteMassage(string? message);
    Command GetMessage(string? commandString);
}