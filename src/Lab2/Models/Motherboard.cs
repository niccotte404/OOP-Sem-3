namespace Itmo.ObjectOrientedProgramming.Lab2.Models;

public sealed class Motherboard
{
    public string? Socket { get; set; }
    public int? AmountPCI { get; set; }
    public int? AmountSATA { get; set; }
    public string? StandartDDR { get; set; }
    public int? AmountRAM { get; set; }
    public BIOS? BIOS { get; set; }
    public FormFactor? FormFactor { get; set; }
    public Chipset? Chipset { get; set; }
}
