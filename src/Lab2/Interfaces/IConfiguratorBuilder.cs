using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
public interface IConfiguratorBuilder
{
    public ConfigPC Build();
    public IConfiguratorBuilder SetMotherboard(Motherboard motherboard);
    public IConfiguratorBuilder SetCPU(CPU cpu);
    public IConfiguratorBuilder SetBIOS(BIOS bios);
    public IConfiguratorBuilder SetCoolingSystem(CPUCoolingSystem coolingSystem);
    public IConfiguratorBuilder SetRAM(RAM ram);
    public IConfiguratorBuilder SetXMP(XMPProfile xmp);
    public IConfiguratorBuilder SetSSD(SSD ssd);
    public IConfiguratorBuilder SetHDD(HDD hdd);
    public IConfiguratorBuilder SetGPU(GPU gpu);
    public IConfiguratorBuilder SetComputerCase(ComputerCase computerCase);
    public IConfiguratorBuilder SetPowerUnit(PowerUnit powerUnit);
    public IConfiguratorBuilder SetWiFiAdapter(WiFiAdapter wifiAdapter);
}
