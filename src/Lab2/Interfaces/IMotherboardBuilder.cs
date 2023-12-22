using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
public interface IMotherboardBuilder
{
    public Motherboard Build();
    public IMotherboardBuilder GetMotherboardSocket(string socket);
    public IMotherboardBuilder GetMotherboardAmountPCI(int amountPCI);
    public IMotherboardBuilder GetMotherboardAmountSATA(int amountSATA);
    public IMotherboardBuilder GetMotherboardStatdartDDR(string ddr);
    public IMotherboardBuilder GetMotherboardAmountRAM(int amountRAM);
    public IMotherboardBuilder GetMotherboardBIOS(IEnumerable<BIOS> bios);
    public IMotherboardBuilder GetMotherboardFormFactor(FormFactor formFactor);
    public IMotherboardBuilder GetMotherboardChipset(Chipset chipset);
}
