using Itmo.ObjectOrientedProgramming.Lab2.Data.Enums;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models;
public class ConfigPC
{
    public ConfigPC(PC? pc, Results result, string? errorMessage)
    {
        PC = pc;
        Result = result;
        ErrorMessage = errorMessage;
    }

    public PC? PC { get; init; }
    public Results Result { get; init; }
    public string? ErrorMessage { get; init; }
}
