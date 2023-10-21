namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
public sealed class ComputerCase
{
    public ComputerCase(FormFactor? maxGPUFormFactor, FormFactor? motherboardFormFactor, FormFactor? formFactor)
    {
        MaxGPUFormFactor = maxGPUFormFactor;
        MotherboardFormFactor = motherboardFormFactor;
        FormFactor = formFactor;
    }

    public FormFactor? MaxGPUFormFactor { get; init; }
    public FormFactor? MotherboardFormFactor { get; init; }
    public FormFactor? FormFactor { get; init; }
}
