using Domain.Models.ConsoleModels;

namespace ConsoleApiAdapter.Interfaces;

public interface IParserHandler
{
    void Handle(string? commandString, Command? command);
    IParserHandler SetNextHandler(IParserHandler handler);
}