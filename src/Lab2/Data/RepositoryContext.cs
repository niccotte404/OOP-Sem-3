using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Data;
public class RepositoryContext
{
    private static readonly Lazy<RepositoryContext> LazySingleton = new Lazy<RepositoryContext>(() => new RepositoryContext());
    public static RepositoryContext Instance { get { return LazySingleton.Value; } }
    public ICollection<Motherboard> Motherboards { get; } = new List<Motherboard>();
    public ICollection<CPU> CPUs { get; } = new List<CPU>();
    public ICollection<PowerUnit> PowerUnits { get; } = new List<PowerUnit>();
    public ICollection<RAM> RAMs { get; } = new List<RAM>();
    public ICollection<CPUCoolingSystem> CPUCoolingSystems { get; } = new List<CPUCoolingSystem>();
    public ICollection<ComputerCase> ComputerCases { get; } = new List<ComputerCase>();
    public ICollection<GPU> GPUs { get; } = new List<GPU>();
    public ICollection<HDD> HDDs { get; } = new List<HDD>();
    public ICollection<SSD> SSDs { get; } = new List<SSD>();
    public ICollection<BIOS> BIOSs { get; } = new List<BIOS>();
    public ICollection<WiFiAdapter> WiFiAdapters { get; } = new List<WiFiAdapter>();
    public ICollection<XMPProfile> XMPProfiles { get; } = new List<XMPProfile>();
}
