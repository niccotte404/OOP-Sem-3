using Domain.Models.ConsoleModels;

namespace Application.Commands;

public class LogOutCommand : IAppCommand
{
    private readonly Command? _command;
    public LogOutCommand(Command? command)
    {
        _command = command;
    }

    public void Execute()
    {
        AppContext.IsLoggedIn = false;
        AppContext.Id = null;
        AppContext.Role = null;
    }

    public void Validate()
    {
        return;
    }
}