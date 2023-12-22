namespace Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
public class PC
{
    public PC(Motherboard? motherboard, CPU? cpu, BIOS? bios, CPUCoolingSystem? cpuCoolingSystem, RAM? ram, XMPProfile? xmpProfile, GPU? gpu, SSD? ssd, HDD? hdd, ComputerCase? computerCase, PowerUnit? powerUnit, WiFiAdapter? wifiAdapter)
    {
        Motherboard = motherboard;
        CPU = cpu;
        BIOS = bios;
        CPUCoolingSystem = cpuCoolingSystem;
        RAM = ram;
        XMPProfile = xmpProfile;
        GPU = gpu;
        SSD = ssd;
        HDD = hdd;
        ComputerCase = computerCase;
        PowerUnit = powerUnit;
        WiFiAdapter = wifiAdapter;
    }

    public Motherboard? Motherboard { get; private set; }
    public CPU? CPU { get; private set; }
    public BIOS? BIOS { get; private set; }
    public CPUCoolingSystem? CPUCoolingSystem { get; private set; }
    public RAM? RAM { get; private set; }
    public XMPProfile? XMPProfile { get; private set; }
    public GPU? GPU { get; private set; }
    public SSD? SSD { get; private set; }
    public HDD? HDD { get; private set; }
    public ComputerCase? ComputerCase { get; private set; }
    public PowerUnit? PowerUnit { get; private set; }
    public WiFiAdapter? WiFiAdapter { get; private set; }
}
