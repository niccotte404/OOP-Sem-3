using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders;
public class HDDBuilder : IHDDBuilder
{
    private HDD _hdd;
    private int _memoryAmount;
    private int _spinSpeed;
    private float _powerConsumption;
    public HDDBuilder()
    {
        _hdd = new HDD(
            memoryAmount: _memoryAmount,
            spinSpeed: _spinSpeed,
            powerConsumprion: _powerConsumption);
    }

    public HDD Build()
    {
        HDD hdd = _hdd;
        return hdd;
    }

    public IHDDBuilder GetHddMemoryAmount(int memoryAmount)
    {
        _memoryAmount = memoryAmount;
        return this;
    }

    public IHDDBuilder GetHddPowerConsumprion(float powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public IHDDBuilder GetHddSpinSpeed(int spinSpeed)
    {
        _spinSpeed = spinSpeed;
        return this;
    }
}
