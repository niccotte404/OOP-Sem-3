using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.RequiredComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.NoneRequiredComponents;
public sealed class BIOS
{
    public BIOS(string type, string version, IEnumerable<CPU> supportedCPU)
    {
        Type = type;
        Version = version;
        SupportedCPU = supportedCPU;
    }

    public string Type { get; init; }
    public string Version { get; init; }
    public IEnumerable<CPU> SupportedCPU { get; init; }
}
