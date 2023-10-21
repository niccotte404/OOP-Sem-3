namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
public sealed class XMPProfile
{
    public XMPProfile(string timing, float voltage, int memoryFrequency)
    {
        Timing = timing;
        Voltage = voltage;
        MemoryFrequency = memoryFrequency;
    }

    public string Timing { get; init; }
    public float Voltage { get; init; }
    public int MemoryFrequency { get; init; }
}