using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Builders.Compositors;
using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Helpers;
using Itmo.ObjectOrientedProgramming.Lab2.Repository;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Data;
public class Seed
{
    private readonly RepositoryContext _context;
    private readonly RepositoryService<CPU, HelperCPU> _cpuRepository;
    private readonly IRepositoryService<CPUCoolingSystem> _coolingSystemRepository;
    private readonly IRepositoryService<GPU> _gpuRepository;
    private readonly IRepositoryService<SSD> _ssdRepository;
    private readonly IRepositoryService<HDD> _hddRepository;
    private readonly IRepositoryService<ComputerCase> _computerCaseRepository;
    private readonly IRepositoryService<PowerUnit> _powerUnitRepostitory;
    private readonly IRepositoryService<RAM> _ramRepository;
    private readonly IRepositoryService<WiFiAdapter> _wifiRepository;
    private readonly IRepositoryService<Motherboard> _motherboardRepository;
    private readonly RepositoryService<BIOS, HelperBIOS> _biosRepository;
    private readonly RepositoryService<XMPProfile, HelperXMPProfile> _xmpRepository;

    private readonly ICPUBuilder _cpuBuilder;
    private readonly ICPUCoolingSystemBuilder _coolingSystemBuilder;
    private readonly IGPUBuilder _gpuBuilder;
    private readonly IMemoryComponent<SSD> _ssdBuilder;
    private readonly IMemoryComponent<HDD> _hddBuilder;
    private readonly IComputerCaseBuilder _computerCaseBuilder;
    private readonly IRAMBuilder _ramBuilder;
    private readonly IWiFiBuilder _wifiBuilder;
    private readonly IMotherboardBuilder _motherboardBuilder;
    public Seed(RepositoryContext context)
    {
        _context = context;
        _cpuRepository = new CPURepository(_context);
        _coolingSystemRepository = new CPUCoolingSystemRepository(_context);
        _gpuRepository = new GPURepository(_context);
        _ssdRepository = new SSDRepository(_context);
        _hddRepository = new HDDRepository(_context);
        _computerCaseRepository = new ComputerCaseRepository(_context);
        _powerUnitRepostitory = new PowerUnitRepository(_context);
        _ramRepository = new RAMRepository(_context);
        _wifiRepository = new WiFiAdapterRepository(_context);
        _motherboardRepository = new MotherboardRepository(_context);
        _biosRepository = new BIOSRepository(_context);
        _xmpRepository = new XMPRepository(_context);

        _cpuBuilder = new CPUBuilder();
        _coolingSystemBuilder = new CPUCoolingSystemBuilder();
        _gpuBuilder = new GPUBuilder();
        _ssdBuilder = new SSDBuilder();
        _hddBuilder = new HDDBuilder();
        _computerCaseBuilder = new ComputerCaseBuilder();
        _ramBuilder = new RAMBuilder();
        _wifiBuilder = new WiFiAdaperBuilder();
        _motherboardBuilder = new MotherboardBuilder();
    }

    public void InitData()
    {
        InitCPUs();
        InitCoolingSystems();
        InitGPUs();
        InitSSDs();
        InitHDDs();
        InitComputerCases();
        InitPowerUnits();
        InitXMPs();
        InitRAMs();
        InitWiFiAdapters();
        InitBios();
        InitMotherboard();
    }

