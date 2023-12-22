using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders.Compositors;
public class SSDBuilder : IMemoryComponent<SSD>
{
    private string? _connectionOption;
    private int _memoryAmount;
    private int _datatransferSpeed;
    private float _powerConsumption;

    public SSD Build()
    {
        var ssd = new SSD(
            connectionOption: _connectionOption,
            memoryAmount: _memoryAmount,
            maxDatatransferSpeed: _datatransferSpeed,
            powerConsumprion: _powerConsumption);
        ValidateComponents.IsSSDValid(ssd);
        return ssd;
    }

    public IMemoryComponent<SSD> GetConnectionOption(string connectionOption)
    {
        _connectionOption = connectionOption;
        return this;
    }

    public IMemoryComponent<SSD> GetDatatransferSpeed(int datatransferSpeed)
    {
        _datatransferSpeed = datatransferSpeed;
        return this;
    }

    public IMemoryComponent<SSD> GetMemoryAmount(int memoryAmount)
    {
        _memoryAmount = memoryAmount;
        return this;
    }

    public IMemoryComponent<SSD> GetPowerConsumprion(float powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }
}
