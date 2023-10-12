using System.ComponentModel.DataAnnotations.Schema;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.RequiredComponents.OnCondition;
public sealed class GPU
{
    public GPU(int videoMemoryAmount, string versionPCI, int chipFrequency, float powerConsumption, FormFactor formFactor)
    {
        VideoMemoryAmount = videoMemoryAmount;
        VersionPCI = versionPCI;
        ChipFrequency = chipFrequency;
        FormFactor = formFactor;
        PowerConsumption = powerConsumption;
    }

    public int VideoMemoryAmount { get; init; }
    public string VersionPCI { get; init; }
    public int ChipFrequency { get; init; }
    public float PowerConsumption { get; init; }

    [ForeignKey("FormFactor")]
    public FormFactor FormFactor { get; init; }
}
