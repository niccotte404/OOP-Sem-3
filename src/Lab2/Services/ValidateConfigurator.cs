using System;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;
public static class ValidateConfigurator
{
    public static string? Validate(PC pc)
    {
        // check if all required components exists
        if (pc is null || pc.Motherboard is null || pc.CPU is null || pc.CPUCoolingSystem is null || pc.RAM is null ||
            (pc.CPU.IGPU == false && pc.GPU is null) || (pc.SSD is null && pc.HDD is null) || pc.ComputerCase is null || pc.PowerUnit is null)
            throw new ArgumentException("PC does not have required component");

        // check if socket is equal
        if (pc.Motherboard.Socket != pc.CPU.Socket && (pc.CPUCoolingSystem.SupportedSockets is null || pc.CPUCoolingSystem.SupportedSockets.Where(elem => elem == pc.Motherboard.Socket).Any() == false))
            throw new ArgumentException("Component has wrong socket");

        // check if DDR is equal
        if (pc.Motherboard.StandartDDR != pc.RAM.DDR)
            throw new ArgumentException("Component has wrong DDR");

        // check if cooling system TDP is enough
        if (pc.CPUCoolingSystem.MaxTDP < pc.CPU.TDP)
            return "Cooling system has not enough TDP";

        // check motherboard format
        if (pc.Motherboard.FormFactor is null || pc.ComputerCase.MotherboardFormFactor is null ||
            pc.Motherboard.FormFactor.Width > pc.ComputerCase.MotherboardFormFactor.Width ||
            pc.Motherboard.FormFactor.Height > pc.ComputerCase.MotherboardFormFactor.Height ||
            pc.Motherboard.FormFactor.Depth > pc.ComputerCase.MotherboardFormFactor.Depth)
            throw new ArgumentException("Motherboard is too big for computer case");

        // check GPU format
        if (pc.GPU is not null && (pc.GPU.FormFactor is null || pc.ComputerCase.MaxGPUFormFactor is null ||
            pc.GPU.FormFactor.Width > pc.ComputerCase.MaxGPUFormFactor.Width ||
            pc.GPU.FormFactor.Height > pc.ComputerCase.MaxGPUFormFactor.Height ||
            pc.GPU.FormFactor.Depth > pc.ComputerCase.MaxGPUFormFactor.Depth))
            throw new ArgumentException("GPU is too big for computer case");

        // check if power unit enough for current pc power consumprion
        float powerConsumption = pc.CPU.PowerConsumption + pc.RAM.PowerConsumption;
        if (pc.SSD is not null) powerConsumption += pc.SSD.PowerConsumprion;
        if (pc.HDD is not null) powerConsumption += pc.HDD.PowerConsumprion;
        if (pc.GPU is not null) powerConsumption += pc.GPU.PowerConsumption;
        if (pc.WiFiAdapter is not null) powerConsumption += pc.WiFiAdapter.PowerConsumption;
        if (powerConsumption * 1.3 >= pc.PowerUnit.MaxPower && powerConsumption <= pc.PowerUnit.MaxPower)
            return "Power unit has not enough power";
        else if (powerConsumption > pc.PowerUnit.MaxPower)
            throw new ArgumentException("Power unit has not enough power");

        return null;
    }
}