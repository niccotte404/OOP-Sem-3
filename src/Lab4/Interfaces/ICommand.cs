using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Interfaces;

public interface ICommand
{
    public void Execute(Command command);
}