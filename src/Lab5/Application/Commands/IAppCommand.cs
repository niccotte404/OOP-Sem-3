namespace Application.Commands;

public interface IAppCommand
{
    void Execute();
    void Validate();
}