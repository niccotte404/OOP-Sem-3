using System.ComponentModel.DataAnnotations.Schema;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.RequiredComponents;
public sealed class ComputerCase
{
    public ComputerCase(FormFactor maxGraphicAdapterFormFactor, FormFactor motherboardFormFactor, FormFactor formFactor)
    {
        MaxGraphicAdapterFormFactor = maxGraphicAdapterFormFactor;
        MotherboardFormFactor = motherboardFormFactor;
        FormFactor = formFactor;
    }

    [ForeignKey("GraphicAdapterFormFactor")]
    public FormFactor MaxGraphicAdapterFormFactor { get; init; }

    [ForeignKey("MotherboardFormFactor")]
    public FormFactor MotherboardFormFactor { get; init; }

    [ForeignKey("FormFactor")]
    public FormFactor FormFactor { get; init; }
}
