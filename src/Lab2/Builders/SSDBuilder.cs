using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders;
public class SSDBuilder : ISSDBuilder
{
    private SSD _ssd;
    private string? _connectionOption;
    private int _memoryAmount;
    private int _datatransferSpeed;
    private float _powerConsumption;

    public SSDBuilder()
    {
        _ssd = new SSD(
            connectionOption: _connectionOption,
            memoryAmount: _memoryAmount,
            maxDatatransferSpeed: _datatransferSpeed,
            powerConsumprion: _powerConsumption);
    }

    public SSD Build()
    {
        SSD ssd = _ssd;
        return ssd;
    }

    public ISSDBuilder GetSsdConnectionOption(string connectionOption)
    {
        _connectionOption = connectionOption;
        return this;
    }

    public ISSDBuilder GetSsdDatatransferSpeed(int datatransferSpeed)
    {
        _datatransferSpeed = datatransferSpeed;
        return this;
    }

    public ISSDBuilder GetSsdMemoryAmount(int memoryAmount)
    {
        _memoryAmount = memoryAmount;
        return this;
    }

    public ISSDBuilder GetSsdPowerConsumprion(float powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }
}
