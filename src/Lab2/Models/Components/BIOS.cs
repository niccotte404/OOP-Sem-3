using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
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