using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Itmo.ObjectOrientedProgramming.Lab2.Models.NoneRequiredComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.RequiredComponents;
public sealed class RAM
{
    public RAM(int memoryAmount, int memoryFrequency, IEnumerable<XMPProfile> supportedXMP)
    {
        MemoryAmount = memoryAmount;
        MemoryFrequency = memoryFrequency;
        SupportedXMP = supportedXMP;
    }

    public int MemoryAmount { get; init; }
    public int MemoryFrequency { get; init; }

    [ForeignKey("XMPProfile")]
    public IEnumerable<XMPProfile> SupportedXMP { get; init; }
}
