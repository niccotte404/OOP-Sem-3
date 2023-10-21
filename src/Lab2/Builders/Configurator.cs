using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Controllers;
public class Configurator : IConfiguratorBuilder
{
    private PC _pc;
    private Motherboard? _motherboard;
    private CPU? _cpu;
    private BIOS? _bios;
    private CPUCoolingSystem? _cpuCoolingSystem;
    private RAM? _ram;
    private XMPProfile? _xmp;
    private GPU? _gpu;
    private SSD? _ssd;
    private HDD? _hdd;
    private ComputerCase? _computerCase;
    private PowerUnit? _powerUnit;
    private WiFiAdapter? _wifiAdapter;
    public Configurator()
    {
        _pc = new PC(
            motherboard: _motherboard,
            cpu: _cpu,
            bios: _bios,
            cpuCoolingSystem: _cpuCoolingSystem,
            ram: _ram,
            xmpProfile: _xmp,
            gpu: _gpu,
            ssd: _ssd,
            hdd: _hdd,
            computerCase: _computerCase,
            powerUnit: _powerUnit,
            wifiAdapter: _wifiAdapter);
    }

    public PC Build()
    {
        PC pc = _pc;
        return pc;
    }

    public IConfiguratorBuilder SetBIOS(BIOS bios)
    {
        _bios = bios;
        return this;
    }

    public IConfiguratorBuilder SetComputerCase(ComputerCase computerCase)
    {
        _computerCase = computerCase;
        return this;
    }

    public IConfiguratorBuilder SetCoolingSystem(CPUCoolingSystem coolingSystem)
    {
        _cpuCoolingSystem = coolingSystem;
        return this;
    }

    public IConfiguratorBuilder SetCPU(CPU cpu)
    {
        _cpu = cpu;
        return this;
    }

    public IConfiguratorBuilder SetHDD(HDD hdd)
    {
        _hdd = hdd;
        return this;
    }

    public IConfiguratorBuilder SetMotherboard(Motherboard motherboard)
    {
        _motherboard = motherboard;
        return this;
    }

    public IConfiguratorBuilder SetPowerUnit(PowerUnit powerUnit)
    {
        _powerUnit = powerUnit;
        return this;
    }

    public IConfiguratorBuilder SetRAM(RAM ram)
    {
        _ram = ram;
        return this;
    }

    public IConfiguratorBuilder SetSSD(SSD ssd)
    {
        _ssd = ssd;
        return this;
    }

    public IConfiguratorBuilder SetWiFiAdapter(WiFiAdapter wifiAdapter)
    {
        _wifiAdapter = wifiAdapter;
        return this;
    }

    public IConfiguratorBuilder SetXMP(XMPProfile xmp)
    {
        _xmp = xmp;
        return this;
    }
}