    private void InitCPUs()
    {
        _cpuRepository.Add(
            _context.CPUs,
            _cpuBuilder.GetCpuSocket("LGA 1700")
                       .GetCpuCoreAmount(6)
                       .GetCpuCoreFrequency(2.5f)
                       .GetCpuGPU(false)
                       .GetCpuSupportedMemoryFrequency(new List<int>() { 4800, 3200 })
                       .GetCpuTDP(65)
                       .GetCpuPowerConsumprion(260)
                       .Build());
        _cpuRepository.Add(
            _context.CPUs,
            _cpuBuilder.GetCpuSocket("LGA 1700")
                       .GetCpuCoreAmount(24)
                       .GetCpuCoreFrequency(3f)
                       .GetCpuGPU(true)
                       .GetCpuSupportedMemoryFrequency(new List<int>() { 5600, 3200 })
                       .GetCpuTDP(125)
                       .GetCpuPowerConsumprion(350)
                       .Build());
        _cpuRepository.Add(
            _context.CPUs,
            _cpuBuilder.GetCpuSocket("AM4")
                       .GetCpuCoreAmount(6)
                       .GetCpuCoreFrequency(3.9f)
                       .GetCpuGPU(true)
                       .GetCpuSupportedMemoryFrequency(new List<int>() { 3200 })
                       .GetCpuTDP(65)
                       .GetCpuPowerConsumprion(88)
                       .Build());
        _cpuRepository.Add(
            _context.CPUs,
            _cpuBuilder.GetCpuSocket("LGA 1200")
                       .GetCpuCoreAmount(4)
                       .GetCpuCoreFrequency(3.6f)
                       .GetCpuGPU(false)
                       .GetCpuSupportedMemoryFrequency(new List<int>() { 2666 })
                       .GetCpuTDP(65)
                       .GetCpuPowerConsumprion(148)
                       .Build());
        _cpuRepository.Add(
            _context.CPUs,
            _cpuBuilder.GetCpuSocket("LGA 1200")
                       .GetCpuCoreAmount(2)
                       .GetCpuCoreFrequency(3.5f)
                       .GetCpuGPU(true)
                       .GetCpuSupportedMemoryFrequency(new List<int>() { 2666 })
                       .GetCpuTDP(58)
                       .GetCpuPowerConsumprion(17)
                       .Build());
        _cpuRepository.Add(
            _context.CPUs,
            _cpuBuilder.GetCpuSocket("AM4")
                       .GetCpuCoreAmount(16)
                       .GetCpuCoreFrequency(3.4f)
                       .GetCpuGPU(false)
                       .GetCpuSupportedMemoryFrequency(new List<int>() { 3200 })
                       .GetCpuTDP(105)
                       .GetCpuPowerConsumprion(142)
                       .Build());
    }

    private void InitCoolingSystems()
    {
        _coolingSystemRepository.Add(
            _context.CPUCoolingSystems,
            _coolingSystemBuilder.GetCoolingSystemSockets(new List<string>() { "AM4", "AM5", "LGA 1150", "LGA 1151", "LGA 1155", "LGA 1200", "LGA 1700" })
                             .GetCoolingSystemTDP(60)
                             .GetCoolingSystemFormFactor(new FormFactor(125, 155, 96))
                             .Build());
        _coolingSystemRepository.Add(
            _context.CPUCoolingSystems,
            _coolingSystemBuilder.GetCoolingSystemSockets(new List<string>() { "AM2", "AM2+", "AM3", "AM3+", "AM4", "AM5", "FM1", "FM2", "FM2+", "LGA 1150", "LGA 1151", "LGA 1155", "LGA 1200", "LGA 1700", "LGA 2011", "LGA 2011-3", "LGA 2066" })
                             .GetCoolingSystemTDP(260)
                             .GetCoolingSystemFormFactor(new FormFactor(129, 160, 138))
                             .Build());
        _coolingSystemRepository.Add(
            _context.CPUCoolingSystems,
            _coolingSystemBuilder.GetCoolingSystemSockets(new List<string>() { "AM4", "AM5", "LGA 1150", "LGA 1151", "LGA 1155", "LGA 1151-v2", "LGA 1156", "LGA 1200", "LGA 1700" })
                             .GetCoolingSystemTDP(130)
                             .GetCoolingSystemFormFactor(new FormFactor(121, 136, 76))
                             .Build());
        _coolingSystemRepository.Add(
            _context.CPUCoolingSystems,
            _coolingSystemBuilder.GetCoolingSystemSockets(new List<string>() { "AM4", "AM5", "FM1", "FM2", "FM2+", "LGA 1150", "LGA 1151", "LGA 1151-v2", "LGA 1155", "LGA 1200", "LGA 1700" })
                             .GetCoolingSystemTDP(180)
                             .GetCoolingSystemFormFactor(new FormFactor(129, 158, 103))
                             .Build());
        _coolingSystemRepository.Add(
            _context.CPUCoolingSystems,
            _coolingSystemBuilder.GetCoolingSystemSockets(new List<string>() { "AM4", "AM5", "LGA 1150", "LGA 1151", "LGA 1155", "LGA 1200", "LGA 1700" })
                             .GetCoolingSystemTDP(200)
                             .GetCoolingSystemFormFactor(new FormFactor(125, 155, 96))
                             .Build());
    }

