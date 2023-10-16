using Itmo.ObjectOrientedProgramming.Lab2.Enums;

namespace Itmo.ObjectOrientedProgramming.Lab2.Models.RequiredComponents.OnCondition;
public sealed class SSD
{
    public ConnectionSSD? ConnectionOption { get; set; }
    public int? MemoryAmount { get; set; }
    public int? MaxDatatransferSpeed { get; set; }
    public float? PowerConsumprion { get; set; }
}
