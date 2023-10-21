using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders;
public class ComputerCaseBuilder : IComputerCaseBuilder
{
    private ComputerCase _computerCase;
    private FormFactor? _motherboardFormFactor;
    private FormFactor? _gpuFormFactor;
    private FormFactor? _formFactor;
    public ComputerCaseBuilder()
    {
        _computerCase = new ComputerCase(
            maxGPUFormFactor: _gpuFormFactor,
            motherboardFormFactor: _motherboardFormFactor,
            formFactor: _formFactor);
    }

    public ComputerCase Build()
    {
        ComputerCase computerCase = _computerCase;
        return computerCase;
    }

    public IComputerCaseBuilder GetComputerCaseFormFactor(FormFactor formFactor)
    {
        _formFactor = formFactor;
        return this;
    }

    public IComputerCaseBuilder GetComputerCaseGPUFormFactor(FormFactor formFactor)
    {
        _gpuFormFactor = formFactor;
        return this;
    }

    public IComputerCaseBuilder GetComputerCaseMotherboardFormFactor(FormFactor formFactor)
    {
        _motherboardFormFactor = formFactor;
        return this;
    }
}