    private void InitGPUs()
    {
        _gpuRepository.Add(
            _context.GPUs,
            _gpuBuilder.GetGpuVideoMemoryAmount(8)
                       .GetGpuVersionPCI("4.0")
                       .GetGpuChipFrequency(1410)
                       .GetGpuPowerConsumption(255f)
                       .GetGpuFormFactor(new FormFactor(118, 53, 294))
                       .Build());
        _gpuRepository.Add(
            _context.GPUs,
            _gpuBuilder.GetGpuVideoMemoryAmount(12)
                       .GetGpuVersionPCI("4.0")
                       .GetGpuChipFrequency(2310)
                       .GetGpuPowerConsumption(285f)
                       .GetGpuFormFactor(new FormFactor(133, 64, 329))
                       .Build());
        _gpuRepository.Add(
            _context.GPUs,
            _gpuBuilder.GetGpuVideoMemoryAmount(4)
                       .GetGpuVersionPCI("3.0")
                       .GetGpuChipFrequency(1410)
                       .GetGpuPowerConsumption(90f)
                       .GetGpuFormFactor(new FormFactor(111, 33, 200))
                       .Build());
        _gpuRepository.Add(
            _context.GPUs,
            _gpuBuilder.GetGpuVideoMemoryAmount(8)
                       .GetGpuVersionPCI("4.0")
                       .GetGpuChipFrequency(2310)
                       .GetGpuPowerConsumption(160f)
                       .GetGpuFormFactor(new FormFactor(124, 41, 250))
                       .Build());
        _gpuRepository.Add(
            _context.GPUs,
            _gpuBuilder.GetGpuVideoMemoryAmount(24)
                       .GetGpuVersionPCI("4.0")
                       .GetGpuChipFrequency(2230)
                       .GetGpuPowerConsumption(450f)
                       .GetGpuFormFactor(new FormFactor(136, 62, 322))
                       .Build());
    }

    private void InitSSDs()
    {
        _ssdRepository.Add(
            _context.SSDs,
            _ssdBuilder.GetConnectionOption("SATA")
                       .GetMemoryAmount(1000)
                       .GetDatatransferSpeed(560)
                       .GetPowerConsumprion(4f)
                       .Build());
        _ssdRepository.Add(
            _context.SSDs,
            _ssdBuilder.GetConnectionOption("SATA")
                       .GetMemoryAmount(240)
                       .GetDatatransferSpeed(520)
                       .GetPowerConsumprion(2f)
                       .Build());
        _ssdRepository.Add(
            _context.SSDs,
            _ssdBuilder.GetConnectionOption("SATA")
                       .GetMemoryAmount(960)
                       .GetDatatransferSpeed(550)
                       .GetPowerConsumprion(4f)
                       .Build());
        _ssdRepository.Add(
            _context.SSDs,
            _ssdBuilder.GetConnectionOption("PCI-E")
                       .GetMemoryAmount(500)
                       .GetDatatransferSpeed(3500)
                       .GetPowerConsumprion(9f)
                       .Build());
        _ssdRepository.Add(
            _context.SSDs,
            _ssdBuilder.GetConnectionOption("PCI-E")
                       .GetMemoryAmount(1024)
                       .GetDatatransferSpeed(7000)
                       .GetPowerConsumprion(6.3f)
                       .Build());
    }

