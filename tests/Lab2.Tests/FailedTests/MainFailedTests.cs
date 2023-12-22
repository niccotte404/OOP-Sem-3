using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.Builders.Compositors;
using Itmo.ObjectOrientedProgramming.Lab2.Data;
using Itmo.ObjectOrientedProgramming.Lab2.Data.Enums;
using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Helpers;
using Itmo.ObjectOrientedProgramming.Lab2.Repository;
using Itmo.ObjectOrientedProgramming.Lab2.Services;
using Xunit;

namespace Itmo.ObjectOrientedProgramming.Lab2.Tests.FailedTests;
public class MainFailedTests
{
    [Fact]
    private void FirstTestCase()
    {
        var context = new RepositoryContext();
        var seed = new Seed(context);
        seed.InitData();
        RepositoryService<Motherboard, HelperMotherboard> repositoryMotherboard = new MotherboardRepository(context);
        RepositoryService<CPU, HelperCPU> repositoryCPU = new CPURepository(context);
        RepositoryService<BIOS, HelperBIOS> repositoryBIOS = new BIOSRepository(context);
        RepositoryService<RAM, HelperRAM> repositoryRAM = new RAMRepository(context);
        RepositoryService<CPUCoolingSystem, HelperCoolingSystem> repositoryCoolingSystem = new CPUCoolingSystemRepository(context);
        RepositoryService<ComputerCase, HelperComputerCase> repositoryConputerCase = new ComputerCaseRepository(context);
        RepositoryService<PowerUnit, HelperPowerUnit> repositoryPowerUnit = new PowerUnitRepository(context);

        Motherboard motherboard = repositoryMotherboard.SelectComponent(new HelperMotherboard { Socket = "AM4" }).First();
        RAM ram = repositoryRAM.SelectComponent(new HelperRAM { DDR = motherboard.StandartDDR }).First();
        CPU cpu = repositoryCPU.SelectComponent(new HelperCPU { IGPU = false }).First();
        BIOS bios = repositoryBIOS.SelectComponent(new HelperBIOS { SupportedCPU = new List<CPU>() { cpu } }).First();
        CPUCoolingSystem coolingSystem = repositoryCoolingSystem.SelectComponent(new HelperCoolingSystem { SupportedSockets = new List<string>() { "AM4" }, MaxTDP = cpu.TDP }).First();
        XMPProfile xmp = context.XMPProfiles.First();
        SSD ssd = context.SSDs.First();
        HDD hdd = context.HDDs.First();
        ComputerCase computerCase = repositoryConputerCase.SelectComponent(new HelperComputerCase { MotherboardFormFactor = motherboard.FormFactor }).First();
        WiFiAdapter wifiAdapter = context.WiFiAdapters.First();
        float power = cpu.PowerConsumption + ram.PowerConsumption + ssd.PowerConsumprion + hdd.PowerConsumprion + wifiAdapter.PowerConsumption;
        PowerUnit powerUnit = repositoryPowerUnit.SelectComponent(new HelperPowerUnit { MaxPower = power }).First();

        IConfiguratorBuilder builder = new Configurator();
        Results result;
        try
        {
            ConfigPC configPC = builder.SetMotherboard(motherboard).SetCPU(cpu).SetBIOS(bios)
                                 .SetCoolingSystem(coolingSystem).SetRAM(ram).SetXMP(xmp)
                                 .SetSSD(ssd).SetHDD(hdd).SetComputerCase(computerCase)
                                 .SetWiFiAdapter(wifiAdapter).SetPowerUnit(powerUnit).Build();
            result = configPC.Result;
        }
        catch (ArgumentException)
        {
            result = Results.Failed;
        }

        Assert.Equal(Results.Failed, result);
    }

