using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.Data;
public class RepositoryContext
{
    private static readonly Lazy<RepositoryContext> LazySingleton = new Lazy<RepositoryContext>(() => new RepositoryContext());
    public static RepositoryContext Instance { get { return LazySingleton.Value; } }
    public ICollection<Motherboard>? Motherboards { get; }
    public ICollection<CPU>? CPUs { get; }
    public ICollection<PowerUnit>? PowerUnits { get; }
    public ICollection<RAM>? RAMs { get; }
    public ICollection<CPUCoolingSystem>? CPUCoolingSystems { get; }
    public ICollection<ComputerCase>? ComputerCases { get; }
    public ICollection<GPU>? GPUs { get; }
    public ICollection<HDD>? HDDs { get; }
    public ICollection<SSD>? SSDs { get; }
    public ICollection<BIOS>? BIOSs { get; }
    public ICollection<WiFiAdapter>? WiFiAdapters { get; }
    public ICollection<XMPProfile>? XMPProfiles { get; }
}