    private void InitHDDs()
    {
        _hddRepository.Add(
            _context.HDDs,
            _hddBuilder.GetMemoryAmount(2000)
                       .GetDatatransferSpeed(7200)
                       .GetPowerConsumprion(3.7f)
                       .Build());
        _hddRepository.Add(
            _context.HDDs,
            _hddBuilder.GetMemoryAmount(4000)
                       .GetDatatransferSpeed(5400)
                       .GetPowerConsumprion(4.7f)
                       .Build());
        _hddRepository.Add(
            _context.HDDs,
            _hddBuilder.GetMemoryAmount(1000)
                       .GetDatatransferSpeed(7200)
                       .GetPowerConsumprion(6.4f)
                       .Build());
        _hddRepository.Add(
            _context.HDDs,
            _hddBuilder.GetMemoryAmount(6000)
                       .GetDatatransferSpeed(5400)
                       .GetPowerConsumprion(5.3f)
                       .Build());
        _hddRepository.Add(
            _context.HDDs,
            _hddBuilder.GetMemoryAmount(18000)
                       .GetDatatransferSpeed(7200)
                       .GetPowerConsumprion(8.4f)
                       .Build());
    }

    private void InitComputerCases()
    {
        _computerCaseRepository.Add(
            _context.ComputerCases,
            _computerCaseBuilder.GetComputerCaseFormFactor(new FormFactor(240, 496, 465))
                                .GetComputerCaseGPUFormFactor(new FormFactor(140, 70, 390))
                                .GetComputerCaseMotherboardFormFactor(new FormFactor(250, 50, 310))
                                .Build());
        _computerCaseRepository.Add(
            _context.ComputerCases,
            _computerCaseBuilder.GetComputerCaseFormFactor(new FormFactor(800, 800, 800))
                                .GetComputerCaseGPUFormFactor(new FormFactor(450, 200, 500))
                                .GetComputerCaseMotherboardFormFactor(new FormFactor(500, 500, 500))
                                .Build());
        _computerCaseRepository.Add(
            _context.ComputerCases,
            _computerCaseBuilder.GetComputerCaseFormFactor(new FormFactor(238, 523, 526))
                                .GetComputerCaseGPUFormFactor(new FormFactor(207, 94, 435))
                                .GetComputerCaseMotherboardFormFactor(new FormFactor(308, 57, 255))
                                .Build());
        _computerCaseRepository.Add(
            _context.ComputerCases,
            _computerCaseBuilder.GetComputerCaseFormFactor(new FormFactor(157, 360, 360))
                                .GetComputerCaseGPUFormFactor(new FormFactor(105, 64, 300))
                                .GetComputerCaseMotherboardFormFactor(new FormFactor(203, 48, 179))
                                .Build());
        _computerCaseRepository.Add(
            _context.ComputerCases,
            _computerCaseBuilder.GetComputerCaseFormFactor(new FormFactor(204, 479, 445))
                                .GetComputerCaseGPUFormFactor(new FormFactor(205, 87, 360))
                                .GetComputerCaseMotherboardFormFactor(new FormFactor(289, 68, 311))
                                .Build());
        _computerCaseRepository.Add(
            _context.ComputerCases,
            _computerCaseBuilder.GetComputerCaseFormFactor(new FormFactor(238, 523, 526))
                                .GetComputerCaseGPUFormFactor(new FormFactor(211, 92, 435))
                                .GetComputerCaseMotherboardFormFactor(new FormFactor(313, 78, 255))
                                .Build());
    }

