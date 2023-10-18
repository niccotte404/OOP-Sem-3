namespace Itmo.ObjectOrientedProgramming.Lab2.Models;
public sealed class GPU
{
    public int? VideoMemoryAmount { get; set; }
    public string? VersionPCI { get; set; }
    public int? ChipFrequency { get; set; }
    public float? PowerConsumption { get; set; }
    public FormFactor? FormFactor { get; set; }
}
