using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders.Decompositors;
public class MotherboardDecompositor : IMotherboardBuilder
{
    private string? _socket;
    private int _amountPCI;
    private int _amountSATA;
    private string? _ddr;
    private int _amountRAM;
    private IEnumerable<BIOS>? _bios;
    private FormFactor? _formFactor;
    private Chipset? _chipset;
    private Motherboard _motherboard;

    public MotherboardDecompositor(Motherboard motherboard)
    {
        _motherboard = motherboard;
        _chipset = _motherboard.Chipset;
        _socket = _motherboard.Socket;
        _amountPCI = _motherboard.AmountPCI;
        _amountRAM = _motherboard.AmountRAM;
        _amountSATA = _motherboard.AmountSATA;
        _ddr = _motherboard.StandartDDR;
        _bios = _motherboard.BIOS;
        _formFactor = _motherboard.FormFactor;
    }

    public Motherboard Build()
    {
        var motherboard = new Motherboard(
            socket: _socket,
            amountPCI: _amountPCI,
            amountSATA: _amountSATA,
            standartDDR: _ddr,
            amountRAM: _amountRAM,
            bios: _bios,
            formFactor: _formFactor,
            chipset: _chipset);
        ValidateComponents.IsMotherboardValid(motherboard);
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
