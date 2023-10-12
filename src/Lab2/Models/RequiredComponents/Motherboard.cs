using System.ComponentModel.DataAnnotations.Schema;
using Itmo.ObjectOrientedProgramming.Lab2.Models.NoneRequiredComponents;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.RequiredComponents;

public sealed class Motherboard
{
    public Motherboard(string socket, int amountPCI, int amountSATA, string standartDDR, int amountRAM, BIOS bios, FormFactor formFactor, Chipset chipset)
    {
        Socket = socket;
        AmountPCI = amountPCI;
        AmountSATA = amountSATA;
        StandartDDR = standartDDR;
        AmountRAM = amountRAM;
        FormFactor = formFactor;
        Chipset = chipset;
        BIOS = bios;
    }

    public string Socket { get; init; }
    public int AmountPCI { get; init; }
    public int AmountSATA { get; init; }
    public string StandartDDR { get; init; }
    public int AmountRAM { get; init; }

    [ForeignKey("BIOS")]
    public BIOS BIOS { get; init; }

    [ForeignKey("FormFactor")]
    public FormFactor FormFactor { get; init; }

    [ForeignKey("Chipinit")]
    public Chipset Chipset { get; init; }
}
