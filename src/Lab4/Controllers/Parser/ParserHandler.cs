using Itmo.ObjectOrientedProgramming.Lab4.Model;

namespace Itmo.ObjectOrientedProgramming.Lab4.Controllers.Parser;
public abstract class ParserHandler
{
    public abstract void Handle(string cmd, Command command);
    public abstract ParserHandler SetNext(ParserHandler handler);
}
