using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models;
public sealed class Chipset
{
    public Chipset(IEnumerable<int> supportedMemoryFrequency, bool xmp)
    {
        SupportedMemoryFrequency = supportedMemoryFrequency;
        XMP = xmp;
    }

    public IEnumerable<int> SupportedMemoryFrequency { get; init; }
    public bool XMP { get; init; }
}
