using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Services;
public static class ValidateComponents
{
    public static string? IsComputerCaseValid(ComputerCase computerCase)
    {
        if (computerCase is null || computerCase.FormFactor is null || computerCase.MotherboardFormFactor is null || computerCase.MaxGPUFormFactor is null)
            return "Computer case is not valid";
        if (IsFormFactorValid(computerCase.FormFactor))
            return "Computer case form factor is not valid";
        if (IsFormFactorValid(computerCase.MaxGPUFormFactor))
            return "Computer case GPU form factor is not valid";
        if (IsFormFactorValid(computerCase.MotherboardFormFactor))
            return "Computer case Motherboard form factor is not valid";
        return null;
    }

    public static string? IsCPUValid(CPU cpu)
    {
        if (cpu is null || cpu.Socket is null || cpu.CoreAmount <= 0 || cpu.CoreFrequency <= 0 ||
            cpu.SupportedMemoryFrequency is null || cpu.PowerConsumption <= 0 ||
            cpu.SupportedMemoryFrequency.Select(elem => elem <= 0) is not null)
            return "CPU is not valid";
        return null;
    }

    public static string? IsCoolingSystemValid(CPUCoolingSystem coolingSystem)
    {
        if (coolingSystem is null || coolingSystem.MaxTDP <= 0 || coolingSystem.SupportedSockets is null || coolingSystem.FormFactor is null)
            return "CPU cooling system is not valid";
        if (IsFormFactorValid(coolingSystem.FormFactor))
            return "CPU cooling system form factor is not valid";
        return null;
    }

    public static string? IsGPUValid(GPU gpu)
    {
        if (gpu is null || gpu.PowerConsumption <= 0 || gpu.VersionPCI is null || gpu.ChipFrequency <= 0 ||
            gpu.FormFactor is null || gpu.VideoMemoryAmount <= 0)
            return "GPU is not valid";
        if (IsFormFactorValid(gpu.FormFactor))
            return "GPU form factor is not valid";
        return null;
    }

    public static string? IsHDDValid(HDD hdd)
    {
        if (hdd is null || hdd.MemoryAmount <= 0 || hdd.PowerConsumprion <= 0 || hdd.SpinSpeed <= 0)
            return "HDD is not valid";
        return null;
    }

    public static string? IsMotherboardValid(Motherboard motherboard)
    {
        if (motherboard is null || motherboard.Socket is null || motherboard.Chipset is null || motherboard.AmountRAM <= 0 ||
            motherboard.AmountPCI <= 0 || motherboard.AmountSATA <= 0 || motherboard.StandartDDR is null || motherboard.FormFactor is null ||
            motherboard.BIOS is null)
            return "Motherboard is not valid";
        if (IsChipsetValid(motherboard.Chipset))
            return "Motherboard chipset is not valid";
        if (IsFormFactorValid(motherboard.FormFactor))
            return "Motherboard form factor is not valid";
        if (IsBIOSValid(motherboard.BIOS))
            return "Motherboard form factor is not valid";
        return null;
    }

    public static string? IsRAMValid(RAM ram)
    {
        if (ram is null || ram.SupportedXMP is null || ram.MemoryAmount <= 0 || ram.PowerConsumption <= 0 ||
            ram.FrequencyAndJEDEC is null || ram.FormFactor is null || ram.DDR is null)
            return "RAM is not valid";
        if (IsFormFactorValid(ram.FormFactor))
            return "RAM form factor is not valid";
        if (IsXMPValid(ram.SupportedXMP))
            return "RAM XMP is not valid";
        if (IsFrequencyAndJEDECValid(ram.FrequencyAndJEDEC))
            return "RAM frequency and JEDEC is not valid";
        return null;
    }

    public static string? IsSSDValid(SSD ssd)
    {
        if (ssd is null || ssd.ConnectionOption is null || ssd.PowerConsumprion <= 0 ||
            ssd.MaxDatatransferSpeed <= 0 || ssd.MemoryAmount <= 0)
            return "SSD is not valid";
        return null;
    }

    public static string? IsWiFiAdapterValid(WiFiAdapter wifiAdapter)
    {
        if (wifiAdapter is null || wifiAdapter.PowerConsumption <= 0 || wifiAdapter.Version is null || wifiAdapter.VersionPCI is null)
            return "WiFi adapter is not valid";
        return null;
    }

    private static bool IsFormFactorValid(FormFactor formFactor)
    {
        if (formFactor.Width <= 0 || formFactor.Depth <= 0 || formFactor.Height <= 0)
            return false;
        return true;
    }

    private static bool IsChipsetValid(Chipset chipset)
    {
        if (chipset.SupportedMemoryFrequency is null || chipset.SupportedMemoryFrequency.Select(elem => elem <= 0) is not null)
            return false;
        return true;
    }

    private static bool IsBIOSValid(IEnumerable<BIOS> bios)
    {
        if (bios.Select(elem => elem.SupportedCPU is null) is not null ||
            bios.Select(elem => elem.Version is null) is not null ||
            bios.Select(elem => elem.Type is null) is not null)
            return false;
        return true;
    }

    private static bool IsXMPValid(IEnumerable<XMPProfile> xmp)
    {
        if (xmp.Select(elem => elem.MemoryFrequency <= 0) is not null ||
            xmp.Select(elem => elem.Voltage <= 0) is not null ||
            xmp.Select(elem => elem.Timing is null) is not null)
            return false;
        return true;
    }

    private static bool IsFrequencyAndJEDECValid(IEnumerable<FrequensyAndJEDEC> frequensyAndJEDEC)
    {
        if (frequensyAndJEDEC.Select(elem => elem.MemoryFrequency <= 0) is not null ||
            frequensyAndJEDEC.Select(elem => elem.JEDEC <= 0) is not null)
            return false;
        return true;
    }
}
