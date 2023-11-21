using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders.Decompositors;
public class SSDDecompositor
{
    private string? _connectionOption;
    private int _memoryAmount;
    private int _datatransferSpeed;
    private float _powerConsumption;
    private SSD _ssd;

    public SSDDecompositor(SSD ssd)
    {
        _ssd = ssd;
        _datatransferSpeed = _ssd.MaxDatatransferSpeed;
        _memoryAmount = _ssd.MemoryAmount;
        _connectionOption = _ssd.ConnectionOption;
        _powerConsumption = _ssd.PowerConsumprion;
    }

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

    public SSDDecompositor GetSsdConnectionOption(string connectionOption)
    {
        _connectionOption = connectionOption;
        return this;
    }

    public SSDDecompositor GetSsdDatatransferSpeed(int datatransferSpeed)
    {
        _datatransferSpeed = datatransferSpeed;
        return this;
    }

    public SSDDecompositor GetSsdMemoryAmount(int memoryAmount)
    {
        _memoryAmount = memoryAmount;
        return this;
    }

    public SSDDecompositor GetSsdPowerConsumprion(float powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }
}
