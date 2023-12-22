using Itmo.ObjectOrientedProgramming.Lab2.Interfaces;
using Itmo.ObjectOrientedProgramming.Lab2.Models.Components;
using Itmo.ObjectOrientedProgramming.Lab2.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.Builders.Compositors;
public class ComputerCaseBuilder : IComputerCaseBuilder
{
    private FormFactor? _motherboardFormFactor;
    private FormFactor? _gpuFormFactor;
    private FormFactor? _formFactor;

    public ComputerCase Build()
    {
        var computerCase = new ComputerCase(
            maxGPUFormFactor: _gpuFormFactor,
            motherboardFormFactor: _motherboardFormFactor,
            formFactor: _formFactor);
        ValidateComponents.IsComputerCaseValid(computerCase);
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