    private void InitPowerUnits()
    {
        _powerUnitRepostitory.Add(_context.PowerUnits, new PowerUnit(600f));
        _powerUnitRepostitory.Add(_context.PowerUnits, new PowerUnit(700f));
        _powerUnitRepostitory.Add(_context.PowerUnits, new PowerUnit(800f));
        _powerUnitRepostitory.Add(_context.PowerUnits, new PowerUnit(900f));
        _powerUnitRepostitory.Add(_context.PowerUnits, new PowerUnit(1000f));
    }

    private void InitXMPs()
    {
        _xmpRepository.Add(_context.XMPProfiles, new XMPProfile("16-20-20", 1.35f, 3200));
        _xmpRepository.Add(_context.XMPProfiles, new XMPProfile("16-18-18", 1.25f, 3200));
        _xmpRepository.Add(_context.XMPProfiles, new XMPProfile("40-40-40", 1.6f, 5600));
        _xmpRepository.Add(_context.XMPProfiles, new XMPProfile("18-22-22", 1.3f, 3600));
        _xmpRepository.Add(_context.XMPProfiles, new XMPProfile("11-11-11-28", 1.1f, 1600));
        _xmpRepository.Add(_context.XMPProfiles, new XMPProfile("16-18-18-35", 1.15f, 2666));
    }

    private void InitRAMs()
    {
        _ramRepository.Add(
            _context.RAMs,
            _ramBuilder.GetRamMemoryAmount(16)
                       .GetRamFrequencyAndJEDEC(new List<FrequensyAndJEDEC>() { new FrequensyAndJEDEC(3200, 1.2f), new FrequensyAndJEDEC(5600, 1.25f), new FrequensyAndJEDEC(3600, 1.3f) })
                       .GetRamFormFactor(new FormFactor(6, 34, 150))
                       .GetRamDDR("DDR4")
                       .GetRamPowerConsumption(1.35f)
                       .GetRamSupportedXMP(_xmpRepository.SelectComponent(new HelperXMPProfile { Voltage = 1.35f, Timing = "16-20-20" }))
                       .Build());
        _ramRepository.Add(
            _context.RAMs,
            _ramBuilder.GetRamMemoryAmount(16)
                       .GetRamFrequencyAndJEDEC(new List<FrequensyAndJEDEC>() { new FrequensyAndJEDEC(2666, 1.25f), new FrequensyAndJEDEC(3600, 1.3f) })
                       .GetRamFormFactor(new FormFactor(6, 35, 150))
                       .GetRamDDR("DDR5")
                       .GetRamPowerConsumption(1.25f)
                       .GetRamSupportedXMP(_xmpRepository.SelectComponent(new HelperXMPProfile { Voltage = 1.25f, Timing = "40-40-40" }))
                       .Build());
        _ramRepository.Add(
            _context.RAMs,
            _ramBuilder.GetRamMemoryAmount(16)
                       .GetRamFrequencyAndJEDEC(new List<FrequensyAndJEDEC>() { new FrequensyAndJEDEC(1600, 1.2f), new FrequensyAndJEDEC(2666, 1.25f) })
                       .GetRamFormFactor(new FormFactor(6, 34, 150))
                       .GetRamDDR("DDR4")
                       .GetRamPowerConsumption(1.45f)
                       .Build());
        _ramRepository.Add(
            _context.RAMs,
            _ramBuilder.GetRamMemoryAmount(8)
                       .GetRamFrequencyAndJEDEC(new List<FrequensyAndJEDEC>() { new FrequensyAndJEDEC(1600, 1.2f) })
                       .GetRamFormFactor(new FormFactor(6, 30, 150))
                       .GetRamDDR("DDR3")
                       .GetRamPowerConsumption(1.1f)
                       .Build());
    }

