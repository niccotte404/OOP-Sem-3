using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
public sealed record Chipset(IEnumerable<int> SupportedMemoryFrequency, bool SupportXMP);
