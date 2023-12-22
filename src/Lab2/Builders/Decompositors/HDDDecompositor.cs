using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders.Decompositors;
public class HDDDecompositor
{
    private int _memoryAmount;
    private int _spinSpeed;
    private float _powerConsumption;
    private HDD _hdd;

    public HDDDecompositor(HDD hdd)
    {
        _hdd = hdd;
        _memoryAmount = _hdd.MemoryAmount;
        _spinSpeed = _hdd.SpinSpeed;
        _powerConsumption = _hdd.PowerConsumprion;
    }

    public HDD Build()
    {
        var hdd = new HDD(
            memoryAmount: _memoryAmount,
            spinSpeed: _spinSpeed,
            powerConsumprion: _powerConsumption);
        ValidateComponents.IsHDDValid(hdd);
        return hdd;
    }

    public HDDDecompositor GetHddMemoryAmount(int memoryAmount)
    {
        _memoryAmount = memoryAmount;
        return this;
    }

    public HDDDecompositor GetHddPowerConsumprion(float powerConsumption)
    {
        _powerConsumption = powerConsumption;
        return this;
    }

    public HDDDecompositor GetHddSpinSpeed(int spinSpeed)
    {
        _spinSpeed = spinSpeed;
        return this;
    }
}
