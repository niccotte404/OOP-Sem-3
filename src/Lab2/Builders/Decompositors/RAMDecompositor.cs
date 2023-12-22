using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders.Decompositors;
public class RAMDecompositor : IRAMBuilder
{
    private int _memoryAmount;
    private IEnumerable<FrequensyAndJEDEC>? _frequensyAndJEDEC;
    private IEnumerable<XMPProfile>? _xmpProfiles;
    private FormFactor? _formFactor;
    private string? _ddr;
    private float _powerConsumption;
    private RAM _ram;

    public RAMDecompositor(RAM ram)
    {
        _ram = ram;
        _memoryAmount = _ram.MemoryAmount;
        _frequensyAndJEDEC = _ram.FrequencyAndJEDEC;
        _xmpProfiles = _ram.SupportedXMP;
        _formFactor = _ram.FormFactor;
        _ddr = _ram.DDR;
        _powerConsumption = _ram.PowerConsumption;
    }

    public RAM Build()
    {
        var ram = new RAM(
            memoryAmount: _memoryAmount,
            frequencyAndJEDEC: _frequensyAndJEDEC,
            supportedXMP: _xmpProfiles,
            formFactor: _formFactor,
            ddr: _ddr,
            powerConsumption: _powerConsumption);
        ValidateComponents.IsRAMValid(ram);
        return ram;
    }

    public IRAMBuilder GetRamDDR(string ddr)
    {
        _ddr = ddr;
        return this;
    }

    public IRAMBuilder GetRamFormFactor(FormFactor formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public IRAMBuilder GetRamFrequencyAndJEDEC(IEnumerable<FrequensyAndJEDEC> frequencyAndJEDEC)
    {
        _frequensyAndJEDEC = frequencyAndJEDEC;
        return this;
    }

    public IRAMBuilder GetRamMemoryAmount(int memoryAmount)
    {
        _memoryAmount = memoryAmount;
        return this;
    }

    public IRAMBuilder GetRamPowerConsumption(float powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public IRAMBuilder GetRamSupportedXMP(IEnumerable<XMPProfile> xmps)
    {
        _xmpProfiles = xmps;
        return this;
    }
}
