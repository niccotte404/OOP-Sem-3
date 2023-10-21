using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders;
public class MotherboardBuilder : IMotherboardBuilder
{
    private Motherboard _motherboard;
    private string? _socket;
    private int _amountPCI;
    private int _amountSATA;
    private string? _ddr;
    private int _amountRAM;
    private IEnumerable<BIOS>? _bios;
    private FormFactor? _formFactor;
    private Chipset? _chipset;
    public MotherboardBuilder()
    {
        _motherboard = new Motherboard(
            socket: _socket,
            amountPCI: _amountPCI,
            amountSATA: _amountSATA,
            standartDDR: _ddr,
            amountRAM: _amountRAM,
            bios: _bios,
            formFactor: _formFactor,
            chipset: _chipset);
    }

    public Motherboard Build()
    {
        Motherboard motherboard = _motherboard;
        return motherboard;
    }

    public IMotherboardBuilder GetMotherboardAmountPCI(int amountPCI)
    {
        _amountPCI = amountPCI;
        return this;
    }

    public IMotherboardBuilder GetMotherboardAmountRAM(int amountRAM)
    {
        _amountRAM = amountRAM;
        return this;
    }

    public IMotherboardBuilder GetMotherboardAmountSATA(int amountSATA)
    {
        _amountSATA = amountSATA;
        return this;
    }

    public IMotherboardBuilder GetMotherboardBIOS(IEnumerable<BIOS> bios)
    {
        _bios = bios;
        return this;
    }

    public IMotherboardBuilder GetMotherboardChipset(Chipset chipset)
    {
        _chipset = chipset;
        return this;
    }

    public IMotherboardBuilder GetMotherboardFormFactor(FormFactor formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public IMotherboardBuilder GetMotherboardSocket(string socket)
    {
        _socket = socket;
        return this;
    }

    public IMotherboardBuilder GetMotherboardStatdartDDR(string ddr)
    {
        _ddr = ddr;
        return this;
    }
}
