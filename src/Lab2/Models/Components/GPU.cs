namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
public sealed class GPU
{
    public GPU(int videoMemoryAmount, string? versionPCI, int chipFrequency, float powerConsumption, FormFactor? formFactor)
    {
        VideoMemoryAmount = videoMemoryAmount;
        VersionPCI = versionPCI;
        ChipFrequency = chipFrequency;
        PowerConsumption = powerConsumption;
        FormFactor = formFactor;
    }

    public int VideoMemoryAmount { get; init; }
    public string? VersionPCI { get; init; }
    public int ChipFrequency { get; init; }
    public float PowerConsumption { get; init; }
    public FormFactor? FormFactor { get; init; }
}
