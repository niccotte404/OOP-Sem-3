namespace Application.Commands;

public class LogOutCommand : IAppCommand
{
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