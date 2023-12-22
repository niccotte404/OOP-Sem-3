using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Helpers;
public sealed class HelperGPU
{
    public int? VideoMemoryAmount { get; set; }
    public string? VersionPCI { get; set; }
    public int? ChipFrequency { get; set; }
    public float? PowerConsumption { get; set; }
    public FormFactor? FormFactor { get; set; }
}
