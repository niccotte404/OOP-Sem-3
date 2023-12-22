using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders.Compositors;
public class HDDBuilder : IMemoryComponent<HDD>
{
    private int _memoryAmount;
    private int _spinSpeed;
    private float _powerConsumption;

    public HDD Build()
    {
        var hdd = new HDD(
            memoryAmount: _memoryAmount,
            spinSpeed: _spinSpeed,
            powerConsumprion: _powerConsumption);
        ValidateComponents.IsHDDValid(hdd);
        return hdd;
    }

    public IMemoryComponent<HDD> GetMemoryAmount(int memoryAmount)
    {
        _memoryAmount = memoryAmount;
        return this;
    }

    public IMemoryComponent<HDD> GetPowerConsumprion(float powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public IMemoryComponent<HDD> GetDatatransferSpeed(int datatransferSpeed)
    {
        _spinSpeed = datatransferSpeed;
        return this;
    }

    public IMemoryComponent<HDD> GetConnectionOption(string connectionOption)
    {
        return this;
    }
}