    [Fact]
    private void SecondTestCase()
    {
        var context = new RepositoryContext();
        var seed = new Seed(context);
        seed.InitData();
        RepositoryService<Motherboard, HelperMotherboard> repositoryMotherboard = new MotherboardRepository(context);
        RepositoryService<CPU, HelperCPU> repositoryCPU = new CPURepository(context);
        RepositoryService<BIOS, HelperBIOS> repositoryBIOS = new BIOSRepository(context);
        RepositoryService<RAM, HelperRAM> repositoryRAM = new RAMRepository(context);
        RepositoryService<CPUCoolingSystem, HelperCoolingSystem> repositoryCoolingSystem = new CPUCoolingSystemRepository(context);
        RepositoryService<ComputerCase, HelperComputerCase> repositoryConputerCase = new ComputerCaseRepository(context);

        Motherboard motherboard = repositoryMotherboard.SelectComponent(new HelperMotherboard { Socket = "AM4" }).First();
        RAM ram = repositoryRAM.SelectComponent(new HelperRAM { DDR = motherboard.StandartDDR }).First();
        CPU cpu = repositoryCPU.SelectComponent(new HelperCPU { Socket = motherboard.Socket }).First();
        BIOS bios = repositoryBIOS.SelectComponent(new HelperBIOS { SupportedCPU = new List<CPU>() { cpu } }).First();
        CPUCoolingSystem coolingSystem = repositoryCoolingSystem.SelectComponent(new HelperCoolingSystem { SupportedSockets = new List<string>() { "AM4" }, MaxTDP = cpu.TDP }).First();
        GPU gpu = context.GPUs.First();
        SSD ssd = context.SSDs.First();
        ComputerCase computerCase = repositoryConputerCase.SelectComponent(new HelperComputerCase { MaxGPUFormFactor = gpu.FormFactor, MotherboardFormFactor = motherboard.FormFactor }).First();
        WiFiAdapter wifiAdapter = context.WiFiAdapters.First();

        IConfiguratorBuilder builder = new Configurator();
        Results result;
        try
        {
            ConfigPC configPC = builder.SetMotherboard(motherboard).SetCPU(cpu).SetBIOS(bios)
                                 .SetCoolingSystem(coolingSystem).SetRAM(ram)
                                 .SetGPU(gpu).SetSSD(ssd).SetComputerCase(computerCase)
                                 .SetWiFiAdapter(wifiAdapter).Build();
            result = configPC.Result;
        }
        catch (ArgumentException)
        {
            result = Results.Failed;
        }

        Assert.Equal(Results.Failed, result);
    }

    [Fact]
    private void ThirdTestCase()
    {
        var context = new RepositoryContext();
        var seed = new Seed(context);
        seed.InitData();
        RepositoryService<Motherboard, HelperMotherboard> repositoryMotherboard = new MotherboardRepository(context);
        RepositoryService<CPU, HelperCPU> repositoryCPU = new CPURepository(context);
        RepositoryService<BIOS, HelperBIOS> repositoryBIOS = new BIOSRepository(context);
        RepositoryService<RAM, HelperRAM> repositoryRAM = new RAMRepository(context);
        RepositoryService<CPUCoolingSystem, HelperCoolingSystem> repositoryCoolingSystem = new CPUCoolingSystemRepository(context);
        RepositoryService<ComputerCase, HelperComputerCase> repositoryConputerCase = new ComputerCaseRepository(context);
        RepositoryService<PowerUnit, HelperPowerUnit> repositoryPowerUnit = new PowerUnitRepository(context);

        Motherboard motherboard = repositoryMotherboard.SelectComponent(new HelperMotherboard { Socket = "AM4" }).First();
        RAM ram = repositoryRAM.SelectComponent(new HelperRAM { DDR = "DDR3" }).First();
        CPU cpu = repositoryCPU.SelectComponent(new HelperCPU { Socket = motherboard.Socket }).First();
        BIOS bios = repositoryBIOS.SelectComponent(new HelperBIOS { SupportedCPU = new List<CPU>() { cpu } }).First();
        CPUCoolingSystem coolingSystem = repositoryCoolingSystem.SelectComponent(new HelperCoolingSystem { SupportedSockets = new List<string>() { "AM4" }, MaxTDP = cpu.TDP }).First();
        XMPProfile xmp = context.XMPProfiles.First();
        GPU gpu = context.GPUs.First();
        SSD ssd = context.SSDs.First();
        HDD hdd = context.HDDs.First();
        ComputerCase computerCase = repositoryConputerCase.SelectComponent(new HelperComputerCase { MaxGPUFormFactor = gpu.FormFactor, MotherboardFormFactor = motherboard.FormFactor }).First();
        WiFiAdapter wifiAdapter = context.WiFiAdapters.First();
        float power = cpu.PowerConsumption + ram.PowerConsumption + gpu.PowerConsumption + ssd.PowerConsumprion + hdd.PowerConsumprion + wifiAdapter.PowerConsumption;
        PowerUnit powerUnit = repositoryPowerUnit.SelectComponent(new HelperPowerUnit { MaxPower = power }).First();

        IConfiguratorBuilder builder = new Configurator();
        Results result;
        try
        {
            ConfigPC configPC = builder.SetMotherboard(motherboard).SetCPU(cpu).SetBIOS(bios)
                                 .SetCoolingSystem(coolingSystem).SetRAM(ram).SetXMP(xmp)
                                 .SetGPU(gpu).SetSSD(ssd).SetHDD(hdd).SetComputerCase(computerCase)
                                 .SetWiFiAdapter(wifiAdapter).SetPowerUnit(powerUnit).Build();
            result = configPC.Result;
        }
        catch (ArgumentException)
        {
            result = Results.Failed;
        }

        Assert.Equal(Results.Failed, result);
    }
}
