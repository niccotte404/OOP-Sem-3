using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Helpers;

public sealed class HelperMotherboard
{
    public string? Socket { get; set; }
    public int? AmountPCI { get; set; }
    public int? AmountSATA { get; set; }
    public string? StandartDDR { get; set; }
    public int? AmountRAM { get; set; }
    public IEnumerable<BIOS>? BIOS { get; set; }
    public FormFactor? FormFactor { get; set; }
    public Chipset? Chipset { get; set; }
}