    private void InitWiFiAdapters()
    {
        _wifiRepository.Add(
            _context.WiFiAdapters,
            _wifiBuilder.GetWifiVersion("802.11ac")
                        .GetWifiVersionPCI("4.0")
                        .GetWifiBluetoothModule(true)
                        .GetWifiPowerConsumption(5f)
                        .Build());
        _wifiRepository.Add(
            _context.WiFiAdapters,
            _wifiBuilder.GetWifiVersion("802.11ax")
                        .GetWifiVersionPCI("4.0")
                        .GetWifiBluetoothModule(true)
                        .GetWifiPowerConsumption(7.5f)
                        .Build());
        _wifiRepository.Add(
            _context.WiFiAdapters,
            _wifiBuilder.GetWifiVersion("802.11n")
                        .GetWifiVersionPCI("4.0")
                        .GetWifiBluetoothModule(false)
                        .GetWifiPowerConsumption(4.5f)
                        .Build());
        _wifiRepository.Add(
            _context.WiFiAdapters,
            _wifiBuilder.GetWifiVersion("802.11n")
                        .GetWifiVersionPCI("3.0")
                        .GetWifiBluetoothModule(false)
                        .GetWifiPowerConsumption(3.7f)
                        .Build());
    }

    private void InitBios()
    {
        if (_context.BIOSs is null) return;

        _biosRepository.Add(
            _context.BIOSs,
            new BIOS(
                version: "7D32VHE",
                type: "UEFI",
                supportedCPU: _cpuRepository.SelectComponent(new HelperCPU { Socket = "LGA 1700" })));
        _biosRepository.Add(
            _context.BIOSs,
            new BIOS(
                version: "7C95V251",
                type: "UEFI",
                supportedCPU: _cpuRepository.SelectComponent(new HelperCPU { Socket = "AM4" })));
        _biosRepository.Add(
            _context.BIOSs,
            new BIOS(
                version: "7E68V113",
                type: "ACI",
                supportedCPU: _cpuRepository.SelectComponent(new HelperCPU { Socket = "LGA 1200" })));
    }

    private void InitMotherboard()
    {
        _motherboardRepository.Add(
            _context.Motherboards,
            _motherboardBuilder.GetMotherboardSocket("LGA 1700")
                               .GetMotherboardAmountPCI(4)
                               .GetMotherboardAmountSATA(6)
                               .GetMotherboardChipset(new Chipset(new List<int>() { 5600, 5800, 6000, 6200, 6400 }, true))
                               .GetMotherboardStatdartDDR("DDR5")
                               .GetMotherboardAmountRAM(4)
                               .GetMotherboardBIOS(_biosRepository.SelectComponent(new HelperBIOS { Type = "UEFI" }))
                               .GetMotherboardFormFactor(new FormFactor(305, 15, 244))
                               .Build());
        _motherboardRepository.Add(
            _context.Motherboards,
            _motherboardBuilder.GetMotherboardSocket("AM4")
                               .GetMotherboardAmountPCI(3)
                               .GetMotherboardAmountSATA(6)
                               .GetMotherboardChipset(new Chipset(new List<int>() { 3200, 3466, 3600, 3733, 3800, 3866, 4000, 4133, 4200, 4266, 4333, 4400, 4466, 4533, 4600, 4666, 4733 }, true))
                               .GetMotherboardStatdartDDR("DDR4")
                               .GetMotherboardAmountRAM(4)
                               .GetMotherboardBIOS(_biosRepository.SelectComponent(new HelperBIOS { Type = "UEFI" }))
                               .GetMotherboardFormFactor(new FormFactor(244, 14, 244))
                               .Build());
        _motherboardRepository.Add(
            _context.Motherboards,
            _motherboardBuilder.GetMotherboardSocket("LGA 1155")
                               .GetMotherboardAmountPCI(2)
                               .GetMotherboardAmountSATA(4)
                               .GetMotherboardChipset(new Chipset(new List<int>() { 1600 }, false))
                               .GetMotherboardStatdartDDR("DDR3")
                               .GetMotherboardAmountRAM(2)
                               .GetMotherboardBIOS(_biosRepository.SelectComponent(new HelperBIOS { Type = "ACI" }))
                               .GetMotherboardFormFactor(new FormFactor(191, 15, 170))
                               .Build());
    }
}
