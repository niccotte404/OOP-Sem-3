using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
public interface IComputerCaseBuilder
{
    public ComputerCase Build();
    public IComputerCaseBuilder GetComputerCaseFormFactor(FormFactor formFactor);
    public IComputerCaseBuilder GetComputerCaseMotherboardFormFactor(FormFactor formFactor);
    public IComputerCaseBuilder GetComputerCaseGPUFormFactor(FormFactor formFactor);
}
