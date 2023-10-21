using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

public sealed class Motherboard
{
    public Motherboard(string? socket, int amountPCI, int amountSATA, string? standartDDR, int amountRAM, IEnumerable<BIOS>? bios, FormFactor? formFactor, Chipset? chipset)
    {
        Socket = socket;
        AmountPCI = amountPCI;
        AmountSATA = amountSATA;
        StandartDDR = standartDDR;
        AmountRAM = amountRAM;
        BIOS = bios;
        FormFactor = formFactor;
        Chipset = chipset;
    }

    public string? Socket { get; init; }
    public int AmountPCI { get; init; }
    public int AmountSATA { get; init; }
    public string? StandartDDR { get; init; }
    public int AmountRAM { get; init; }
    public IEnumerable<BIOS>? BIOS { get; init; }
    public FormFactor? FormFactor { get; init; }
    public Chipset? Chipset { get; init; }
}
